using KahveApp.Abstract;
using KahveApp.Adapters;
using KahveApp.Concreate;
using KahveApp.Entities;
using System;

namespace KahveApp
{
     class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth=new DateTime(1999,8,8), Firstname="Ceren", LastName="Saldıran", NationalityId="39386033432"});
            Console.ReadLine();
        }
    }
}
