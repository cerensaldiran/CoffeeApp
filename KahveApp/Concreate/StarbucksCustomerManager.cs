using KahveApp.Abstract;
using KahveApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveApp.Concreate
{
    public class StarbucksCustomerManager:BaseCustomerManager
    {
        private IPersonCheckService _personCheckService;
        public StarbucksCustomerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }
        public override void Save(Customer customer)
        {
            if (_personCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }


    }
}
