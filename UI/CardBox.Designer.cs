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
            cvvLabel = new Label();
            expLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)cardBack).BeginInit();
            cardBack.SuspendLayout();
            SuspendLayout();
            // 
            // cardBack
            // 
            cardBack.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cardBack.Controls.Add(cvvLabel);
            cardBack.Controls.Add(expLabel);
            cardBack.Location = new Point(20, 40);
            cardBack.Name = "cardBack";
            cardBack.Size = new Size(520, 312);
            cardBack.SizeMode = PictureBoxSizeMode.StretchImage;
            cardBack.TabIndex = 0;
            cardBack.TabStop = false;
            // 
            // cvvLabel
            // 
            cvvLabel.AutoSize = true;
            cvvLabel.BackColor = Color.Transparent;
            cvvLabel.Font = new Font("Kredit Back", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cvvLabel.ForeColor = Color.Gold;
            cvvLabel.Location = new Point(402, 222);
            cvvLabel.Name = "cvvLabel";
            cvvLabel.Size = new Size(81, 46);
            cvvLabel.TabIndex = 2;
            cvvLabel.Text = "316";
            // 
            // expLabel
            // 
            expLabel.AutoSize = true;
            expLabel.BackColor = Color.Transparent;
            expLabel.Font = new Font("Kredit Back", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expLabel.ForeColor = Color.Gold;
            expLabel.Location = new Point(40, 222);
            expLabel.Name = "expLabel";
            expLabel.Size = new Size(144, 46);
            expLabel.TabIndex = 2;
            expLabel.Text = "09 / 26";
            // 
            // CardBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 371);
            Controls.Add(cardBack);
            FormStyle = FormStyles.ActionBar_None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CardBox";
            Padding = new Padding(3, 24, 3, 3);
            Sizable = false;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)cardBack).EndInit();
            cardBack.ResumeLayout(false);
            cardBack.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox cardBack;
        private Label expLabel;
        private Label cvvLabel;
    }
}