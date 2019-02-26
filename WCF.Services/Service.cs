using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCF.Data;
using WCF.Entities;

namespace WCF.Services
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
	public class Service : IService, IDisposable
	{
		private readonly WCF_DbContext _DbContext = new WCF_DbContext();

		public List<Customer> GetCustomers()
		{
			return _DbContext.Customers.ToList();
		}

		public List<Product> GetProducts()
		{
			return _DbContext.Products.ToList();
		}

		[OperationBehavior(TransactionScopeRequired = true)]
		public void SubmitOrder(Order order)
		{
			_DbContext.Orders.Add(order);
			order.OrderItems.ForEach(x => _DbContext.OrderItems.Add(x));
			_DbContext.SaveChanges();
		}

		public void Dispose()
		{
			_DbContext.Dispose();
		}
	}
}
