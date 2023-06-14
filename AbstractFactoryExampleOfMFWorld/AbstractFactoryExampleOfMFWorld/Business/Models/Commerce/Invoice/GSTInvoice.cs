using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExampleOfMFWorld.Business.Models.Commerce.Invoice
{
    public class GSTInvoice : IInvoice
    {
        public byte[] GenerateInvoice()
        {
            return
                Encoding
                .Default
                .GetBytes("GST INVOICE");
        }
    }
}
