using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExampleOfMFWorld.Business.Models.Commerce.Summary
{
    public class SMSSummary : ISummary
    {
        public string CreateOrderSummary(Order order)
        {
            return $"SMS Summary sens!";
        }
        public void Send()
        {

        }
    }
}
