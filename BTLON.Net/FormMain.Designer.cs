
namespace BTLON.Net
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CReportButton = new Guna.UI2.WinForms.Guna2Button();
            this.CheckoutButton = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EmployeeButton = new Guna.UI2.WinForms.Guna2Button();
            this.QLHangHoaButton = new Guna.UI2.WinForms.Guna2Button();
            this.CustomerManagementButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.MaximizeButton = new System.Windows.Forms.PictureBox();
            this.Date = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.uC_Nhanvien1 = new BTLON.Net.UC_Nhanvien();
            this.uC_CrystalReport1 = new BTLON.Net.UC_CrystalReport();
            this.uC_KhachHang1 = new BTLON.Net.UC_KhachHang();
            this.uC_HangHoa1 = new BTLON.Net.UC_HangHoa();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.uC_HoaDon1 = new BTLON.Net.UC_HoaDon();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeButton)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.panel1.Controls.Add(this.CReportButton);
            this.panel1.Controls.Add(this.CheckoutButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.EmployeeButton);
            this.panel1.Controls.Add(this.QLHangHoaButton);
            this.panel1.Controls.Add(this.CustomerManagementButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 664);
            this.panel1.TabIndex = 0;
            // 
            // CReportButton
            // 
            this.CReportButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.CReportButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.CReportButton.CheckedState.ForeColor = System.Drawing.Color.Lime;
            this.CReportButton.CheckedState.Parent = this.CReportButton;
            this.CReportButton.CustomImages.Parent = this.CReportButton;
            this.CReportButton.FillColor = System.Drawing.Color.Empty;
            this.CReportButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CReportButton.ForeColor = System.Drawing.Color.White;
            this.CReportButton.HoverState.Parent = this.CReportButton;
            this.CReportButton.Location = new System.Drawing.Point(3, 518);
            this.CReportButton.Name = "CReportButton";
            this.CReportButton.ShadowDecoration.Parent = this.CReportButton;
            this.CReportButton.Size = new System.Drawing.Size(167, 65);
            this.CReportButton.TabIndex = 14;
            this.CReportButton.Text = "Thống kê";
            this.CReportButton.Click += new System.EventHandler(this.CReportButton_Click);
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.CheckoutButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.CheckoutButton.CheckedState.ForeColor = System.Drawing.Color.Lime;
            this.CheckoutButton.CheckedState.Parent = this.CheckoutButton;
            this.CheckoutButton.CustomImages.Parent = this.CheckoutButton;
            this.CheckoutButton.FillColor = System.Drawing.Color.Empty;
            this.CheckoutButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckoutButton.ForeColor = System.Drawing.Color.White;
            this.CheckoutButton.HoverState.Parent = this.CheckoutButton;
            this.CheckoutButton.Location = new System.Drawing.Point(0, 426);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.ShadowDecoration.Parent = this.CheckoutButton;
            this.CheckoutButton.Size = new System.Drawing.Size(170, 65);
            this.CheckoutButton.TabIndex = 13;
            this.CheckoutButton.Text = "Thanh toán";
            this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.pictureBox1.Image = global::BTLON.Net.Properties.Resources.grocery_cart__1_;
            this.pictureBox1.Location = new System.Drawing.Point(28, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.EmployeeButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.EmployeeButton.CheckedState.ForeColor = System.Drawing.Color.Lime;
            this.EmployeeButton.CheckedState.Parent = this.EmployeeButton;
            this.EmployeeButton.CustomImages.Parent = this.EmployeeButton;
            this.EmployeeButton.FillColor = System.Drawing.Color.Empty;
            this.EmployeeButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeButton.ForeColor = System.Drawing.Color.White;
            this.EmployeeButton.HoverState.Parent = this.EmployeeButton;
            this.EmployeeButton.Location = new System.Drawing.Point(4, 334);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.ShadowDecoration.Parent = this.EmployeeButton;
            this.EmployeeButton.Size = new System.Drawing.Size(170, 65);
            this.EmployeeButton.TabIndex = 11;
            this.EmployeeButton.Text = "Quản lý nhân viên";
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            // 
            // QLHangHoaButton
            // 
            this.QLHangHoaButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.QLHangHoaButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.QLHangHoaButton.CheckedState.ForeColor = System.Drawing.Color.Lime;
            this.QLHangHoaButton.CheckedState.Parent = this.QLHangHoaButton;
            this.QLHangHoaButton.CustomImages.Parent = this.QLHangHoaButton;
            this.QLHangHoaButton.FillColor = System.Drawing.Color.Empty;
            this.QLHangHoaButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLHangHoaButton.ForeColor = System.Drawing.Color.White;
            this.QLHangHoaButton.HoverState.Parent = this.QLHangHoaButton;
            this.QLHangHoaButton.Location = new System.Drawing.Point(0, 150);
            this.QLHangHoaButton.Name = "QLHangHoaButton";
            this.QLHangHoaButton.ShadowDecoration.Parent = this.QLHangHoaButton;
            this.QLHangHoaButton.Size = new System.Drawing.Size(173, 65);
            this.QLHangHoaButton.TabIndex = 7;
            this.QLHangHoaButton.Text = "Quản lý hàng hóa";
            this.QLHangHoaButton.Click += new System.EventHandler(this.QLHangHoaButton_Click);
            // 
            // CustomerManagementButton
            // 
            this.CustomerManagementButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.CustomerManagementButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.CustomerManagementButton.CheckedState.ForeColor = System.Drawing.Color.Lime;
            this.CustomerManagementButton.CheckedState.Parent = this.CustomerManagementButton;
            this.CustomerManagementButton.CustomImages.Parent = this.CustomerManagementButton;
            this.CustomerManagementButton.FillColor = System.Drawing.Color.Empty;
            this.CustomerManagementButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerManagementButton.ForeColor = System.Drawing.Color.White;
            this.CustomerManagementButton.HoverState.Parent = this.CustomerManagementButton;
            this.CustomerManagementButton.Location = new System.Drawing.Point(1, 242);
            this.CustomerManagementButton.Name = "CustomerManagementButton";
            this.CustomerManagementButton.ShadowDecoration.Parent = this.CustomerManagementButton;
            this.CustomerManagementButton.Size = new System.Drawing.Size(170, 65);
            this.CustomerManagementButton.TabIndex = 9;
            this.CustomerManagementButton.Text = "Quản lý khách hàng thân thiết";
            this.CustomerManagementButton.Click += new System.EventHandler(this.CustomerManagementButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.MinimizeButton);
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.MaximizeButton);
            this.panel2.Controls.Add(this.Date);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(173, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 66);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Image")));
            this.MinimizeButton.Location = new System.Drawing.Point(841, 17);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(32, 32);
            this.MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimizeButton.TabIndex = 5;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            this.MinimizeButton.MouseHover += new System.EventHandler(this.MinimizeButton_MouseHover);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(953, 17);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(32, 32);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CloseButton.TabIndex = 3;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseHover += new System.EventHandler(this.CloseButton_MouseHover);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MaximizeButton.Image")));
            this.MaximizeButton.Location = new System.Drawing.Point(897, 17);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(33, 32);
            this.MaximizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MaximizeButton.TabIndex = 4;
            this.MaximizeButton.TabStop = false;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            this.MaximizeButton.MouseHover += new System.EventHandler(this.MaximizeButton_MouseHover);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.BackColor = System.Drawing.Color.White;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.Date.Location = new System.Drawing.Point(6, 29);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(19, 20);
            this.Date.TabIndex = 1;
            this.Date.Text = "!!";
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.Controls.Add(this.uC_HoaDon1);
            this.MainPanel.Controls.Add(this.uC_Nhanvien1);
            this.MainPanel.Controls.Add(this.uC_CrystalReport1);
            this.MainPanel.Controls.Add(this.uC_KhachHang1);
            this.MainPanel.Controls.Add(this.uC_HangHoa1);
            this.MainPanel.Location = new System.Drawing.Point(179, 73);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(979, 579);
            this.MainPanel.TabIndex = 2;
            // 
            // uC_Nhanvien1
            // 
            this.uC_Nhanvien1.BackColor = System.Drawing.Color.White;
            this.uC_Nhanvien1.Location = new System.Drawing.Point(4, 9);
            this.uC_Nhanvien1.Name = "uC_Nhanvien1";
            this.uC_Nhanvien1.Size = new System.Drawing.Size(979, 579);
            this.uC_Nhanvien1.TabIndex = 3;
            this.uC_Nhanvien1.Load += new System.EventHandler(this.uC_Nhanvien1_Load);
            // 
            // uC_CrystalReport1
            // 
            this.uC_CrystalReport1.BackColor = System.Drawing.Color.White;
            this.uC_CrystalReport1.Location = new System.Drawing.Point(6, 8);
            this.uC_CrystalReport1.Name = "uC_CrystalReport1";
            this.uC_CrystalReport1.Size = new System.Drawing.Size(979, 579);
            this.uC_CrystalReport1.TabIndex = 2;
            // 
            // uC_KhachHang1
            // 
            this.uC_KhachHang1.BackColor = System.Drawing.Color.White;
            this.uC_KhachHang1.Location = new System.Drawing.Point(4, 7);
            this.uC_KhachHang1.Name = "uC_KhachHang1";
            this.uC_KhachHang1.Size = new System.Drawing.Size(979, 579);
            this.uC_KhachHang1.TabIndex = 1;
            // 
            // uC_HangHoa1
            // 
            this.uC_HangHoa1.AllowDrop = true;
            this.uC_HangHoa1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_HangHoa1.AutoScroll = true;
            this.uC_HangHoa1.BackColor = System.Drawing.Color.White;
            this.uC_HangHoa1.Location = new System.Drawing.Point(0, 4);
            this.uC_HangHoa1.Name = "uC_HangHoa1";
            this.uC_HangHoa1.Size = new System.Drawing.Size(979, 579);
            this.uC_HangHoa1.TabIndex = 0;
            this.uC_HangHoa1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // uC_HoaDon1
            // 
            this.uC_HoaDon1.BackColor = System.Drawing.Color.MistyRose;
            this.uC_HoaDon1.Location = new System.Drawing.Point(2, 3);
            this.uC_HoaDon1.Name = "uC_HoaDon1";
            this.uC_HoaDon1.Size = new System.Drawing.Size(977, 576);
            this.uC_HoaDon1.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1170, 664);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeButton)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox MinimizeButton;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.PictureBox MaximizeButton;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Panel MainPanel;
        private Guna.UI2.WinForms.Guna2Button EmployeeButton;
        private Guna.UI2.WinForms.Guna2Button QLHangHoaButton;
        private Guna.UI2.WinForms.Guna2Button CustomerManagementButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button CReportButton;
        private Guna.UI2.WinForms.Guna2Button CheckoutButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private UC_HangHoa uC_HangHoa1;
        private UC_KhachHang uC_KhachHang1;
        private UC_CrystalReport uC_CrystalReport1;
        private UC_Nhanvien uC_Nhanvien1;
        private UC_HoaDon uC_HoaDon1;
    }
}