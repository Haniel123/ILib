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
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbPositionUser = new System.Windows.Forms.ComboBox();
            this.txtPasswordRepeatUset = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPasswordUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddressUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhoneUser = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.txtUsername);
            this.GroupBox.Controls.Add(this.label7);
            this.GroupBox.Controls.Add(this.cbbPositionUser);
            this.GroupBox.Controls.Add(this.txtPasswordRepeatUset);
            this.GroupBox.Controls.Add(this.label5);
            this.GroupBox.Controls.Add(this.txtPasswordUser);
            this.GroupBox.Controls.Add(this.label6);
            this.GroupBox.Controls.Add(this.txtAddressUser);
            this.GroupBox.Controls.Add(this.label3);
            this.GroupBox.Controls.Add(this.label9);
            this.GroupBox.Controls.Add(this.txtPhoneUser);
            this.GroupBox.Controls.Add(this.txtFullname);
            this.GroupBox.Controls.Add(this.label2);
            this.GroupBox.Controls.Add(this.label4);
            this.GroupBox.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.GroupBox.Location = new System.Drawing.Point(9, 72);
            this.GroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox.Size = new System.Drawing.Size(734, 198);
            this.GroupBox.TabIndex = 2;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Thông tin";
            this.GroupBox.Enter += new System.EventHandler(this.GroupBox_Enter);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Arial", 14F);
            this.txtUsername.Location = new System.Drawing.Point(143, 162);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(587, 29);
            this.txtUsername.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(4, 167);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tên tài khoản";
            // 
            // cbbPositionUser
            // 
            this.cbbPositionUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPositionUser.Font = new System.Drawing.Font("Arial", 14F);
            this.cbbPositionUser.FormattingEnabled = true;
            this.cbbPositionUser.Location = new System.Drawing.Point(485, 75);
            this.cbbPositionUser.Margin = new System.Windows.Forms.Padding(2);
            this.cbbPositionUser.Name = "cbbPositionUser";
            this.cbbPositionUser.Size = new System.Drawing.Size(245, 30);
            this.cbbPositionUser.TabIndex = 10;
            this.cbbPositionUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboComboBox1_KeyPress);
            // 
            // txtPasswordRepeatUset
            // 
            this.txtPasswordRepeatUset.Font = new System.Drawing.Font("Arial", 14F);
            this.txtPasswordRepeatUset.Location = new System.Drawing.Point(485, 115);
            this.txtPasswordRepeatUset.Margin = new System.Windows.Forms.Padding(2);
            this.txtPasswordRepeatUset.Name = "txtPasswordRepeatUset";
            this.txtPasswordRepeatUset.Size = new System.Drawing.Size(245, 29);
            this.txtPasswordRepeatUset.TabIndex = 14;
            this.txtPasswordRepeatUset.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(370, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nhập lại MK";
            // 
            // txtPasswordUser
            // 
            this.txtPasswordUser.Font = new System.Drawing.Font("Arial", 14F);
            this.txtPasswordUser.Location = new System.Drawing.Point(106, 115);
            this.txtPasswordUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtPasswordUser.Name = "txtPasswordUser";
            this.txtPasswordUser.Size = new System.Drawing.Size(245, 29);
            this.txtPasswordUser.TabIndex = 12;
            this.txtPasswordUser.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(4, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mật khẩu";
            // 
            // txtAddressUser
            // 
            this.txtAddressUser.Font = new System.Drawing.Font("Arial", 14F);
            this.txtAddressUser.Location = new System.Drawing.Point(485, 36);
            this.txtAddressUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddressUser.Name = "txtAddressUser";
            this.txtAddressUser.Size = new System.Drawing.Size(245, 29);
            this.txtAddressUser.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(370, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa chỉ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(370, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "Chức vụ";
            // 
            // txtPhoneUser
            // 
            this.txtPhoneUser.Font = new System.Drawing.Font("Arial", 14F);
            this.txtPhoneUser.Location = new System.Drawing.Point(106, 76);
            this.txtPhoneUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneUser.Name = "txtPhoneUser";
            this.txtPhoneUser.Size = new System.Drawing.Size(245, 29);
            this.txtPhoneUser.TabIndex = 8;
            // 
            // txtFullname
            // 
            this.txtFullname.Font = new System.Drawing.Font("Arial", 14F);
            this.txtFullname.Location = new System.Drawing.Point(106, 36);
            this.txtFullname.Margin = new System.Windows.Forms.Padding(2);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(245, 29);
            this.txtFullname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(4, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(4, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Điện thoại";
            // 
            // txtIdUser
            // 
            this.txtIdUser.Font = new System.Drawing.Font("Arial", 14F);
            this.txtIdUser.Location = new System.Drawing.Point(254, 53);
            this.txtIdUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdUser.Name = "txtIdUser";
            this.txtIdUser.Size = new System.Drawing.Size(245, 29);
            this.txtIdUser.TabIndex = 16;
            this.txtIdUser.Visible = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(754, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Thủ Thư";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Fullname,
            this.Phone,
            this.Username,
            this.Address,
            this.IdType,
            this.Status});
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUser.Location = new System.Drawing.Point(0, 332);
            this.dgvUser.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.Size = new System.Drawing.Size(754, 318);
            this.dgvUser.TabIndex = 20;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã";
            this.id.Name = "id";
            // 
            // Fullname
            // 
            this.Fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fullname.DataPropertyName = "Fullname";
            this.Fullname.HeaderText = "Tên";
            this.Fullname.Name = "Fullname";
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Điện thoại";
            this.Phone.Name = "Phone";
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Tên tài khoản";
            this.Username.Name = "Username";
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
            this.IdType.DataPropertyName = "IdType";
            this.IdType.HeaderText = "Chức vụ";
            this.IdType.Name = "IdType";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Trạng thái";
            this.Status.Name = "Status";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.AutoSize = true;
            this.btnDeleteUser.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnDeleteUser.Image = global::ILib.Properties.Resources.icons8_delete_48;
            this.btnDeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUser.Location = new System.Drawing.Point(127, 274);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnDeleteUser.Size = new System.Drawing.Size(112, 54);
            this.btnDeleteUser.TabIndex = 16;
            this.btnDeleteUser.Text = "Xóa";
            this.btnDeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click_1);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.button5.Image = global::ILib.Properties.Resources.icons8_cancel_48;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(631, 274);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 54);
            this.button5.TabIndex = 19;
            this.button5.Text = "Đóng";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnEditUser
            // 
            this.btnEditUser.AutoSize = true;
            this.btnEditUser.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnEditUser.Image = global::ILib.Properties.Resources.icons8_repair_48;
            this.btnEditUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditUser.Location = new System.Drawing.Point(244, 274);
            this.btnEditUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnEditUser.Size = new System.Drawing.Size(112, 54);
            this.btnEditUser.TabIndex = 17;
            this.btnEditUser.Text = "Sửa";
            this.btnEditUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click_1);
            // 
            // btnAddUser
            // 
            this.btnAddUser.AutoSize = true;
            this.btnAddUser.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnAddUser.Image = global::ILib.Properties.Resources.icons8_plus_48;
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(9, 274);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(112, 54);
            this.btnAddUser.TabIndex = 15;
            this.btnAddUser.Text = "Thêm";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // userManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 650);
            this.ControlBox = false;
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdUser);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnAddUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(6, 8);
            this.Name = "userManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thủ thư";
            this.Load += new System.EventHandler(this.userManage_Load_1);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.TextBox txtAddressUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPhoneUser;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtPasswordRepeatUset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPasswordUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbPositionUser;
        private System.Windows.Forms.TextBox txtIdUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}