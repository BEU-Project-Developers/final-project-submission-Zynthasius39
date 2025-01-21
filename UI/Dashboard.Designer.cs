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
            homeLayout = new TableLayoutPanel();
            infoLayout = new TableLayoutPanel();
            paymentsMini1 = new PaymentsMini();
            transactionsTable = new TableLayoutPanel();
            tractHistoryLabel = new MaterialSkin.Controls.MaterialLabel();
            customerLayout = new TableLayoutPanel();
            profilePic = new PictureBox();
            customerName = new MaterialSkin.Controls.MaterialLabel();
            logoutButton0 = new MaterialSkin.Controls.MaterialButton();
            customerInfo = new MaterialSkin.Controls.MaterialLabel();
            refreshButton = new MaterialSkin.Controls.MaterialButton();
            cards = new TabPage();
            cardsTable = new TableLayoutPanel();
            payments = new TabPage();
            paymentsTable = new TableLayoutPanel();
            account = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            logoutButton1 = new MaterialSkin.Controls.MaterialButton();
            accountOp0 = new MaterialSkin.Controls.MaterialLabel();
            accountBtn0 = new MaterialSkin.Controls.MaterialButton();
            accountOp3 = new MaterialSkin.Controls.MaterialLabel();
            cusDelBtn = new MaterialSkin.Controls.MaterialButton();
            accountOp4 = new MaterialSkin.Controls.MaterialLabel();
            accComboBox = new MaterialSkin.Controls.MaterialComboBox();
            imageList1 = new ImageList(components);
            mainStrip = new StatusStrip();
            mainStatus = new ToolStripStatusLabel();
            mainTips = new ToolTip(components);
            TabControl.SuspendLayout();
            home.SuspendLayout();
            homeLayout.SuspendLayout();
            infoLayout.SuspendLayout();
            customerLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePic).BeginInit();
            cards.SuspendLayout();
            payments.SuspendLayout();
            account.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            mainStrip.SuspendLayout();
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
            home.Controls.Add(homeLayout);
            home.ImageKey = "home.png";
            home.Location = new Point(4, 57);
            home.Name = "home";
            home.Padding = new Padding(20);
            home.Size = new Size(1013, 632);
            home.TabIndex = 2;
            home.Text = "Home";
            home.UseVisualStyleBackColor = true;
            // 
            // homeLayout
            // 
            homeLayout.ColumnCount = 2;
            homeLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            homeLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            homeLayout.Controls.Add(infoLayout, 0, 0);
            homeLayout.Controls.Add(customerLayout, 1, 0);
            homeLayout.Dock = DockStyle.Fill;
            homeLayout.Location = new Point(20, 20);
            homeLayout.Name = "homeLayout";
            homeLayout.RowCount = 1;
            homeLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            homeLayout.Size = new Size(973, 592);
            homeLayout.TabIndex = 0;
            // 
            // infoLayout
            // 
            infoLayout.ColumnCount = 1;
            infoLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            infoLayout.Controls.Add(paymentsMini1, 0, 0);
            infoLayout.Controls.Add(transactionsTable, 0, 2);
            infoLayout.Controls.Add(tractHistoryLabel, 0, 1);
            infoLayout.Dock = DockStyle.Fill;
            infoLayout.Location = new Point(3, 3);
            infoLayout.Name = "infoLayout";
            infoLayout.RowCount = 3;
            infoLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            infoLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            infoLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            infoLayout.Size = new Size(723, 586);
            infoLayout.TabIndex = 1;
            // 
            // paymentsMini1
            // 
            paymentsMini1.Dock = DockStyle.Fill;
            paymentsMini1.Location = new Point(3, 3);
            paymentsMini1.Name = "paymentsMini1";
            paymentsMini1.Size = new Size(717, 267);
            paymentsMini1.TabIndex = 0;
            // 
            // transactionsTable
            // 
            transactionsTable.AutoScroll = true;
            transactionsTable.ColumnCount = 1;
            transactionsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            transactionsTable.Dock = DockStyle.Fill;
            transactionsTable.Location = new Point(1, 314);
            transactionsTable.Margin = new Padding(1);
            transactionsTable.Name = "transactionsTable";
            transactionsTable.RowCount = 2;
            transactionsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            transactionsTable.RowStyles.Add(new RowStyle());
            transactionsTable.Size = new Size(721, 271);
            transactionsTable.TabIndex = 1;
            // 
            // tractHistoryLabel
            // 
            tractHistoryLabel.AutoSize = true;
            tractHistoryLabel.Depth = 0;
            tractHistoryLabel.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            tractHistoryLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            tractHistoryLabel.Location = new Point(3, 273);
            tractHistoryLabel.MouseState = MaterialSkin.MouseState.HOVER;
            tractHistoryLabel.Name = "tractHistoryLabel";
            tractHistoryLabel.Size = new Size(210, 29);
            tractHistoryLabel.TabIndex = 2;
            tractHistoryLabel.Text = "Transaction History";
            // 
            // customerLayout
            // 
            customerLayout.ColumnCount = 1;
            customerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            customerLayout.Controls.Add(profilePic, 0, 0);
            customerLayout.Controls.Add(customerName, 0, 1);
            customerLayout.Controls.Add(logoutButton0, 0, 3);
            customerLayout.Controls.Add(customerInfo, 0, 2);
            customerLayout.Controls.Add(refreshButton, 0, 4);
            customerLayout.Dock = DockStyle.Fill;
            customerLayout.Location = new Point(732, 3);
            customerLayout.Name = "customerLayout";
            customerLayout.RowCount = 5;
            customerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            customerLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            customerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            customerLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            customerLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            customerLayout.Size = new Size(238, 586);
            customerLayout.TabIndex = 2;
            // 
            // profilePic
            // 
            profilePic.Dock = DockStyle.Fill;
            profilePic.Location = new Point(10, 10);
            profilePic.Margin = new Padding(10);
            profilePic.Name = "profilePic";
            profilePic.Size = new Size(218, 208);
            profilePic.SizeMode = PictureBoxSizeMode.Zoom;
            profilePic.TabIndex = 0;
            profilePic.TabStop = false;
            // 
            // customerName
            // 
            customerName.AutoSize = true;
            customerName.Depth = 0;
            customerName.Dock = DockStyle.Fill;
            customerName.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            customerName.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            customerName.Location = new Point(3, 228);
            customerName.MouseState = MaterialSkin.MouseState.HOVER;
            customerName.Name = "customerName";
            customerName.Size = new Size(232, 30);
            customerName.TabIndex = 1;
            customerName.Text = "undefined";
            customerName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logoutButton0
            // 
            logoutButton0.AutoSize = false;
            logoutButton0.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            logoutButton0.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            logoutButton0.Depth = 0;
            logoutButton0.Dock = DockStyle.Fill;
            logoutButton0.HighEmphasis = true;
            logoutButton0.Icon = null;
            logoutButton0.Location = new Point(4, 492);
            logoutButton0.Margin = new Padding(4, 6, 4, 6);
            logoutButton0.MouseState = MaterialSkin.MouseState.HOVER;
            logoutButton0.Name = "logoutButton0";
            logoutButton0.NoAccentTextColor = Color.Empty;
            logoutButton0.Size = new Size(230, 38);
            logoutButton0.TabIndex = 2;
            logoutButton0.Text = "LogOut";
            logoutButton0.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            logoutButton0.UseAccentColor = false;
            logoutButton0.UseVisualStyleBackColor = true;
            logoutButton0.Click += LogoutButton_Click;
            // 
            // customerInfo
            // 
            customerInfo.AutoSize = true;
            customerInfo.Depth = 0;
            customerInfo.Dock = DockStyle.Fill;
            customerInfo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            customerInfo.Location = new Point(10, 268);
            customerInfo.Margin = new Padding(10);
            customerInfo.MouseState = MaterialSkin.MouseState.HOVER;
            customerInfo.Name = "customerInfo";
            customerInfo.Size = new Size(218, 208);
            customerInfo.TabIndex = 3;
            customerInfo.Text = "NetWorth:\r\nTotal Shares: \r\nTotal Debt: \r\nActive accounts:\r\nActive contracts:\r\nTotal Transactions:\r\nRegistered in:";
            // 
            // refreshButton
            // 
            refreshButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            refreshButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            refreshButton.Depth = 0;
            refreshButton.Dock = DockStyle.Fill;
            refreshButton.HighEmphasis = true;
            refreshButton.Icon = null;
            refreshButton.Location = new Point(4, 542);
            refreshButton.Margin = new Padding(4, 6, 4, 6);
            refreshButton.MouseState = MaterialSkin.MouseState.HOVER;
            refreshButton.Name = "refreshButton";
            refreshButton.NoAccentTextColor = Color.Empty;
            refreshButton.Size = new Size(230, 38);
            refreshButton.TabIndex = 4;
            refreshButton.Text = "Refresh";
            refreshButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            refreshButton.UseAccentColor = false;
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += Refresh_Btn_Click;
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
            account.Controls.Add(tableLayoutPanel1);
            account.ImageKey = "user.png";
            account.Location = new Point(4, 57);
            account.Name = "account";
            account.Size = new Size(1013, 632);
            account.TabIndex = 3;
            account.Text = "Account";
            account.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(logoutButton1, 1, 5);
            tableLayoutPanel1.Controls.Add(accountOp0, 0, 0);
            tableLayoutPanel1.Controls.Add(accountBtn0, 1, 0);
            tableLayoutPanel1.Controls.Add(accountOp3, 0, 1);
            tableLayoutPanel1.Controls.Add(cusDelBtn, 1, 1);
            tableLayoutPanel1.Controls.Add(accountOp4, 0, 2);
            tableLayoutPanel1.Controls.Add(accComboBox, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20);
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1013, 632);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // logoutButton1
            // 
            logoutButton1.AutoSize = false;
            logoutButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            logoutButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            logoutButton1.Depth = 0;
            logoutButton1.Dock = DockStyle.Fill;
            logoutButton1.HighEmphasis = true;
            logoutButton1.Icon = null;
            logoutButton1.Location = new Point(802, 568);
            logoutButton1.Margin = new Padding(4, 6, 4, 6);
            logoutButton1.MouseState = MaterialSkin.MouseState.HOVER;
            logoutButton1.Name = "logoutButton1";
            logoutButton1.NoAccentTextColor = Color.Empty;
            logoutButton1.Size = new Size(187, 38);
            logoutButton1.TabIndex = 2;
            logoutButton1.Text = "LogOut";
            logoutButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            logoutButton1.UseAccentColor = false;
            logoutButton1.UseVisualStyleBackColor = true;
            logoutButton1.Click += LogoutButton_Click;
            // 
            // accountOp0
            // 
            accountOp0.AutoSize = true;
            accountOp0.Depth = 0;
            accountOp0.Dock = DockStyle.Fill;
            accountOp0.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            accountOp0.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            accountOp0.Location = new Point(23, 20);
            accountOp0.MouseState = MaterialSkin.MouseState.HOVER;
            accountOp0.Name = "accountOp0";
            accountOp0.Size = new Size(772, 50);
            accountOp0.TabIndex = 3;
            accountOp0.Text = "Reset your password";
            accountOp0.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // accountBtn0
            // 
            accountBtn0.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            accountBtn0.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            accountBtn0.Depth = 0;
            accountBtn0.Dock = DockStyle.Fill;
            accountBtn0.HighEmphasis = true;
            accountBtn0.Icon = null;
            accountBtn0.Location = new Point(802, 26);
            accountBtn0.Margin = new Padding(4, 6, 4, 6);
            accountBtn0.MouseState = MaterialSkin.MouseState.HOVER;
            accountBtn0.Name = "accountBtn0";
            accountBtn0.NoAccentTextColor = Color.Empty;
            accountBtn0.Size = new Size(187, 38);
            accountBtn0.TabIndex = 4;
            accountBtn0.Text = "Change Password";
            accountBtn0.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            accountBtn0.UseAccentColor = false;
            accountBtn0.UseVisualStyleBackColor = true;
            accountBtn0.Click += ChangePassword_Click;
            // 
            // accountOp3
            // 
            accountOp3.AutoSize = true;
            accountOp3.Depth = 0;
            accountOp3.Dock = DockStyle.Fill;
            accountOp3.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            accountOp3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            accountOp3.Location = new Point(23, 70);
            accountOp3.MouseState = MaterialSkin.MouseState.HOVER;
            accountOp3.Name = "accountOp3";
            accountOp3.Size = new Size(772, 50);
            accountOp3.TabIndex = 3;
            accountOp3.Text = "Delete your account";
            accountOp3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cusDelBtn
            // 
            cusDelBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cusDelBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            cusDelBtn.Depth = 0;
            cusDelBtn.Dock = DockStyle.Fill;
            cusDelBtn.HighEmphasis = true;
            cusDelBtn.Icon = null;
            cusDelBtn.Location = new Point(802, 76);
            cusDelBtn.Margin = new Padding(4, 6, 4, 6);
            cusDelBtn.MouseState = MaterialSkin.MouseState.HOVER;
            cusDelBtn.Name = "cusDelBtn";
            cusDelBtn.NoAccentTextColor = Color.Empty;
            cusDelBtn.Size = new Size(187, 38);
            cusDelBtn.TabIndex = 4;
            cusDelBtn.Text = "Delete Account";
            cusDelBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            cusDelBtn.UseAccentColor = false;
            cusDelBtn.UseVisualStyleBackColor = true;
            cusDelBtn.Click += DeleteAccount_Click;
            // 
            // accountOp4
            // 
            accountOp4.AutoSize = true;
            accountOp4.Depth = 0;
            accountOp4.Dock = DockStyle.Fill;
            accountOp4.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            accountOp4.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            accountOp4.Location = new Point(23, 120);
            accountOp4.MouseState = MaterialSkin.MouseState.HOVER;
            accountOp4.Name = "accountOp4";
            accountOp4.Size = new Size(772, 50);
            accountOp4.TabIndex = 5;
            accountOp4.Text = "Default Account";
            accountOp4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // accComboBox
            // 
            accComboBox.AutoResize = false;
            accComboBox.BackColor = Color.FromArgb(255, 255, 255);
            accComboBox.Depth = 0;
            accComboBox.Dock = DockStyle.Fill;
            accComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            accComboBox.DropDownHeight = 174;
            accComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            accComboBox.DropDownWidth = 121;
            accComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            accComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            accComboBox.FormattingEnabled = true;
            accComboBox.IntegralHeight = false;
            accComboBox.ItemHeight = 43;
            accComboBox.Location = new Point(801, 123);
            accComboBox.MaxDropDownItems = 4;
            accComboBox.MouseState = MaterialSkin.MouseState.OUT;
            accComboBox.Name = "accComboBox";
            accComboBox.Size = new Size(189, 49);
            accComboBox.StartIndex = 0;
            accComboBox.TabIndex = 6;
            accComboBox.SelectedIndexChanged += accComboBox_SelectedIndexChanged;
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
            // mainStrip
            // 
            mainStrip.Items.AddRange(new ToolStripItem[] { mainStatus });
            mainStrip.Location = new Point(0, 743);
            mainStrip.Name = "mainStrip";
            mainStrip.Size = new Size(1021, 22);
            mainStrip.TabIndex = 1;
            // 
            // mainStatus
            // 
            mainStatus.Name = "mainStatus";
            mainStatus.Size = new Size(0, 17);
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1024, 768);
            Controls.Add(mainStrip);
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
            home.ResumeLayout(false);
            homeLayout.ResumeLayout(false);
            infoLayout.ResumeLayout(false);
            infoLayout.PerformLayout();
            customerLayout.ResumeLayout(false);
            customerLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilePic).EndInit();
            cards.ResumeLayout(false);
            payments.ResumeLayout(false);
            account.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            mainStrip.ResumeLayout(false);
            mainStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private MaterialSkin.Controls.MaterialButton logoutButton1;
        private TableLayoutPanel homeLayout;
        private TableLayoutPanel infoLayout;
        private TableLayoutPanel customerLayout;
        private PictureBox profilePic;
        private MaterialSkin.Controls.MaterialLabel customerName;
        private MaterialSkin.Controls.MaterialButton logoutButton0;
        private MaterialSkin.Controls.MaterialLabel customerInfo;
        private PaymentsMini paymentsMini1;
        private TableLayoutPanel transactionsTable;
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel accountOp0;
        private MaterialSkin.Controls.MaterialButton accountBtn0;
        private StatusStrip mainStrip;
        private ToolStripStatusLabel mainStatus;
        private MaterialSkin.Controls.MaterialLabel accountOp3;
        private MaterialSkin.Controls.MaterialButton cusDelBtn;
        private ToolTip mainTips;
        private MaterialSkin.Controls.MaterialLabel tractHistoryLabel;
        private MaterialSkin.Controls.MaterialButton refreshButton;
        private MaterialSkin.Controls.MaterialLabel accountOp4;
        private MaterialSkin.Controls.MaterialComboBox accComboBox;
    }
}