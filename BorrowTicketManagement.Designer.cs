namespace ILib
{
    partial class BorrowTicketManagement
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
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.cbbBook = new System.Windows.Forms.ComboBox();
            this.dgvBorrow = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbReader = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdReader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Cambria", 13F);
            this.dtpStart.Location = new System.Drawing.Point(114, 116);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(245, 28);
            this.dtpStart.TabIndex = 12;
            // 
            // cbbBook
            // 
            this.cbbBook.Font = new System.Drawing.Font("Cambria", 14F);
            this.cbbBook.FormattingEnabled = true;
            this.cbbBook.Location = new System.Drawing.Point(114, 76);
            this.cbbBook.Margin = new System.Windows.Forms.Padding(2);
            this.cbbBook.Name = "cbbBook";
            this.cbbBook.Size = new System.Drawing.Size(245, 30);
            this.cbbBook.TabIndex = 8;
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.code,
            this.IdReader,
            this.IdBook,
            this.DateStart,
            this.DateEnd,
            this.Status});
            this.dgvBorrow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBorrow.Location = new System.Drawing.Point(0, 330);
            this.dgvBorrow.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.RowHeadersWidth = 51;
            this.dgvBorrow.Size = new System.Drawing.Size(754, 320);
            this.dgvBorrow.TabIndex = 20;
            this.dgvBorrow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrow_CellClick);
            this.dgvBorrow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrow_CellContentClick);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.button5.Image = global::ILib.Properties.Resources.icons8_cancel_48;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(631, 247);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 54);
            this.button5.TabIndex = 19;
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
            this.button4.Location = new System.Drawing.Point(360, 247);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.button4.Size = new System.Drawing.Size(112, 54);
            this.button4.TabIndex = 18;
            this.button4.Text = "Lưu";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Image = global::ILib.Properties.Resources.icons8_repair_48;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(244, 247);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnDelete.Size = new System.Drawing.Size(112, 54);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Sửa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Image = global::ILib.Properties.Resources.icons8_delete_48;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(127, 247);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnEdit.Size = new System.Drawing.Size(112, 54);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Xóa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Image = global::ILib.Properties.Resources.icons8_plus_48;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(9, 247);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 54);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(4, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ngày mượn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(384, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã vé";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(4, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên sách";
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.txtCode);
            this.GroupBox.Controls.Add(this.dtpEnd);
            this.GroupBox.Controls.Add(this.label3);
            this.GroupBox.Controls.Add(this.cbbReader);
            this.GroupBox.Controls.Add(this.label2);
            this.GroupBox.Controls.Add(this.dtpStart);
            this.GroupBox.Controls.Add(this.cbbBook);
            this.GroupBox.Controls.Add(this.txtStatus);
            this.GroupBox.Controls.Add(this.label9);
            this.GroupBox.Controls.Add(this.label6);
            this.GroupBox.Controls.Add(this.label5);
            this.GroupBox.Controls.Add(this.label4);
            this.GroupBox.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.GroupBox.Location = new System.Drawing.Point(9, 72);
            this.GroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox.Size = new System.Drawing.Size(734, 165);
            this.GroupBox.TabIndex = 2;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Thông tin";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Cambria", 14F);
            this.txtCode.Location = new System.Drawing.Point(485, 37);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(245, 29);
            this.txtCode.TabIndex = 6;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("Cambria", 13F);
            this.dtpEnd.Location = new System.Drawing.Point(485, 115);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(245, 28);
            this.dtpEnd.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(384, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ngày trả";
            // 
            // cbbReader
            // 
            this.cbbReader.Font = new System.Drawing.Font("Cambria", 14F);
            this.cbbReader.FormattingEnabled = true;
            this.cbbReader.Location = new System.Drawing.Point(114, 37);
            this.cbbReader.Margin = new System.Windows.Forms.Padding(2);
            this.cbbReader.Name = "cbbReader";
            this.cbbReader.Size = new System.Drawing.Size(245, 30);
            this.cbbReader.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(4, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Độc giả";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cambria", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(754, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Vé Mượn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Cambria", 14F);
            this.txtId.Location = new System.Drawing.Point(9, 305);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(245, 29);
            this.txtId.TabIndex = 16;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // code
            // 
            this.code.DataPropertyName = "code";
            this.code.HeaderText = "Mã";
            this.code.Name = "code";
            // 
            // IdReader
            // 
            this.IdReader.DataPropertyName = "IdReader";
            this.IdReader.HeaderText = "Độc giả";
            this.IdReader.Name = "IdReader";
            this.IdReader.Width = 150;
            // 
            // IdBook
            // 
            this.IdBook.DataPropertyName = "IdBook";
            this.IdBook.HeaderText = "Sách";
            this.IdBook.Name = "IdBook";
            // 
            // DateStart
            // 
            this.DateStart.DataPropertyName = "DateStart";
            this.DateStart.HeaderText = "Ngày mượn";
            this.DateStart.Name = "DateStart";
            this.DateStart.Width = 125;
            // 
            // DateEnd
            // 
            this.DateEnd.DataPropertyName = "DateEnd";
            this.DateEnd.HeaderText = "Ngày trả";
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Width = 125;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Trạng thái";
            this.Status.Name = "Status";
            // 
            // BorrowTicketManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 650);
            this.ControlBox = false;
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvBorrow);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(6, 8);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BorrowTicketManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BorrowTicketManagement";
            this.Load += new System.EventHandler(this.BorrowTicketManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.ComboBox cbbBook;
        private System.Windows.Forms.DataGridView dgvBorrow;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbReader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdReader;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}