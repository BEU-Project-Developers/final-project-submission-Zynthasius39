using BankingApp.DAL;
using BankingApp.Models;
using BankingApp.Models.Enums;
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
    public partial class ModForm : Form
    {
        private readonly BindingList<Customer> _customersList = [];

        public ModForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = _customersList;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            int count = CustomerRepository.Delete(Convert.ToInt32(textBox1.Text));
            toolStripStatusLabel1.Text = "Deleted " + count + " Customer(s)";
        }

        private void get_all_button_Click(object sender, EventArgs e)
        {
            int inCounter = 0;
            toolStripProgressBar1.Value = 0;

            List<Customer> remoteList = CustomerRepository.GetAll();
            foreach (Customer c in remoteList)
            {
                _customersList.Add(c);
                inCounter++;
            }
            toolStripStatusLabel1.Text = "Got " + inCounter.ToString() + " Customer(s)";
            toolStripProgressBar1.Value = 100;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 0;
            _customersList.Clear();
            toolStripStatusLabel1.Text = "Cleared";
            toolStripProgressBar1.Value = 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 0;
            CustomerRepository.Add(new Customer()
            {
                Email = "unknown@home.alak",
                Name = "Unknown",
                Surname = "Unknownov",
                Phone = "+994000000000",
                Password = "",
                Role = Rolet.Visitor
            });
            toolStripStatusLabel1.Text = "Added a predefined Customer";
            toolStripProgressBar1.Value = 100;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 0;
            Customer customer;
            try
            {
                customer = CustomerRepository.Get(Convert.ToInt32(textBox2.Text));
                _customersList.Add(customer);
                toolStripStatusLabel1.Text = "Got 1 Customer";
            }
            catch (Exception ce)
            {
                toolStripStatusLabel1.Text = ce.Message;
            }
            toolStripProgressBar1.Value = 100;
        }

        private void insert_all_button_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                toolStripProgressBar1.Value = 0;
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
                toolStripProgressBar1.Value = 100;
            }
        }
    }
}
