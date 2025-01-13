using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_NorthWind
{
    public partial class frmShippers : Form
    {
        public frmShippers()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;
        public int MyProperty { get; set; }
        public String MyCompany { get; set; }
        public String Phone { get; set; }
        public string Status { get; set; }
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }


        private void frmShippers_Load(object sender, EventArgs e)
        {
            
            txtShipperID.Text = ShipperID.ToString();
            txtCompanyName.Text = CompanyName;
            txtPhone.Text = Phone;
            txtCompanyName.Focus();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn = ConnectDB.ConnectNorthwind();
            if (Status == "insert")
            {
                InsertShippers();

            }
            else if (Status == "update")
            {
                UpdateShippers();

            }
            
            this.Close();
        }

        private void UpdateShippers()
        {

            if (!int.TryParse(txtShipperID.Text.Trim(), out int shipperID))
            {
                MessageBox.Show("รหัส ShipperID ต้องเป็นตัวเลขเท่านั้น", "เกิดข้อผิดพลาด");
                return;
            }

            if (String.IsNullOrEmpty(txtCompanyName.Text))
            {
                MessageBox.Show("กรุณากรอกชื่อบริษัท", "เกิดข้อผิดพลาด");
                return;
            }

            if (String.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("กรุณากรอกเบอร์โทรศัพท์", "เกิดข้อผิดพลาด");
                return;
            }

            string sql = "UPDATE Shippers SET CompanyName = @CompanyName, Phone = @Phone WHERE ShipperID = @ShipperID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ShipperID", shipperID);
            cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text.Trim());
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("ปรับปรุงข้อมูลสำเร็จ", "สำเร็จ");
                }
                else
                {
                    MessageBox.Show("ไม่พบข้อมูลที่ต้องการปรับปรุง", "เกิดข้อผิดพลาด");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"เกิดข้อผิดพลาด: {ex.Message}", "ข้อผิดพลาด");
            }

        }

        private void InsertShippers()
        {
            if (String.IsNullOrEmpty(txtCompanyName.Text))
            {
                MessageBox.Show("โปรดใส่ข้อมูลก่อน", "เกิดข้อผิดพลาด");
                return;
            }
            //เพิ่มข้อมูลเข้าฐานข้อมูล
            string sql = "Insert into shippers"
                        + " Values(@CompanyName,@Phone)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text.Trim());
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
            int n = cmd.ExecuteNonQuery();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
