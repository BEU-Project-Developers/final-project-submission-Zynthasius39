using BankingApp.Models;
using BankingApp.Models.Enums;


namespace BankingApp.UI
{
    partial class ModForm
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
            textBox1 = new TextBox();
            clear_button = new Button();
            get_all_button = new Button();
            delete_button = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            button3 = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            surnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            Manual = new DataGridViewCheckBoxColumn();
            customerBindingSource = new BindingSource(components);
            insert_all_button = new Button();
            comboBox1 = new ComboBox();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 23);
            textBox1.TabIndex = 0;
            // 
            // clear_button
            // 
            clear_button.Location = new Point(164, 282);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(104, 23);
            clear_button.TabIndex = 1;
            clear_button.Text = "Clear";
            clear_button.UseVisualStyleBackColor = true;
            clear_button.Click += clear_button_Click;
            // 
            // get_all_button
            // 
            get_all_button.Location = new Point(164, 100);
            get_all_button.Name = "get_all_button";
            get_all_button.Size = new Size(104, 23);
            get_all_button.TabIndex = 1;
            get_all_button.Text = "Get All";
            get_all_button.UseVisualStyleBackColor = true;
            get_all_button.Click += get_all_button_Click;
            // 
            // delete_button
            // 
            delete_button.Location = new Point(164, 44);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(104, 23);
            delete_button.TabIndex = 1;
            delete_button.Text = "Delete";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(164, 129);
            button2.Name = "button2";
            button2.Size = new Size(104, 23);
            button2.TabIndex = 3;
            button2.Text = "Add Predef.";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(10, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(148, 23);
            textBox2.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(164, 71);
            button3.Name = "button3";
            button3.Size = new Size(104, 23);
            button3.TabIndex = 6;
            button3.Text = "Get";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 308);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1118, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(39, 17);
            toolStripStatusLabel1.Text = "Status";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, surnameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, roleDataGridViewTextBoxColumn, Manual });
            dataGridView1.DataSource = customerBindingSource;
            dataGridView1.Location = new Point(274, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(832, 293);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            roleDataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(Rolet));
            roleDataGridViewTextBoxColumn.HeaderText = "Role";
            roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            roleDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            roleDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Manual
            // 
            Manual.HeaderText = "Insert";
            Manual.Name = "Manual";
            Manual.Width = 75;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Customer);
            // 
            // insert_all_button
            // 
            insert_all_button.Location = new Point(164, 253);
            insert_all_button.Name = "insert_all_button";
            insert_all_button.Size = new Size(104, 23);
            insert_all_button.TabIndex = 9;
            insert_all_button.Text = "Insert All";
            insert_all_button.UseVisualStyleBackColor = true;
            insert_all_button.Click += insert_all_button_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(10, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(258, 23);
            comboBox1.TabIndex = 10;
            // 
            // ModForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 330);
            Controls.Add(comboBox1);
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
            Text = "BankingAPP Customer Dashboard";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button get_all_button;
        private Button delete_button;
        private Button clear_button;
        private Button button2;
        private TextBox textBox2;
        private Button button3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private DataGridView dataGridView1;
        private BindingSource customerBindingSource;
        private Button insert_all_button;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn roleDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn Manual;
        private ComboBox comboBox1;
        private ToolStripProgressBar toolStripProgressBar1;
    }
}