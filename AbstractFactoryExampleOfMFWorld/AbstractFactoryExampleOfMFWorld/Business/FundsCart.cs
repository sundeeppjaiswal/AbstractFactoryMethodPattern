using AbstractFactoryExampleOfMFWorld.Business.Models.Commerce;
using AbstractFactoryExampleOfMFWorld.Business.Models.Confirmation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExampleOfMFWorld.Business
{
    public class FundsCart
    {
        private readonly Order order;
        private readonly IMutualFundPurchaseProviderFactory mutualFundPurchaseProviderFactory;

        public FundsCart(Order order, IMutualFundPurchaseProviderFactory mutualFundPurchaseProviderFactory)
        {
            this.order = order;
            this.mutualFundPurchaseProviderFactory = mutualFundPurchaseProviderFactory;
        }
        public string Finalize()
        {
            var confirmationProvider = mutualFundPurchaseProviderFactory.CreateConfirmationProvider(order);
            var invoice = mutualFundPurchaseProviderFactory.CreateInvoice(order);
            invoice.GenerateInvoice();
            var summary = mutualFundPurchaseProviderFactory.CreateSummary(order);
            summary.Send();
            order.OrderConfirmationStatus = OrderConfirmationStatus.Delivered;
            return confirmationProvider.GenerateConfirmationLabelFor(order);
        }
    }
}
