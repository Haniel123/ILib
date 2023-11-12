namespace ILib
{
    partial class TypeofBookManagement
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
            this.title_typeOfBook = new System.Windows.Forms.Label();
            this.grp_typeOfBookDetail = new System.Windows.Forms.GroupBox();
            this.txt_typeOfBookStatus = new System.Windows.Forms.TextBox();
            this.lbl_typeOfBookStatus = new System.Windows.Forms.Label();
            this.txt_typeOfBookId = new System.Windows.Forms.TextBox();
            this.lbl_typeOfBookId = new System.Windows.Forms.Label();
            this.txt_typeOfBookName = new System.Windows.Forms.TextBox();
            this.lbl_typeOfBookName = new System.Windows.Forms.Label();
            this.btn_typeOfBookUpdate = new System.Windows.Forms.Button();
            this.btn_typeOfBookAdd = new System.Windows.Forms.Button();
            this.lst_typeOfBook = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.grp_typeOfBookDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_typeOfBook
            // 
            this.title_typeOfBook.AutoSize = true;
            this.title_typeOfBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.title_typeOfBook.Location = new System.Drawing.Point(135, 7);
            this.title_typeOfBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_typeOfBook.Name = "title_typeOfBook";
            this.title_typeOfBook.Size = new System.Drawing.Size(290, 37);
            this.title_typeOfBook.TabIndex = 0;
            this.title_typeOfBook.Text = "Quản Lý Loại Sách";
            // 
            // grp_typeOfBookDetail
            // 
            this.grp_typeOfBookDetail.Controls.Add(this.txt_typeOfBookStatus);
            this.grp_typeOfBookDetail.Controls.Add(this.lbl_typeOfBookStatus);
            this.grp_typeOfBookDetail.Controls.Add(this.txt_typeOfBookId);
            this.grp_typeOfBookDetail.Controls.Add(this.lbl_typeOfBookId);
            this.grp_typeOfBookDetail.Controls.Add(this.txt_typeOfBookName);
            this.grp_typeOfBookDetail.Controls.Add(this.lbl_typeOfBookName);
            this.grp_typeOfBookDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.grp_typeOfBookDetail.Location = new System.Drawing.Point(9, 85);
            this.grp_typeOfBookDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grp_typeOfBookDetail.Name = "grp_typeOfBookDetail";
            this.grp_typeOfBookDetail.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grp_typeOfBookDetail.Size = new System.Drawing.Size(422, 101);
            this.grp_typeOfBookDetail.TabIndex = 4;
            this.grp_typeOfBookDetail.TabStop = false;
            this.grp_typeOfBookDetail.Text = "Thông tin chi tiết";
            // 
            // txt_typeOfBookStatus
            // 
            this.txt_typeOfBookStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_typeOfBookStatus.Location = new System.Drawing.Point(284, 63);
            this.txt_typeOfBookStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_typeOfBookStatus.Name = "txt_typeOfBookStatus";
            this.txt_typeOfBookStatus.Size = new System.Drawing.Size(134, 24);
            this.txt_typeOfBookStatus.TabIndex = 6;
            this.txt_typeOfBookStatus.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_typeOfBookStatus
            // 
            this.lbl_typeOfBookStatus.AutoSize = true;
            this.lbl_typeOfBookStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_typeOfBookStatus.Location = new System.Drawing.Point(205, 66);
            this.lbl_typeOfBookStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_typeOfBookStatus.Name = "lbl_typeOfBookStatus";
            this.lbl_typeOfBookStatus.Size = new System.Drawing.Size(77, 18);
            this.lbl_typeOfBookStatus.TabIndex = 5;
            this.lbl_typeOfBookStatus.Text = "Trạng thái:";
            this.lbl_typeOfBookStatus.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_typeOfBookId
            // 
            this.txt_typeOfBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_typeOfBookId.Location = new System.Drawing.Point(106, 63);
            this.txt_typeOfBookId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_typeOfBookId.Name = "txt_typeOfBookId";
            this.txt_typeOfBookId.Size = new System.Drawing.Size(96, 24);
            this.txt_typeOfBookId.TabIndex = 4;
            // 
            // lbl_typeOfBookId
            // 
            this.lbl_typeOfBookId.AutoSize = true;
            this.lbl_typeOfBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_typeOfBookId.Location = new System.Drawing.Point(11, 66);
            this.lbl_typeOfBookId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_typeOfBookId.Name = "lbl_typeOfBookId";
            this.lbl_typeOfBookId.Size = new System.Drawing.Size(96, 18);
            this.lbl_typeOfBookId.TabIndex = 3;
            this.lbl_typeOfBookId.Text = "Mã loại sách:";
            // 
            // txt_typeOfBookName
            // 
            this.txt_typeOfBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_typeOfBookName.Location = new System.Drawing.Point(106, 31);
            this.txt_typeOfBookName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_typeOfBookName.Name = "txt_typeOfBookName";
            this.txt_typeOfBookName.Size = new System.Drawing.Size(312, 24);
            this.txt_typeOfBookName.TabIndex = 2;
            // 
            // lbl_typeOfBookName
            // 
            this.lbl_typeOfBookName.AutoSize = true;
            this.lbl_typeOfBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_typeOfBookName.Location = new System.Drawing.Point(10, 34);
            this.lbl_typeOfBookName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_typeOfBookName.Name = "lbl_typeOfBookName";
            this.lbl_typeOfBookName.Size = new System.Drawing.Size(64, 18);
            this.lbl_typeOfBookName.TabIndex = 1;
            this.lbl_typeOfBookName.Text = "Tên loại:";
            // 
            // btn_typeOfBookUpdate
            // 
            this.btn_typeOfBookUpdate.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_typeOfBookUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_typeOfBookUpdate.ForeColor = System.Drawing.Color.White;
            this.btn_typeOfBookUpdate.Location = new System.Drawing.Point(435, 148);
            this.btn_typeOfBookUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_typeOfBookUpdate.Name = "btn_typeOfBookUpdate";
            this.btn_typeOfBookUpdate.Size = new System.Drawing.Size(105, 32);
            this.btn_typeOfBookUpdate.TabIndex = 8;
            this.btn_typeOfBookUpdate.Text = "Cập nhật";
            this.btn_typeOfBookUpdate.UseVisualStyleBackColor = false;
            // 
            // btn_typeOfBookAdd
            // 
            this.btn_typeOfBookAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_typeOfBookAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_typeOfBookAdd.ForeColor = System.Drawing.Color.White;
            this.btn_typeOfBookAdd.Location = new System.Drawing.Point(435, 75);
            this.btn_typeOfBookAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_typeOfBookAdd.Name = "btn_typeOfBookAdd";
            this.btn_typeOfBookAdd.Size = new System.Drawing.Size(105, 32);
            this.btn_typeOfBookAdd.TabIndex = 7;
            this.btn_typeOfBookAdd.Text = "Thêm mới";
            this.btn_typeOfBookAdd.UseVisualStyleBackColor = false;
            this.btn_typeOfBookAdd.Click += new System.EventHandler(this.btn_bookAdd_Click);
            // 
            // lst_typeOfBook
            // 
            this.lst_typeOfBook.HideSelection = false;
            this.lst_typeOfBook.Location = new System.Drawing.Point(9, 191);
            this.lst_typeOfBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lst_typeOfBook.Name = "lst_typeOfBook";
            this.lst_typeOfBook.Size = new System.Drawing.Size(532, 144);
            this.lst_typeOfBook.TabIndex = 9;
            this.lst_typeOfBook.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(435, 112);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Xoá";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TypeofBookManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 368);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lst_typeOfBook);
            this.Controls.Add(this.btn_typeOfBookUpdate);
            this.Controls.Add(this.grp_typeOfBookDetail);
            this.Controls.Add(this.btn_typeOfBookAdd);
            this.Controls.Add(this.title_typeOfBook);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TypeofBookManagement";
            this.Text = "TypeofBookManagement";
            this.grp_typeOfBookDetail.ResumeLayout(false);
            this.grp_typeOfBookDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_typeOfBook;
        private System.Windows.Forms.GroupBox grp_typeOfBookDetail;
        private System.Windows.Forms.Button btn_typeOfBookUpdate;
        private System.Windows.Forms.Button btn_typeOfBookAdd;
        private System.Windows.Forms.TextBox txt_typeOfBookId;
        private System.Windows.Forms.Label lbl_typeOfBookId;
        private System.Windows.Forms.TextBox txt_typeOfBookName;
        private System.Windows.Forms.Label lbl_typeOfBookName;
        private System.Windows.Forms.ListView lst_typeOfBook;
        private System.Windows.Forms.TextBox txt_typeOfBookStatus;
        private System.Windows.Forms.Label lbl_typeOfBookStatus;
        private System.Windows.Forms.Button button1;
    }
}