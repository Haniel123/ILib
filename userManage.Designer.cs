namespace ILib
{
    partial class userManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userManage));
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.btnCLose = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditUser = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteUser = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddUser = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhoneUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddressUser = new System.Windows.Forms.TextBox();
            this.cbbPositionUser = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPasswordUser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPasswordRepeatUset = new System.Windows.Forms.TextBox();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 22F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(163, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 36);
            this.label5.TabIndex = 28;
            this.label5.Text = "Danh Mục Thủ Thư";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(19, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tên thủ thư";
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(115, 63);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(186, 20);
            this.txtFullname.TabIndex = 24;
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fullname,
            this.Phone,
            this.Address,
            this.IdType});
            this.dgvUser.Location = new System.Drawing.Point(23, 188);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.Size = new System.Drawing.Size(610, 244);
            this.dgvUser.TabIndex = 31;
            this.dgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnCLose
            // 
            this.btnCLose.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnCLose.Appearance.Options.UseFont = true;
            this.btnCLose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.btnCLose.Location = new System.Drawing.Point(556, 447);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(75, 23);
            this.btnCLose.TabIndex = 23;
            this.btnCLose.Text = "Đóng";
            // 
            // btnEditUser
            // 
            this.btnEditUser.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnEditUser.Appearance.Options.UseFont = true;
            this.btnEditUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.btnEditUser.Location = new System.Drawing.Point(115, 447);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(74, 23);
            this.btnEditUser.TabIndex = 22;
            this.btnEditUser.Text = "Sửa";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDeleteUser.Appearance.Options.UseFont = true;
            this.btnDeleteUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.btnDeleteUser.Location = new System.Drawing.Point(212, 447);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUser.TabIndex = 21;
            this.btnDeleteUser.Text = "Xoá";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(311, 447);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 20;
            this.simpleButton2.Text = "Lưu";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAddUser.Appearance.Options.UseFont = true;
            this.btnAddUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnAddUser.Location = new System.Drawing.Point(21, 447);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 19;
            this.btnAddUser.Text = "Thêm";
            this.btnAddUser.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(341, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Số điện thoại";
            // 
            // txtPhoneUser
            // 
            this.txtPhoneUser.Location = new System.Drawing.Point(446, 63);
            this.txtPhoneUser.Name = "txtPhoneUser";
            this.txtPhoneUser.Size = new System.Drawing.Size(187, 20);
            this.txtPhoneUser.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(360, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "Chức vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(52, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Địa chỉ";
            // 
            // txtAddressUser
            // 
            this.txtAddressUser.AccessibleName = "txtAddressUser";
            this.txtAddressUser.Location = new System.Drawing.Point(115, 112);
            this.txtAddressUser.Name = "txtAddressUser";
            this.txtAddressUser.Size = new System.Drawing.Size(186, 20);
            this.txtAddressUser.TabIndex = 57;
            // 
            // cbbPositionUser
            // 
            this.cbbPositionUser.FormattingEnabled = true;
            this.cbbPositionUser.Location = new System.Drawing.Point(432, 112);
            this.cbbPositionUser.Name = "cbbPositionUser";
            this.cbbPositionUser.Size = new System.Drawing.Size(187, 21);
            this.cbbPositionUser.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(34, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 63;
            this.label6.Text = "Mật khẩu";
            // 
            // txtPasswordUser
            // 
            this.txtPasswordUser.Location = new System.Drawing.Point(115, 150);
            this.txtPasswordUser.Name = "txtPasswordUser";
            this.txtPasswordUser.Size = new System.Drawing.Size(186, 20);
            this.txtPasswordUser.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(307, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 65;
            this.label7.Text = "Nhập lại mật khẩu";
            // 
            // txtPasswordRepeatUset
            // 
            this.txtPasswordRepeatUset.Location = new System.Drawing.Point(446, 150);
            this.txtPasswordRepeatUset.Name = "txtPasswordRepeatUset";
            this.txtPasswordRepeatUset.Size = new System.Drawing.Size(187, 20);
            this.txtPasswordRepeatUset.TabIndex = 64;
            // 
            // Fullname
            // 
            this.Fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fullname.DataPropertyName = "Fullname";
            this.Fullname.HeaderText = "Họ tên";
            this.Fullname.Name = "Fullname";
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Số điện thoại";
            this.Phone.Name = "Phone";
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Địa chỉ";
            this.Address.Name = "Address";
            // 
            // IdType
            // 
            this.IdType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdType.DataPropertyName = "IdType";
            this.IdType.HeaderText = "Chức vụ";
            this.IdType.Name = "IdType";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(-7, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 67;
            this.label8.Text = "Tên đăng nhập";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(115, 86);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(186, 20);
            this.txtUsername.TabIndex = 66;
            // 
            // userManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 484);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPasswordRepeatUset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPasswordUser);
            this.Controls.Add(this.cbbPositionUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddressUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPhoneUser);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnAddUser);
            this.Name = "userManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thủ thư";
            this.Load += new System.EventHandler(this.userManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFullname;
        private DevExpress.XtraEditors.SimpleButton btnCLose;
        private DevExpress.XtraEditors.SimpleButton btnEditUser;
        private DevExpress.XtraEditors.SimpleButton btnDeleteUser;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnAddUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhoneUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddressUser;
        private System.Windows.Forms.ComboBox cbbPositionUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPasswordUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPasswordRepeatUset;
        public System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsername;
    }
}