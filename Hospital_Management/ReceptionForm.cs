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
    public partial class ReceptionForm : Form
    {
        private string connString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=tcp)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));User Id= " + Global.loginname + ";Password= " + Global.password + ";";

        public ReceptionForm()
        {
            InitializeComponent();
        }

        private void dgvDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            dgvReception.DataSource = dt;

            con.Close();
        }

        private void btnViewHĐ_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connString;
            con.Open();

            OracleCommand cmd = new OracleCommand("SELECT * FROM AD1.HOADON", con);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvReception.DataSource = dt;

            con.Close();
        }

        private void btnBenhNhan_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connString;
            con.Open();

            OracleCommand cmd = new OracleCommand("SELECT * FROM AD1.BENHNHAN", con);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvReception.DataSource = dt;

            con.Close();
        }
    }
}
