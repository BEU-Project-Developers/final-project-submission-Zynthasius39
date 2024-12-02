namespace BankingApp.UI
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.ComponentModel.ComponentResourceManager resources = null;

        /// <sumGmary>
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            TabControl = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            cards = new UserControl1();
            tabPage2 = new TabPage();
            imageList1 = new ImageList(components);
            TabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tabPage1);
            TabControl.Controls.Add(tabPage2);
            TabControl.Depth = 0;
            TabControl.Dock = DockStyle.Fill;
            TabControl.ImageList = imageList1;
            TabControl.Location = new Point(0, 72);
            TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            TabControl.Multiline = true;
            TabControl.Name = "TabControl";
            TabControl.Padding = new Point(12, 12);
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1021, 693);
            TabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(cards);
            tabPage1.ImageKey = "home.png";
            tabPage1.Location = new Point(4, 57);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1013, 632);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            // 
            // cards
            // 
            cards.AutoScroll = true;
            cards.AutoSize = true;
            cards.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cards.Dock = DockStyle.Fill;
            cards.Location = new Point(3, 3);
            cards.Name = "cards";
            cards.Size = new Size(1007, 626);
            cards.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.ImageKey = "wallet.png";
            tabPage2.Location = new Point(4, 57);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1013, 632);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Payments";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "home.png");
            imageList1.Images.SetKeyName(1, "wallet.png");
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1024, 768);
            Controls.Add(TabControl);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = TabControl;
            FormStyle = FormStyles.ActionBar_48;
            MinimumSize = new Size(1024, 768);
            Name = "Dashboard";
            Padding = new Padding(0, 72, 3, 3);
            Text = "Dashboard";
            TabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ImageList imageList1;
        private UserControl1 cards;
    }
}