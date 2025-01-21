namespace BankingApp.UI
{
    partial class PaymentsMini
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentsMini));
            payMiniLayout = new TableLayoutPanel();
            quickPayBtn = new MaterialSkin.Controls.MaterialButton();
            exchangeBtn = new MaterialSkin.Controls.MaterialButton();
            blockCard = new MaterialSkin.Controls.MaterialButton();
            transfer = new MaterialSkin.Controls.MaterialButton();
            supportBtn = new MaterialSkin.Controls.MaterialButton();
            donateBtn = new MaterialSkin.Controls.MaterialButton();
            payMiniLayout.SuspendLayout();
            SuspendLayout();
            // 
            // payMiniLayout
            // 
            payMiniLayout.ColumnCount = 3;
            payMiniLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            payMiniLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            payMiniLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            payMiniLayout.Controls.Add(quickPayBtn, 0, 0);
            payMiniLayout.Controls.Add(exchangeBtn, 1, 0);
            payMiniLayout.Controls.Add(blockCard, 2, 0);
            payMiniLayout.Controls.Add(transfer, 0, 1);
            payMiniLayout.Controls.Add(supportBtn, 1, 1);
            payMiniLayout.Controls.Add(donateBtn, 2, 1);
            payMiniLayout.Dock = DockStyle.Fill;
            payMiniLayout.Location = new Point(0, 0);
            payMiniLayout.Name = "payMiniLayout";
            payMiniLayout.Padding = new Padding(10);
            payMiniLayout.RowCount = 2;
            payMiniLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            payMiniLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            payMiniLayout.Size = new Size(328, 299);
            payMiniLayout.TabIndex = 0;
            // 
            // quickPayBtn
            // 
            quickPayBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            quickPayBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            quickPayBtn.Depth = 0;
            quickPayBtn.Dock = DockStyle.Fill;
            quickPayBtn.HighEmphasis = true;
            quickPayBtn.Icon = (Image)resources.GetObject("quickPayBtn.Icon");
            quickPayBtn.Location = new Point(14, 16);
            quickPayBtn.Margin = new Padding(4, 6, 4, 6);
            quickPayBtn.MouseState = MaterialSkin.MouseState.HOVER;
            quickPayBtn.Name = "quickPayBtn";
            quickPayBtn.NoAccentTextColor = Color.Empty;
            quickPayBtn.Size = new Size(94, 127);
            quickPayBtn.TabIndex = 0;
            quickPayBtn.Text = "Quick-Pay";
            quickPayBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            quickPayBtn.UseAccentColor = false;
            quickPayBtn.UseVisualStyleBackColor = true;
            quickPayBtn.Click += QuickPayBtn_Click;
            // 
            // exchangeBtn
            // 
            exchangeBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            exchangeBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            exchangeBtn.Depth = 0;
            exchangeBtn.Dock = DockStyle.Fill;
            exchangeBtn.HighEmphasis = true;
            exchangeBtn.Icon = (Image)resources.GetObject("exchangeBtn.Icon");
            exchangeBtn.Location = new Point(116, 16);
            exchangeBtn.Margin = new Padding(4, 6, 4, 6);
            exchangeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            exchangeBtn.Name = "exchangeBtn";
            exchangeBtn.NoAccentTextColor = Color.Empty;
            exchangeBtn.Size = new Size(94, 127);
            exchangeBtn.TabIndex = 1;
            exchangeBtn.Text = "Exchange";
            exchangeBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            exchangeBtn.UseAccentColor = false;
            exchangeBtn.UseVisualStyleBackColor = true;
            exchangeBtn.Click += exchangeBtn_Click;
            // 
            // blockCard
            // 
            blockCard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            blockCard.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            blockCard.Depth = 0;
            blockCard.Dock = DockStyle.Fill;
            blockCard.HighEmphasis = true;
            blockCard.Icon = (Image)resources.GetObject("blockCard.Icon");
            blockCard.Location = new Point(218, 16);
            blockCard.Margin = new Padding(4, 6, 4, 6);
            blockCard.MouseState = MaterialSkin.MouseState.HOVER;
            blockCard.Name = "blockCard";
            blockCard.NoAccentTextColor = Color.Empty;
            blockCard.Size = new Size(96, 127);
            blockCard.TabIndex = 2;
            blockCard.Text = "Freeze Account";
            blockCard.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            blockCard.UseAccentColor = false;
            blockCard.UseVisualStyleBackColor = true;
            blockCard.Click += blockCard_Click;
            // 
            // transfer
            // 
            transfer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            transfer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            transfer.Depth = 0;
            transfer.Dock = DockStyle.Fill;
            transfer.HighEmphasis = true;
            transfer.Icon = (Image)resources.GetObject("transfer.Icon");
            transfer.Image = (Image)resources.GetObject("transfer.Image");
            transfer.Location = new Point(14, 155);
            transfer.Margin = new Padding(4, 6, 4, 6);
            transfer.MouseState = MaterialSkin.MouseState.HOVER;
            transfer.Name = "transfer";
            transfer.NoAccentTextColor = Color.Empty;
            transfer.Size = new Size(94, 128);
            transfer.TabIndex = 3;
            transfer.Text = "Transfer";
            transfer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            transfer.UseAccentColor = false;
            transfer.UseVisualStyleBackColor = true;
            transfer.Click += transfer_Click;
            // 
            // supportBtn
            // 
            supportBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            supportBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            supportBtn.Depth = 0;
            supportBtn.Dock = DockStyle.Fill;
            supportBtn.HighEmphasis = true;
            supportBtn.Icon = (Image)resources.GetObject("supportBtn.Icon");
            supportBtn.Location = new Point(116, 155);
            supportBtn.Margin = new Padding(4, 6, 4, 6);
            supportBtn.MouseState = MaterialSkin.MouseState.HOVER;
            supportBtn.Name = "supportBtn";
            supportBtn.NoAccentTextColor = Color.Empty;
            supportBtn.Size = new Size(94, 128);
            supportBtn.TabIndex = 4;
            supportBtn.Text = "get help";
            supportBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            supportBtn.UseAccentColor = false;
            supportBtn.UseVisualStyleBackColor = true;
            // 
            // donateBtn
            // 
            donateBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            donateBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            donateBtn.Depth = 0;
            donateBtn.Dock = DockStyle.Fill;
            donateBtn.HighEmphasis = true;
            donateBtn.Icon = (Image)resources.GetObject("donateBtn.Icon");
            donateBtn.Location = new Point(218, 155);
            donateBtn.Margin = new Padding(4, 6, 4, 6);
            donateBtn.MouseState = MaterialSkin.MouseState.HOVER;
            donateBtn.Name = "donateBtn";
            donateBtn.NoAccentTextColor = Color.Empty;
            donateBtn.Size = new Size(96, 128);
            donateBtn.TabIndex = 5;
            donateBtn.Text = "donate";
            donateBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            donateBtn.UseAccentColor = false;
            donateBtn.UseVisualStyleBackColor = true;
            donateBtn.Click += donateBtn_Click;
            // 
            // PaymentsMini
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(payMiniLayout);
            Name = "PaymentsMini";
            Size = new Size(328, 299);
            payMiniLayout.ResumeLayout(false);
            payMiniLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel payMiniLayout;
        private MaterialSkin.Controls.MaterialButton quickPayBtn;
        private MaterialSkin.Controls.MaterialButton exchangeBtn;
        private MaterialSkin.Controls.MaterialButton blockCard;
        private MaterialSkin.Controls.MaterialButton transfer;
        private MaterialSkin.Controls.MaterialButton supportBtn;
        private MaterialSkin.Controls.MaterialButton donateBtn;
    }
}
