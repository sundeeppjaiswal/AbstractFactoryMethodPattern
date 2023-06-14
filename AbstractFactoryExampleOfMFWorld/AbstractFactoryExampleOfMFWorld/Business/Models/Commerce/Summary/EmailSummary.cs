using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExampleOfMFWorld.Business.Models.Commerce.Summary
{
    public class EmailSummary
    {
        public string CreateOrderSummary(Order order)
        {
            return $"EMAIL Summary sens!";
        }
        public void Send()
        {

        }
    }
}
