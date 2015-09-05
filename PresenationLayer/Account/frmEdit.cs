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
using System.Globalization;
using BIT.Account;

namespace BIT
{
    public partial class frmEdit : Form
    {
        private static string UserRole { get; set; }
        private static string UserLogin { get; set; }

        public static string TabPageSelected { get; set; }
        public static string TransactionType { get; set; }


        private Client client;
        private Contractor contractor;
        private Coordinator coordinator;
        private User user;
        private Skill skill;


        public frmEdit()
        {
            InitializeComponent();
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            btnTabHide.PerformClick();

            TransactionType = "Update";
            txtTransactionType.Text = TransactionType;

            // fetch the Role* from profileType
            String s = BIT.frmMain.ProfileType;
            String userRole = string.Concat(s.TakeWhile((c) => c != ' '));

            // fetch the Login* from profileType
            string userLogin = s.Split('/').Last().Trim();

            //Set Role and Login
            UserRole = userRole;
            UserLogin = userLogin;
        }

        private void btnTabHide_Click(object sender, EventArgs e)
        {
            string title = TabPageSelected;
            TabPage myTabPage = new TabPage(title);
            TabControlHelper.HideAllPages(tabControlEdit, title);
        }

        private void btnEditClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxCorrect_Click(object sender, EventArgs e)
        {
            lblNewMessage.Text = "";
            pictureBoxCorrect.Visible = false;
        }

        private void btnEditNext_Click(object sender, EventArgs e)
        {

        }

        public static void msgOutput(frmEdit frm, string msg)
        {
            frm.lblNewMessage.Text = msg;
        }


        public void populateUIClientdata(Client client)
        {
            txtEditClientClientID.Text = Convert.ToString(client.ClientID);
            txtEditClientTitle.Text = client.ClientTitle;
            txtEditClientFirstName.Text = client.ClientFirstName;
            txtEditClientLastName.Text = client.ClientLastName;
            txtEditClientEmailP.Text = client.ClientEmailPrimary;
            txtEditClientEmailA.Text = client.ClientEmailAlternate;
            txtEditClientFax.Text = client.ClientFax;
            txtEditClientPhoneP.Text = client.ClientPhonePrimary;
            txtEditClientPhoneH.Text = client.ClientPhoneHome;
            txtEditClientPhoneM.Text = client.ClientPhoneMobile;
            txtEditClientPhoneW.Text = client.ClientPhoneWork;
            txtEditClientPhoneE.Text = client.ClientPhoneEmergency;
            txtEditClientCompany.Text = client.ClientCompanyName;
            txtEditClientPosition.Text = client.ClientPosition;
            txtEditClientDescription.Text = client.ClientDescription;
        }

        public void populateUIContractordata(Contractor contractor)
        {
            txtEditContractorContractorID.Text = Convert.ToString(contractor.ContractorID);
            txtEditContractorTitle.Text = contractor.ContractorTitle;
            txtEditContractorFirstName.Text = contractor.ContractorFirstName;
            txtEditContractorLastName.Text = contractor.ContractorLastName;
            txtEditContractorEmailP.Text = contractor.ContractorEmailPrimary;
            txtEditContractorEmailA.Text = contractor.ContractorEmailAlternate;
            txtEditContractorFax.Text = contractor.ContractorFax;
            txtEditContractorPhoneP.Text = contractor.ContractorPhonePrimary;
            txtEditContractorPhoneH.Text = contractor.ContractorPhoneHome;
            txtEditContractorPhoneM.Text = contractor.ContractorPhoneMobile;
            txtEditContractorPhoneW.Text = contractor.ContractorPhoneWork;
            txtEditContractorPhoneE.Text = contractor.ContractorPhoneEmergency;
            txtEditContractorCompany.Text = contractor.ContractorCompanyName;
            txtEditContractorPosition.Text = contractor.ContractorPosition;
            txtEditContractorDescription.Text = contractor.ContractorDescription;
        }

