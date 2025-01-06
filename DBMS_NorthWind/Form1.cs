using Microsoft.Data.SqlClient;

using System.Data;
using System.Data.Common;
using static System.ComponentModel.Design.ObjectSelectorEditor;
namespace DBMS_NorthWind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;


        private void Form1_Load(object sender, EventArgs e)
        {
            conn = ConnectDB.ConnectNorthwind();
            //if(conn.State == ConnectionState.Open)
            //{
            //    MessageBox.Show("เชื่อมต่อฐานข้อมูลเรียบร้อย", "Database Connected");
            //}
            Showdata();
        }

        private void Showdata()
        {
            string sql = "SELECT * FROM Shippers";
            SqlCommand cmd = new SqlCommand(sql, conn); // สร้างคำสั่ง SQL
            SqlDataAdapter da = new SqlDataAdapter(cmd); // ใช้ SqlDataAdapter เพื่อดึงข้อมูล
            DataSet ds = new DataSet(); // สร้าง DataSet สำหรับเก็บข้อมูล
            da.Fill(ds);
            DGV_Shipper.DataSource = ds.Tables[0];
        }

        private void DGV_Shipper_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtShipperID.Text = DGV_Shipper.CurrentRow.Cells[0].Value.ToString();
            txtCompanyName.Text = DGV_Shipper.CurrentRow.Cells[1].Value.ToString();
            txtPhone.Text = DGV_Shipper.CurrentRow.Cells[2].Value.ToString();
        }

        private void clearForm()
        {
            txtShipperID.Clear();
            txtCompanyName.Text = null;
            txtPhone.Text = string.Empty;
            txtCompanyName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            //ตรวจสอบข้อมูล
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
            if (n > 0)
            {
                Showdata();
                clearForm();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtShipperID.Text))
            {
                MessageBox.Show("โปรดเลือกข้อมูลที่จะปรับปรุง", "เกิดข้อผิดพลาด");
                return;
            }
            else if (String.IsNullOrEmpty(txtCompanyName.Text))
            {
                MessageBox.Show("โปรดใส่ข้อมูลก่อน", "เกิดข้อผิดพลาด");
                return;
            }
            //เพิ่มข้อมูลเข้าฐานข้อมูล
            string sql = "Update Shippers"
                        + " set CompanyName = @CompanyName,Phone = @Phone"
                        + " Where ShipperID = @ShipperID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text.Trim());
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
            cmd.Parameters.AddWithValue("@ShipperID", txtShipperID.Text);
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                Showdata();
                clearForm();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Confirm to delete
            if (MessageBox.Show("Confirm to Delete?","Confirm",MessageBoxButtons.YesNo)
                                                                            == DialogResult.No)
            {

            }

            if (String.IsNullOrEmpty(txtShipperID.Text))
            {
                MessageBox.Show("โปรดเลือกข้อมูลที่จะลบ", "เกิดข้อผิดพลาด");
                return;
            }
           
            //เพิ่มข้อมูลเข้าฐานข้อมูล
            string sql = "Delete from Shippers"
                        + " Where ShipperID = @ShipperID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ShipperID", txtShipperID.Text);
            try 
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    Showdata();
                    clearForm();
                }
            } catch(Exception ex) 
            {
                MessageBox.Show("เกิดข้อผิดพลาด" + Environment.NewLine + ex.Message, "Errer!!!");
            }
            
        }
    }
}
