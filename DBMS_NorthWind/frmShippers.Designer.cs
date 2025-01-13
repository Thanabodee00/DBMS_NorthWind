namespace DBMS_NorthWind
{
    partial class frmShippers
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
            txtPhone = new TextBox();
            txtCompanyName = new TextBox();
            txtShipperID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(96, 135);
            txtPhone.MaxLength = 100;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(237, 27);
            txtPhone.TabIndex = 12;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(98, 91);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(235, 27);
            txtCompanyName.TabIndex = 11;
            // 
            // txtShipperID
            // 
            txtShipperID.Location = new Point(134, 44);
            txtShipperID.Name = "txtShipperID";
            txtShipperID.ReadOnly = true;
            txtShipperID.Size = new Size(199, 27);
            txtShipperID.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 135);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 9;
            label3.Text = "เบอร์โทร";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 91);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 8;
            label2.Text = "ชื่อบริษัท";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 44);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 7;
            label1.Text = "รหัสบริษัทขนส่ง";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 255, 192);
            btnSave.Location = new Point(31, 203);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 27);
            btnSave.TabIndex = 13;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 192, 192);
            btnCancel.Location = new Point(246, 203);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(87, 28);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "ยกเลิก";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmShippers
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPhone);
            Controls.Add(txtCompanyName);
            Controls.Add(txtShipperID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmShippers";
            Text = "frmShippers";
            Load += frmShippers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPhone;
        private TextBox txtCompanyName;
        private TextBox txtShipperID;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSave;
        private Button btnCancel;
    }
}