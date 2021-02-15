using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Data.ViewModels
{
    public class StripeDashboardVM
    {
        public Balance Balance { get; set; }
        public List<BalanceTransaction> Transactions { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Charge> Charges { get; set; }
    }
}
