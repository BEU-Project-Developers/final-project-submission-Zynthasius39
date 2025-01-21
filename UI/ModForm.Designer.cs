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
            clearButton = new MaterialButton();
            getAllButton = new MaterialButton();
            deleteButton = new MaterialButton();
            insertDefaultButton = new MaterialButton();
            textBox2 = new MaterialTextBox2();
            getButton = new MaterialButton();
            statusStrip1 = new StatusStrip();
            statusBar = new ToolStripStatusLabel();
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
            logoutButton = new MaterialButton();
            insertAllButton = new MaterialButton();
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
            // clearButton
            // 
            clearButton.AutoSize = false;
            clearButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            clearButton.Density = MaterialButton.MaterialButtonDensity.Default;
            clearButton.Depth = 0;
            clearButton.HighEmphasis = true;
            clearButton.Icon = null;
            clearButton.Location = new Point(166, 527);
            clearButton.Margin = new Padding(4, 6, 4, 6);
            clearButton.MouseState = MaterialSkin.MouseState.HOVER;
            clearButton.Name = "clearButton";
            clearButton.NoAccentTextColor = Color.Empty;
            clearButton.Size = new Size(123, 35);
            clearButton.TabIndex = 1;
            clearButton.Text = "Clear";
            clearButton.Type = MaterialButton.MaterialButtonType.Contained;
            clearButton.UseAccentColor = false;
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += Clear_button_Click;
            // 
            // getAllButton
            // 
            getAllButton.AutoSize = false;
            getAllButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            getAllButton.Density = MaterialButton.MaterialButtonDensity.Default;
            getAllButton.Depth = 0;
            getAllButton.HighEmphasis = true;
            getAllButton.Icon = null;
            getAllButton.Location = new Point(166, 196);
            getAllButton.Margin = new Padding(4, 6, 4, 6);
            getAllButton.MouseState = MaterialSkin.MouseState.HOVER;
            getAllButton.Name = "getAllButton";
            getAllButton.NoAccentTextColor = Color.Empty;
            getAllButton.Size = new Size(123, 35);
            getAllButton.TabIndex = 1;
            getAllButton.Text = "Get All";
            getAllButton.Type = MaterialButton.MaterialButtonType.Contained;
            getAllButton.UseAccentColor = false;
            getAllButton.UseVisualStyleBackColor = true;
            getAllButton.Click += Get_all_button_Click;
            // 
            // deleteButton
            // 
            deleteButton.AutoSize = false;
            deleteButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deleteButton.Density = MaterialButton.MaterialButtonDensity.Default;
            deleteButton.Depth = 0;
            deleteButton.HighEmphasis = true;
            deleteButton.Icon = null;
            deleteButton.Location = new Point(166, 83);
            deleteButton.Margin = new Padding(4, 6, 4, 6);
            deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            deleteButton.Name = "deleteButton";
            deleteButton.NoAccentTextColor = Color.Empty;
            deleteButton.Size = new Size(123, 35);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Delete";
            deleteButton.Type = MaterialButton.MaterialButtonType.Contained;
            deleteButton.UseAccentColor = false;
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += Delete_button_Click;
            // 
            // insertDefaultButton
            // 
            insertDefaultButton.AutoSize = false;
            insertDefaultButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            insertDefaultButton.Density = MaterialButton.MaterialButtonDensity.Default;
            insertDefaultButton.Depth = 0;
            insertDefaultButton.HighEmphasis = true;
            insertDefaultButton.Icon = null;
            insertDefaultButton.Location = new Point(20, 467);
            insertDefaultButton.Margin = new Padding(4, 6, 4, 6);
            insertDefaultButton.MouseState = MaterialSkin.MouseState.HOVER;
            insertDefaultButton.Name = "insertDefaultButton";
            insertDefaultButton.NoAccentTextColor = Color.Empty;
            insertDefaultButton.Size = new Size(123, 35);
            insertDefaultButton.TabIndex = 3;
            insertDefaultButton.Text = "INSERT DEFAULT";
            insertDefaultButton.Type = MaterialButton.MaterialButtonType.Contained;
            insertDefaultButton.UseAccentColor = false;
            insertDefaultButton.UseVisualStyleBackColor = true;
            insertDefaultButton.Click += Insert_default_button_Click;
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
            // getButton
            // 
            getButton.AutoSize = false;
            getButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            getButton.Density = MaterialButton.MaterialButtonDensity.Default;
            getButton.Depth = 0;
            getButton.HighEmphasis = true;
            getButton.Icon = null;
            getButton.Location = new Point(166, 139);
            getButton.Margin = new Padding(4, 6, 4, 6);
            getButton.MouseState = MaterialSkin.MouseState.HOVER;
            getButton.Name = "getButton";
            getButton.NoAccentTextColor = Color.Empty;
            getButton.Size = new Size(123, 35);
            getButton.TabIndex = 6;
            getButton.Text = "Get";
            getButton.Type = MaterialButton.MaterialButtonType.Contained;
            getButton.UseAccentColor = false;
            getButton.UseVisualStyleBackColor = true;
            getButton.Click += Add_Btn_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusBar });
            statusStrip1.Location = new Point(3, 594);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1233, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusBar
            // 
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(39, 17);
            statusBar.Text = "Status";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            dataGridViewTextBoxColumn4.HeaderText = "Email";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Password";
            dataGridViewTextBoxColumn6.HeaderText = "Password";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
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
            // 
            // customerBindingSource1
            // 
            customerBindingSource1.DataSource = typeof(Customer);
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Customer);
            // 
            // logoutButton
            // 
            logoutButton.AutoSize = false;
            logoutButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            logoutButton.Density = MaterialButton.MaterialButtonDensity.Default;
            logoutButton.Depth = 0;
            logoutButton.Font = new Font("Noto Sans", 9F);
            logoutButton.HighEmphasis = true;
            logoutButton.Icon = null;
            logoutButton.Location = new Point(20, 528);
            logoutButton.Margin = new Padding(4, 6, 4, 6);
            logoutButton.MouseState = MaterialSkin.MouseState.HOVER;
            logoutButton.Name = "logoutButton";
            logoutButton.NoAccentTextColor = Color.Empty;
            logoutButton.Size = new Size(123, 35);
            logoutButton.TabIndex = 11;
            logoutButton.Text = "LogOut";
            logoutButton.Type = MaterialButton.MaterialButtonType.Contained;
            logoutButton.UseAccentColor = false;
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += Logout_Btn_Click;
            // 
            // insertAllButton
            // 
            insertAllButton.AutoSize = false;
            insertAllButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            insertAllButton.Density = MaterialButton.MaterialButtonDensity.Default;
            insertAllButton.Depth = 0;
            insertAllButton.HighEmphasis = true;
            insertAllButton.Icon = null;
            insertAllButton.Location = new Point(166, 467);
            insertAllButton.Margin = new Padding(4, 6, 4, 6);
            insertAllButton.MouseState = MaterialSkin.MouseState.HOVER;
            insertAllButton.Name = "insertAllButton";
            insertAllButton.NoAccentTextColor = Color.Empty;
            insertAllButton.Size = new Size(123, 35);
            insertAllButton.TabIndex = 9;
            insertAllButton.Text = "Insert All";
            insertAllButton.Type = MaterialButton.MaterialButtonType.Contained;
            insertAllButton.UseAccentColor = false;
            insertAllButton.UseVisualStyleBackColor = true;
            insertAllButton.Click += Insert_all_button_Click;
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
            ClientSize = new Size(1239, 619);
            Controls.Add(progress_bar);
            Controls.Add(logoutButton);
            Controls.Add(insertAllButton);
            Controls.Add(dataGridView1);
            Controls.Add(statusStrip1);
            Controls.Add(getButton);
            Controls.Add(textBox2);
            Controls.Add(insertDefaultButton);
            Controls.Add(clearButton);
            Controls.Add(deleteButton);
            Controls.Add(getAllButton);
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
        private MaterialButton getAllButton;
        private MaterialButton deleteButton;
        private MaterialButton clearButton;
        private MaterialButton insertDefaultButton;
        private MaterialTextBox2 textBox2;
        private MaterialButton getButton;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusBar;
        private DataGridView dataGridView1;
        private BindingSource customerBindingSource;
        private MaterialButton insertAllButton;
        private MaterialSkin.Controls.MaterialButton logoutButton;
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