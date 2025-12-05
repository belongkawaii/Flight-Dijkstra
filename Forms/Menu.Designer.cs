namespace Flight_Dijkstra.Forms
{
    partial class Menu
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
            this.panelTools = new System.Windows.Forms.Panel();
            this.groupChoice = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupButton = new System.Windows.Forms.GroupBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Solve = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelTools.SuspendLayout();
            this.groupChoice.SuspendLayout();
            this.groupButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTools
            // 
            this.panelTools.Controls.Add(this.groupChoice);
            this.panelTools.Controls.Add(this.groupButton);
            this.panelTools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTools.Location = new System.Drawing.Point(0, 689);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(1482, 264);
            this.panelTools.TabIndex = 0;
            // 
            // groupChoice
            // 
            this.groupChoice.Controls.Add(this.label4);
            this.groupChoice.Controls.Add(this.label3);
            this.groupChoice.Controls.Add(this.label2);
            this.groupChoice.Controls.Add(this.label1);
            this.groupChoice.Controls.Add(this.comboBox3);
            this.groupChoice.Controls.Add(this.comboBox2);
            this.groupChoice.Controls.Add(this.textBox1);
            this.groupChoice.Controls.Add(this.comboBox1);
            this.groupChoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupChoice.Location = new System.Drawing.Point(0, 0);
            this.groupChoice.Name = "groupChoice";
            this.groupChoice.Size = new System.Drawing.Size(911, 264);
            this.groupChoice.TabIndex = 0;
            this.groupChoice.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nơi Xuất Phát";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lựa chọn muốn đi qua đâu (chọn nếu có)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Điểm Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập Tên Của Bạn";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Việt Nam",
            "Mỹ",
            "Lọ Vương",
            "Putin",
            "Trung Quốc"});
            this.comboBox3.Location = new System.Drawing.Point(578, 112);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(255, 33);
            this.comboBox3.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "None",
            "Việt Nam",
            "Mỹ",
            "Lọ Vương",
            "Putin",
            "Trung Quốc"});
            this.comboBox2.Location = new System.Drawing.Point(578, 175);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(255, 33);
            this.comboBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(139, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 30);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Việt Nam",
            "Mỹ",
            "Lọ Vương",
            "Putin",
            "Trung Quốc"});
            this.comboBox1.Location = new System.Drawing.Point(139, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(255, 33);
            this.comboBox1.TabIndex = 0;
            // 
            // groupButton
            // 
            this.groupButton.Controls.Add(this.Exit);
            this.groupButton.Controls.Add(this.Delete);
            this.groupButton.Controls.Add(this.Solve);
            this.groupButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupButton.Location = new System.Drawing.Point(911, 0);
            this.groupButton.Name = "groupButton";
            this.groupButton.Size = new System.Drawing.Size(571, 264);
            this.groupButton.TabIndex = 1;
            this.groupButton.TabStop = false;
            this.groupButton.Text = "Chức Năng";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(115, 197);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(151, 46);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Thoát";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(115, 122);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(151, 46);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Xóa";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Solve
            // 
            this.Solve.Location = new System.Drawing.Point(115, 43);
            this.Solve.Name = "Solve";
            this.Solve.Size = new System.Drawing.Size(151, 46);
            this.Solve.TabIndex = 0;
            this.Solve.Text = "Tính Toán";
            this.Solve.UseVisualStyleBackColor = true;
            // 
            // panelHeader
            // 
            this.panelHeader.BackgroundImage = global::Flight_Dijkstra.Properties.Resources.z7191174422390_e209f71af0d5528edcf38be54e051c45;
            this.panelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1482, 689);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelTools);
            this.DoubleBuffered = true;
            this.Name = "Menu";
            this.Text = "Flight_Dijkstra";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panelTools.ResumeLayout(false);
            this.groupChoice.ResumeLayout(false);
            this.groupChoice.PerformLayout();
            this.groupButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.GroupBox groupChoice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupButton;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Solve;
        private System.Windows.Forms.Panel panelHeader;
    }
}