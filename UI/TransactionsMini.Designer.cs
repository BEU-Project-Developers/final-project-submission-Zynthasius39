namespace BankingApp.UI
{
    partial class TransactionsMini
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
            tractsMiniLayout = new TableLayoutPanel();
            SuspendLayout();
            // 
            // tractsMiniLayout
            // 
            tractsMiniLayout.ColumnCount = 1;
            tractsMiniLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tractsMiniLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tractsMiniLayout.Dock = DockStyle.Fill;
            tractsMiniLayout.Location = new Point(0, 0);
            tractsMiniLayout.Name = "tractsMiniLayout";
            tractsMiniLayout.RowCount = 2;
            tractsMiniLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tractsMiniLayout.RowStyles.Add(new RowStyle());
            tractsMiniLayout.Size = new Size(150, 150);
            tractsMiniLayout.TabIndex = 0;
            // 
            // TransactionsMini
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tractsMiniLayout);
            Name = "TransactionsMini";
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tractsMiniLayout;
    }
}
