namespace orphans.Gui.GuiHome
{
    partial class Home
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
            TreeNode treeNode39 = new TreeNode("Dashboard      ");
            TreeNode treeNode40 = new TreeNode("تسجيل يتيم جديد");
            TreeNode treeNode41 = new TreeNode("إستبدال الايتام");
            TreeNode treeNode42 = new TreeNode("الجانب المالي");
            TreeNode treeNode43 = new TreeNode("كفالة الطلاب ");
            TreeNode treeNode44 = new TreeNode("كفالة المعلمين");
            TreeNode treeNode45 = new TreeNode("Node3");
            TreeNode treeNode46 = new TreeNode("Node9");
            TreeNode treeNode47 = new TreeNode("Node10");
            TreeNode treeNode48 = new TreeNode("نظام الايتام     ", new TreeNode[] { treeNode40, treeNode41, treeNode42, treeNode43, treeNode44, treeNode45, treeNode46, treeNode47 });
            TreeNode treeNode49 = new TreeNode("إنشائية");
            TreeNode treeNode50 = new TreeNode("إنسانية");
            TreeNode treeNode51 = new TreeNode("تنموية");
            TreeNode treeNode52 = new TreeNode("Node15");
            TreeNode treeNode53 = new TreeNode("المشاريع     ", new TreeNode[] { treeNode49, treeNode50, treeNode51, treeNode52 });
            TreeNode treeNode54 = new TreeNode("تقارير الايتام");
            TreeNode treeNode55 = new TreeNode("تقارير المشاريع");
            TreeNode treeNode56 = new TreeNode("Node19");
            TreeNode treeNode57 = new TreeNode("التقارير    ", new TreeNode[] { treeNode54, treeNode55, treeNode56 });
            panelTree = new Panel();
            treeView2 = new TreeView();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelContainer = new Panel();
            panelTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelTree
            // 
            panelTree.BackColor = Color.DimGray;
            panelTree.Controls.Add(treeView2);
            panelTree.Controls.Add(panel2);
            panelTree.Controls.Add(label2);
            panelTree.Controls.Add(label1);
            panelTree.Controls.Add(pictureBox1);
            panelTree.Dock = DockStyle.Left;
            panelTree.Location = new Point(0, 0);
            panelTree.Name = "panelTree";
            panelTree.Size = new Size(223, 665);
            panelTree.TabIndex = 1;
            // 
            // treeView2
            // 
            treeView2.BackColor = Color.DimGray;
            treeView2.BorderStyle = BorderStyle.None;
            treeView2.Font = new Font("Cairo", 12F);
            treeView2.ForeColor = Color.White;
            treeView2.HideSelection = false;
            treeView2.Indent = 20;
            treeView2.ItemHeight = 39;
            treeView2.LineColor = Color.White;
            treeView2.Location = new Point(0, 102);
            treeView2.Name = "treeView2";
            treeNode39.Name = "Dashboard";
            treeNode39.NodeFont = new Font("Cairo Medium", 12F, FontStyle.Bold);
            treeNode39.Text = "Dashboard      ";
            treeNode40.Name = "NodeNewData";
            treeNode40.Text = "تسجيل يتيم جديد";
            treeNode41.Name = "NodeReplacement";
            treeNode41.Text = "إستبدال الايتام";
            treeNode42.Name = "NodeSalary";
            treeNode42.Text = "الجانب المالي";
            treeNode43.Name = "Node1";
            treeNode43.Text = "كفالة الطلاب ";
            treeNode44.Name = "Node2";
            treeNode44.Text = "كفالة المعلمين";
            treeNode45.Name = "Node3";
            treeNode45.Text = "Node3";
            treeNode46.Name = "Node9";
            treeNode46.Text = "Node9";
            treeNode47.Name = "Node10";
            treeNode47.Text = "Node10";
            treeNode48.Name = "Node0";
            treeNode48.NodeFont = new Font("Cairo Medium", 12F, FontStyle.Bold);
            treeNode48.Text = "نظام الايتام     ";
            treeNode49.Name = "Node5";
            treeNode49.Text = "إنشائية";
            treeNode50.Name = "Node6";
            treeNode50.Text = "إنسانية";
            treeNode51.Name = "Node7";
            treeNode51.Text = "تنموية";
            treeNode52.Name = "Node15";
            treeNode52.Text = "Node15";
            treeNode53.Name = "Node4";
            treeNode53.NodeFont = new Font("Cairo Medium", 12F, FontStyle.Bold);
            treeNode53.Text = "المشاريع     ";
            treeNode54.Name = "Node16";
            treeNode54.Text = "تقارير الايتام";
            treeNode55.Name = "Node18";
            treeNode55.Text = "تقارير المشاريع";
            treeNode56.Name = "Node19";
            treeNode56.Text = "Node19";
            treeNode57.Name = "Node8";
            treeNode57.NodeFont = new Font("Cairo Medium", 12F, FontStyle.Bold);
            treeNode57.Text = "التقارير    ";
            treeView2.Nodes.AddRange(new TreeNode[] { treeNode39, treeNode48, treeNode53, treeNode57 });
            treeView2.PathSeparator = "/";
            treeView2.RightToLeft = RightToLeft.Yes;
            treeView2.RightToLeftLayout = true;
            treeView2.Size = new Size(223, 551);
            treeView2.TabIndex = 2;
            treeView2.AfterSelect += treeView2_AfterSelect;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(15, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 5);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cairo", 8.999999F);
            label2.ForeColor = SystemColors.GradientInactiveCaption;
            label2.Location = new Point(64, 46);
            label2.Name = "label2";
            label2.Size = new Size(31, 23);
            label2.TabIndex = 2;
            label2.Text = "مدير";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cairo", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 15);
            label1.Name = "label1";
            label1.Size = new Size(51, 30);
            label1.TabIndex = 1;
            label1.Text = "الاسم";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.icons8_male_user_321;
            pictureBox1.Location = new Point(111, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(223, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(951, 665);
            panelContainer.TabIndex = 2;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 665);
            Controls.Add(panelContainer);
            Controls.Add(panelTree);
            Name = "Home";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            FormClosed += Home_FormClosed;
            Load += Home_Load;
            panelTree.ResumeLayout(false);
            panelTree.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panelTree;
        private TreeView treeView2;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        public Panel panelContainer;
    }
}