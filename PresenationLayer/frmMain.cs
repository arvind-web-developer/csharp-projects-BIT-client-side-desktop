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


namespace BIT
{
    public partial class frmMain : Form 
    {
        public static string ProfileType { get; set; }

        //public static string TransactionType { get; set; }

        private Boolean FORCED_SHUTDOWN = false;

        public frmMain()
        {
            InitializeComponent();
            Load += new EventHandler(frmMain_Load);

        }

        private void frmMain_Load(object sender, System.EventArgs e)
        {
            frmMain _frmMain = new frmMain();
            Account.frmLogin frm = new Account.frmLogin(_frmMain);
            frm.ShowDialog();

            lblProfileType.Text = "You are logged in as: " + ProfileType + "!";

            String s = ProfileType;
            String userType; 

            if (String.IsNullOrEmpty(s))
            {
                userType = "";
            }
            else
            {
                userType = string.Concat(s.TakeWhile((c) => c != ' '));
            }
                //MessageBox.Show("Role: " + userType);

                routeRequest(userType);
            
        }

        private void routeRequest(string userType)
        {
            if (userType == "Admin")
            {
                
            }
            else if (userType == "Coordinator")
            {
                // coordinator* menu item and shortcut key are disabled
                coordinatorToolStripMenuItem.Enabled = false;
                coordinatorToolStripMenuItem1.Enabled = false;

                // coordinator* menu item are removed from the view without disabling the shortcut key
                coordinatorToolStripMenuItem.Visible = false;
                coordinatorToolStripMenuItem1.Visible = false;
            }
            else if (userType == "Contractor")
            {
                // coordinator* menu item and shortcut key are disabled
                coordinatorToolStripMenuItem.Enabled = false;
                coordinatorToolStripMenuItem1.Enabled = false;

                // coordinator* menu item are removed from the view without disabling the shortcut key
                coordinatorToolStripMenuItem.Visible = false;
                coordinatorToolStripMenuItem1.Visible = false;

                // contractor* menu item and shortcut key are disabled
                contractorToolStripMenuItem.Enabled = false;
                contractorToolStripMenuItem1.Enabled = false;

                // contractor* menu item are removed from the view without disabling the shortcut key
                contractorToolStripMenuItem.Visible = false;
                contractorToolStripMenuItem1.Visible = false;

                // new client* menu item are disabled
                clientToolStripMenuItem.Enabled = false;
                
                // new client* menu item are removed from the view 
                clientToolStripMenuItem.Visible = false;

                // new request* menu item are disabled
                requestToolStripMenuItem.Enabled = false;

                // new location* menu item are removed from the view 
                requestToolStripMenuItem.Visible = false;

                // new availability* menu item are removed from the view 
                availabilityToolStripMenuItem.Visible = false;
            }
            else if (userType == "Client")
            {
                // coordinator* menu item and shortcut key are disabled
                coordinatorToolStripMenuItem.Enabled = false;
                coordinatorToolStripMenuItem1.Enabled = false;

                // coordinator* menu item are removed from the view without disabling the shortcut key
                coordinatorToolStripMenuItem.Visible = false;
                coordinatorToolStripMenuItem1.Visible = false;

                // contractor* menu item and shortcut key are disabled
                contractorToolStripMenuItem.Enabled = false;
                contractorToolStripMenuItem1.Enabled = false;

                // contractor* menu item are removed from the view without disabling the shortcut key
                contractorToolStripMenuItem.Visible = false;
                contractorToolStripMenuItem1.Visible = false;

                // client* menu item and shortcut key are disabled
                clientToolStripMenuItem.Enabled = false;
                clientToolStripMenuItem1.Enabled = false;

                // client* menu item are removed from the view without disabling the shortcut key
                clientToolStripMenuItem.Visible = false;
                clientToolStripMenuItem1.Visible = false;

                // new request* menu item are disabled
                requestToolStripMenuItem.Enabled = false;

                // new location* menu item are removed from the view 
                requestToolStripMenuItem.Visible = false;

                // new availability* menu item are removed from the view 
                availabilityToolStripMenuItem.Visible = false;

                // new job* menu item are removed from the view 
                jobToolStripMenuItem1.Visible = false;
                
            }
            else
            {
                FORCED_SHUTDOWN = true;
                this.Close();
            }

        }

        private void clientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmList frm = new frmList();
            frm.ShowDialog();
        }

        private void contractorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmList frm = new frmList();   
            frm.ShowDialog();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNew frm = new frmNew();
            //frm.NewObject = true;
            BIT.frmNew.TransactionType = "Save";
            frm.ShowDialog();
        }

        private void contractorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNew frm = new frmNew();
            frm.ShowDialog();
        }

        private void coordinatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNew frm = new frmNew();
            frm.ShowDialog();
        }

        private void requestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNew frm = new frmNew();
            frm.ShowDialog();
        }

        private void availabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNew frm = new frmNew();
            frm.ShowDialog();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNew frm = new frmNew();
            frm.ShowDialog();
        }

        private void coordinatorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmList frm = new frmList();
            frm.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp frm = new frmHelp();
            frm.ShowDialog();
        }

        private void jobToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmList frm = new frmList();
            frm.ShowDialog();
        }

        private void requestToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmList frm = new frmList();
            frm.ShowDialog();
        }

        private void manageuserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Account.frmManage frm = new Account.frmManage();
            frm.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Hide();

            frmMain frm = new frmMain();
            frm.ShowDialog();

            this.Close();
            frmMain_Load(sender, e);
            
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // this.Close();

            try
            {
                foreach (Form frm in Application.OpenForms)
                {

                    frm.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (!FORCED_SHUTDOWN)
                {
                    DialogResult yesNo = MessageBox.Show(this, "Are you sure you want to Exit BIT Application?", "BIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (yesNo == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    Application.Exit();
                }
            }
        }

    }
}
