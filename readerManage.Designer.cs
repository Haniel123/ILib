namespace ILib
{
    partial class readerManage
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
            this.txtAddressUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhoneUser = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReader = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReader)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.txtAddressUser);
            this.GroupBox.Controls.Add(this.label3);
            this.GroupBox.Controls.Add(this.txtStatus);
            this.GroupBox.Controls.Add(this.label9);
            this.GroupBox.Controls.Add(this.txtPhoneUser);
            this.GroupBox.Controls.Add(this.txtFullname);
            this.GroupBox.Controls.Add(this.label2);
            this.GroupBox.Controls.Add(this.label4);
            this.GroupBox.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.GroupBox.Location = new System.Drawing.Point(9, 72);
            this.GroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox.Size = new System.Drawing.Size(734, 122);
            this.GroupBox.TabIndex = 102;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Thông tin";
            // 
            // txtAddressUser
            // 
            this.txtAddressUser.Font = new System.Drawing.Font("Cambria", 14F);
            this.txtAddressUser.Location = new System.Drawing.Point(485, 36);
            this.txtAddressUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddressUser.Name = "txtAddressUser";
            this.txtAddressUser.Size = new System.Drawing.Size(245, 29);
            this.txtAddressUser.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(384, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa chỉ";
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Cambria", 14F);
            this.txtStatus.Location = new System.Drawing.Point(485, 76);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(245, 29);
            this.txtStatus.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(384, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "Trạng thái";
            // 
            // txtPhoneUser
            // 
            this.txtPhoneUser.Font = new System.Drawing.Font("Cambria", 14F);
            this.txtPhoneUser.Location = new System.Drawing.Point(106, 76);
            this.txtPhoneUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneUser.Name = "txtPhoneUser";
            this.txtPhoneUser.Size = new System.Drawing.Size(245, 29);
            this.txtPhoneUser.TabIndex = 8;
            // 
            // txtFullname
            // 
            this.txtFullname.Font = new System.Drawing.Font("Cambria", 14F);
            this.txtFullname.Location = new System.Drawing.Point(106, 36);
            this.txtFullname.Margin = new System.Windows.Forms.Padding(2);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(245, 29);
            this.txtFullname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
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
            this.label4.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(4, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Điện thoại";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cambria", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(754, 70);
            this.label1.TabIndex = 101;
            this.label1.Text = "Quản Lý Bạn Đọc";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvReader
            // 
            this.dgvReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Fullname,
            this.Address,
            this.Phone,
            this.Status});
            this.dgvReader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvReader.Location = new System.Drawing.Point(0, 297);
            this.dgvReader.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReader.Name = "dgvReader";
            this.dgvReader.RowHeadersWidth = 51;
            this.dgvReader.Size = new System.Drawing.Size(754, 353);
            this.dgvReader.TabIndex = 16;
            this.dgvReader.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReader_CellClick);
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
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Địa chỉ";
            this.Address.Name = "Address";
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Điện thoại";
            this.Phone.Name = "Phone";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Trạng thái";
            this.Status.Name = "Status";
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.button5.Image = global::ILib.Properties.Resources.icons8_cancel_48;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(631, 204);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 54);
            this.button5.TabIndex = 15;
            this.button5.Text = "Đóng";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.button4.Image = global::ILib.Properties.Resources.icons8_save_48;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(360, 204);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.button4.Size = new System.Drawing.Size(112, 54);
            this.button4.TabIndex = 14;
            this.button4.Text = "Lưu";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Image = global::ILib.Properties.Resources.icons8_repair_48;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(244, 204);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnEdit.Size = new System.Drawing.Size(112, 54);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Image = global::ILib.Properties.Resources.icons8_delete_48;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(127, 204);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnDelete.Size = new System.Drawing.Size(112, 54);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Image = global::ILib.Properties.Resources.icons8_plus_48;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(9, 204);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 54);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Cambria", 14F);
            this.txtId.Location = new System.Drawing.Point(6, 264);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(245, 29);
            this.txtId.TabIndex = 11;
            // 
            // readerManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 650);
            this.ControlBox = false;
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReader);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(6, 8);
            this.Name = "readerManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bạn đọc";
            this.Load += new System.EventHandler(this.readerManage_Load);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.TextBox txtAddressUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPhoneUser;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReader;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}