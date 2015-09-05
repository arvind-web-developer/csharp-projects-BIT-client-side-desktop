using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace BIT.Account
{
    public partial class frmLogin : Form
    {
        public readonly frmMain _frmMain;


        public frmLogin(frmMain frm)
        {
            _frmMain = frm;
            InitializeComponent();
        }


        public frmLogin()
        {
            InitializeComponent();
            this.ActiveControl = txtUserName; 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            // we need to call the user class to check if the user is valid or not.
            User obj = new User();
            obj.UserName = txtUserName.Text;
            obj.Password = txtPassword.Text;
            if(obj.IsValid(obj))
            {
                // valid user
               this.Close();
               BIT.frmMain.ProfileType = obj.ProfileType + " / " + obj.UserName;

            }
            else
            {
                switch (obj.UserID)
                {
                    case -1:
                        MessageBox.Show("Username is incorrect.");
                        break;
                    case -2:
                        MessageBox.Show("Password is incorrect.");
                        break;
                    case -3:
                        MessageBox.Show("Account has not been activated.");
                        break;
                    case -4:
                        MessageBox.Show("User is Locked.");
                        break;

                    default:
                        MessageBox.Show("Invalid credentials");
                        break;
                }
                // invalid user
                //MessageBox.Show("Invalid credentials");
                txtPassword.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
