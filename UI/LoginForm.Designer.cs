using MaterialSkin.Controls;

namespace BankingApp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            email_box = new MaterialTextBox2();
            password_box = new MaterialTextBox2();
            submit_button = new MaterialButton();
            forgot_link = new LinkLabel();
            name_box = new MaterialTextBox2();
            surname_box = new MaterialTextBox2();
            role_radio_1 = new MaterialRadioButton();
            role_radio_2 = new MaterialRadioButton();
            statusStrip1 = new StatusStrip();
            statusBar = new ToolStripStatusLabel();
            phone_box = new MaterialTextBox2();
            banking_banner = new PictureBox();
            banking_title = new MaterialLabel();
            dark_switch = new MaterialSwitch();
            signup_button = new MaterialButton();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)banking_banner).BeginInit();
            SuspendLayout();
            // 
            // email_box
            // 
            email_box.Anchor = AnchorStyles.None;
            email_box.AnimateReadOnly = false;
            email_box.BackgroundImageLayout = ImageLayout.None;
            email_box.CharacterCasing = CharacterCasing.Normal;
            email_box.Depth = 0;
            email_box.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            email_box.HideSelection = true;
            email_box.Hint = "E-Mail";
            email_box.LeadingIcon = null;
            email_box.Location = new Point(36, 334);
            email_box.MaxLength = 50;
            email_box.MouseState = MaterialSkin.MouseState.OUT;
            email_box.Name = "email_box";
            email_box.PasswordChar = '\0';
            email_box.PrefixSuffixText = null;
            email_box.ReadOnly = false;
            email_box.RightToLeft = RightToLeft.No;
            email_box.SelectedText = "";
            email_box.SelectionLength = 0;
            email_box.SelectionStart = 0;
            email_box.ShortcutsEnabled = true;
            email_box.Size = new Size(310, 48);
            email_box.TabIndex = 0;
            email_box.TabStop = false;
            email_box.TextAlign = HorizontalAlignment.Left;
            email_box.TrailingIcon = null;
            email_box.UseSystemPasswordChar = false;
            // 
            // password_box
            // 
            password_box.Anchor = AnchorStyles.None;
            password_box.AnimateReadOnly = false;
            password_box.BackgroundImageLayout = ImageLayout.None;
            password_box.CharacterCasing = CharacterCasing.Normal;
            password_box.Depth = 0;
            password_box.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            password_box.HelperText = "Repeat your password";
            password_box.HideSelection = true;
            password_box.Hint = "Password";
            password_box.LeadingIcon = null;
            password_box.Location = new Point(36, 388);
            password_box.MaxLength = 50;
            password_box.MouseState = MaterialSkin.MouseState.OUT;
            password_box.Name = "password_box";
            password_box.PasswordChar = '●';
            password_box.PrefixSuffixText = null;
            password_box.ReadOnly = false;
            password_box.RightToLeft = RightToLeft.No;
            password_box.SelectedText = "";
            password_box.SelectionLength = 0;
            password_box.SelectionStart = 0;
            password_box.ShortcutsEnabled = true;
            password_box.Size = new Size(310, 48);
            password_box.TabIndex = 1;
            password_box.TabStop = false;
            password_box.TextAlign = HorizontalAlignment.Left;
            password_box.TrailingIcon = null;
            password_box.UseSystemPasswordChar = true;
            // 
            // submit_button
            // 
            submit_button.Anchor = AnchorStyles.None;
            submit_button.AutoSize = false;
            submit_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            submit_button.BackColor = Color.SlateBlue;
            submit_button.Density = MaterialButton.MaterialButtonDensity.Default;
            submit_button.Depth = 0;
            submit_button.FlatAppearance.BorderColor = Color.Indigo;
            submit_button.FlatAppearance.BorderSize = 5;
            submit_button.FlatStyle = FlatStyle.Popup;
            submit_button.Font = new Font("Noto Sans", 14F, FontStyle.Bold);
            submit_button.ForeColor = SystemColors.Control;
            submit_button.HighEmphasis = true;
            submit_button.Icon = null;
            submit_button.Location = new Point(36, 691);
            submit_button.Margin = new Padding(4, 6, 4, 6);
            submit_button.MouseState = MaterialSkin.MouseState.HOVER;
            submit_button.Name = "submit_button";
            submit_button.NoAccentTextColor = Color.Empty;
            submit_button.Size = new Size(310, 36);
            submit_button.TabIndex = 7;
            submit_button.Text = "Login";
            submit_button.Type = MaterialButton.MaterialButtonType.Contained;
            submit_button.UseAccentColor = true;
            submit_button.UseVisualStyleBackColor = false;
            submit_button.Click += Submit_button_Click;
            // 
            // forgot_link
            // 
            forgot_link.Anchor = AnchorStyles.None;
            forgot_link.BackColor = Color.Transparent;
            forgot_link.Font = new Font("Noto Sans", 9F);
            forgot_link.LinkColor = Color.Blue;
            forgot_link.Location = new Point(36, 667);
            forgot_link.Name = "forgot_link";
            forgot_link.Size = new Size(310, 18);
            forgot_link.TabIndex = 8;
            forgot_link.TabStop = true;
            forgot_link.Text = "Forgot Password";
            forgot_link.TextAlign = ContentAlignment.MiddleRight;
            forgot_link.LinkClicked += Forgot_LinkClicked;
            // 
            // name_box
            // 
            name_box.Anchor = AnchorStyles.None;
            name_box.AnimateReadOnly = false;
            name_box.BackgroundImageLayout = ImageLayout.None;
            name_box.CharacterCasing = CharacterCasing.Normal;
            name_box.Depth = 0;
            name_box.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            name_box.HideSelection = true;
            name_box.Hint = "Name";
            name_box.LeadingIcon = null;
            name_box.Location = new Point(36, 442);
            name_box.MaxLength = 50;
            name_box.MouseState = MaterialSkin.MouseState.OUT;
            name_box.Name = "name_box";
            name_box.PasswordChar = '\0';
            name_box.PrefixSuffixText = null;
            name_box.ReadOnly = false;
            name_box.RightToLeft = RightToLeft.No;
            name_box.SelectedText = "";
            name_box.SelectionLength = 0;
            name_box.SelectionStart = 0;
            name_box.ShortcutsEnabled = true;
            name_box.Size = new Size(310, 48);
            name_box.TabIndex = 2;
            name_box.TabStop = false;
            name_box.TextAlign = HorizontalAlignment.Left;
            name_box.TrailingIcon = null;
            name_box.UseSystemPasswordChar = false;
            name_box.Visible = false;
            // 
            // surname_box
            // 
            surname_box.Anchor = AnchorStyles.None;
            surname_box.AnimateReadOnly = false;
            surname_box.BackgroundImageLayout = ImageLayout.None;
            surname_box.CharacterCasing = CharacterCasing.Normal;
            surname_box.Depth = 0;
            surname_box.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            surname_box.HideSelection = true;
            surname_box.Hint = "Surname";
            surname_box.LeadingIcon = null;
            surname_box.Location = new Point(36, 498);
            surname_box.MaxLength = 50;
            surname_box.MouseState = MaterialSkin.MouseState.OUT;
            surname_box.Name = "surname_box";
            surname_box.PasswordChar = '\0';
            surname_box.PrefixSuffixText = null;
            surname_box.ReadOnly = false;
            surname_box.RightToLeft = RightToLeft.No;
            surname_box.SelectedText = "";
            surname_box.SelectionLength = 0;
            surname_box.SelectionStart = 0;
            surname_box.ShortcutsEnabled = true;
            surname_box.Size = new Size(310, 48);
            surname_box.TabIndex = 3;
            surname_box.TabStop = false;
            surname_box.TextAlign = HorizontalAlignment.Left;
            surname_box.TrailingIcon = null;
            surname_box.UseSystemPasswordChar = false;
            surname_box.Visible = false;
            // 
            // role_radio_1
            // 
            role_radio_1.Anchor = AnchorStyles.None;
            role_radio_1.AutoSize = true;
            role_radio_1.Depth = 0;
            role_radio_1.Font = new Font("Noto Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            role_radio_1.ForeColor = Color.BlueViolet;
            role_radio_1.Location = new Point(80, 605);
            role_radio_1.Margin = new Padding(0);
            role_radio_1.MouseLocation = new Point(-1, -1);
            role_radio_1.MouseState = MaterialSkin.MouseState.HOVER;
            role_radio_1.Name = "role_radio_1";
            role_radio_1.Ripple = true;
            role_radio_1.Size = new Size(93, 37);
            role_radio_1.TabIndex = 5;
            role_radio_1.TabStop = true;
            role_radio_1.Tag = "customer_type";
            role_radio_1.Text = "Member";
            role_radio_1.UseVisualStyleBackColor = true;
            role_radio_1.Visible = false;
            // 
            // role_radio_2
            // 
            role_radio_2.Anchor = AnchorStyles.None;
            role_radio_2.AutoSize = true;
            role_radio_2.Depth = 0;
            role_radio_2.Font = new Font("Noto Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            role_radio_2.ForeColor = Color.BlueViolet;
            role_radio_2.Location = new Point(195, 605);
            role_radio_2.Margin = new Padding(0);
            role_radio_2.MouseLocation = new Point(-1, -1);
            role_radio_2.MouseState = MaterialSkin.MouseState.HOVER;
            role_radio_2.Name = "role_radio_2";
            role_radio_2.Ripple = true;
            role_radio_2.Size = new Size(99, 37);
            role_radio_2.TabIndex = 6;
            role_radio_2.TabStop = true;
            role_radio_2.Tag = "customer_type";
            role_radio_2.Text = "Business";
            role_radio_2.UseVisualStyleBackColor = true;
            role_radio_2.Visible = false;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusBar });
            statusStrip1.Location = new Point(3, 906);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(377, 22);
            statusStrip1.TabIndex = 12;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusBar
            // 
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(55, 17);
            statusBar.Text = "statusBar";
            // 
            // phone_box
            // 
            phone_box.Anchor = AnchorStyles.None;
            phone_box.AnimateReadOnly = false;
            phone_box.BackgroundImageLayout = ImageLayout.None;
            phone_box.CharacterCasing = CharacterCasing.Normal;
            phone_box.Depth = 0;
            phone_box.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            phone_box.HideSelection = true;
            phone_box.Hint = "Phone";
            phone_box.LeadingIcon = null;
            phone_box.Location = new Point(36, 554);
            phone_box.MaxLength = 50;
            phone_box.MouseState = MaterialSkin.MouseState.OUT;
            phone_box.Name = "phone_box";
            phone_box.PasswordChar = '\0';
            phone_box.PrefixSuffixText = null;
            phone_box.ReadOnly = false;
            phone_box.RightToLeft = RightToLeft.No;
            phone_box.SelectedText = "";
            phone_box.SelectionLength = 0;
            phone_box.SelectionStart = 0;
            phone_box.ShortcutsEnabled = true;
            phone_box.Size = new Size(310, 48);
            phone_box.TabIndex = 4;
            phone_box.TabStop = false;
            phone_box.TextAlign = HorizontalAlignment.Left;
            phone_box.TrailingIcon = null;
            phone_box.UseSystemPasswordChar = false;
            phone_box.Visible = false;
            // 
            // banking_banner
            // 
            banking_banner.Anchor = AnchorStyles.None;
            banking_banner.BackColor = Color.Transparent;
            banking_banner.BackgroundImageLayout = ImageLayout.None;
            banking_banner.Image = Properties.Resources.gringotts_white;
            banking_banner.Location = new Point(104, 82);
            banking_banner.Name = "banking_banner";
            banking_banner.Size = new Size(175, 175);
            banking_banner.SizeMode = PictureBoxSizeMode.StretchImage;
            banking_banner.TabIndex = 2;
            banking_banner.TabStop = false;
            // 
            // banking_title
            // 
            banking_title.Anchor = AnchorStyles.None;
            banking_title.AutoSize = true;
            banking_title.Depth = 0;
            banking_title.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            banking_title.Location = new Point(104, 286);
            banking_title.MouseState = MaterialSkin.MouseState.HOVER;
            banking_title.Name = "banking_title";
            banking_title.Size = new Size(181, 19);
            banking_title.TabIndex = 14;
            banking_title.Text = "Gringotts Wizarding Bank";
            // 
            // dark_switch
            // 
            dark_switch.AutoSize = true;
            dark_switch.Checked = true;
            dark_switch.CheckState = CheckState.Checked;
            dark_switch.Depth = 0;
            dark_switch.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dark_switch.Location = new Point(26, 816);
            dark_switch.Margin = new Padding(0);
            dark_switch.MouseLocation = new Point(-1, -1);
            dark_switch.MouseState = MaterialSkin.MouseState.HOVER;
            dark_switch.Name = "dark_switch";
            dark_switch.Ripple = true;
            dark_switch.Size = new Size(135, 37);
            dark_switch.TabIndex = 16;
            dark_switch.Text = "Dark Mode";
            dark_switch.UseVisualStyleBackColor = true;
            dark_switch.CheckedChanged += Dark_switch_CheckedChanged;
            // 
            // signup_button
            // 
            signup_button.Anchor = AnchorStyles.None;
            signup_button.AutoSize = false;
            signup_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            signup_button.BackColor = Color.Transparent;
            signup_button.Density = MaterialButton.MaterialButtonDensity.Default;
            signup_button.Depth = 0;
            signup_button.FlatAppearance.BorderColor = Color.SlateBlue;
            signup_button.FlatAppearance.BorderSize = 5;
            signup_button.Font = new Font("Noto Sans", 14F, FontStyle.Bold);
            signup_button.ForeColor = SystemColors.WindowText;
            signup_button.HighEmphasis = true;
            signup_button.Icon = null;
            signup_button.Location = new Point(36, 739);
            signup_button.Margin = new Padding(4, 6, 4, 6);
            signup_button.MouseState = MaterialSkin.MouseState.HOVER;
            signup_button.Name = "signup_button";
            signup_button.NoAccentTextColor = Color.Empty;
            signup_button.Size = new Size(310, 36);
            signup_button.TabIndex = 7;
            signup_button.Text = "Signup";
            signup_button.Type = MaterialButton.MaterialButtonType.Outlined;
            signup_button.UseAccentColor = true;
            signup_button.UseVisualStyleBackColor = false;
            signup_button.Click += Signup_button_Click;
            // 
            // LoginForm
            // 
            AcceptButton = submit_button;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(383, 931);
            Controls.Add(dark_switch);
            Controls.Add(banking_title);
            Controls.Add(phone_box);
            Controls.Add(statusStrip1);
            Controls.Add(role_radio_2);
            Controls.Add(role_radio_1);
            Controls.Add(surname_box);
            Controls.Add(name_box);
            Controls.Add(forgot_link);
            Controls.Add(signup_button);
            Controls.Add(submit_button);
            Controls.Add(password_box);
            Controls.Add(email_box);
            Controls.Add(banking_banner);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            FormStyle = FormStyles.ActionBar_None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginForm";
            Padding = new Padding(3, 24, 3, 3);
            Text = "Login";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)banking_banner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialTextBox2 email_box;
        private MaterialTextBox2 password_box;
        private MaterialButton submit_button;
        private LinkLabel forgot_link;
        private MaterialTextBox2 name_box;
        private MaterialTextBox2 surname_box;
        private MaterialRadioButton role_radio_1;
        private MaterialRadioButton role_radio_2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusBar;
        private MaterialTextBox2 phone_box;
        private PictureBox banking_banner;
        private MaterialLabel banking_title;
        private MaterialSwitch dark_switch;
        private MaterialButton signup_button;
    }
}
