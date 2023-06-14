using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExampleOfMFWorld.Business.Models.Confirmation.Factories
{
    public abstract class ConfirmationProviderFactory
    {
        public abstract ConfirmationProvider CreateConfirmationProvider(string fundType);
        public ConfirmationProvider GetConfirmationProvider(string fundType)
        {
            var provider = CreateConfirmationProvider(fundType);
            if(fundType == "Equity" && provider.InsuranceOptions.InsuranceApplied)
            {
                provider.RequireSignature = false;
            }
            return provider;
        }
    }
}
