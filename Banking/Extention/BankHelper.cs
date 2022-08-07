using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.Extention
{
    public class BankHelper
    {
        public static List<SelectListItem> GetBanks(List<string> Bank)
        {
            List<SelectListItem> bankList = null;
            bankList = new List<SelectListItem>();
            bankList.Add(new SelectListItem { Value = "", Text = "-- select --" });
            foreach (var item in Bank)
            {
                bankList.Add(new SelectListItem { Value = item, Text = item });
            }
            return bankList;
        }
    }
}
