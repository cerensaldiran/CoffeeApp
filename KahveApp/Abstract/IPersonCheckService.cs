using KahveApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveApp.Abstract
{
    public interface IPersonCheckService
    {
         bool CheckIfRealPerson(Customer customer);
    }
}
