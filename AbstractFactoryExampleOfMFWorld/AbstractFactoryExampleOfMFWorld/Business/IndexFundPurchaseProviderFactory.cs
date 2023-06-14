using AbstractFactoryExampleOfMFWorld.Business.Models.Commerce.Invoice;
using AbstractFactoryExampleOfMFWorld.Business.Models.Commerce.Summary;
using AbstractFactoryExampleOfMFWorld.Business.Models.Confirmation;
using AbstractFactoryExampleOfMFWorld.Business.Models.Commerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExampleOfMFWorld.Business
{
    public class IndexFundPurchaseProviderFactory : IMutualFundPurchaseProviderFactory
    {
        public IInvoice CreateInvoice(Order order)
        {
            return new GSTInvoice();
        }
        public ConfirmationProvider CreateConfirmationProvider(OrderedParallelQuery order)
        {
            return 
        }
        public ISummary CreateSummary(Order order)
        {
            return new EmailSummary();
        }

    }
}
