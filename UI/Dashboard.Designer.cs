namespace BankingApp.UI
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            TabControl = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tabPage2 = new TabPage();
            imageList1 = new ImageList(components);
            label2 = new Label();
            TabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.ImageKey = "home.png";
            tabPage1.Location = new Point(4, 57);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1013, 632);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Kredit Back", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(583, 193);
            label1.Name = "label1";
            label1.Size = new Size(360, 44);
            label1.TabIndex = 1;
            label1.Text = "5550 1309 6672 6224";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(505, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(416, 263);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(416, 263);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Kredit Back", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(45, 188);
            label2.Name = "label2";
            label2.Size = new Size(360, 44);
            label2.TabIndex = 1;
            label2.Text = "5550 1309 6672 6224";
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
            Sizable = false;
            Text = "Dashboard";
            TabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
    }
}