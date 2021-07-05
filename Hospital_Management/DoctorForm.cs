﻿using System;
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
    public partial class DoctorForm : Form
    {
        private string connString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=tcp)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));User Id= " + Global.loginname + ";Password= " + Global.password + ";";

        public DoctorForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            dgvDoctor.DataSource = dt;

            con.Close();
        }

        private void btnViewHSBA_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connString;
            con.Open();

            OracleCommand cmd = new OracleCommand("SELECT * FROM AD1.HOSOBENHAN", con);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDoctor.DataSource = dt;

            con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connString;
                con.Open();

                string sql = "UPDATE AD1.HOSOBENHAN SET TINHTRANGBANDAU = '" + txtTinhTrangBĐ.Text + "', KETLUANCUABACSI = '" + txtKetLuan.Text + "' WHERE MAKHAMBENH = " + txtMaBN.Text;
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
    }
}
