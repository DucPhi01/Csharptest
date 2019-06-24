namespace MyPresentation
{
    partial class Form1
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
            this.CbxMaKhoa = new System.Windows.Forms.ComboBox();
            this.KhoaDataGridView = new System.Windows.Forms.DataGridView();
            this.TxtTongKhoa = new System.Windows.Forms.TextBox();
            this.TxtTenKhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DiscardButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNamThanhLap = new System.Windows.Forms.TextBox();
            this.TxtTenKhoa2 = new System.Windows.Forms.TextBox();
            this.TxtMaKhoa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.KhoaDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbxMaKhoa
            // 
            this.CbxMaKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxMaKhoa.FormattingEnabled = true;
            this.CbxMaKhoa.Location = new System.Drawing.Point(86, 51);
            this.CbxMaKhoa.Name = "CbxMaKhoa";
            this.CbxMaKhoa.Size = new System.Drawing.Size(81, 21);
            this.CbxMaKhoa.TabIndex = 0;
            this.CbxMaKhoa.SelectedIndexChanged += new System.EventHandler(this.MaKhoaCbx_SelectedIndexChanged);
            // 
            // KhoaDataGridView
            // 
            this.KhoaDataGridView.AllowUserToAddRows = false;
            this.KhoaDataGridView.AllowUserToDeleteRows = false;
            this.KhoaDataGridView.AllowUserToResizeColumns = false;
            this.KhoaDataGridView.AllowUserToResizeRows = false;
            this.KhoaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KhoaDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.KhoaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.KhoaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KhoaDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KhoaDataGridView.Location = new System.Drawing.Point(352, 35);
            this.KhoaDataGridView.MultiSelect = false;
            this.KhoaDataGridView.Name = "KhoaDataGridView";
            this.KhoaDataGridView.ReadOnly = true;
            this.KhoaDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.KhoaDataGridView.RowTemplate.ReadOnly = true;
            this.KhoaDataGridView.ShowEditingIcon = false;
            this.KhoaDataGridView.Size = new System.Drawing.Size(289, 248);
            this.KhoaDataGridView.TabIndex = 1;
            // 
            // TxtTongKhoa
            // 
            this.TxtTongKhoa.Location = new System.Drawing.Point(590, 9);
            this.TxtTongKhoa.Name = "TxtTongKhoa";
            this.TxtTongKhoa.ReadOnly = true;
            this.TxtTongKhoa.Size = new System.Drawing.Size(29, 20);
            this.TxtTongKhoa.TabIndex = 2;
            // 
            // TxtTenKhoa
            // 
            this.TxtTenKhoa.Location = new System.Drawing.Point(232, 51);
            this.TxtTenKhoa.Name = "TxtTenKhoa";
            this.TxtTenKhoa.ReadOnly = true;
            this.TxtTenKhoa.Size = new System.Drawing.Size(114, 20);
            this.TxtTenKhoa.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tổng khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã Khoa";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(647, 214);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Thêm";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(743, 214);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "Sửa";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(846, 214);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(647, 246);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Lưu ";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // DiscardButton
            // 
            this.DiscardButton.Location = new System.Drawing.Point(743, 246);
            this.DiscardButton.Name = "DiscardButton";
            this.DiscardButton.Size = new System.Drawing.Size(75, 23);
            this.DiscardButton.TabIndex = 11;
            this.DiscardButton.Text = "Hủy";
            this.DiscardButton.UseVisualStyleBackColor = true;
            this.DiscardButton.Click += new System.EventHandler(this.DiscardButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(846, 246);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Thoát";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TxtNamThanhLap);
            this.panel1.Controls.Add(this.TxtTenKhoa2);
            this.panel1.Controls.Add(this.TxtMaKhoa);
            this.panel1.Controls.Add(this.CbxMaKhoa);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.DiscardButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.UpdateButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.TxtTongKhoa);
            this.panel1.Controls.Add(this.TxtTenKhoa);
            this.panel1.Controls.Add(this.KhoaDataGridView);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 306);
            this.panel1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(647, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Năm Thành Lập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(668, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tên Khoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(672, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mã Khoa";
            // 
            // TxtNamThanhLap
            // 
            this.TxtNamThanhLap.Location = new System.Drawing.Point(743, 135);
            this.TxtNamThanhLap.Name = "TxtNamThanhLap";
            this.TxtNamThanhLap.Size = new System.Drawing.Size(100, 20);
            this.TxtNamThanhLap.TabIndex = 15;
            // 
            // TxtTenKhoa2
            // 
            this.TxtTenKhoa2.Location = new System.Drawing.Point(743, 92);
            this.TxtTenKhoa2.Name = "TxtTenKhoa2";
            this.TxtTenKhoa2.Size = new System.Drawing.Size(155, 20);
            this.TxtTenKhoa2.TabIndex = 14;
            // 
            // TxtMaKhoa
            // 
            this.TxtMaKhoa.Location = new System.Drawing.Point(743, 47);
            this.TxtMaKhoa.Name = "TxtMaKhoa";
            this.TxtMaKhoa.Size = new System.Drawing.Size(100, 20);
            this.TxtMaKhoa.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 295);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.KhoaDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxMaKhoa;
        private System.Windows.Forms.DataGridView KhoaDataGridView;
        private System.Windows.Forms.TextBox TxtTongKhoa;
        private System.Windows.Forms.TextBox TxtTenKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DiscardButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtNamThanhLap;
        private System.Windows.Forms.TextBox TxtTenKhoa2;
        private System.Windows.Forms.TextBox TxtMaKhoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

