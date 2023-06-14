using AbstractFactoryExampleOfMFWorld.Business.Models.Commerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExampleOfMFWorld.Business.Models.Confirmation
{
    public class InternationalConfirmationProvider : ConfirmationProvider
    {
        public override string GenerateConfirmationLabelFor(Order order)
        {
            return "Global-Funds";  
        }
    }
}
