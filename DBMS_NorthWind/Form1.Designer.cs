namespace DBMS_NorthWind
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DGV_Shipper = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtShipperID = new TextBox();
            txtCompanyName = new TextBox();
            txtPhone = new TextBox();
            btninsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_Shipper).BeginInit();
            SuspendLayout();
            // 
            // DGV_Shipper
            // 
            DGV_Shipper.AllowUserToAddRows = false;
            DGV_Shipper.AllowUserToDeleteRows = false;
            DGV_Shipper.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Shipper.Location = new Point(11, 17);
            DGV_Shipper.Name = "DGV_Shipper";
            DGV_Shipper.ReadOnly = true;
            DGV_Shipper.RowHeadersWidth = 51;
            DGV_Shipper.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Shipper.Size = new Size(777, 191);
            DGV_Shipper.TabIndex = 0;
            DGV_Shipper.CellMouseUp += DGV_Shipper_CellMouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 228);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 1;
            label1.Text = "รหัสบริษัทขนส่ง";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 275);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 2;
            label2.Text = "ชื่อบริษัท";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 319);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 3;
            label3.Text = "เบอร์โทร";
            // 
            // txtShipperID
            // 
            txtShipperID.Location = new Point(114, 228);
            txtShipperID.Name = "txtShipperID";
            txtShipperID.ReadOnly = true;
            txtShipperID.Size = new Size(136, 27);
            txtShipperID.TabIndex = 4;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(78, 275);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(241, 27);
            txtCompanyName.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(76, 319);
            txtPhone.MaxLength = 100;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(237, 27);
            txtPhone.TabIndex = 6;
            // 
            // btninsert
            // 
            btninsert.BackColor = Color.FromArgb(192, 255, 255);
            btninsert.Location = new Point(76, 381);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(94, 29);
            btninsert.TabIndex = 7;
            btninsert.Text = "เพิ่ม";
            btninsert.UseVisualStyleBackColor = false;
            btninsert.Click += btninsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 255, 192);
            btnUpdate.Location = new Point(256, 381);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "ปรับปรุง";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 192, 255);
            btnDelete.Location = new Point(441, 381);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "ลบ";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightCoral;
            btnClear.Location = new Point(627, 381);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 10;
            btnClear.Text = "ล้างฟอร์ม";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btninsert);
            Controls.Add(txtPhone);
            Controls.Add(txtCompanyName);
            Controls.Add(txtShipperID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DGV_Shipper);
            Name = "Form1";
            Text = "จัดการข้อมูลในบริษัทขนส่ง";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_Shipper).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV_Shipper;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtShipperID;
        private TextBox txtCompanyName;
        private TextBox txtPhone;
        private Button btninsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
    }
}
