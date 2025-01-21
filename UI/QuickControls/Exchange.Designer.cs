namespace BankingApp.UI.QuickControls
{
    partial class Exchange
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
            mainLabel = new Label();
            amountText = new MaterialSkin.Controls.MaterialTextBox2();
            exchTo = new MaterialSkin.Controls.MaterialComboBox();
            submitBtn = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // mainLabel
            // 
            mainLabel.AutoSize = true;
            mainLabel.Font = new Font("Noto Sans", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            mainLabel.Location = new Point(289, 72);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(174, 49);
            mainLabel.TabIndex = 3;
            mainLabel.Text = "Exchange";
            // 
            // amountText
            // 
            amountText.AnimateReadOnly = false;
            amountText.BackgroundImageLayout = ImageLayout.None;
            amountText.CharacterCasing = CharacterCasing.Normal;
            amountText.Depth = 0;
            amountText.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            amountText.HideSelection = true;
            amountText.Hint = "Amount";
            amountText.LeadingIcon = null;
            amountText.Location = new Point(241, 162);
            amountText.MaxLength = 32767;
            amountText.MouseState = MaterialSkin.MouseState.OUT;
            amountText.Name = "amountText";
            amountText.PasswordChar = '\0';
            amountText.PrefixSuffixText = null;
            amountText.ReadOnly = false;
            amountText.RightToLeft = RightToLeft.No;
            amountText.SelectedText = "";
            amountText.SelectionLength = 0;
            amountText.SelectionStart = 0;
            amountText.ShortcutsEnabled = true;
            amountText.Size = new Size(135, 48);
            amountText.TabIndex = 2;
            amountText.TabStop = false;
            amountText.TextAlign = HorizontalAlignment.Left;
            amountText.TrailingIcon = null;
            amountText.UseSystemPasswordChar = false;
            // 
            // exchTo
            // 
            exchTo.AutoResize = false;
            exchTo.BackColor = Color.FromArgb(255, 255, 255);
            exchTo.Depth = 0;
            exchTo.DrawMode = DrawMode.OwnerDrawVariable;
            exchTo.DropDownHeight = 174;
            exchTo.DropDownStyle = ComboBoxStyle.DropDownList;
            exchTo.DropDownWidth = 121;
            exchTo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            exchTo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            exchTo.FormattingEnabled = true;
            exchTo.IntegralHeight = false;
            exchTo.ItemHeight = 43;
            exchTo.Items.AddRange(new object[] { "AZN", "USD", "GOLD", "EUR", "TRY" });
            exchTo.Location = new Point(382, 162);
            exchTo.MaxDropDownItems = 4;
            exchTo.MouseState = MaterialSkin.MouseState.OUT;
            exchTo.Name = "exchTo";
            exchTo.Size = new Size(121, 49);
            exchTo.StartIndex = 0;
            exchTo.TabIndex = 4;
            // 
            // submitBtn
            // 
            submitBtn.AutoSize = false;
            submitBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            submitBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            submitBtn.Depth = 0;
            submitBtn.HighEmphasis = true;
            submitBtn.Icon = null;
            submitBtn.Location = new Point(241, 288);
            submitBtn.Margin = new Padding(4, 6, 4, 6);
            submitBtn.MouseState = MaterialSkin.MouseState.HOVER;
            submitBtn.Name = "submitBtn";
            submitBtn.NoAccentTextColor = Color.Empty;
            submitBtn.Size = new Size(262, 48);
            submitBtn.TabIndex = 1;
            submitBtn.Text = "EXCHANGE";
            submitBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            submitBtn.UseAccentColor = false;
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += Exchange_Btn_Click;
            // 
            // Exchange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(exchTo);
            Controls.Add(mainLabel);
            Controls.Add(submitBtn);
            Controls.Add(amountText);
            Name = "Exchange";
            Size = new Size(784, 461);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainLabel;
        private MaterialSkin.Controls.MaterialTextBox2 amountText;
        private MaterialSkin.Controls.MaterialComboBox exchTo;
        private MaterialSkin.Controls.MaterialButton submitBtn;
    }
}
