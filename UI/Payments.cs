using BankingApp.Models.Enums;
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

namespace BankingApp.UI
{
    public partial class Payments : UserControl
    {
        public static readonly Size ContainerSize = new(890, 100);
        public Payments()
        {
            Payment pay = new()
            {
                Id = 0,
                Name = "AzTelekom",
                Destination = 5678908756780987,
            };

            InitializeComponent();

            var locations = FormHelpers.CalculateVerticalListPositions(ContainerSize, 10, 16);

            locations.ForEach(y =>
            {
                FormHelpers.AddPayment(this, pay, new Point(20, y + payments_label.Height + 40));
            });
        }
    }
}
