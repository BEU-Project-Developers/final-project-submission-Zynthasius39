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
using BankingApp.Properties;

namespace BankingApp.UI
{
    public partial class Dashboard : MaterialForm
    {
        public Dashboard()
        {
            InitializeComponent();

            IEnumerator i = TabControl.TabPages.GetEnumerator();
            while (i.MoveNext())
            {
                TabPage j = (TabPage)i.Current;
                j.BackColor = AppSkinHelper.materialSkinManager.BackgroundColor;
            }

        }
    }
}
