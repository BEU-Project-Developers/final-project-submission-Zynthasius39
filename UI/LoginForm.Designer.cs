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
            banking_banner = new PictureBox();
            email_box = new TextBox();
            password_box = new TextBox();
            submit_button = new Button();
            forgot_link = new LinkLabel();
            signup_link = new LinkLabel();
            name_box = new TextBox();
            surname_box = new TextBox();
            role_radio_1 = new RadioButton();
            role_radio_2 = new RadioButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            phone_box = new TextBox();
            app_label = new Label();
            ((System.ComponentModel.ISupportInitialize)banking_banner).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // banking_banner
            // 
            banking_banner.BackgroundImageLayout = ImageLayout.None;
            banking_banner.Image = Properties.Resources.SOBK0422040_780x440_mobile;
            banking_banner.Location = new Point(12, 12);
            banking_banner.Name = "banking_banner";
            banking_banner.Size = new Size(414, 201);
            banking_banner.SizeMode = PictureBoxSizeMode.StretchImage;
            banking_banner.TabIndex = 2;
            banking_banner.TabStop = false;
            // 
            // email_box
            // 
            email_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            email_box.Location = new Point(97, 305);
            email_box.Name = "email_box";
            email_box.PlaceholderText = "E-Mail";
            email_box.Size = new Size(237, 29);
            email_box.TabIndex = 3;
            // 
            // password_box
            // 
            password_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            password_box.Location = new Point(97, 340);
            password_box.Name = "password_box";
            password_box.PlaceholderText = "Password";
            password_box.Size = new Size(237, 29);
            password_box.TabIndex = 4;
            password_box.UseSystemPasswordChar = true;
            // 
            // submit_button
            // 
            submit_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            submit_button.Location = new Point(97, 520);
            submit_button.Name = "submit_button";
            submit_button.Size = new Size(237, 35);
            submit_button.TabIndex = 5;
            submit_button.Text = "Login";
            submit_button.UseVisualStyleBackColor = true;
            submit_button.Click += submit_button_Click;
            // 
            // forgot_link
            // 
            forgot_link.AutoSize = true;
            forgot_link.Location = new Point(239, 502);
            forgot_link.Name = "forgot_link";
            forgot_link.Size = new Size(95, 15);
            forgot_link.TabIndex = 6;
            forgot_link.TabStop = true;
            forgot_link.Text = "Forgot Password";
            forgot_link.TextAlign = ContentAlignment.TopCenter;
            forgot_link.LinkClicked += forgot_LinkClicked;
            // 
            // signup_link
            // 
            signup_link.AutoSize = true;
            signup_link.Location = new Point(167, 567);
            signup_link.Name = "signup_link";
            signup_link.Size = new Size(99, 15);
            signup_link.TabIndex = 7;
            signup_link.TabStop = true;
            signup_link.Text = "Not a Customer ?";
            signup_link.LinkClicked += signup_link_LinkClicked;
            // 
            // name_box
            // 
            name_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            name_box.Location = new Point(97, 375);
            name_box.Name = "name_box";
            name_box.PlaceholderText = "Name";
            name_box.Size = new Size(237, 29);
            name_box.TabIndex = 8;
            name_box.Visible = false;
            // 
            // surname_box
            // 
            surname_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            surname_box.Location = new Point(97, 410);
            surname_box.Name = "surname_box";
            surname_box.PlaceholderText = "Surname";
            surname_box.Size = new Size(237, 29);
            surname_box.TabIndex = 9;
            surname_box.Visible = false;
            // 
            // role_radio_1
            // 
            role_radio_1.AutoSize = true;
            role_radio_1.Location = new Point(137, 480);
            role_radio_1.Name = "role_radio_1";
            role_radio_1.Size = new Size(70, 19);
            role_radio_1.TabIndex = 10;
            role_radio_1.TabStop = true;
            role_radio_1.Tag = "customer_type";
            role_radio_1.Text = "Member";
            role_radio_1.UseVisualStyleBackColor = true;
            role_radio_1.Visible = false;
            // 
            // role_radio_2
            // 
            role_radio_2.AutoSize = true;
            role_radio_2.Location = new Point(213, 480);
            role_radio_2.Name = "role_radio_2";
            role_radio_2.Size = new Size(70, 19);
            role_radio_2.TabIndex = 11;
            role_radio_2.TabStop = true;
            role_radio_2.Tag = "customer_type";
            role_radio_2.Text = "Business";
            role_radio_2.UseVisualStyleBackColor = true;
            role_radio_2.Visible = false;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 597);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(438, 22);
            statusStrip1.TabIndex = 12;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // phone_box
            // 
            phone_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            phone_box.Location = new Point(97, 445);
            phone_box.Name = "phone_box";
            phone_box.PlaceholderText = "Phone";
            phone_box.Size = new Size(237, 29);
            phone_box.TabIndex = 13;
            phone_box.Visible = false;
            // 
            // app_label
            // 
            app_label.AutoSize = true;
            app_label.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            app_label.Location = new Point(117, 236);
            app_label.Name = "app_label";
            app_label.Size = new Size(206, 45);
            app_label.TabIndex = 14;
            app_label.Text = "BankingAPP";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 619);
            Controls.Add(app_label);
            Controls.Add(phone_box);
            Controls.Add(statusStrip1);
            Controls.Add(role_radio_2);
            Controls.Add(role_radio_1);
            Controls.Add(surname_box);
            Controls.Add(name_box);
            Controls.Add(signup_link);
            Controls.Add(forgot_link);
            Controls.Add(submit_button);
            Controls.Add(password_box);
            Controls.Add(email_box);
            Controls.Add(banking_banner);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "BankingAPP Login";
            ((System.ComponentModel.ISupportInitialize)banking_banner).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox banking_banner;
        private TextBox email_box;
        private TextBox password_box;
        private Button submit_button;
        private LinkLabel forgot_link;
        private LinkLabel signup_link;
        private TextBox name_box;
        private TextBox surname_box;
        private RadioButton role_radio_1;
        private RadioButton role_radio_2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TextBox phone_box;
        private Label app_label;
    }
}
