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
    public partial class ServiceForm : Form
    {
        private string connString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=tcp)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));User Id= " + Global.loginname + ";Password= " + Global.password + ";";

        public ServiceForm()
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
            dgvService.DataSource = dt;

            con.Close();
        }

        private void btnCTDV_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connString;
            con.Open();

            OracleCommand cmd = new OracleCommand("SELECT * FROM AD1.infor_ctdv", con);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvService.DataSource = dt;

            con.Close();
        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connString;
                con.Open();

                var cmd = new OracleCommand("AD1.MAHOA_CTDV", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("MAKB", OracleDbType.Int32, ParameterDirection.Input).Value = txtMaKhamBenh.Text;
                cmd.Parameters.Add("KL", OracleDbType.NVarchar2, ParameterDirection.Input).Value = txtKetluan.Text;
                cmd.Parameters.Add("KEY_EN", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtKey.Text;

                var da = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connString;
                con.Open();

                var cmd = new OracleCommand("AD1.GIAIMA_CTDV", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("MAKB", OracleDbType.Int32, ParameterDirection.Input).Value = txtMaKB.Text;
                cmd.Parameters.Add("KEY_EN", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtKey_Decode.Text;

                var da = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connString;
            con.Open();

            OracleCommand cmd = new OracleCommand("SELECT * FROM AD1.DICHVU", con);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvService.DataSource = dt;

            con.Close();
        }

        private void btnKeys_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connString;
            con.Open();

            OracleCommand cmd = new OracleCommand("SELECT * FROM AD1.infor_key_en", con);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvService.DataSource = dt;

            con.Close();
        }
    }
}
