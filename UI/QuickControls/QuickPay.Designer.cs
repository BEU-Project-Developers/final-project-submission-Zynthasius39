namespace BankingApp.UI.QuickControls
{
    partial class QuickPay
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
            destText = new MaterialSkin.Controls.MaterialTextBox2();
            addBtn0 = new MaterialSkin.Controls.MaterialButton();
            amountText = new MaterialSkin.Controls.MaterialTextBox2();
            addBtn1 = new MaterialSkin.Controls.MaterialButton();
            addBtn2 = new MaterialSkin.Controls.MaterialButton();
            addBtn3 = new MaterialSkin.Controls.MaterialButton();
            clrBtn = new MaterialSkin.Controls.MaterialButton();
            submitBtn = new MaterialSkin.Controls.MaterialButton();
            mainLabel = new Label();
            SuspendLayout();
            // 
            // destText
            // 
            destText.AnimateReadOnly = false;
            destText.BackgroundImageLayout = ImageLayout.None;
            destText.CharacterCasing = CharacterCasing.Normal;
            destText.Depth = 0;
            destText.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            destText.HideSelection = true;
            destText.Hint = "Destination Account";
            destText.LeadingIcon = null;
            destText.Location = new Point(183, 148);
            destText.MaxLength = 32767;
            destText.MouseState = MaterialSkin.MouseState.OUT;
            destText.Name = "destText";
            destText.PasswordChar = '\0';
            destText.PrefixSuffixText = null;
            destText.ReadOnly = false;
            destText.RightToLeft = RightToLeft.No;
            destText.SelectedText = "";
            destText.SelectionLength = 0;
            destText.SelectionStart = 0;
            destText.ShortcutsEnabled = true;
            destText.Size = new Size(414, 48);
            destText.TabIndex = 0;
            destText.TabStop = false;
            destText.TextAlign = HorizontalAlignment.Left;
            destText.TrailingIcon = null;
            destText.UseSystemPasswordChar = false;
            // 
            // addBtn0
            // 
            addBtn0.AutoSize = false;
            addBtn0.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addBtn0.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addBtn0.Depth = 0;
            addBtn0.HighEmphasis = true;
            addBtn0.Icon = null;
            addBtn0.Location = new Point(325, 205);
            addBtn0.Margin = new Padding(4, 6, 4, 6);
            addBtn0.MouseState = MaterialSkin.MouseState.HOVER;
            addBtn0.Name = "addBtn0";
            addBtn0.NoAccentTextColor = Color.Empty;
            addBtn0.Size = new Size(48, 48);
            addBtn0.TabIndex = 1;
            addBtn0.Text = "+5₼";
            addBtn0.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            addBtn0.UseAccentColor = false;
            addBtn0.UseVisualStyleBackColor = true;
            addBtn0.Click += AddFive_Click;
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
            amountText.Location = new Point(183, 205);
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
            amountText.Click += amountText_Click;
            // 
            // addBtn1
            // 
            addBtn1.AutoSize = false;
            addBtn1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addBtn1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addBtn1.Depth = 0;
            addBtn1.HighEmphasis = true;
            addBtn1.Icon = null;
            addBtn1.Location = new Point(381, 205);
            addBtn1.Margin = new Padding(4, 6, 4, 6);
            addBtn1.MouseState = MaterialSkin.MouseState.HOVER;
            addBtn1.Name = "addBtn1";
            addBtn1.NoAccentTextColor = Color.Empty;
            addBtn1.Size = new Size(48, 48);
            addBtn1.TabIndex = 1;
            addBtn1.Text = "+10₼";
            addBtn1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            addBtn1.UseAccentColor = false;
            addBtn1.UseVisualStyleBackColor = true;
            addBtn1.Click += AddTen_Click;
            // 
            // addBtn2
            // 
            addBtn2.AutoSize = false;
            addBtn2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addBtn2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addBtn2.Depth = 0;
            addBtn2.HighEmphasis = true;
            addBtn2.Icon = null;
            addBtn2.Location = new Point(437, 205);
            addBtn2.Margin = new Padding(4, 6, 4, 6);
            addBtn2.MouseState = MaterialSkin.MouseState.HOVER;
            addBtn2.Name = "addBtn2";
            addBtn2.NoAccentTextColor = Color.Empty;
            addBtn2.Size = new Size(48, 48);
            addBtn2.TabIndex = 1;
            addBtn2.Text = "+50₼";
            addBtn2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            addBtn2.UseAccentColor = false;
            addBtn2.UseVisualStyleBackColor = true;
            addBtn2.Click += AddFifty_Click;
            // 
            // addBtn3
            // 
            addBtn3.AutoSize = false;
            addBtn3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addBtn3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addBtn3.Depth = 0;
            addBtn3.HighEmphasis = true;
            addBtn3.Icon = null;
            addBtn3.Location = new Point(493, 205);
            addBtn3.Margin = new Padding(4, 6, 4, 6);
            addBtn3.MouseState = MaterialSkin.MouseState.HOVER;
            addBtn3.Name = "addBtn3";
            addBtn3.NoAccentTextColor = Color.Empty;
            addBtn3.Size = new Size(48, 48);
            addBtn3.TabIndex = 1;
            addBtn3.Text = "+100₼";
            addBtn3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            addBtn3.UseAccentColor = false;
            addBtn3.UseVisualStyleBackColor = true;
            addBtn3.Click += AddHundred_Click;
            // 
            // clrBtn
            // 
            clrBtn.AutoSize = false;
            clrBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            clrBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            clrBtn.Depth = 0;
            clrBtn.HighEmphasis = true;
            clrBtn.Icon = null;
            clrBtn.Location = new Point(549, 205);
            clrBtn.Margin = new Padding(4, 6, 4, 6);
            clrBtn.MouseState = MaterialSkin.MouseState.HOVER;
            clrBtn.Name = "clrBtn";
            clrBtn.NoAccentTextColor = Color.Empty;
            clrBtn.Size = new Size(48, 48);
            clrBtn.TabIndex = 1;
            clrBtn.Text = "Clear";
            clrBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            clrBtn.UseAccentColor = false;
            clrBtn.UseVisualStyleBackColor = true;
            clrBtn.Click += Clear_Click;
            // 
            // submitBtn
            // 
            submitBtn.AutoSize = false;
            submitBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            submitBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            submitBtn.Depth = 0;
            submitBtn.HighEmphasis = true;
            submitBtn.Icon = null;
            submitBtn.Location = new Point(183, 308);
            submitBtn.Margin = new Padding(4, 6, 4, 6);
            submitBtn.MouseState = MaterialSkin.MouseState.HOVER;
            submitBtn.Name = "submitBtn";
            submitBtn.NoAccentTextColor = Color.Empty;
            submitBtn.Size = new Size(414, 48);
            submitBtn.TabIndex = 1;
            submitBtn.Text = "Send";
            submitBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            submitBtn.UseAccentColor = false;
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += Submit_Click;
            // 
            // mainLabel
            // 
            mainLabel.AutoSize = true;
            mainLabel.Font = new Font("Noto Sans", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            mainLabel.Location = new Point(304, 73);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(181, 49);
            mainLabel.TabIndex = 3;
            mainLabel.Text = "Quick-Pay";
            // 
            // QuickPay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainLabel);
            Controls.Add(amountText);
            Controls.Add(submitBtn);
            Controls.Add(clrBtn);
            Controls.Add(addBtn3);
            Controls.Add(addBtn2);
            Controls.Add(addBtn1);
            Controls.Add(addBtn0);
            Controls.Add(destText);
            Name = "QuickPay";
            Size = new Size(784, 461);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 destText;
        private MaterialSkin.Controls.MaterialButton addBtn0;
        private MaterialSkin.Controls.MaterialTextBox2 amountText;
        private MaterialSkin.Controls.MaterialButton addBtn1;
        private MaterialSkin.Controls.MaterialButton addBtn2;
        private MaterialSkin.Controls.MaterialButton addBtn3;
        private MaterialSkin.Controls.MaterialButton clrBtn;
        private MaterialSkin.Controls.MaterialButton submitBtn;
        private Label mainLabel;
    }
}
