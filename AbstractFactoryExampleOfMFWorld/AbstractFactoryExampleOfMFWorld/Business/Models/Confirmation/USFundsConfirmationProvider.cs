using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryExampleOfMFWorld.Business.Models.Commerce;

namespace AbstractFactoryExampleOfMFWorld.Business.Models.Confirmation
{
    public class USFundsConfirmationProvider : ConfirmationProvider
    {   
        private readonly string folioId;
        private readonly string pan;

        public USFundsConfirmationProvider(string folioId, string pan, ConfirmationCostCalculator confirmationCostCalculator, InsuranceOptions insuranceOptions)
        {
            this.folioId = folioId;
            this.pan = pan;
            ConfirmationCostCalculator= confirmationCostCalculator;
            InsuranceOptions = insuranceOptions;
        }
        public override string GenerateConfirmationLabelFor(Order order)
        {
            var confirmationId = GetConfirmationId();
            if (confirmationId == null) 
            {
                throw new NotSupportedException("Error while generating Confirmation ID.");
            }
            var confirmationDetails = ConfirmationCostCalculator.CalculatorFor(order.BuyerDetails.FolioNo, order.TotalAmount);
            return $"Confirmation Id: {confirmationId} {Environment.NewLine}" +
                    $"To:{order.BuyerDetails.Email} {Environment.NewLine}" +
                    $"Total Amount: {order.TotalAmount}";
        }
        private string GetConfirmationId()
        {
            //Invoke the API with API key
            return $"US-{Guid.NewGuid()}";
        }

    }
}
