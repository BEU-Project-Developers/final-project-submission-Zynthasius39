namespace BankingApp.UI
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.ComponentModel.ComponentResourceManager resources = null;

        /// <sumGmary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            TabControl = new MaterialSkin.Controls.MaterialTabControl();
            home = new TabPage();
            cards = new TabPage();
            cardsTable = new TableLayoutPanel();
            payments = new TabPage();
            paymentsTable = new TableLayoutPanel();
            account = new TabPage();
            imageList1 = new ImageList(components);
            logoutButton = new MaterialSkin.Controls.MaterialButton();
            TabControl.SuspendLayout();
            cards.SuspendLayout();
            payments.SuspendLayout();
            account.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(home);
            TabControl.Controls.Add(cards);
            TabControl.Controls.Add(payments);
            TabControl.Controls.Add(account);
            TabControl.Depth = 0;
            TabControl.Dock = DockStyle.Fill;
            TabControl.ImageList = imageList1;
            TabControl.Location = new Point(0, 72);
            TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            TabControl.Multiline = true;
            TabControl.Name = "TabControl";
            TabControl.Padding = new Point(12, 12);
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1021, 693);
            TabControl.TabIndex = 0;
            // 
            // home
            // 
            home.ImageKey = "home.png";
            home.Location = new Point(4, 57);
            home.Name = "home";
            home.Size = new Size(1013, 632);
            home.TabIndex = 2;
            home.Text = "Home";
            home.UseVisualStyleBackColor = true;
            // 
            // cards
            // 
            cards.BackColor = Color.Transparent;
            cards.Controls.Add(cardsTable);
            cards.ImageKey = "credit-card.png";
            cards.Location = new Point(4, 57);
            cards.Name = "cards";
            cards.Padding = new Padding(3);
            cards.Size = new Size(1013, 632);
            cards.TabIndex = 0;
            cards.Text = "Cards";
            // 
            // cardsTable
            // 
            cardsTable.AutoScroll = true;
            cardsTable.ColumnCount = 1;
            cardsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            cardsTable.Dock = DockStyle.Fill;
            cardsTable.Location = new Point(3, 3);
            cardsTable.Name = "cardsTable";
            cardsTable.RowCount = 1;
            cardsTable.RowStyles.Add(new RowStyle());
            cardsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            cardsTable.Size = new Size(1007, 626);
            cardsTable.TabIndex = 0;
            // 
            // payments
            // 
            payments.Controls.Add(paymentsTable);
            payments.ImageKey = "wallet.png";
            payments.Location = new Point(4, 57);
            payments.Name = "payments";
            payments.Padding = new Padding(3);
            payments.Size = new Size(1013, 632);
            payments.TabIndex = 1;
            payments.Text = "Payments";
            payments.UseVisualStyleBackColor = true;
            // 
            // paymentsTable
            // 
            paymentsTable.AutoScroll = true;
            paymentsTable.ColumnCount = 1;
            paymentsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            paymentsTable.Dock = DockStyle.Fill;
            paymentsTable.Location = new Point(3, 3);
            paymentsTable.Name = "paymentsTable";
            paymentsTable.RowCount = 1;
            paymentsTable.RowStyles.Add(new RowStyle());
            paymentsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            paymentsTable.Size = new Size(1007, 626);
            paymentsTable.TabIndex = 0;
            // 
            // account
            // 
            account.Controls.Add(logoutButton);
            account.ImageKey = "user.png";
            account.Location = new Point(4, 57);
            account.Name = "account";
            account.Size = new Size(1013, 632);
            account.TabIndex = 3;
            account.Text = "Account";
            account.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "home.png");
            imageList1.Images.SetKeyName(1, "credit-card.png");
            imageList1.Images.SetKeyName(2, "wallet.png");
            imageList1.Images.SetKeyName(3, "user.png");
            // 
            // logoutButton
            // 
            logoutButton.AutoSize = false;
            logoutButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            logoutButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            logoutButton.Depth = 0;
            logoutButton.HighEmphasis = true;
            logoutButton.Icon = null;
            logoutButton.Location = new Point(20, 20);
            logoutButton.Margin = new Padding(4, 6, 4, 6);
            logoutButton.MouseState = MaterialSkin.MouseState.HOVER;
            logoutButton.Name = "logoutButton";
            logoutButton.NoAccentTextColor = Color.Empty;
            logoutButton.Size = new Size(100, 36);
            logoutButton.TabIndex = 2;
            logoutButton.Text = "LogOut";
            logoutButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            logoutButton.UseAccentColor = false;
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += LogoutButton_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1024, 768);
            Controls.Add(TabControl);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = TabControl;
            FormStyle = FormStyles.ActionBar_48;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1024, 768);
            Name = "Dashboard";
            Padding = new Padding(0, 72, 3, 3);
            Text = "Dashboard";
            TabControl.ResumeLayout(false);
            cards.ResumeLayout(false);
            payments.ResumeLayout(false);
            account.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private TabPage cards;
        private TabPage payments;
        private ImageList imageList1;
        private TableLayoutPanel cardsTable;
        private TableLayoutPanel paymentsTable;
        private TabPage home;
        private TabPage account;
        private MaterialSkin.Controls.MaterialButton logoutButton;
    }
}