namespace BankingApp.UI
{
    partial class Cards
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
            accounts_label = new MaterialSkin.Controls.MaterialLabel();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // accounts_label
            // 
            accounts_label.AutoSize = true;
            accounts_label.Depth = 0;
            accounts_label.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            accounts_label.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            accounts_label.Location = new Point(20, 20);
            accounts_label.MouseState = MaterialSkin.MouseState.HOVER;
            accounts_label.Name = "accounts_label";
            accounts_label.Size = new Size(145, 41);
            accounts_label.TabIndex = 0;
            accounts_label.Text = "Accounts";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Location = new Point(20, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(961, 100);
            panel1.TabIndex = 1;
            // 
            // Cards
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel1);
            Controls.Add(accounts_label);
            Name = "Cards";
            Size = new Size(1000, 562);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel accounts_label;
        private Panel panel1;
    }
}
