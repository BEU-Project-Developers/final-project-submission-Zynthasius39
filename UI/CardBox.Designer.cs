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
            optionsTab = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            cbBtn0 = new MaterialSkin.Controls.MaterialButton();
            cbBtn1 = new MaterialSkin.Controls.MaterialButton();
            cbBtn2 = new MaterialSkin.Controls.MaterialButton();
            cbBtn3 = new MaterialSkin.Controls.MaterialButton();
            cbBtn4 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)cardBack).BeginInit();
            cardBack.SuspendLayout();
            optionsTab.SuspendLayout();
            SuspendLayout();
            // 
            // cardBack
            // 
            cardBack.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cardBack.Controls.Add(cvvLabel);
            cardBack.Controls.Add(expLabel);
            cardBack.Image = Properties.Resources.card_back;
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
            // optionsTab
            // 
            optionsTab.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            optionsTab.BackColor = Color.Transparent;
            optionsTab.ColumnCount = 1;
            optionsTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            optionsTab.Controls.Add(tableLayoutPanel1, 0, 5);
            optionsTab.Controls.Add(cbBtn0, 0, 0);
            optionsTab.Controls.Add(cbBtn1, 0, 1);
            optionsTab.Controls.Add(cbBtn2, 0, 2);
            optionsTab.Controls.Add(cbBtn3, 0, 3);
            optionsTab.Controls.Add(cbBtn4, 0, 4);
            optionsTab.Location = new Point(20, 372);
            optionsTab.Name = "optionsTab";
            optionsTab.RowCount = 6;
            optionsTab.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            optionsTab.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            optionsTab.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            optionsTab.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            optionsTab.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            optionsTab.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            optionsTab.Size = new Size(520, 600);
            optionsTab.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(3, 253);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(8, 8);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // cbBtn0
            // 
            cbBtn0.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cbBtn0.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            cbBtn0.Depth = 0;
            cbBtn0.Dock = DockStyle.Fill;
            cbBtn0.HighEmphasis = true;
            cbBtn0.Icon = null;
            cbBtn0.Location = new Point(4, 6);
            cbBtn0.Margin = new Padding(4, 6, 4, 6);
            cbBtn0.MouseState = MaterialSkin.MouseState.HOVER;
            cbBtn0.Name = "cbBtn0";
            cbBtn0.NoAccentTextColor = Color.Empty;
            cbBtn0.Size = new Size(512, 38);
            cbBtn0.TabIndex = 1;
            cbBtn0.Text = "Google Pay";
            cbBtn0.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            cbBtn0.UseAccentColor = false;
            cbBtn0.UseVisualStyleBackColor = true;
            // 
            // cbBtn1
            // 
            cbBtn1.AccessibleDescription = "";
            cbBtn1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cbBtn1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            cbBtn1.Depth = 0;
            cbBtn1.Dock = DockStyle.Fill;
            cbBtn1.HighEmphasis = true;
            cbBtn1.Icon = null;
            cbBtn1.Location = new Point(4, 56);
            cbBtn1.Margin = new Padding(4, 6, 4, 6);
            cbBtn1.MouseState = MaterialSkin.MouseState.HOVER;
            cbBtn1.Name = "cbBtn1";
            cbBtn1.NoAccentTextColor = Color.Empty;
            cbBtn1.Size = new Size(512, 38);
            cbBtn1.TabIndex = 1;
            cbBtn1.Text = "Reissue card";
            cbBtn1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            cbBtn1.UseAccentColor = false;
            cbBtn1.UseVisualStyleBackColor = true;
            // 
            // cbBtn2
            // 
            cbBtn2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cbBtn2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            cbBtn2.Depth = 0;
            cbBtn2.Dock = DockStyle.Fill;
            cbBtn2.HighEmphasis = true;
            cbBtn2.Icon = null;
            cbBtn2.Location = new Point(4, 106);
            cbBtn2.Margin = new Padding(4, 6, 4, 6);
            cbBtn2.MouseState = MaterialSkin.MouseState.HOVER;
            cbBtn2.Name = "cbBtn2";
            cbBtn2.NoAccentTextColor = Color.Empty;
            cbBtn2.Size = new Size(512, 38);
            cbBtn2.TabIndex = 1;
            cbBtn2.Text = "Document delivery";
            cbBtn2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            cbBtn2.UseAccentColor = false;
            cbBtn2.UseVisualStyleBackColor = true;
            // 
            // cbBtn3
            // 
            cbBtn3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cbBtn3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            cbBtn3.Depth = 0;
            cbBtn3.Dock = DockStyle.Fill;
            cbBtn3.HighEmphasis = true;
            cbBtn3.Icon = null;
            cbBtn3.Location = new Point(4, 156);
            cbBtn3.Margin = new Padding(4, 6, 4, 6);
            cbBtn3.MouseState = MaterialSkin.MouseState.HOVER;
            cbBtn3.Name = "cbBtn3";
            cbBtn3.NoAccentTextColor = Color.Empty;
            cbBtn3.Size = new Size(512, 38);
            cbBtn3.TabIndex = 1;
            cbBtn3.Text = "Requisites";
            cbBtn3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            cbBtn3.UseAccentColor = false;
            cbBtn3.UseVisualStyleBackColor = true;
            // 
            // cbBtn4
            // 
            cbBtn4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cbBtn4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            cbBtn4.Depth = 0;
            cbBtn4.Dock = DockStyle.Fill;
            cbBtn4.HighEmphasis = true;
            cbBtn4.Icon = null;
            cbBtn4.Location = new Point(4, 206);
            cbBtn4.Margin = new Padding(4, 6, 4, 6);
            cbBtn4.MouseState = MaterialSkin.MouseState.HOVER;
            cbBtn4.Name = "cbBtn4";
            cbBtn4.NoAccentTextColor = Color.Empty;
            cbBtn4.Size = new Size(512, 38);
            cbBtn4.TabIndex = 1;
            cbBtn4.Text = "Generate QR code";
            cbBtn4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            cbBtn4.UseAccentColor = false;
            cbBtn4.UseVisualStyleBackColor = true;
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
            cardBack.ResumeLayout(false);
            cardBack.PerformLayout();
            optionsTab.ResumeLayout(false);
            optionsTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox cardBack;
        private TableLayoutPanel optionsTab;
        private Label expLabel;
        private Label cvvLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton cbBtn0;
        private MaterialSkin.Controls.MaterialButton cbBtn1;
        private MaterialSkin.Controls.MaterialButton cbBtn2;
        private MaterialSkin.Controls.MaterialButton cbBtn3;
        private MaterialSkin.Controls.MaterialButton cbBtn4;
    }
}