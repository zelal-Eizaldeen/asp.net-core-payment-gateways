using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryApp.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Stripe;

namespace LibraryApp.Controllers
{
    public class StripeDashboardController : Controller
    {
        public IActionResult Index()
        {
            var response = new StripeDashboardVM();

            var balanceService = new BalanceService();
            var balanceResult = balanceService.Get();
            response.Balance = balanceResult;

            var transactionService = new BalanceTransactionService();
            var transactionsResult = transactionService.List().ToList();
            response.Transactions = transactionsResult;

            var customerService = new CustomerService();
            var customerResult = customerService.List().ToList();
            response.Customers = customerResult;

            return View(response);
        }
    }
}