﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExampleOfMFWorld.Business.Models.Confirmation.Factories
{
    public class USFundsConfirmationProviderFactory : ConfirmationProviderFactory
    {
        public override ConfirmationProvider CreateConfirmationProvider(string fundType)
        {
            return  new USFundsConfirmationProviderFactory();
        }
    }
}
