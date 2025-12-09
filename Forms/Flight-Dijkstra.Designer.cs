namespace Flight_Dijkstra.Forms
{
    partial class Flight_Dijkstra
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelFunction = new System.Windows.Forms.Panel();
            this.grbButton = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grbChoice = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbOrder = new System.Windows.Forms.ComboBox();
            this.cbbEnd = new System.Windows.Forms.ComboBox();
            this.cbbStart = new System.Windows.Forms.ComboBox();
            this.panelFunction.SuspendLayout();
            this.grbButton.SuspendLayout();
            this.grbChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelHeader.BackgroundImage = global::Flight_Dijkstra.Properties.Resources.windows_wallpaper_27;
            this.panelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1300, 900);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // panelFunction
            // 
            this.panelFunction.Controls.Add(this.grbButton);
            this.panelFunction.Controls.Add(this.grbChoice);
            this.panelFunction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFunction.Location = new System.Drawing.Point(0, 636);
            this.panelFunction.Name = "panelFunction";
            this.panelFunction.Size = new System.Drawing.Size(1300, 264);
            this.panelFunction.TabIndex = 1;
            // 
            // grbButton
            // 
            this.grbButton.Controls.Add(this.btnExit);
            this.grbButton.Controls.Add(this.btnClean);
            this.grbButton.Controls.Add(this.btnAdd);
            this.grbButton.Controls.Add(this.btnSearch);
            this.grbButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbButton.Location = new System.Drawing.Point(700, 0);
            this.grbButton.Name = "grbButton";
            this.grbButton.Size = new System.Drawing.Size(600, 264);
            this.grbButton.TabIndex = 1;
            this.grbButton.TabStop = false;
            this.grbButton.Text = "Chức Năng";
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(355, 157);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(192, 56);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "THOÁT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClean
            // 
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(69, 161);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(192, 56);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "XÓA";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(355, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(192, 56);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "THÊM ĐIỂM";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(69, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(192, 56);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "TÌM KIẾM";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // grbChoice
            // 
            this.grbChoice.Controls.Add(this.label3);
            this.grbChoice.Controls.Add(this.label2);
            this.grbChoice.Controls.Add(this.label1);
            this.grbChoice.Controls.Add(this.cbbOrder);
            this.grbChoice.Controls.Add(this.cbbEnd);
            this.grbChoice.Controls.Add(this.cbbStart);
            this.grbChoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbChoice.Location = new System.Drawing.Point(0, 0);
            this.grbChoice.Name = "grbChoice";
            this.grbChoice.Size = new System.Drawing.Size(1300, 264);
            this.grbChoice.TabIndex = 0;
            this.grbChoice.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "ĐIỀU KIỆN (NẾU CÓ)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Điểm Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nơi Xuất Phát";
            // 
            // cbbOrder
            // 
            this.cbbOrder.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbOrder.FormattingEnabled = true;
            this.cbbOrder.Location = new System.Drawing.Point(348, 177);
            this.cbbOrder.Name = "cbbOrder";
            this.cbbOrder.Size = new System.Drawing.Size(306, 39);
            this.cbbOrder.TabIndex = 2;
            // 
            // cbbEnd
            // 
            this.cbbEnd.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEnd.FormattingEnabled = true;
            this.cbbEnd.Location = new System.Drawing.Point(348, 96);
            this.cbbEnd.Name = "cbbEnd";
            this.cbbEnd.Size = new System.Drawing.Size(306, 39);
            this.cbbEnd.TabIndex = 1;
            // 
            // cbbStart
            // 
            this.cbbStart.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbStart.FormattingEnabled = true;
            this.cbbStart.Location = new System.Drawing.Point(348, 21);
            this.cbbStart.Name = "cbbStart";
            this.cbbStart.Size = new System.Drawing.Size(306, 39);
            this.cbbStart.TabIndex = 0;
            // 
            // Flight_Dijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 900);
            this.Controls.Add(this.panelFunction);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Flight_Dijkstra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight_Dijkstra";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            this.panelFunction.ResumeLayout(false);
            this.grbButton.ResumeLayout(false);
            this.grbChoice.ResumeLayout(false);
            this.grbChoice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelFunction;
        private System.Windows.Forms.GroupBox grbButton;
        private System.Windows.Forms.GroupBox grbChoice;
        private System.Windows.Forms.ComboBox cbbStart;
        private System.Windows.Forms.ComboBox cbbOrder;
        private System.Windows.Forms.ComboBox cbbEnd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClean;
    }
}