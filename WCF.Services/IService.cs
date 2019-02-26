using System.Collections.Generic;
using System.ServiceModel;
using WCF.Entities;

namespace WCF.Services
{
	[ServiceContract]
	public interface IService
	{
		[OperationContract]
		List<Product> GetProducts();
		[OperationContract]
		List<Customer> GetCustomers();
		[OperationContract]
		void SubmitOrder(Order order);
	}
}
