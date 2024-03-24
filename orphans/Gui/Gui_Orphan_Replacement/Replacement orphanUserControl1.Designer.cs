namespace orphans.Gui.Gui_Orphan_Replacement
{
    partial class Replacement_orphanUserControl1
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label2 = new Label();
            buttonReplacementOrphanDetails = new Button();
            button2 = new Button();
            buttonReplacmentOrphan = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker2 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 200);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1008, 516);
            dataGridView1.TabIndex = 20;
            // 
            // Column1
            // 
            Column1.HeaderText = "من";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "الى";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "تاريخ الانشاء";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "اسم المستخدم";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "الحالة";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttonReplacementOrphanDetails);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(buttonReplacmentOrphan);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 200);
            panel1.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cairo", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(60, 54, 51);
            label2.Location = new Point(415, 1);
            label2.Name = "label2";
            label2.Size = new Size(154, 30);
            label2.TabIndex = 33;
            label2.Text = "طلبات استبدال ايتام";
            // 
            // buttonReplacementOrphanDetails
            // 
            buttonReplacementOrphanDetails.BackColor = SystemColors.ControlLight;
            buttonReplacementOrphanDetails.FlatStyle = FlatStyle.Flat;
            buttonReplacementOrphanDetails.Location = new Point(132, 165);
            buttonReplacementOrphanDetails.Margin = new Padding(3, 5, 3, 5);
            buttonReplacementOrphanDetails.Name = "buttonReplacementOrphanDetails";
            buttonReplacementOrphanDetails.Size = new Size(88, 31);
            buttonReplacementOrphanDetails.TabIndex = 30;
            buttonReplacementOrphanDetails.Text = "تفاصيل";
            buttonReplacementOrphanDetails.UseVisualStyleBackColor = false;
            buttonReplacementOrphanDetails.Click += buttonReplacementOrphanDetails_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(226, 165);
            button2.Margin = new Padding(3, 5, 3, 5);
            button2.Name = "button2";
            button2.Size = new Size(88, 31);
            button2.TabIndex = 31;
            button2.Text = "حذف";
            button2.UseVisualStyleBackColor = false;
            // 
            // buttonReplacmentOrphan
            // 
            buttonReplacmentOrphan.BackColor = SystemColors.ControlLight;
            buttonReplacmentOrphan.FlatStyle = FlatStyle.Flat;
            buttonReplacmentOrphan.Location = new Point(8, 165);
            buttonReplacmentOrphan.Margin = new Padding(3, 5, 3, 5);
            buttonReplacmentOrphan.Name = "buttonReplacmentOrphan";
            buttonReplacmentOrphan.Size = new Size(118, 31);
            buttonReplacmentOrphan.TabIndex = 32;
            buttonReplacmentOrphan.Text = "إستبدال يتيم";
            buttonReplacmentOrphan.UseVisualStyleBackColor = false;
            buttonReplacmentOrphan.Click += buttonReplacmentOrphan_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(919, 63);
            label1.Name = "label1";
            label1.Size = new Size(71, 24);
            label1.TabIndex = 25;
            label1.Text = "حالة الطلب ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(428, 87);
            dateTimePicker1.Margin = new Padding(3, 10, 3, 10);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 32);
            dateTimePicker1.TabIndex = 23;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(367, 60);
            label3.Name = "label3";
            label3.Size = new Size(51, 24);
            label3.TabIndex = 26;
            label3.Text = "الى تاريخ";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Location = new Point(662, 87);
            textBox1.Margin = new Padding(3, 10, 3, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 32);
            textBox1.TabIndex = 22;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(829, 87);
            comboBox1.Margin = new Padding(3, 10, 3, 10);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(161, 32);
            comboBox1.TabIndex = 20;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(756, 59);
            label5.Name = "label5";
            label5.Size = new Size(64, 24);
            label5.TabIndex = 27;
            label5.Text = "أسم اليتيم";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(598, 60);
            label6.Name = "label6";
            label6.Size = new Size(55, 24);
            label6.TabIndex = 28;
            label6.Text = "من تاريخ ";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker2.Location = new Point(194, 87);
            dateTimePicker2.Margin = new Padding(3, 10, 3, 10);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(228, 32);
            dateTimePicker2.TabIndex = 24;
            // 
            // Replacement_orphanUserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Font = new Font("Cairo", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 5, 3, 5);
            Name = "Replacement_orphanUserControl1";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1008, 716);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button buttonReplacementOrphanDetails;
        private Button button2;
        private Button buttonReplacmentOrphan;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
