using BankingApp.BLL;
using BankingApp.DAL;
using BankingApp.Models;
using BankingApp.Models.Enums;
using Npgsql;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace BankingApp
{
    public partial class LoginForm : Form
    {
        private bool _isLogin = true;
        public LoginForm()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = string.Empty;
        }

        private void switch_Menu()
        {
            if (_isLogin)
            {
                submit_button.Text = "Register";
                signup_link.Text = "Already registered ?";
                forgot_link.Visible = false;
                name_box.Visible = true;
                surname_box.Visible = true;
                role_radio_1.Visible = true;
                role_radio_2.Visible = true;
                _isLogin = false;
            }
            else
            {
                submit_button.Text = "Login";
                signup_link.Text = "Not a Customer ?";
                forgot_link.Visible = true;
                name_box.Visible = false;
                surname_box.Visible = false;
                role_radio_1.Visible = false;
                role_radio_2.Visible = false;
                _isLogin = true;
            }
        }

        private void forgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            switch_Menu();
        }

        private void signup_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_isLogin)
            {
                submit_button.Text = "Register";
                signup_link.Text = "Already registered ?";
                forgot_link.Visible = false;
                name_box.Visible = true;
                surname_box.Visible = true;
                phone_box.Visible = true;
                role_radio_1.Visible = true;
                role_radio_2.Visible = true;
                _isLogin = false;
            }
            else
            {
                submit_button.Text = "Login";
                signup_link.Text = "Not a Customer ?";
                forgot_link.Visible = true;
                name_box.Visible = false;
                surname_box.Visible = false;
                phone_box.Visible = false;
                role_radio_1.Visible = false;
                role_radio_2.Visible = false;
                _isLogin = true;
            }
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            if (_isLogin)
            {
                try
                {
                    Customer customer = CustomerService.GetCustomer(email_box.Text.Trim());
                    //toolStripStatusLabel1.Text = CustomerService.VerifyPassword(customer, password_box.Text.Trim());
                    if (CustomerService.VerifyPassword(customer, password_box.Text.Trim()))
                    {
                        Debug.WriteLine(customer.Id + " logged in at " + DateTime.Now);
                        toolStripStatusLabel1.Text = "Welcome back, " + customer.Name + "!";
                    }
                    else
                    {
                        Debug.WriteLine(customer.Id + " failed login attempt at " + DateTime.Now);
                        toolStripStatusLabel1.Text = "Wrong password entered!";
                    }

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    toolStripStatusLabel1.Text = ex.Message;
                }
            }
            else
            {
                Rolet rolet;
                if (role_radio_1.Checked)
                    rolet = Rolet.Member;
                else rolet = Rolet.Business;

                try
                {
                    CustomerService.CreateCustomer(new Customer()
                    {
                        Email = email_box.Text.Trim(),
                        Password = password_box.Text.Trim(),
                        Name = name_box.Text.Trim(),
                        Surname = surname_box.Text.Trim(),
                        Phone = phone_box.Text.Trim(),
                        Role = rolet
                    });
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    toolStripStatusLabel1.Text = ex.Message;
                }
                toolStripStatusLabel1.Text = "Successfully registered. You can now login to your account!";
                _isLogin = true;
                switch_Menu();
            }
        }
    }
}
