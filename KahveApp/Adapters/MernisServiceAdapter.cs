using KahveApp.Abstract;
using KahveApp.Entities;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ServiceReference1.KPSPublicSoapClient;

namespace KahveApp.Adapters
{
    public class MernisServiceAdapter : IPersonCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId), customer.Firstname.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
            
            
        }
    }
}
