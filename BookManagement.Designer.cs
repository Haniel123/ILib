namespace ILib
{
    partial class BookManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookManagement));
            this.grp_bookDetail = new System.Windows.Forms.GroupBox();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txt_bookStatus = new System.Windows.Forms.TextBox();
            this.lbl_bookStatus = new System.Windows.Forms.Label();
            this.txt_bookId = new System.Windows.Forms.TextBox();
            this.lbl_bookId = new System.Windows.Forms.Label();
            this.txt_bookQuantity = new System.Windows.Forms.TextBox();
            this.lbl_bookQuantity = new System.Windows.Forms.Label();
            this.txt_bookPrice = new System.Windows.Forms.TextBox();
            this.lbl_bookPrice = new System.Windows.Forms.Label();
            this.txt_bookAuthor = new System.Windows.Forms.TextBox();
            this.lbl_bookAuthor = new System.Windows.Forms.Label();
            this.txt_bookType = new System.Windows.Forms.TextBox();
            this.lbl_bookType = new System.Windows.Forms.Label();
            this.txt_bookName = new System.Windows.Forms.TextBox();
            this.lbl_bookName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_book = new System.Windows.Forms.DataGridView();
            this.grid_col_bookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_col_bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_col_bookType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_col_bookAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_col_bookQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_col_bookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_bookDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_book)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_bookDetail
            // 
            this.grp_bookDetail.Controls.Add(this.simpleButton4);
            this.grp_bookDetail.Controls.Add(this.simpleButton3);
            this.grp_bookDetail.Controls.Add(this.simpleButton1);
            this.grp_bookDetail.Controls.Add(this.txt_bookStatus);
            this.grp_bookDetail.Controls.Add(this.lbl_bookStatus);
            this.grp_bookDetail.Controls.Add(this.txt_bookId);
            this.grp_bookDetail.Controls.Add(this.lbl_bookId);
            this.grp_bookDetail.Controls.Add(this.txt_bookQuantity);
            this.grp_bookDetail.Controls.Add(this.lbl_bookQuantity);
            this.grp_bookDetail.Controls.Add(this.txt_bookPrice);
            this.grp_bookDetail.Controls.Add(this.lbl_bookPrice);
            this.grp_bookDetail.Controls.Add(this.txt_bookAuthor);
            this.grp_bookDetail.Controls.Add(this.lbl_bookAuthor);
            this.grp_bookDetail.Controls.Add(this.txt_bookType);
            this.grp_bookDetail.Controls.Add(this.lbl_bookType);
            this.grp_bookDetail.Controls.Add(this.txt_bookName);
            this.grp_bookDetail.Controls.Add(this.lbl_bookName);
            this.grp_bookDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.grp_bookDetail.Location = new System.Drawing.Point(7, 57);
            this.grp_bookDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grp_bookDetail.Name = "grp_bookDetail";
            this.grp_bookDetail.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grp_bookDetail.Size = new System.Drawing.Size(568, 179);
            this.grp_bookDetail.TabIndex = 3;
            this.grp_bookDetail.TabStop = false;
            this.grp_bookDetail.Text = "Thông tin chi tiết";
            this.grp_bookDetail.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(390, 133);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(74, 24);
            this.simpleButton4.TabIndex = 17;
            this.simpleButton4.Text = "Sửa";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(485, 133);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 24);
            this.simpleButton3.TabIndex = 16;
            this.simpleButton3.Text = "Xoá";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(294, 133);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 24);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "Thêm";
            // 
            // txt_bookStatus
            // 
            this.txt_bookStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_bookStatus.Location = new System.Drawing.Point(85, 133);
            this.txt_bookStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_bookStatus.Name = "txt_bookStatus";
            this.txt_bookStatus.Size = new System.Drawing.Size(187, 24);
            this.txt_bookStatus.TabIndex = 14;
            this.txt_bookStatus.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lbl_bookStatus
            // 
            this.lbl_bookStatus.AutoSize = true;
            this.lbl_bookStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_bookStatus.Location = new System.Drawing.Point(10, 136);
            this.lbl_bookStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bookStatus.Name = "lbl_bookStatus";
            this.lbl_bookStatus.Size = new System.Drawing.Size(77, 18);
            this.lbl_bookStatus.TabIndex = 13;
            this.lbl_bookStatus.Text = "Trạng thái:";
            // 
            // txt_bookId
            // 
            this.txt_bookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_bookId.Location = new System.Drawing.Point(85, 97);
            this.txt_bookId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_bookId.Name = "txt_bookId";
            this.txt_bookId.Size = new System.Drawing.Size(76, 24);
            this.txt_bookId.TabIndex = 8;
            this.txt_bookId.TextChanged += new System.EventHandler(this.txt_bookId_TextChanged);
            // 
            // lbl_bookId
            // 
            this.lbl_bookId.AutoSize = true;
            this.lbl_bookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_bookId.Location = new System.Drawing.Point(10, 99);
            this.lbl_bookId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bookId.Name = "lbl_bookId";
            this.lbl_bookId.Size = new System.Drawing.Size(69, 18);
            this.lbl_bookId.TabIndex = 7;
            this.lbl_bookId.Text = "Mã sách:";
            // 
            // txt_bookQuantity
            // 
            this.txt_bookQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_bookQuantity.Location = new System.Drawing.Point(390, 64);
            this.txt_bookQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_bookQuantity.Name = "txt_bookQuantity";
            this.txt_bookQuantity.Size = new System.Drawing.Size(170, 24);
            this.txt_bookQuantity.TabIndex = 6;
            // 
            // lbl_bookQuantity
            // 
            this.lbl_bookQuantity.AutoSize = true;
            this.lbl_bookQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_bookQuantity.Location = new System.Drawing.Point(317, 67);
            this.lbl_bookQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bookQuantity.Name = "lbl_bookQuantity";
            this.lbl_bookQuantity.Size = new System.Drawing.Size(71, 18);
            this.lbl_bookQuantity.TabIndex = 5;
            this.lbl_bookQuantity.Text = "Số lượng:";
            // 
            // txt_bookPrice
            // 
            this.txt_bookPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_bookPrice.Location = new System.Drawing.Point(85, 64);
            this.txt_bookPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_bookPrice.Name = "txt_bookPrice";
            this.txt_bookPrice.Size = new System.Drawing.Size(212, 24);
            this.txt_bookPrice.TabIndex = 4;
            // 
            // lbl_bookPrice
            // 
            this.lbl_bookPrice.AutoSize = true;
            this.lbl_bookPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_bookPrice.Location = new System.Drawing.Point(10, 67);
            this.lbl_bookPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bookPrice.Name = "lbl_bookPrice";
            this.lbl_bookPrice.Size = new System.Drawing.Size(35, 18);
            this.lbl_bookPrice.TabIndex = 3;
            this.lbl_bookPrice.Text = "Giá:";
            // 
            // txt_bookAuthor
            // 
            this.txt_bookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_bookAuthor.Location = new System.Drawing.Point(229, 97);
            this.txt_bookAuthor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_bookAuthor.Name = "txt_bookAuthor";
            this.txt_bookAuthor.Size = new System.Drawing.Size(121, 24);
            this.txt_bookAuthor.TabIndex = 10;
            this.txt_bookAuthor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_bookAuthor
            // 
            this.lbl_bookAuthor.AutoSize = true;
            this.lbl_bookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_bookAuthor.Location = new System.Drawing.Point(166, 99);
            this.lbl_bookAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bookAuthor.Name = "lbl_bookAuthor";
            this.lbl_bookAuthor.Size = new System.Drawing.Size(60, 18);
            this.lbl_bookAuthor.TabIndex = 9;
            this.lbl_bookAuthor.Text = "Tác giả:";
            this.lbl_bookAuthor.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txt_bookType
            // 
            this.txt_bookType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_bookType.Location = new System.Drawing.Point(433, 96);
            this.txt_bookType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_bookType.Name = "txt_bookType";
            this.txt_bookType.Size = new System.Drawing.Size(127, 24);
            this.txt_bookType.TabIndex = 12;
            this.txt_bookType.TextChanged += new System.EventHandler(this.txt_bookType_TextChanged);
            // 
            // lbl_bookType
            // 
            this.lbl_bookType.AutoSize = true;
            this.lbl_bookType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_bookType.Location = new System.Drawing.Point(357, 99);
            this.lbl_bookType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bookType.Name = "lbl_bookType";
            this.lbl_bookType.Size = new System.Drawing.Size(76, 18);
            this.lbl_bookType.TabIndex = 11;
            this.lbl_bookType.Text = "Loại sách:";
            this.lbl_bookType.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_bookName
            // 
            this.txt_bookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_bookName.Location = new System.Drawing.Point(85, 31);
            this.txt_bookName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_bookName.Name = "txt_bookName";
            this.txt_bookName.Size = new System.Drawing.Size(475, 24);
            this.txt_bookName.TabIndex = 2;
            this.txt_bookName.TextChanged += new System.EventHandler(this.txt_bookName_TextChanged);
            // 
            // lbl_bookName
            // 
            this.lbl_bookName.AutoSize = true;
            this.lbl_bookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_bookName.Location = new System.Drawing.Point(10, 34);
            this.lbl_bookName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bookName.Name = "lbl_bookName";
            this.lbl_bookName.Size = new System.Drawing.Size(73, 18);
            this.lbl_bookName.TabIndex = 1;
            this.lbl_bookName.Text = "Tên sách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(198, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Sách";
            // 
            // grid_book
            // 
            this.grid_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_book.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid_col_bookId,
            this.grid_col_bookName,
            this.grid_col_bookType,
            this.grid_col_bookAuthor,
            this.grid_col_bookQuantity,
            this.grid_col_bookPrice});
            this.grid_book.Location = new System.Drawing.Point(7, 244);
            this.grid_book.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grid_book.Name = "grid_book";
            this.grid_book.RowHeadersWidth = 51;
            this.grid_book.RowTemplate.Height = 24;
            this.grid_book.Size = new System.Drawing.Size(568, 132);
            this.grid_book.TabIndex = 15;
            this.grid_book.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_book_CellContentClick);
            // 
            // grid_col_bookId
            // 
            this.grid_col_bookId.HeaderText = "Mã sách";
            this.grid_col_bookId.MinimumWidth = 6;
            this.grid_col_bookId.Name = "grid_col_bookId";
            this.grid_col_bookId.Width = 90;
            // 
            // grid_col_bookName
            // 
            this.grid_col_bookName.HeaderText = "Tên sách";
            this.grid_col_bookName.MinimumWidth = 6;
            this.grid_col_bookName.Name = "grid_col_bookName";
            this.grid_col_bookName.Width = 180;
            // 
            // grid_col_bookType
            // 
            this.grid_col_bookType.HeaderText = "Mã loại sách";
            this.grid_col_bookType.MinimumWidth = 6;
            this.grid_col_bookType.Name = "grid_col_bookType";
            this.grid_col_bookType.Width = 120;
            // 
            // grid_col_bookAuthor
            // 
            this.grid_col_bookAuthor.HeaderText = "Mã tác giả";
            this.grid_col_bookAuthor.MinimumWidth = 6;
            this.grid_col_bookAuthor.Name = "grid_col_bookAuthor";
            this.grid_col_bookAuthor.Width = 125;
            // 
            // grid_col_bookQuantity
            // 
            this.grid_col_bookQuantity.HeaderText = "Số lượng";
            this.grid_col_bookQuantity.MinimumWidth = 6;
            this.grid_col_bookQuantity.Name = "grid_col_bookQuantity";
            this.grid_col_bookQuantity.Width = 90;
            // 
            // grid_col_bookPrice
            // 
            this.grid_col_bookPrice.HeaderText = "Giá";
            this.grid_col_bookPrice.MinimumWidth = 6;
            this.grid_col_bookPrice.Name = "grid_col_bookPrice";
            this.grid_col_bookPrice.Width = 125;
            // 
            // BookManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 386);
            this.Controls.Add(this.grid_book);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grp_bookDetail);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BookManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookForm";
            this.grp_bookDetail.ResumeLayout(false);
            this.grp_bookDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_book)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_bookDetail;
        private System.Windows.Forms.Label lbl_bookId;
        private System.Windows.Forms.TextBox txt_bookId;
        private System.Windows.Forms.TextBox txt_bookType;
        private System.Windows.Forms.Label lbl_bookType;
        private System.Windows.Forms.TextBox txt_bookName;
        private System.Windows.Forms.Label lbl_bookName;
        private System.Windows.Forms.TextBox txt_bookAuthor;
        private System.Windows.Forms.Label lbl_bookAuthor;
        private System.Windows.Forms.TextBox txt_bookQuantity;
        private System.Windows.Forms.Label lbl_bookQuantity;
        private System.Windows.Forms.TextBox txt_bookPrice;
        private System.Windows.Forms.Label lbl_bookPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_book;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_col_bookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_col_bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_col_bookType;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_col_bookAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_col_bookQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_col_bookPrice;
        private System.Windows.Forms.TextBox txt_bookStatus;
        private System.Windows.Forms.Label lbl_bookStatus;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}