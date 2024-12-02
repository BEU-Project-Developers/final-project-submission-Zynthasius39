using BankingApp.Models;
using BankingApp.Models.Enums;
using MaterialSkin.Controls;


namespace BankingApp.UI
{
    partial class ModForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox1 = new MaterialTextBox2();
            clear_button = new MaterialButton();
            get_all_button = new MaterialButton();
            delete_button = new MaterialButton();
            button2 = new MaterialButton();
            textBox2 = new MaterialTextBox2();
            button3 = new MaterialButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            Manual = new DataGridViewCheckBoxColumn();
            customerBindingSource1 = new BindingSource(components);
            customerBindingSource = new BindingSource(components);
            logout_button = new MaterialButton();
            insert_all_button = new MaterialButton();
            progress_bar = new MaterialProgressBar();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.AnimateReadOnly = false;
            textBox1.BackgroundImageLayout = ImageLayout.None;
            textBox1.CharacterCasing = CharacterCasing.Normal;
            textBox1.Depth = 0;
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.HideSelection = true;
            textBox1.LeadingIcon = null;
            textBox1.Location = new Point(20, 83);
            textBox1.MaxLength = 32767;
            textBox1.MouseState = MaterialSkin.MouseState.OUT;
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '\0';
            textBox1.PrefixSuffixText = null;
            textBox1.ReadOnly = false;
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.SelectedText = "";
            textBox1.SelectionLength = 0;
            textBox1.SelectionStart = 0;
            textBox1.ShortcutsEnabled = true;
            textBox1.Size = new Size(123, 48);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.TextAlign = HorizontalAlignment.Left;
            textBox1.TrailingIcon = null;
            textBox1.UseSystemPasswordChar = false;
            // 
            // clear_button
            // 
            clear_button.AutoSize = false;
            clear_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            clear_button.Density = MaterialButton.MaterialButtonDensity.Default;
            clear_button.Depth = 0;
            clear_button.HighEmphasis = true;
            clear_button.Icon = null;
            clear_button.Location = new Point(166, 527);
            clear_button.Margin = new Padding(4, 6, 4, 6);
            clear_button.MouseState = MaterialSkin.MouseState.HOVER;
            clear_button.Name = "clear_button";
            clear_button.NoAccentTextColor = Color.Empty;
            clear_button.Size = new Size(123, 35);
            clear_button.TabIndex = 1;
            clear_button.Text = "Clear";
            clear_button.Type = MaterialButton.MaterialButtonType.Contained;
            clear_button.UseAccentColor = false;
            clear_button.UseVisualStyleBackColor = true;
            clear_button.Click += Clear_button_Click;
            // 
            // get_all_button
            // 
            get_all_button.AutoSize = false;
            get_all_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            get_all_button.Density = MaterialButton.MaterialButtonDensity.Default;
            get_all_button.Depth = 0;
            get_all_button.HighEmphasis = true;
            get_all_button.Icon = null;
            get_all_button.Location = new Point(166, 196);
            get_all_button.Margin = new Padding(4, 6, 4, 6);
            get_all_button.MouseState = MaterialSkin.MouseState.HOVER;
            get_all_button.Name = "get_all_button";
            get_all_button.NoAccentTextColor = Color.Empty;
            get_all_button.Size = new Size(123, 35);
            get_all_button.TabIndex = 1;
            get_all_button.Text = "Get All";
            get_all_button.Type = MaterialButton.MaterialButtonType.Contained;
            get_all_button.UseAccentColor = false;
            get_all_button.UseVisualStyleBackColor = true;
            get_all_button.Click += Get_all_button_Click;
            // 
            // delete_button
            // 
            delete_button.AutoSize = false;
            delete_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            delete_button.Density = MaterialButton.MaterialButtonDensity.Default;
            delete_button.Depth = 0;
            delete_button.HighEmphasis = true;
            delete_button.Icon = null;
            delete_button.Location = new Point(166, 83);
            delete_button.Margin = new Padding(4, 6, 4, 6);
            delete_button.MouseState = MaterialSkin.MouseState.HOVER;
            delete_button.Name = "delete_button";
            delete_button.NoAccentTextColor = Color.Empty;
            delete_button.Size = new Size(123, 35);
            delete_button.TabIndex = 1;
            delete_button.Text = "Delete";
            delete_button.Type = MaterialButton.MaterialButtonType.Contained;
            delete_button.UseAccentColor = false;
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += Delete_button_Click;
            // 
            // button2
            // 
            button2.AutoSize = false;
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.Density = MaterialButton.MaterialButtonDensity.Default;
            button2.Depth = 0;
            button2.HighEmphasis = true;
            button2.Icon = null;
            button2.Location = new Point(20, 467);
            button2.Margin = new Padding(4, 6, 4, 6);
            button2.MouseState = MaterialSkin.MouseState.HOVER;
            button2.Name = "button2";
            button2.NoAccentTextColor = Color.Empty;
            button2.Size = new Size(123, 35);
            button2.TabIndex = 3;
            button2.Text = "INSERT DEFAULT";
            button2.Type = MaterialButton.MaterialButtonType.Contained;
            button2.UseAccentColor = false;
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // textBox2
            // 
            textBox2.AnimateReadOnly = false;
            textBox2.BackgroundImageLayout = ImageLayout.None;
            textBox2.CharacterCasing = CharacterCasing.Normal;
            textBox2.Depth = 0;
            textBox2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBox2.HideSelection = true;
            textBox2.LeadingIcon = null;
            textBox2.Location = new Point(20, 139);
            textBox2.MaxLength = 32767;
            textBox2.MouseState = MaterialSkin.MouseState.OUT;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '\0';
            textBox2.PrefixSuffixText = null;
            textBox2.ReadOnly = false;
            textBox2.RightToLeft = RightToLeft.No;
            textBox2.SelectedText = "";
            textBox2.SelectionLength = 0;
            textBox2.SelectionStart = 0;
            textBox2.ShortcutsEnabled = true;
            textBox2.Size = new Size(123, 48);
            textBox2.TabIndex = 5;
            textBox2.TabStop = false;
            textBox2.TextAlign = HorizontalAlignment.Left;
            textBox2.TrailingIcon = null;
            textBox2.UseSystemPasswordChar = false;
            // 
            // button3
            // 
            button3.AutoSize = false;
            button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button3.Density = MaterialButton.MaterialButtonDensity.Default;
            button3.Depth = 0;
            button3.HighEmphasis = true;
            button3.Icon = null;
            button3.Location = new Point(166, 139);
            button3.Margin = new Padding(4, 6, 4, 6);
            button3.MouseState = MaterialSkin.MouseState.HOVER;
            button3.Name = "button3";
            button3.NoAccentTextColor = Color.Empty;
            button3.Size = new Size(123, 35);
            button3.TabIndex = 6;
            button3.Text = "Get";
            button3.Type = MaterialButton.MaterialButtonType.Contained;
            button3.UseAccentColor = false;
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button3_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(3, 655);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1253, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(39, 17);
            toolStripStatusLabel1.Text = "Status";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn7, Manual });
            dataGridView1.DataSource = customerBindingSource1;
            dataGridView1.Location = new Point(323, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(900, 513);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            dataGridViewTextBoxColumn4.HeaderText = "Email";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Password";
            dataGridViewTextBoxColumn6.HeaderText = "Password";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Surname";
            dataGridViewTextBoxColumn3.HeaderText = "Surname";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Phone";
            dataGridViewTextBoxColumn5.HeaderText = "Phone";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "Role";
            dataGridViewTextBoxColumn7.HeaderText = "Role";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Manual
            // 
            Manual.HeaderText = "Insert";
            Manual.Name = "Manual";
            Manual.Width = 50;
            // 
            // customerBindingSource1
            // 
            customerBindingSource1.DataSource = typeof(Customer);
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Customer);
            // 
            // logout_button
            // 
            logout_button.AutoSize = false;
            logout_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            logout_button.Density = MaterialButton.MaterialButtonDensity.Default;
            logout_button.Depth = 0;
            logout_button.Font = new Font("Noto Sans", 9F);
            logout_button.HighEmphasis = true;
            logout_button.Icon = null;
            logout_button.Location = new Point(20, 528);
            logout_button.Margin = new Padding(4, 6, 4, 6);
            logout_button.MouseState = MaterialSkin.MouseState.HOVER;
            logout_button.Name = "logout_button";
            logout_button.NoAccentTextColor = Color.Empty;
            logout_button.Size = new Size(123, 35);
            logout_button.TabIndex = 11;
            logout_button.Text = "LogOut";
            logout_button.Type = MaterialButton.MaterialButtonType.Contained;
            logout_button.UseAccentColor = false;
            logout_button.UseVisualStyleBackColor = true;
            logout_button.Click += MaterialButton1_Click;
            // 
            // insert_all_button
            // 
            insert_all_button.AutoSize = false;
            insert_all_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            insert_all_button.Density = MaterialButton.MaterialButtonDensity.Default;
            insert_all_button.Depth = 0;
            insert_all_button.HighEmphasis = true;
            insert_all_button.Icon = null;
            insert_all_button.Location = new Point(166, 467);
            insert_all_button.Margin = new Padding(4, 6, 4, 6);
            insert_all_button.MouseState = MaterialSkin.MouseState.HOVER;
            insert_all_button.Name = "insert_all_button";
            insert_all_button.NoAccentTextColor = Color.Empty;
            insert_all_button.Size = new Size(123, 35);
            insert_all_button.TabIndex = 9;
            insert_all_button.Text = "Insert All";
            insert_all_button.Type = MaterialButton.MaterialButtonType.Contained;
            insert_all_button.UseAccentColor = false;
            insert_all_button.UseVisualStyleBackColor = true;
            insert_all_button.Click += Insert_all_button_Click;
            // 
            // progress_bar
            // 
            progress_bar.Depth = 0;
            progress_bar.Location = new Point(20, 581);
            progress_bar.MouseState = MaterialSkin.MouseState.HOVER;
            progress_bar.Name = "progress_bar";
            progress_bar.Size = new Size(269, 5);
            progress_bar.TabIndex = 12;
            // 
            // ModForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 680);
            Controls.Add(progress_bar);
            Controls.Add(logout_button);
            Controls.Add(insert_all_button);
            Controls.Add(dataGridView1);
            Controls.Add(statusStrip1);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(clear_button);
            Controls.Add(delete_button);
            Controls.Add(get_all_button);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ModForm";
            Sizable = false;
            Text = "Customer Dashboard";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialTextBox2 textBox1;
        private MaterialButton get_all_button;
        private MaterialButton delete_button;
        private MaterialButton clear_button;
        private MaterialButton button2;
        private MaterialTextBox2 textBox2;
        private MaterialButton button3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private DataGridView dataGridView1;
        private BindingSource customerBindingSource;
        private MaterialButton insert_all_button;
        private MaterialSkin.Controls.MaterialButton logout_button;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn roleDataGridViewTextBoxColumn;
        private MaterialProgressBar progress_bar;
        private BindingSource customerBindingSource1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewCheckBoxColumn Manual;
    }
}