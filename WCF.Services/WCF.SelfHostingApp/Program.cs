using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCF.Services;

namespace WCF.SelfHostingApp
{
	class Program
	{
		public static void Main(string[] args)
		{
			try {
				ServiceHost serviceHost = new ServiceHost(typeof(Service));
				serviceHost.Open();
				Console.WriteLine("Press any key to abort hosting... ...");
				Console.ReadKey();
				serviceHost.Close();
			}
			catch (Exception ex) {
				Console.WriteLine(ex.Message);
				Console.ReadKey();
			}
			
		}
	}
}
