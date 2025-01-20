using BankingApp.Models;
using BankingApp.Models.Enums;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;
using System.Drawing.Drawing2D;

namespace BankingApp.UI
{
    public partial class Dashboard : MaterialForm
    {
        private const int _borderRadius = 30;

        private List<Account> _testTable = [
            new() {
                AccountType = Accountt.Debit,
                CIdList = [0, 1, 2, 3, 4],
                CreationDate = DateTime.Now,
                ExpirationDate = DateTime.Now,
                Currency = Currency.AZN,
                Id = 0,
                Amount = 5000000
            }
            ];
        public Dashboard()
        {
            InitializeComponent();

            IEnumerator i = TabControl.TabPages.GetEnumerator();
            while (i.MoveNext())
            {
                TabPage j = (TabPage)i.Current;
                j.BackColor = AppSkin.materialSkinManager.BackgroundColor;
            }

            pictureBox1.Location = new Point(20, 20);
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(( pictureBox1.Size.Width - label1.Width ) / 2, (int)(pictureBox1.Size.Height * 0.65));
            pictureBox1.Region = new Region(CreateRoundedRectanglePath(pictureBox1.ClientRectangle, _borderRadius));

            pictureBox2.Location = new Point(pictureBox1.Location.X + pictureBox1.Width + 20, pictureBox1.Location.Y);
            label2.Parent = pictureBox2;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point((pictureBox2.Size.Width - label2.Width) / 2, (int)(pictureBox2.Size.Height * 0.65));
            pictureBox2.Region = new Region(CreateRoundedRectanglePath(pictureBox2.ClientRectangle, _borderRadius));
        }
        public static GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.Left, rect.Top, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Top, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.Left, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