        public void populateUICoordinatordata(Coordinator coordinator)
        {
            txtEditCoordinatorCoordinatorID.Text = Convert.ToString(coordinator.CoordinatorID);
            txtEditCoordinatorTitle.Text = coordinator.CoordinatorTitle;
            txtEditCoordinatorFirstName.Text = coordinator.CoordinatorFirstName;
            txtEditCoordinatorLastName.Text = coordinator.CoordinatorLastName;
            txtEditCoordinatorEmailP.Text = coordinator.CoordinatorEmailPrimary;
            txtEditCoordinatorEmailA.Text = coordinator.CoordinatorEmailAlternate;
            txtEditCoordinatorFax.Text = coordinator.CoordinatorFax;
            txtEditCoordinatorPhoneP.Text = coordinator.CoordinatorPhonePrimary;
            txtEditCoordinatorPhoneH.Text = coordinator.CoordinatorPhoneHome;
            txtEditCoordinatorPhoneM.Text = coordinator.CoordinatorPhoneMobile;
            txtEditCoordinatorPhoneW.Text = coordinator.CoordinatorPhoneWork;
            txtEditCoordinatorPhoneE.Text = coordinator.CoordinatorPhoneEmergency;
            txtEditCoordinatorCompany.Text = coordinator.CoordinatorCompanyName;
            txtEditCoordinatorPosition.Text = coordinator.CoordinatorPosition;
            txtEditCoordinatorDescription.Text = coordinator.CoordinatorDescription;
        }


        private Client populateClientUIdata(Client client)
        {
            client.ClientID = Convert.ToInt32(txtEditClientClientID.Text);
            client.ClientTitle = txtEditClientTitle.Text;
            client.ClientFirstName = txtEditClientFirstName.Text;
            client.ClientLastName = txtEditClientLastName.Text;
            client.ClientEmailPrimary = txtEditClientEmailP.Text;
            client.ClientEmailAlternate = txtEditClientEmailA.Text;
            client.ClientFax = txtEditClientFax.Text;
            client.ClientPhonePrimary = txtEditClientPhoneP.Text;
            client.ClientPhoneHome = txtEditClientPhoneH.Text;
            client.ClientPhoneMobile = txtEditClientPhoneM.Text;
            client.ClientPhoneWork = txtEditClientPhoneW.Text;
            client.ClientPhoneEmergency = txtEditClientPhoneE.Text;
            client.ClientCompanyName = txtEditClientCompany.Text;
            client.ClientPosition = txtEditClientPosition.Text;
            client.ClientDescription = txtEditClientDescription.Text;

            return client;
        }

        private Contractor populateContractorUIdata(Contractor contractor)
        {
            contractor.ContractorID = Convert.ToInt32(txtEditContractorContractorID.Text);
            contractor.ContractorTitle = txtEditContractorTitle.Text;
            contractor.ContractorFirstName = txtEditContractorFirstName.Text;
            contractor.ContractorLastName = txtEditContractorLastName.Text;
            contractor.ContractorEmailPrimary = txtEditContractorEmailP.Text;
            contractor.ContractorEmailAlternate = txtEditContractorEmailA.Text;
            contractor.ContractorFax = txtEditContractorFax.Text;
            contractor.ContractorPhonePrimary = txtEditContractorPhoneP.Text;
            contractor.ContractorPhoneHome = txtEditContractorPhoneH.Text;
            contractor.ContractorPhoneMobile = txtEditContractorPhoneM.Text;
            contractor.ContractorPhoneWork = txtEditContractorPhoneW.Text;
            contractor.ContractorPhoneEmergency = txtEditContractorPhoneE.Text;
            contractor.ContractorCompanyName = txtEditContractorCompany.Text;
            contractor.ContractorPosition = txtEditContractorPosition.Text;
            contractor.ContractorDescription = txtEditContractorDescription.Text;

            return contractor;
        }

