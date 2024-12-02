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
    public partial class UserControl1 : UserControl
    {
        private Size _containerSize;
        private const int _borderRadius = 30;
        public UserControl1()
        {
            InitializeComponent();

            _containerSize = new(0, 200);

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

            var locations = FormHelpers.CalculateVerticalListPositions(_containerSize, 20, 4);

            locations.ForEach(y =>
            {
                AddAccount(this, acc, new Point(20, y + accounts_label.Height + 40));
            });
        }

        private static void AddAccount(Control control, Account account, Point location)
        {
            var container = new Panel()
            {
                Size = new Size(890, 200),
                Location = location,
                BackColor = AppSkinHelper.materialSkinManager.BackgroundFocusColor,
                ForeColor = Color.FromArgb(222, 0, 0, 0),
                Margin = new Padding(10),
                Padding = new Padding(10),
                TabStop = false,
            };
            var cardImage = new PictureBox()
            {
                Size = new Size(260, 156),
                Location = new Point(container.Size.Width - 260 - 20, (container.Size.Height - 156) / 2),
                Image = Properties.Resources.card_0,
                SizeMode = PictureBoxSizeMode.StretchImage,
                TabStop = false,
            };
            cardImage.Region = new Region(FormHelpers.CreateRoundedRectanglePath(cardImage.ClientRectangle, _borderRadius));
            container.Region = new Region(FormHelpers.CreateRoundedRectanglePath(container.ClientRectangle, _borderRadius));
            container.Controls.Add(cardImage);
            control.Controls.Add(container);
        }

        private static void AddCard(Control control, Account account, Point location)
        {
            PictureBox pictureBoxX = new()
            {
                Image = Properties.Resources.card_0,
                Location = location,
                Name = "pictureBoxX",
                Size = new Size(416, 225),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            Label labelX = new()
            {
                Location = new Point((pictureBoxX.Size.Width - 376) / 2, (int)(pictureBoxX.Size.Height * 0.65)),
                AutoSize = true,
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Kredit", 28F, FontStyle.Regular, GraphicsUnit.Point, 0),
                ForeColor = Color.Gold,
                Name = "labelX",
                Size = new Size(376, 46),
                Text = string.Join(" ", FormHelpers.SplitIntoChunks(account.AccountNumber.ToString(), 4)),
            };

            pictureBoxX.Region = new Region(FormHelpers.CreateRoundedRectanglePath(pictureBoxX.ClientRectangle, _borderRadius));

            pictureBoxX.Controls.Add(labelX);
            control.Controls.Add(pictureBoxX);
        }

        
    }
}
