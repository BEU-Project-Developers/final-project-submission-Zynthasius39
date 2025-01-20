namespace BankingApp.UI
{
    partial class PaymentBox
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentBox));
            paymentLabel = new Label();
            payBtn = new MaterialSkin.Controls.MaterialButton();
            mainTips = new ToolTip(components);
            SuspendLayout();
            // 
            // paymentLabel
            // 
            paymentLabel.BackColor = Color.Transparent;
            paymentLabel.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            paymentLabel.ForeColor = Color.FromArgb(255, 255, 255);
            paymentLabel.Location = new Point(26, 82);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new Size(235, 135);
            paymentLabel.TabIndex = 0;
            paymentLabel.Text = "AzTelekom\r\nInternet + Telephone\r\nPublic IP\r\n100 Mbps";
            // 
            // payBtn
            // 
            payBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            payBtn.BackColor = Color.Transparent;
            payBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            payBtn.Depth = 0;
            payBtn.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            payBtn.HighEmphasis = true;
            payBtn.Icon = null;
            payBtn.Location = new Point(268, 181);
            payBtn.Margin = new Padding(4, 6, 4, 6);
            payBtn.MouseState = MaterialSkin.MouseState.HOVER;
            payBtn.Name = "payBtn";
            payBtn.NoAccentTextColor = Color.Empty;
            payBtn.Size = new Size(72, 36);
            payBtn.TabIndex = 1;
            payBtn.Text = "25.00 ₼";
            payBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            payBtn.UseAccentColor = false;
            payBtn.UseVisualStyleBackColor = false;
            payBtn.Click += PayBtn_Click;
            // 
            // mainTips
            // 
            mainTips.Popup += MainTips_Popup;
            // 
            // PaymentBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 240);
            Controls.Add(payBtn);
            Controls.Add(paymentLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PaymentBox";
            Sizable = false;
            Text = "Payment Confirmation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label paymentLabel;
        private MaterialSkin.Controls.MaterialButton payBtn;
        private ToolTip mainTips;
    }
}