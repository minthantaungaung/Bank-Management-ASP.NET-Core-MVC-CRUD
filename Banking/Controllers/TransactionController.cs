using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banking.Extention;
using Banking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Banking.Controllers
{
    public class TransactionController : Controller
    {
        BankingContext context = new BankingContext();
        public IActionResult Index(string status)
        {
            ViewBag.status = status;
            return View();
        }
        public IActionResult _TransactionList(string last5)
        {
            List<Transaction> tranlist = null;
            if (last5 == "yes")
            {
                tranlist = context.Transactions.FromSqlRaw($"GetLast5Transaction").ToList();
            }
            else
            {
                tranlist = context.Transactions.FromSqlRaw($"GetAllTransaction").ToList();
            }
            return PartialView(tranlist);
        }
        public IActionResult _TransactionForm(string FormType, int ID)
        {
            var bank = context.Banks.Select(a => a.IssuanceBankName).Distinct().ToList();
            ViewBag.bank = BankHelper.GetBanks(bank);
            if (FormType == "Edit")
            {
                Transaction data = context.Transactions.Where(a => a.Id == ID).FirstOrDefault();
                var lcamt = data.LcAmount;
                var tolerance = data.Tolerance;
                var TV = lcamt * tolerance/ 100;
                ViewBag.ToleranceValue = TV;
                return PartialView("_TransactionForm", data);
            }
            else
            {
                return PartialView();
            }
        }
        public List<string> getBank()
        {
            var bank = context.Banks.Select(a => a.IssuanceBankName).Distinct().ToList();
            return bank;
        }
        public string UpSertForm(Transaction formData)
        {
            var tranDB = context.Transactions.Where(a => a.Id == formData.Id).FirstOrDefault();
            if (tranDB != null)
            {
                #region DataSetting
                tranDB.EastWest = formData.EastWest;
                tranDB.PetredecEntity = formData.PetredecEntity;
                tranDB.Desk = formData.Desk;
                tranDB.ImportExport = formData.ImportExport;
                tranDB.CreditStatus = formData.CreditStatus;
                tranDB.CounterParty = formData.CounterParty;
                tranDB.Incoterm = formData.Incoterm;
                tranDB.LoadPort = formData.LoadPort;
                tranDB.PaymentTerms = formData.PaymentTerms;
                tranDB.ExportBank = formData.ExportBank;
                tranDB.Comments = formData.Comments;
                tranDB.LcRef = formData.LcRef;
                tranDB.AdvisingConfirmingBank = formData.AdvisingConfirmingBank;
                tranDB.IssuanceDate = formData.IssuanceDate;
                tranDB.ExpiryDate = formData.ExpiryDate;
                tranDB.LcAmount = formData.LcAmount;
                tranDB.Tolerance = formData.Tolerance;
                tranDB.LcFees = formData.LcFees;
                tranDB.LcLineUtilisation = formData.LcLineUtilisation;
                tranDB.LcRate = formData.LcRate;
                tranDB.FullyCancelled = formData.FullyCancelled;
                #endregion
                context.SaveChanges();
                return "updated";
            }
            else
            {
                context.Transactions.Add(formData);
                context.SaveChanges();
                return "added";
            }
        }
    }
}
