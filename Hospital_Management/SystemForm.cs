using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Oracle.DataAccess.Client;
using Oracle.ManagedDataAccess.Client;

namespace Hospital_Management
{
    public partial class SystemForm : Form
    {
        private string connString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=tcp)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));User Id= " + Global.loginname + ";Password= " + Global.password + ";";

        public SystemForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connString;
            con.Open();

            // OracleCommand cmd = new OracleCommand("SELECT * FROM DBA_USERS", con);
            //OracleCommand cmd = new OracleCommand("SELECT * FROM ALL_USERS", con);
            //OracleDataAdapter da = new OracleDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dgvAdmin1.DataSource = dt;

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "WATCH_USERS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("UNAME", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAdmin1.DataSource = dt;
            //cmd.Parameters.Add("nParentId", OracleDbType.Int16).Value = -1;
            //OracleParameter oraP = new OracleParameter();
            //oraP.OracleDbType = OracleDbType.RefCursor;
            //oraP.Direction = ParameterDirection.Output;
            //cmd.Parameters.Add(oraP);
            //cmd.ExecuteNonQuery();

            //OracleDataReader reader = cmd.ExecuteReader();

            //while (reader.Read())
            //{

            //}
            //reader.Close();
            con.Close();
        }

        private void btnViewRoles_Click(object sender, EventArgs e)
        {
            //OracleConnection con = new OracleConnection();
            //con.ConnectionString = connString;
            //con.Open();

            //OracleCommand cmd = new OracleCommand("SELECT * FROM DBA_ROLES", con);
            //// OracleCommand cmd = new OracleCommand("SELECT * FROM AD1.ROLE_VIEW", con);
            //OracleDataAdapter da = new OracleDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dgvAdmin2.DataSource = dt;

            //con.Close();
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connString;
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "WATCH_ROLES";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("RNAME", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAdmin2.DataSource = dt;
            con.Close();
        }

        private void btnRTP_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connString;
            con.Open();

            OracleCommand cmd = new OracleCommand("SELECT Rtp.role, Rtp.table_Name, RTP.COLUMN_NAME, Rtp.grantable, Rtp.privilege FROM ROLE_TAB_PRIVS RTP", con);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAdmin2.DataSource = dt;

            con.Close();
        }

        private void btnUTP_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connString;
            con.Open();

            OracleCommand cmd = new OracleCommand("SELECT Utp.table_Name, Utp.privilege, UTP.OWNER FROM USER_TAB_PRIVS  UTP", con);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAdmin1.DataSource = dt;

            con.Close();
        }

        private void txtSysPrivis_grantrole_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connString;
                con.Open();

                var cmd = new OracleCommand("PROC_CREATE_USER", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("USER_NAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtUsername_create.Text;
                cmd.Parameters.Add("U_PASSWORD", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtPassword_create.Text;

                var da = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                //var dt = new DataTable();
                //da.Fill(dt);
                //dgvAdmin.DataSource = dt;
                //Form_Admin_Load(sender, e);
                MessageBox.Show("Successfully created user", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed created user", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDropUser_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connString;
                con.Open();

                var cmd = new OracleCommand("PROC_DROP_USER", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("USERNAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtUsername_drop.Text;
                var da = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully dropped user", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed dropped user", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterUser_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connString;
                con.Open();


                var cmd = new OracleCommand("RESET_PASS", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_USERNAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtUsername_alter.Text;
                cmd.Parameters.Add("P_OLDPASS", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtOldPw.Text;
                cmd.Parameters.Add("P_NEWPASS", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtNewPw.Text;
                var da = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully reset password", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed reset password", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateRole_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connString;
                con.Open();

                var cmd = new OracleCommand("PROC_CREATE_ROLE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("ROLE_NAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtRole_create.Text;
                var da = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully created role", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed created role", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDropRole_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connString;
                con.Open();

                var cmd = new OracleCommand("PROC_DROP_ROLE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("ROLE_NAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtRole_drop.Text;
                var da = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully dropped role", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed dropped role", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterRole_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connString;
                con.Open();

                var cmd = new OracleCommand("ALTER_ROLE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("ROLENAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtRole_alter.Text;
                cmd.Parameters.Add("PASSROLENAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtRolepw_alter.Text;
                var da = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully altered role", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed altered role", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void btnViewObjPrivs_Click(object sender, EventArgs e)
        //{
        //    //OracleConnection con = new OracleConnection();
        //    //con.ConnectionString = connString;
        //    //con.Open();

        //    //string sql = "SELECT * FROM WATCH_USERS_PRIVS_SYS WHERE GRANTEE = " + Global.loginname;
        //    //OracleCommand cmd = new OracleCommand(sql, con);
        //    //// OracleCommand cmd = new OracleCommand("SELECT TABLE_NAME,PRIVILEGE FROM DBA_TAB_PRIVS WHERE GRANTEE IN (SELECT granted_role FROM DBA_ROLE_PRIVS WHERE GRANTEE = 'XYZ')", con);
        //    //OracleDataAdapter da = new OracleDataAdapter(cmd);
        //    //DataTable dt = new DataTable();
        //    //da.Fill(dt);
        //    //dgvAdmin3.DataSource = dt;

        //    //con.Close();
        //    OracleConnection con = new OracleConnection();
        //    con.ConnectionString = connString;
        //    con.Open();

        //    OracleCommand cmd = new OracleCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = "WATCH_USER_OBJECT_PRIVS";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add("NAME_OF_USER", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtUsername_VIewPriv.Text;
        //    cmd.Parameters.Add("DISPLAY", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
        //    OracleDataAdapter da = new OracleDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    dgvAdmin3.DataSource = dt;
        //    con.Close();
        //}

        //private void btnViewSysPrivs_Click(object sender, EventArgs e)
        //{
        //    //OracleConnection con = new OracleConnection();
        //    //con.ConnectionString = connString;
        //    //con.Open();

        //    //// string sql = @"SELECT Rtp.role, Rtp.table_Name, RTP.COLUMN_NAME, Rtp.grantable, Rtp.privilege FROM ROLE_TAB_PRIVS RTP";
        //    //string sql = "SELECT * FROM WATCH_USERS_PRIVS_SYS WHERE GRANTEE = " + Global.loginname;
        //    //OracleCommand cmd = new OracleCommand();

        //    //OracleDataAdapter da = new OracleDataAdapter(cmd);
        //    //DataTable dt = new DataTable();
        //    //da.Fill(dt);
        //    //dgvAdmin3.DataSource = dt;

        //    //con.Close();
        //    OracleConnection con = new OracleConnection();
        //    con.ConnectionString = connString;
        //    con.Open();

        //    OracleCommand cmd = new OracleCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = "WATCH_USER_SYS_PRIVS";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add("NAME_OF_USER", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtUsername_VIewPriv.Text;
        //    cmd.Parameters.Add("DISPLAY", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
        //    OracleDataAdapter da = new OracleDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    dgvAdmin3.DataSource = dt;
        //    con.Close();
        //}

        //private void btnViewSys_Click(object sender, EventArgs e)
        //{
        //    //OracleConnection con = new OracleConnection();
        //    //con.ConnectionString = connString;
        //    //con.Open();

        //    //string sql = @"SELECT Rtp.role, Rtp.table_Name, RTP.COLUMN_NAME, Rtp.grantable, Rtp.privilege FROM ROLE_TAB_PRIVS RTP";
        //    //OracleCommand cmd = new OracleCommand(sql, con);
        //    //OracleDataAdapter da = new OracleDataAdapter(cmd);
        //    //DataTable dt = new DataTable();
        //    //da.Fill(dt);
        //    //dgvAdmin4.DataSource = dt;

        //    //con.Close();
        //    OracleConnection con = new OracleConnection();
        //    con.ConnectionString = connString;
        //    con.Open();

        //    OracleCommand cmd = new OracleCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = "WATCH_USER_SYS_PRIVS";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    //cmd.Parameters.Add("NAME_OF_USER", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtUsername_ViewPrivs.Text;
        //    cmd.Parameters.Add("DISPLAY", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
        //    OracleDataAdapter da = new OracleDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    dgvAdmin4.DataSource = dt;
        //    con.Close();
        //}

        //private void btnViewObj_Click(object sender, EventArgs e)
        //{
        //    //OracleConnection con = new OracleConnection();
        //    //con.ConnectionString = connString;
        //    //con.Open();

        //    //OracleCommand cmd = new OracleCommand("SELECT TABLE_NAME,PRIVILEGE FROM DBA_TAB_PRIVS WHERE GRANTEE IN (SELECT granted_role FROM DBA_ROLE_PRIVS WHERE GRANTEE = 'XYZ')", con);
        //    //OracleDataAdapter da = new OracleDataAdapter(cmd);
        //    //DataTable dt = new DataTable();
        //    //da.Fill(dt);
        //    //dgvAdmin4.DataSource = dt;

        //    //con.Close();
        //    OracleConnection con = new OracleConnection();
        //    con.ConnectionString = connString;
        //    con.Open();

        //    OracleCommand cmd = new OracleCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = "WATCH_USER_OBJECT_PRIVS";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    //cmd.Parameters.Add("NAME_OF_USER", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtUsername_ViewPrivs.Text;
        //    cmd.Parameters.Add("DISPLAY", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
        //    OracleDataAdapter da = new OracleDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    dgvAdmin4.DataSource = dt;
        //    con.Close();
        //}

        private void btnGrantSysToUser_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connString;
                con.Open();

                var cmd = new OracleCommand("GRANT_SYS_USER", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("USERNAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtUser.Text;
                cmd.Parameters.Add("PRIVS", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtPrivsSys.Text;
                cmd.Parameters.Add("FLAG", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtFlagAdmin.Text;
                var da = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully granted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed granted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGrantSysToRole_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connString;
                con.Open();

                var cmd = new OracleCommand("GRANT_SYS_ROLE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("ROLENAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtRolename_grantrole.Text;
                cmd.Parameters.Add("PRIVS", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtSysPrivis_grantrole.Text;
                cmd.Parameters.Add("FLAG", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtFlagAdmin_grantrole.Text;

                var da = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully granted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed granted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGrantObjToUser_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connString;
                con.Open();

                var cmd = new OracleCommand("GRANT_PRIVS_OBJ_USER", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("USERNAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtUser_GrantObj.Text;
                cmd.Parameters.Add("PRIVS", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtPrivisObj.Text;
                cmd.Parameters.Add("OBJECTS", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtObject_GrantUser.Text;
                var da = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully granted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed granted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGrantObjToRole_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connString;
                con.Open();

                var cmd = new OracleCommand("GRANT_PRIVS_OBJ_ROLE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("ROLENAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtRole_grantrole.Text;
                cmd.Parameters.Add("PRIVS", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtObjPrivis_grantrole.Text;
                cmd.Parameters.Add("OBJECTS", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtObject_GrantRole.Text;

                var da = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully granted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed granted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGrantRoleToUser_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connString;
                con.Open();

                var cmd = new OracleCommand("GRANT_ROLE_TO_USER", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("USERNAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtUsername_grantRU.Text;
                cmd.Parameters.Add("ROLENAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtRole_grantRU.Text;

                var da = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully granted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed granted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditSys_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connString;
                con.Open();

                var cmd = new OracleCommand("PRO_EDIT_PRIVS_SYS", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("NAME_EDIT", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtNameEdit.Text;
                cmd.Parameters.Add("PRIVS_CHANGE", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtNewPrivisSys.Text;
                cmd.Parameters.Add("FLAG", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtFlag_editsys.Text;
                cmd.Parameters.Add("PRIVS_OLD", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtOldPrivisSys.Text;
                var da = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully edited privileges system", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed edited privileges system", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditObj_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connString;
                con.Open();

                var cmd = new OracleCommand("PRO_EDIT_PRIVS_OBJ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("NAME_EDIT", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtNameEdit_obj.Text;
                cmd.Parameters.Add("PRIVS_CHANGE", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtNewPrivisObj.Text;
                cmd.Parameters.Add("OBJ", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtObject_editobj.Text;
                cmd.Parameters.Add("FLAG", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtFlag_editobj.Text;
                cmd.Parameters.Add("OLD_PRIVS", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtOldPrivisObj.Text;
                var da = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully edited privileges object", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed edited privileges object", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRevokeUserSys_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connString;
                con.Open();
                var cmd = new OracleCommand("PROC_REVOKE_PRIVS_FROM_USER", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("USERNAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtUser_revokeuser.Text;
                cmd.Parameters.Add("PRIVS", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtSysPrivis_revokeuser.Text;

                var da = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully revoked", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed revoked", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRevokeUserObj_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connString;
                con.Open();
                var cmd = new OracleCommand("PROC_REVOKE_PRIVS_TABLE_FROM_USER", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("USERNAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtUser_revokeuser.Text;
                cmd.Parameters.Add("PRIVS", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtObjPrivis_revokeuser.Text;
                cmd.Parameters.Add("TABLENAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtTable_revokeuser.Text;

                var da = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully revoked", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed revoked", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRevokeRoleObj_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connString;
                con.Open();
                var cmd = new OracleCommand("PROC_REVOKE_PRIVS_OBJECT_ROLE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("ROLENAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtRole_revokerole.Text;
                cmd.Parameters.Add("RPRIVS", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtObjPrivis_revokerole.Text;
                cmd.Parameters.Add("ROBJECT", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtObject_revokerole.Text;

                var da = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully revoked", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed revoked", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRevokeRoleSys_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connString;
                con.Open();
                var cmd = new OracleCommand("PROC_REVOKE_PRIVS_ROLE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("ROLENAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtRole_revokerole.Text;
                cmd.Parameters.Add("RPRIVS", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtSysPrivis_revokerole.Text;

                var da = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully revoked", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed revoked", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBenhNhan_AuditStandard_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connString;
            con.Open();

            OracleCommand cmd = new OracleCommand("SELECT USERNAME, EXTENDED_TIMESTAMP, OWNER, OBJ_NAME, ACTION_NAME FROM DBA_AUDIT_TRAIL WHERE OWNER = 'AD1' ORDER BY TIMESTAMP", con);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAdmin5.DataSource = dt;

            con.Close();
        }

        private void btnFGA_Audit_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connString;
            con.Open();

            OracleCommand cmd = new OracleCommand("SELECT * FROM DBA_FGA_AUDIT_TRAIL", con);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAdmin5.DataSource = dt;

            con.Close();
        }

        private void btnSeeTables_Click(object sender, EventArgs e)
        {
            //OracleConnection con = new OracleConnection();
            //con.ConnectionString = connString;
            //con.Open();

            //OracleCommand cmd = new OracleCommand("SELECT * FROM AD1.TABLENAME", con);
            //OracleDataAdapter da = new OracleDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dgvAdmin1.DataSource = dt;

            //con.Close();
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connString;
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "WATCH_TABLES";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("TNAME", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAdmin1.DataSource = dt;
            con.Close();
        }

        private void btnSeeViews_Click(object sender, EventArgs e)
        {
            //OracleConnection con = new OracleConnection();
            //con.ConnectionString = connString;
            //con.Open();

            //OracleCommand cmd = new OracleCommand("SELECT * FROM AD1.VIEWNAME", con);
            //OracleDataAdapter da = new OracleDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dgvAdmin1.DataSource = dt;

            //con.Close();
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connString;
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "WATCH_VIEWS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("VNAME", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAdmin1.DataSource = dt;
            con.Close();
        }

        //private void btnViewSysOfRole_Click(object sender, EventArgs e)
        //{
        //    OracleConnection con = new OracleConnection();
        //    con.ConnectionString = connString;
        //    con.Open();

        //    OracleCommand cmd = new OracleCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = "WATCH_ROLE_SYS_PRIVS";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add("NAME_OF_ROLE", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtRole_ViewPriv.Text;
        //    cmd.Parameters.Add("DISPLAY", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
        //    OracleDataAdapter da = new OracleDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    dgvAdmin3.DataSource = dt;
        //    con.Close();
        //}

        //private void btnViewObjOfRole_Click(object sender, EventArgs e)
        //{
        //    OracleConnection con = new OracleConnection();
        //    con.ConnectionString = connString;
        //    con.Open();

        //    OracleCommand cmd = new OracleCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = "WATCH_ROLE_OBJECT_PRIVS";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add("NAME_OF_ROLE", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtRole_ViewPriv.Text;
        //    cmd.Parameters.Add("DISPLAY", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
        //    OracleDataAdapter da = new OracleDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    dgvAdmin3.DataSource = dt;
        //    con.Close();
        //}

        //private void btnRole_ViewSys_Click(object sender, EventArgs e)
        //{
        //    OracleConnection con = new OracleConnection();
        //    con.ConnectionString = connString;
        //    con.Open();

        //    OracleCommand cmd = new OracleCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = "WATCH_ROLE_SYS_PRIVS";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add("NAME_OF_ROLE", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtRole_ViewPrivs.Text;
        //    cmd.Parameters.Add("DISPLAY", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
        //    OracleDataAdapter da = new OracleDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    dgvAdmin4.DataSource = dt;
        //    con.Close();
        //}

        //private void btnRole_ViewObj_Click(object sender, EventArgs e)
        //{
        //    OracleConnection con = new OracleConnection();
        //    con.ConnectionString = connString;
        //    con.Open();

        //    OracleCommand cmd = new OracleCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = "WATCH_ROLE_OBJECT_PRIVS";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add("NAME_OF_ROLE", OracleDbType.Varchar2, ParameterDirection.Input).Value = txtRole_ViewPrivs.Text;
        //    cmd.Parameters.Add("DISPLAY", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
        //    OracleDataAdapter da = new OracleDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    dgvAdmin4.DataSource = dt;
        //    con.Close();
        //}

        private void SystemForm_Load(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connString;
            con.Open();

            OracleCommand cmd1 = new OracleCommand("SELECT * FROM ALL_USERS", con);
            OracleDataAdapter da1 = new OracleDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            OracleCommand cmd2 = new OracleCommand("SELECT * FROM DBA_ROLES", con);
            OracleDataAdapter da2 = new OracleDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            if (dt1.Rows.Count>0)
            {
                cbbUsername.DataSource = dt1;
                cbbUsername.DisplayMember = "USERNAME";
                cbbUsername.ValueMember = "USER_ID";
            }

            if (dt2.Rows.Count > 0)
            {
                cbbRole.DataSource = dt2;
                cbbRole.DisplayMember = "ROLE";
                cbbRole.ValueMember = "ROLE_ID";
            }

            con.Close();
        }

        private void btnViewSys_Click_1(object sender, EventArgs e)
        {
            string username = cbbUsername.Text.ToString();
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connString;
            con.Open();

            
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "WATCH_USER_SYS_PRIVS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("NAME_OF_USER", OracleDbType.Varchar2, ParameterDirection.Input).Value = username;
            cmd.Parameters.Add("DISPLAY", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAdmin4.DataSource = dt;
            con.Close();
        }

        private void btnViewObj_Click_1(object sender, EventArgs e)
        {
            string username = cbbUsername.Text.ToString();
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connString;
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "WATCH_USER_OBJECT_PRIVS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("NAME_OF_USER", OracleDbType.Varchar2, ParameterDirection.Input).Value = username;
            cmd.Parameters.Add("DISPLAY", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAdmin4.DataSource = dt;
            con.Close();
        }

        private void btnRole_ViewSys_Click_1(object sender, EventArgs e)
        {
            string role = cbbRole.Text.ToString();
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connString;
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "WATCH_ROLE_SYS_PRIVS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("NAME_OF_ROLE", OracleDbType.Varchar2, ParameterDirection.Input).Value = role;
            cmd.Parameters.Add("DISPLAY", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAdmin4.DataSource = dt;
            con.Close();
        }

        private void btnRole_ViewObj_Click_1(object sender, EventArgs e)
        {
            string role = cbbRole.Text.ToString();
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connString;
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "WATCH_ROLE_OBJECT_PRIVS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("NAME_OF_ROLE", OracleDbType.Varchar2, ParameterDirection.Input).Value = role;
            cmd.Parameters.Add("DISPLAY", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAdmin4.DataSource = dt;
            con.Close();
        }
    }
}
