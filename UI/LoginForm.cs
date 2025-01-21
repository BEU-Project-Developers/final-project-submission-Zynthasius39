using BankingApp.BLL;
using BankingApp.Models;
using BankingApp.Models.Enums;
using BankingApp.UI;
using MaterialSkin.Controls;
using System.Diagnostics;

namespace BankingApp
{
    public partial class LoginForm : MaterialForm
    {
        private bool _isLogin = true;
        private Bitmap? gringots_black;
        private Bitmap? gringots_white;

        public LoginForm()
        {
            try
            {
                gringots_white = new(FormHelpers.PATH + @"\gringotts_white.png");
                gringots_black = new(FormHelpers.PATH + @"\gringotts_black.png");
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            InitializeComponent();
            MaterialSkinManager_ThemeChanged(this);
            AppSkinHelper.msm.AddFormToManage(this);
            StatusBar.AddStatusBar(statusBar);

            if (AppSkinHelper.IsDark())
            {
                dark_switch.Checked = true;
            }
            else
            {
                dark_switch.Checked = false;
            }

            banking_banner.Location = new Point((Width - banking_banner.Width) / 2 - 10, banking_banner.Location.Y);
            banking_title.Location = new Point((Width - banking_title.Width) / 2 - 10, banking_title.Location.Y);

            forgot_link.LinkColor = AppSkinHelper.msm.ColorScheme.AccentColor;
            forgot_link.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;

            AppSkinHelper.msm.ThemeChanged += MaterialSkinManager_ThemeChanged;
        }

        private void MaterialSkinManager_ThemeChanged(object sender)
        {
            if (AppSkinHelper.IsDark())
            {
                banking_banner.Image = gringots_white;
            }
            else
            {
                banking_banner.Image = gringots_black;
            }
        }

        private void Switch_Menu()
        {
            if (_isLogin)
            {
                signup_button.Text = "Login";
                submit_button.Text = "Signup";
                forgot_link.Visible = false;
                name_box.Visible = true;
                surname_box.Visible = true;
                role_radio_1.Visible = true;
                role_radio_2.Visible = true;
                phone_box.Visible = true;
                _isLogin = false;
            }
            else
            {
                signup_button.Text = "Signup";
                submit_button.Text = "Login";
                forgot_link.Visible = true;
                name_box.Visible = false;
                surname_box.Visible = false;
                role_radio_1.Visible = false;
                role_radio_2.Visible = false;
                phone_box.Visible = false;
                _isLogin = true;
            }
        }

        private void VerifyFields()
        {
            if (!VerifyService.VerifyEmail(email_box.Text.Trim()))
            {
                email_box.SetErrorState(true);
                throw new Exception("Invalid E-Mail");
            }
            if (string.IsNullOrWhiteSpace(password_box.Text))
            {
                password_box.SetErrorState(true);
                throw new Exception("Password is required");
            }
            if (!_isLogin)
            {
                if (string.IsNullOrWhiteSpace(name_box.Text))
                {
                    name_box.SetErrorState(true);
                    throw new Exception("Name is required");
                }
                if (string.IsNullOrWhiteSpace(surname_box.Text))
                {
                    surname_box.SetErrorState(true);
                    throw new Exception("Surname is required");
                }
                if (string.IsNullOrWhiteSpace(phone_box.Text))
                {
                    phone_box.SetErrorState(true);
                    throw new Exception("Phone is required");
                }
                if (!role_radio_1.Checked && !role_radio_2.Checked)
                {
                    throw new Exception("Select an account type");
                }
            }
            email_box.SetErrorState(false);
            password_box.SetErrorState(false);
            name_box.SetErrorState(false);
            surname_box.SetErrorState(false);
            phone_box.SetErrorState(false);
        }

        private void Forgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VerifyService.ForgotPassword();
        }

        private void Signup_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Switch_Menu();
        }

        private void Signup_button_Click(object sender, EventArgs e)
        {
            Switch_Menu();
        }

        private void Submit_button_Click(object sender, EventArgs e)
        {
            if (_isLogin)
            {
                try
                {
                    VerifyFields();

                    // Uncomment to enable offline mode
                    //Customer customer = FormHelpers.OfflineUser;
                    Customer customer = CustomerService.GetCustomer(email_box.Text.Trim());
                    if (CustomerService.VerifyPassword(customer, password_box.Text.Trim()))
                    {
                        FormHelpers.CurrentUser = customer;
                        Debug.WriteLine(customer.Id + " logged in at " + DateTime.Now);
                        StatusBar.Status = "Welcome back, " + customer.Name + "!";
                        if (customer.Role == Rolet.Admin || customer.Role == Rolet.Mod)
                        {
                            Hide();
                            Form mod = new ModForm();
                            mod.FormClosed += (s, args) => Close();
                            mod.Show();
                        }
                        else
                        {
                            Hide();
                            Form dash = new Dashboard();
                            dash.FormClosed += (s, args) => Close();
                            dash.Show();
                        }
                    }
                    else
                    {
                        Debug.WriteLine(customer.Id + " failed login attempt at " + DateTime.Now);
                        StatusBar.Status = "Wrong password entered!";
                    }

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    StatusBar.Status = ex.Message;
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
                        Role = rolet,
                        RegisterDate = DateTime.Now,
                        TransactionIDs = []
                    });
                    StatusBar.Status = "Successfully registered. You can now login to your account!";
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    StatusBar.Status = ex.Message;
                }
                _isLogin = true;
                Switch_Menu();
            }
        }

        private void Dark_switch_CheckedChanged(object sender, EventArgs e)
        {
            AppSkinHelper.ToggleDark();
        }
    }
}
