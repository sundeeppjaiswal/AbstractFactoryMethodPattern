using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExampleOfMFWorld.Business.Models.Commerce
{
    public class FundItemList
    {
        public string Id { get; }
        public string Name { get; }
        public string Category { get; }
        public string PlanName { get; }
        public decimal NAV { get; }
        public decimal Units { get; }

        private decimal Price;
        public decimal TotalAmount
        {
            get { return Price; }
            set
            { if( NAV > 0 && Units > 0 )
                {
                    Price = NAV * Units; 
                }
            }
        }

        public FundItemList(string id, string name, string category, string planname, decimal nav)
        {
            Id = id;
            Name = name;
            Category = category;
            PlanName = planname;
            NAV = nav;
        }
    }
}
