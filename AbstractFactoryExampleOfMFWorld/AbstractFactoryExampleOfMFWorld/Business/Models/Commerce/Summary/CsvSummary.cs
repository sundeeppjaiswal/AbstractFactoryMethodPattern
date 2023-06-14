using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExampleOfMFWorld.Business.Models.Commerce.Summary
{
    public class CsvSummary
    {
        public string CreateOrderSummary(Order order)
        {
            return $"CSV Summary sens!";
        }
        public void Send()
        {

        }
    }
}
