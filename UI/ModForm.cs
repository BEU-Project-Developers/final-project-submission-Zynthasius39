using BankingApp.DAL;
using BankingApp.Models;
using BankingApp.Models.Enums;
using MaterialSkin;
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
    public partial class ModForm : MaterialForm
    {
        private readonly BindingList<Customer> _customersList = [];

        public ModForm()
        {
            InitializeComponent();
            // Add this form to custom skin helper
            AppSkinHelper.msm.AddFormToManage(this);

            // Force window size
            Size = new Size(1245, 643);
            MaximumSize = Size;
            MinimumSize = Size;
            FormBorderStyle = FormBorderStyle.Fixed3D;

            // MaterialUI coloring
            dataGridView1.BackgroundColor = AppSkinHelper.msm.BackgroundColor;
            dataGridView1.ForeColor = AppSkinHelper.msm.ColorScheme.PrimaryColor;
            dataGridView1.GridColor = AppSkinHelper.msm.ColorScheme.TextColor;
            dataGridView1.BackgroundColor = AppSkinHelper.msm.BackgroundColor;

            dataGridView1.DataSource = _customersList;
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            int count = CustomerRepository.Delete(Convert.ToInt32(textBox1.Text.Trim()));
            StatusBar.Status = "Deleted " + count + " Customer(s)";
        }

        private void Get_all_button_Click(object sender, EventArgs e)
        {
            int inCounter = 0;
            progress_bar.Value = 0;

            List<Customer> remoteList = CustomerRepository.GetAll();
            foreach (Customer c in remoteList)
            {
                _customersList.Add(c);
                inCounter++;
            }
            StatusBar.Status = "Got " + inCounter.ToString() + " Customer(s)";
            progress_bar.Value = 100;
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            progress_bar.Value = 0;
            _customersList.Clear();
            StatusBar.Status = "Cleared";
            progress_bar.Value = 100;
        }

        private void Insert_default_button_Click(object sender, EventArgs e)
        {
            progress_bar.Value = 0;

            // Example Customer
            CustomerRepository.Add(new Customer()
            {
                Email = "admin@home.alak",
                Name = "Gringott",
                Surname = "the goblin",
                Phone = "+994000000000",
                Password = "a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3",
                Role = Rolet.Admin,
                RegisterDate = DateTime.Now,
                TransactionIDs = []
            });
            StatusBar.Status = "Added a predefined Customer";
            progress_bar.Value = 100;
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            progress_bar.Value = 0;
            Customer customer;
            try
            {
                customer = CustomerRepository.Get(Convert.ToInt32(textBox2.Text.Trim()));
                _customersList.Add(customer);
                StatusBar.Status = "Got 1 Customer";
            }
            catch (Exception ce)
            {
                StatusBar.Status = ce.Message;
            }
            progress_bar.Value = 100;
        }

        private void Insert_all_button_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                progress_bar.Value = 0;
                if (row.Cells.Count > 0)
                    if (row.Cells["Manual"].Value != null)
                        if ((bool)row.Cells["Manual"].Value)
                        {
                            Customer? customer = row.DataBoundItem as Customer;
                            if (customer != null)
                            {
                                int newId = CustomerRepository.Add(customer);
                                Debug.WriteLine("Inserted a new customer as " + newId);
                            }
                            else
                            {
                                Debug.WriteLine("Customer being inserted is null");
                            }
                        }
                progress_bar.Value = 100;
            }
        }

        private void Logout_Btn_Click(object sender, EventArgs e)
        {
            Hide();
            // Go back to login
            Form login = new LoginForm();
            login.FormClosed += (s, args) => Close();
            login.Show();
        }
    }
}