        private Coordinator populateCoordinatorUIdata(Coordinator coordinator)
        {
            coordinator.CoordinatorID = Convert.ToInt32(txtEditCoordinatorCoordinatorID.Text);
            coordinator.CoordinatorTitle = txtEditCoordinatorTitle.Text;
            coordinator.CoordinatorFirstName = txtEditCoordinatorFirstName.Text;
            coordinator.CoordinatorLastName = txtEditCoordinatorLastName.Text;
            coordinator.CoordinatorEmailPrimary = txtEditCoordinatorEmailP.Text;
            coordinator.CoordinatorEmailAlternate = txtEditCoordinatorEmailA.Text;
            coordinator.CoordinatorFax = txtEditCoordinatorFax.Text;
            coordinator.CoordinatorPhonePrimary = txtEditCoordinatorPhoneP.Text;
            coordinator.CoordinatorPhoneHome = txtEditCoordinatorPhoneH.Text;
            coordinator.CoordinatorPhoneMobile = txtEditCoordinatorPhoneM.Text;
            coordinator.CoordinatorPhoneWork = txtEditCoordinatorPhoneW.Text;
            coordinator.CoordinatorPhoneEmergency = txtEditCoordinatorPhoneE.Text;
            coordinator.CoordinatorCompanyName = txtEditCoordinatorCompany.Text;
            coordinator.CoordinatorPosition = txtEditCoordinatorPosition.Text;
            coordinator.CoordinatorDescription = txtEditCoordinatorDescription.Text;

            return coordinator;
        }


        private DataTable updateClientData(Client client)
        {
            DataTable dt = new DataTable();
            dt = Client.UpdateClient(UserRole, UserLogin, client);
            return dt;
        }

        private DataTable updateContractorData(Contractor contractor)
        {
            DataTable dt = new DataTable();
            dt = Contractor.UpdateContractor(UserRole, UserLogin, contractor);
            return dt;
        }

        private DataTable updateCoordinatorData(Coordinator coordinator)
        {
            DataTable dt = new DataTable();
            dt = Coordinator.UpdateCoordinator(UserRole, UserLogin, coordinator);
            return dt;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                string msg = "MESSAGE: ";


                switch (TabPageSelected)
                {
                    case "tabPageEditClient":                    // Client* selected
                        client = new Client();
                        dt = updateClientData(populateClientUIdata(client));
                        msg = msg + "Client Updated! ";
                        client.ClientID = Convert.ToInt32(dt.Rows[0][0]);
                        break;
                    case "tabPageEditContractor":                // Contractor* selected
                        contractor = new Contractor();
                        dt = updateContractorData(populateContractorUIdata(contractor));
                        msg = msg + "Contractor Updated! ";
                        contractor.ContractorID = Convert.ToInt32(dt.Rows[0][0]);
                        break;
                    case "tabPageEditCoordinator":               // Coordinator* selected
                        coordinator = new Coordinator();
                        dt = updateCoordinatorData(populateCoordinatorUIdata(coordinator));
                        msg = msg + "Coordinator Updated! ";
                        coordinator.CoordinatorID = Convert.ToInt32(dt.Rows[0][0]);
                        break;
                    case "tabPageEditRequest":                   // Request* selected


                        break;
                    case "tabPageEditJob":                       // Job* selected


                        break;
                    case "tabPageEditContractorSkill":          // ContractorSkill* selected


                        break;
                    case "tabPageEditSkill":                     // Skill* selected


                        break;
                    case "tabPageEditLocation":                  // Location* selected


                        break;
                    // ... unauthorized user...
                    default:
                        break;
                }

                if (dt.Rows.Count > 0)
                    msg = msg + "with ID: " + Convert.ToString(dt.Rows[0][0]);

                lblNewMessage.Text = msg;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType() + ex.Message);
            }
        }

    }
}
