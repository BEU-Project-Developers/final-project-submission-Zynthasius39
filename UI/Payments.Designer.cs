namespace BankingApp.UI
{
    partial class Payments
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
            payments_label = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // payments_label
            // 
            payments_label.AutoSize = true;
            payments_label.Depth = 0;
            payments_label.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            payments_label.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            payments_label.Location = new Point(20, 20);
            payments_label.MouseState = MaterialSkin.MouseState.HOVER;
            payments_label.Name = "payments_label";
            payments_label.Size = new Size(153, 41);
            payments_label.TabIndex = 1;
            payments_label.Text = "Payments";
            // 
            // Payments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(payments_label);
            Name = "Payments";
            Size = new Size(1000, 562);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel payments_label;
    }
}
