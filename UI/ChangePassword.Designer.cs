namespace BankingApp.UI
{
    partial class ChangePassword
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
            curPassText = new MaterialSkin.Controls.MaterialTextBox2();
            newPassText0 = new MaterialSkin.Controls.MaterialTextBox2();
            newPassText1 = new MaterialSkin.Controls.MaterialTextBox2();
            chPassBtn = new MaterialSkin.Controls.MaterialButton();
            statusStrip1 = new StatusStrip();
            chPassStatus = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // curPassText
            // 
            curPassText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            curPassText.AnimateReadOnly = false;
            curPassText.BackgroundImageLayout = ImageLayout.None;
            curPassText.CharacterCasing = CharacterCasing.Normal;
            curPassText.Depth = 0;
            curPassText.Font = new Font("Noto Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            curPassText.HideSelection = true;
            curPassText.Hint = "Current Password";
            curPassText.LeadingIcon = null;
            curPassText.Location = new Point(93, 133);
            curPassText.MaxLength = 32767;
            curPassText.MouseState = MaterialSkin.MouseState.OUT;
            curPassText.Name = "curPassText";
            curPassText.PasswordChar = '●';
            curPassText.PrefixSuffixText = null;
            curPassText.ReadOnly = false;
            curPassText.RightToLeft = RightToLeft.No;
            curPassText.SelectedText = "";
            curPassText.SelectionLength = 0;
            curPassText.SelectionStart = 0;
            curPassText.ShortcutsEnabled = true;
            curPassText.Size = new Size(250, 48);
            curPassText.TabIndex = 0;
            curPassText.TabStop = false;
            curPassText.TextAlign = HorizontalAlignment.Left;
            curPassText.TrailingIcon = null;
            curPassText.UseSystemPasswordChar = true;
            // 
            // newPassText0
            // 
            newPassText0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            newPassText0.AnimateReadOnly = false;
            newPassText0.BackgroundImageLayout = ImageLayout.None;
            newPassText0.CharacterCasing = CharacterCasing.Normal;
            newPassText0.Depth = 0;
            newPassText0.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            newPassText0.HideSelection = true;
            newPassText0.Hint = "New Password";
            newPassText0.LeadingIcon = null;
            newPassText0.Location = new Point(93, 187);
            newPassText0.MaxLength = 32767;
            newPassText0.MouseState = MaterialSkin.MouseState.OUT;
            newPassText0.Name = "newPassText0";
            newPassText0.PasswordChar = '●';
            newPassText0.PrefixSuffixText = null;
            newPassText0.ReadOnly = false;
            newPassText0.RightToLeft = RightToLeft.No;
            newPassText0.SelectedText = "";
            newPassText0.SelectionLength = 0;
            newPassText0.SelectionStart = 0;
            newPassText0.ShortcutsEnabled = true;
            newPassText0.Size = new Size(250, 48);
            newPassText0.TabIndex = 1;
            newPassText0.TabStop = false;
            newPassText0.TextAlign = HorizontalAlignment.Left;
            newPassText0.TrailingIcon = null;
            newPassText0.UseSystemPasswordChar = true;
            // 
            // newPassText1
            // 
            newPassText1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            newPassText1.AnimateReadOnly = false;
            newPassText1.BackgroundImageLayout = ImageLayout.None;
            newPassText1.CharacterCasing = CharacterCasing.Normal;
            newPassText1.Depth = 0;
            newPassText1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            newPassText1.HideSelection = true;
            newPassText1.Hint = "Repeat New Password";
            newPassText1.LeadingIcon = null;
            newPassText1.Location = new Point(93, 241);
            newPassText1.MaxLength = 32767;
            newPassText1.MouseState = MaterialSkin.MouseState.OUT;
            newPassText1.Name = "newPassText1";
            newPassText1.PasswordChar = '●';
            newPassText1.PrefixSuffixText = null;
            newPassText1.ReadOnly = false;
            newPassText1.RightToLeft = RightToLeft.No;
            newPassText1.SelectedText = "";
            newPassText1.SelectionLength = 0;
            newPassText1.SelectionStart = 0;
            newPassText1.ShortcutsEnabled = true;
            newPassText1.Size = new Size(250, 48);
            newPassText1.TabIndex = 1;
            newPassText1.TabStop = false;
            newPassText1.TextAlign = HorizontalAlignment.Left;
            newPassText1.TrailingIcon = null;
            newPassText1.UseSystemPasswordChar = true;
            // 
            // chPassBtn
            // 
            chPassBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chPassBtn.AutoSize = false;
            chPassBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            chPassBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            chPassBtn.Depth = 0;
            chPassBtn.HighEmphasis = true;
            chPassBtn.Icon = null;
            chPassBtn.Location = new Point(93, 341);
            chPassBtn.Margin = new Padding(4, 6, 4, 6);
            chPassBtn.MouseState = MaterialSkin.MouseState.HOVER;
            chPassBtn.Name = "chPassBtn";
            chPassBtn.NoAccentTextColor = Color.Empty;
            chPassBtn.Size = new Size(250, 36);
            chPassBtn.TabIndex = 2;
            chPassBtn.Text = "RESET";
            chPassBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            chPassBtn.UseAccentColor = false;
            chPassBtn.UseVisualStyleBackColor = true;
            chPassBtn.Click += ChPassBtn_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { chPassStatus });
            statusStrip1.Location = new Point(3, 433);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(433, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // chPassStatus
            // 
            chPassStatus.Name = "chPassStatus";
            chPassStatus.Size = new Size(0, 17);
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 458);
            Controls.Add(statusStrip1);
            Controls.Add(chPassBtn);
            Controls.Add(newPassText1);
            Controls.Add(newPassText0);
            Controls.Add(curPassText);
            Name = "ChangePassword";
            Text = "Reset Password";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 curPassText;
        private MaterialSkin.Controls.MaterialTextBox2 newPassText0;
        private MaterialSkin.Controls.MaterialTextBox2 newPassText1;
        private MaterialSkin.Controls.MaterialButton chPassBtn;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel chPassStatus;
    }
}