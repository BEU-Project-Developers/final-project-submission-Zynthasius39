namespace BankingApp.UI
{
    partial class CardBox
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
            cardBack = new PictureBox();
            optionsTab = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)cardBack).BeginInit();
            SuspendLayout();
            // 
            // cardBack
            // 
            cardBack.Location = new Point(20, 40);
            cardBack.Name = "cardBack";
            cardBack.Size = new Size(520, 312);
            cardBack.TabIndex = 0;
            cardBack.TabStop = false;
            // 
            // optionsTab
            // 
            optionsTab.ColumnCount = 1;
            optionsTab.ColumnStyles.Add(new ColumnStyle());
            optionsTab.Location = new Point(20, 372);
            optionsTab.Name = "optionsTab";
            optionsTab.RowCount = 1;
            optionsTab.RowStyles.Add(new RowStyle());
            optionsTab.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            optionsTab.Size = new Size(520, 600);
            optionsTab.TabIndex = 1;
            // 
            // CardBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 992);
            Controls.Add(optionsTab);
            Controls.Add(cardBack);
            FormStyle = FormStyles.ActionBar_None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CardBox";
            Padding = new Padding(3, 24, 3, 3);
            Sizable = false;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)cardBack).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox cardBack;
        private TableLayoutPanel optionsTab;
    }
}