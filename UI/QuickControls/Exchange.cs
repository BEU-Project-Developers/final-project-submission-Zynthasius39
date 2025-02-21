﻿using BankingApp.BLL;
using BankingApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp.UI.QuickControls
{
    public partial class Exchange : UserControl
    {
        private Account? _account;

        public Exchange()
        {
            InitializeComponent();
        }

        public Exchange(Account account)
        {
            _account = account;
            InitializeComponent();
        }

        private void Exchange_Btn_Click(object sender, EventArgs e)
        {
            Account? account;
            if (FormHelpers.UserDefAccount != null) {
                account = FormHelpers.UserDefAccount;
                string oldCur = exchTo.Text.ToLower();
                if (oldCur == "azn") account.Currency = Models.Enums.Currency.AZN;
                else if (oldCur == "usd") account.Currency = Models.Enums.Currency.USD;
                else if (oldCur == "try") account.Currency = Models.Enums.Currency.TRY;
                else if (oldCur == "gold") account.Currency = Models.Enums.Currency.GOLD;
                else if (oldCur == "eur") account.Currency = Models.Enums.Currency.EUR;
                else StatusBar.Status = "Couldn't find the exchange currency!";
                AccountService.UpdateAccount(account);
            }
        }
    }
}
