namespace BankingApp.UI.QuickControls
{
    partial class Transfer
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
            destText = new MaterialSkin.Controls.MaterialTextBox2();
            srcText = new MaterialSkin.Controls.MaterialTextBox2();
            submitBtn = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // mainLabel
            // 
            mainLabel.AutoSize = true;
            mainLabel.Font = new Font("Noto Sans", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            mainLabel.Location = new Point(308, 79);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(155, 49);
            mainLabel.TabIndex = 3;
            mainLabel.Text = "Transfer";
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
            destText.Location = new Point(178, 209);
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
            // srcText
            // 
            srcText.AnimateReadOnly = false;
            srcText.BackgroundImageLayout = ImageLayout.None;
            srcText.CharacterCasing = CharacterCasing.Normal;
            srcText.Depth = 0;
            srcText.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            srcText.HideSelection = true;
            srcText.Hint = "Source Account";
            srcText.LeadingIcon = null;
            srcText.Location = new Point(178, 155);
            srcText.MaxLength = 32767;
            srcText.MouseState = MaterialSkin.MouseState.OUT;
            srcText.Name = "srcText";
            srcText.PasswordChar = '\0';
            srcText.PrefixSuffixText = null;
            srcText.ReadOnly = false;
            srcText.RightToLeft = RightToLeft.No;
            srcText.SelectedText = "";
            srcText.SelectionLength = 0;
            srcText.SelectionStart = 0;
            srcText.ShortcutsEnabled = true;
            srcText.Size = new Size(414, 48);
            srcText.TabIndex = 0;
            srcText.TabStop = false;
            srcText.TextAlign = HorizontalAlignment.Left;
            srcText.TrailingIcon = null;
            srcText.UseSystemPasswordChar = false;
            // 
            // submitBtn
            // 
            submitBtn.AutoSize = false;
            submitBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            submitBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            submitBtn.Depth = 0;
            submitBtn.HighEmphasis = true;
            submitBtn.Icon = null;
            submitBtn.Location = new Point(178, 308);
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
            // 
            // Transfer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainLabel);
            Controls.Add(srcText);
            Controls.Add(submitBtn);
            Controls.Add(destText);
            Name = "Transfer";
            Size = new Size(784, 461);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainLabel;
        private MaterialSkin.Controls.MaterialTextBox2 destText;
        private MaterialSkin.Controls.MaterialTextBox2 srcText;
        private MaterialSkin.Controls.MaterialButton submitBtn;
    }
}
