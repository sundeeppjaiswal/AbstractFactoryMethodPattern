using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExampleOfMFWorld.Business.Models.Commerce.Users
{
    public class UserDetails
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string FolioNo { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string PAN { get; set; }
        public decimal TotalHoldingAmount { get; set; }
    }
}
