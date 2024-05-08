namespace GUI
{
    partial class MainViewCustomer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainViewCustomer));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDatban = new System.Windows.Forms.Button();
            this.BtnXemlichsudatmon = new System.Windows.Forms.Button();
            this.BtnChinhsuathongtin = new System.Windows.Forms.Button();
            this.BtnDangxuat = new System.Windows.Forms.Button();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btnham = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelUser = new System.Windows.Forms.Label();
            this.sidebar.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sidebar.Controls.Add(this.btnDatban);
            this.sidebar.Controls.Add(this.BtnXemlichsudatmon);
            this.sidebar.Controls.Add(this.BtnChinhsuathongtin);
            this.sidebar.Controls.Add(this.BtnDangxuat);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 82);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(290, 462);
            this.sidebar.TabIndex = 1;
            // 
            // btnDatban
            // 
            this.btnDatban.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatban.Image = ((System.Drawing.Image)(resources.GetObject("btnDatban.Image")));
            this.btnDatban.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatban.Location = new System.Drawing.Point(3, 3);
            this.btnDatban.Name = "btnDatban";
            this.btnDatban.Size = new System.Drawing.Size(274, 78);
            this.btnDatban.TabIndex = 2;
            this.btnDatban.Text = "              Đặt bàn";
            this.btnDatban.UseVisualStyleBackColor = true;
            this.btnDatban.Click += new System.EventHandler(this.btnDatban_Click);
            // 
            // BtnXemlichsudatmon
            // 
            this.BtnXemlichsudatmon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXemlichsudatmon.Image = ((System.Drawing.Image)(resources.GetObject("BtnXemlichsudatmon.Image")));
            this.BtnXemlichsudatmon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnXemlichsudatmon.Location = new System.Drawing.Point(3, 87);
            this.BtnXemlichsudatmon.Name = "BtnXemlichsudatmon";
            this.BtnXemlichsudatmon.Size = new System.Drawing.Size(274, 78);
            this.BtnXemlichsudatmon.TabIndex = 3;
            this.BtnXemlichsudatmon.Text = "                     Xem lịch sử đặt món";
            this.BtnXemlichsudatmon.UseVisualStyleBackColor = true;
            this.BtnXemlichsudatmon.Click += new System.EventHandler(this.BtnXemlichsudatmon_Click);
            // 
            // BtnChinhsuathongtin
            // 
            this.BtnChinhsuathongtin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChinhsuathongtin.Image = ((System.Drawing.Image)(resources.GetObject("BtnChinhsuathongtin.Image")));
            this.BtnChinhsuathongtin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnChinhsuathongtin.Location = new System.Drawing.Point(3, 171);
            this.BtnChinhsuathongtin.Name = "BtnChinhsuathongtin";
            this.BtnChinhsuathongtin.Size = new System.Drawing.Size(274, 78);
            this.BtnChinhsuathongtin.TabIndex = 4;
            this.BtnChinhsuathongtin.Text = "                    Chỉnh sửa thông tin";
            this.BtnChinhsuathongtin.UseVisualStyleBackColor = true;
            this.BtnChinhsuathongtin.Click += new System.EventHandler(this.BtnChinhsuathongtin_Click);
            // 
            // BtnDangxuat
            // 
            this.BtnDangxuat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDangxuat.Image = ((System.Drawing.Image)(resources.GetObject("BtnDangxuat.Image")));
            this.BtnDangxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDangxuat.Location = new System.Drawing.Point(3, 255);
            this.BtnDangxuat.Name = "BtnDangxuat";
            this.BtnDangxuat.Size = new System.Drawing.Size(274, 78);
            this.BtnDangxuat.TabIndex = 5;
            this.BtnDangxuat.Text = "                  Đăng xuất";
            this.BtnDangxuat.UseVisualStyleBackColor = true;
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.Location = new System.Drawing.Point(111, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "ABC restaurant";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.LabelUser);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.btnham);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1075, 82);
            this.panel.TabIndex = 0;
            // 
            // btnham
            // 
            this.btnham.Image = ((System.Drawing.Image)(resources.GetObject("btnham.Image")));
            this.btnham.Location = new System.Drawing.Point(12, 26);
            this.btnham.Name = "btnham";
            this.btnham.Size = new System.Drawing.Size(35, 27);
            this.btnham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnham.TabIndex = 1;
            this.btnham.TabStop = false;
            this.btnham.Click += new System.EventHandler(this.btnham_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(828, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LabelUser
            // 
            this.LabelUser.AutoSize = true;
            this.LabelUser.Location = new System.Drawing.Point(931, 35);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(44, 16);
            this.LabelUser.TabIndex = 6;
            this.LabelUser.Text = "label2";
            // 
            // MainViewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 544);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "MainViewCustomer";
            this.Text = "MainViewCustomer";
            this.sidebar.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button btnDatban;
        private System.Windows.Forms.Button BtnXemlichsudatmon;
        private System.Windows.Forms.Button BtnChinhsuathongtin;
        private System.Windows.Forms.Button BtnDangxuat;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.PictureBox btnham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelUser;
    }
}