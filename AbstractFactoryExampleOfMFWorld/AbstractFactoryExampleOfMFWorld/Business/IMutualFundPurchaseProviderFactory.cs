using AbstractFactoryExampleOfMFWorld.Business.Models.Confirmation;
using AbstractFactoryExampleOfMFWorld.Business.Models.Commerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryExampleOfMFWorld.Business.Models.Commerce.Invoice;
using AbstractFactoryExampleOfMFWorld.Business.Models.Commerce.Summary;

namespace AbstractFactoryExampleOfMFWorld.Business
{
    public interface IMutualFundPurchaseProviderFactory
    {
        ConfirmationProvider CreateConfirmationProvider(Order order);
        IInvoice CreateInvoice(Order order);
        ISummary CreateSummary(Order order);
    }
}
