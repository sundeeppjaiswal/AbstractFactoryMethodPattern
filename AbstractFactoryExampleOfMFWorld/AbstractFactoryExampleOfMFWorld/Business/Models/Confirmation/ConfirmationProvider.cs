using AbstractFactoryExampleOfMFWorld.Business.Models.Commerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryExampleOfMFWorld.Business.Models.Commerce;


namespace AbstractFactoryExampleOfMFWorld.Business.Models.Confirmation
{
    public abstract class ConfirmationProvider
    {
        public ConfirmationCostCalculator ConfirmationCostCalculator { get; protected set; }
        public InsuranceOptions InsuranceOptions { get; protected set; }
        public bool RequireSignature { get; set; }
        public abstract string GenerateConfirmationLabelFor(Order order);


    }
    public class InsuranceOptions
    {
        public bool InsuranceApplied { get; set; }
        public string InsurerName { get; set; }
        public DateTime InsuranceValidity { get; set; }
    }
    public class ConfirmationCostCalculator
    {
        private readonly decimal expensRatio;
        private readonly decimal taxCost;
        public PurchaseType PurchaseType { get; set; }
        public ConfirmationCostCalculator(decimal expensRatio, decimal taxCost,
            PurchaseType purchaseType = PurchaseType.Monthly)
        {
            this.expensRatio = expensRatio;
            this.taxCost = taxCost;
            PurchaseType = purchaseType;
        }
        public decimal CalculatorFor(string fundType, decimal totalAmount)
        {
            decimal total = 500;
            if (fundType  == "Equity")
            {
                total = totalAmount + expensRatio + taxCost;
            } else if (fundType == "Debt")
            {
                total = totalAmount + expensRatio + taxCost;
            }
            else if (fundType == "Hybrid")
            {
                total = totalAmount + expensRatio + taxCost;
            }
            else if (fundType == "Index")
            {
                total = totalAmount + expensRatio + taxCost;
            }
            else { return total = 0; }

            switch (PurchaseType)
            {
                case PurchaseType.Daily: total += 5; break;
                case PurchaseType.Weekly: total += 8; break;
                case PurchaseType.Monthly: total += 10; break;
                case PurchaseType.Quartly: total += 12; break;
                case PurchaseType.HalfYearly: total += 15; break;
               
            }
            return total;
        }
    }
    public enum PurchaseType
    {
        Daily,
        Weekly,
        Monthly,
        Quartly,
        HalfYearly
    }

    public enum OrderConfirmationStatus
    {
        WaitingForPayment,
        Delivered,
        Paid,
        InProcess,
        UnitAlloted
    }

   
}
