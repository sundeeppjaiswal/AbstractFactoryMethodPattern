using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryExampleOfMFWorld.Business.Models.Commerce.Users;
using AbstractFactoryExampleOfMFWorld.Business.Models.Confirmation;

namespace AbstractFactoryExampleOfMFWorld.Business.Models.Commerce
{
    public class Order
    {
        public Dictionary<FundItemList, int> FundListItems { get; } = new Dictionary<FundItemList, int>();
        public IList<Payment> SelectedPayments { get; } = new List<Payment>();
        public decimal PurchaseOrder => FundListItems.Sum(FundItemList => FundItemList.Key.TotalAmount);
        public OrderConfirmationStatus OrderConfirmationStatus { get; set; } = OrderConfirmationStatus.WaitingForPayment;
        public UserDetails BuyerDetails { get; set; }
        public decimal TotalAmount { get; set; }

    }
}
