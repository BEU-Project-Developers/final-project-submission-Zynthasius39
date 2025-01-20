using BankingApp.Models.Enums;
using BankingApp.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp.UI
{
    public partial class Cards : UserControl
    {
        public static readonly Size ContainerSize = new(890, 200);
        public Cards()
        {
            Account acc = new()
            {
                AccountNumber = 1234567812345678,
                AccountType = Accountt.Credit,
                CIdList = [],
                Amount = 0,
                CreationDate = DateTime.Now,
                ExpirationDate = DateTime.Now,
                Currency = Currency.USD,
                Id = 0,
            };

            InitializeComponent();

            SizeChanged += (sender, e) => panel1.Width = Width;

            var locations = FormHelpers.CalculateVerticalListPositions(ContainerSize, 10, 4);

            locations.ForEach(y =>
            {
                FormHelpers.AddAccount(this, acc, new Point(20, y + accounts_label.Height + 40));
            });
        }
    }
}