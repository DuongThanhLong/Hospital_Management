using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private bool isFormValid()
        {
            if (txtUsername.Text.ToString().Trim() == string.Empty || txtPassword.Text.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Required fields must not empty!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isFormValid())
            {
                if (txtUsername.Text == "AD1")
                {
                    if (txtPassword.Text == "123")
                    {
                        Global.loginname = txtUsername.Text;
                        Global.password = txtPassword.Text;
                        SystemForm sysForm = new SystemForm();
                        sysForm.ShowDialog();
                    }
                    else
                        MessageBox.Show("Username or Password is incorrect", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtUsername.Text == "CONAN" || txtUsername.Text == "KRIS")
                {
                    if (txtPassword.Text == "123")
                    {
                        Global.loginname = txtUsername.Text;
                        Global.password = txtPassword.Text;
                        DoctorForm doctor = new DoctorForm();
                        doctor.ShowDialog();
                    }
                    else
                        MessageBox.Show("Username or Password is incorrect", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtUsername.Text == "THANH" || txtUsername.Text == "TLONG")
                {
                    if (txtPassword.Text == "123")
                    {
                        Global.loginname = txtUsername.Text;
                        Global.password = txtPassword.Text;
                        ReceptionForm recept = new ReceptionForm();
                        recept.ShowDialog();
                    }
                }
                else if (txtUsername.Text == "NHAN" || txtUsername.Text == "HAIBARA")
                {
                    if (txtPassword.Text == "123")
                    {
                        Global.loginname = txtUsername.Text;
                        Global.password = txtPassword.Text;
                        MedicineForm med = new MedicineForm();
                        med.ShowDialog();
                    }
                }
                else if (txtUsername.Text == "ELIZABETH")
                {
                    if (txtPassword.Text == "TRONG1234")
                    {
                        Global.loginname = txtUsername.Text;
                        Global.password = txtPassword.Text;
                        ServiceForm ser = new ServiceForm();
                        ser.ShowDialog();
                    }
                }
                else if (txtUsername.Text == "SHERLOCK" || txtUsername.Text == "GLASS")
                {
                    if (txtPassword.Text == "123")
                    {
                        Global.loginname = txtUsername.Text;
                        Global.password = txtPassword.Text;
                        ServiceForm ser = new ServiceForm();
                        ser.ShowDialog();
                    }
                }
                else
                    MessageBox.Show("Username or Password is incorrect", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
