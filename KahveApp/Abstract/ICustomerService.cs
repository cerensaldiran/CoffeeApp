﻿using KahveApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KahveApp.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
