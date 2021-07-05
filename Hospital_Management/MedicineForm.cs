using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Hospital_Management
{
    public partial class MedicineForm : Form
    {
        private string connString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=tcp)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));User Id= " + Global.loginname + ";Password= " + Global.password + ";";

        public MedicineForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connString;
            con.Open();

            OracleCommand cmd = new OracleCommand("SELECT * FROM AD1.NHANVIEN", con);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMedicine.DataSource = dt;

            con.Close();
        }

        private void btnThuoc_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connString;
            con.Open();

            // OracleCommand cmd = new OracleCommand("SELECT * FROM AD1.THUOC", con);
            OracleCommand cmd = new OracleCommand("SELECT MATHUOC, DONGIA, LUUY FROM AD1.THUOC", con);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMedicine.DataSource = dt;

            con.Close();
        }

        private void txtKetLuan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateDrug_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connString;
                con.Open();

                string sql = "UPDATE AD1.THUOC SET LUUY = '" + txtLuuY_Update.Text + "' WHERE MATHUOC = " + txtMaThuoc_Update.Text;
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;

                var da = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully updated", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Record not updated", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddDrug_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connString;
                con.Open();

                var cmd = new OracleCommand("AD1.INSERT_INTO_THUOC", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("MTHUOC", OracleDbType.Int32, ParameterDirection.Input).Value = txtMathuoc.Text;
                cmd.Parameters.Add("NAMETHUOC", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtTenthuoc.Text;
                cmd.Parameters.Add("DVT", OracleDbType.NVarchar2, ParameterDirection.Input).Value = txtDVTinh.Text;
                cmd.Parameters.Add("DG", OracleDbType.BinaryFloat, ParameterDirection.Input).Value = txtDonGia.Text;
                cmd.Parameters.Add("NOTE", OracleDbType.NVarchar2, ParameterDirection.Input).Value = txtLuuY.Text;

                var da = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully added", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Record not added", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
