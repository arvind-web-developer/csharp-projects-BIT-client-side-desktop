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
using System.Text.RegularExpressions;


namespace BIT
{
    public partial class frmNew : Form
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
        private ContractorSkill contractorskill;
        private int cmbNewSkillIsActiveResultIndex = -1;


        private void btnNewClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewSave_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string msg = "MESSAGE: ";

            switch (TabPageSelected)
            {
                case "tabPageNewClient":                    // Client* selected
                    client = new Client();
                    dt = insertClientData(populateClientUIdata(client));
                    msg = msg + "Client Created! ";
                    client.ClientID = Convert.ToInt32(dt.Rows[0][0]);
                    break;
                case "tabPageNewContractor":                // Contractor* selected
                    contractor = new Contractor();
                    dt = insertContractorData(populateContractorUIdata(contractor));
                    msg = msg + "Contractor Created! ";
                    contractor.ContractorID = Convert.ToInt32(dt.Rows[0][0]);
                    break;
                case "tabPageNewCoordinator":               // Coordinator* selected
                    coordinator = new Coordinator();
                    dt = insertCoordinatorData(populateCoordinatorUIdata(coordinator));
                    msg = msg + "Coordinator Created! ";
                    coordinator.CoordinatorID = Convert.ToInt32(dt.Rows[0][0]);
                    break;
                case "tabPageNewRequest":                   // Request* selected


                    break;
                case "tabPageNewJob":                       // Job* selected


                    break;
                case "tabPageNewContractorSkill":          // ContractorSkill* selected


                    break;
                case "tabPageNewSkill":                     // Skill* selected


                    break;
                case "tabPageNewLocation":                  // Location* selected


                    break;
                case "tabPageNewAvailability":              // Availability* selected


                    break;
                // ... unauthorized user...
                default:
                    break;
            }

            if (dt.Rows.Count > 0)
                msg = msg + "with ID: " + Convert.ToString(dt.Rows[0][0]);

            lblNewMessage.Text = msg;


            btnNewSave.Visible = false;
            btnNewApprove.Visible = true;
        }

        private void btnNewApprove_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string msg = "MESSAGE: ";


            switch (TabPageSelected)
            {
                case "tabPageNewClient":                    // Client* selected
                    dt = approveClientdata(client);
                    msg = msg + "Client Approved! ";
                    break;
                case "tabPageNewContractor":                // Contractor* selected
                    dt = approveContractordata(contractor);
                    msg = msg + "Contractor Approved! ";
                    break;
                case "tabPageNewCoordinator":               // Coordinator* selected
                    dt = approveCoordinatordata(coordinator);
                    msg = msg + "Coordinator Approved! ";
                    break;
                case "tabPageNewRequest":                   // Request* selected


                    break;
                case "tabPageNewJob":                       // Job* selected


                    break;
                case "tabPageNewContractorSkill":          // ContractorSkill* selected


                    break;
                case "tabPageNewSkill":                     // Skill* selected


                    break;
                case "tabPageNewLocation":                  // Location* selected


                    break;
                // ... unauthorized user...
                default:
                    break;
            }

            if (dt.Rows.Count > 0)
                msg = msg + "with ID: " + Convert.ToString(dt.Rows[0][0]);

            lblNewMessage.Text = msg;


            btnNewApprove.Visible = false;
            btnNewCreateUser.Visible = true;
        }

        private void btnNewCreateUser_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string msg = "MESSAGE: ";

            switch (TabPageSelected)
            {
                case "tabPageNewClient":                    // Client* selected
                    user = new User();
                    dt = createUserdata(populateClientUserUIdata(user), "Client");
                    msg = msg + "Client User Approved & Login Created! ";
                    //client.ClientID = Convert.ToInt32(dt.Rows[0][0]);
                    break;
                case "tabPageNewContractor":                // Contractor* selected
                    user = new User();
                    dt = createUserdata(populateContractorUserUIdata(user), "Contractor");
                    msg = msg + "Contractor User Approved & Login Created! ";
                    //contractor.ContractorID = Convert.ToInt32(dt.Rows[0][0]);
                    break;
                case "tabPageNewCoordinator":               // Coordinator* selected
                    user = new User();
                    dt = createUserdata(populateCoordinatorUserUIdata(user), "Coordinator");
                    msg = msg + "Coordinator User Approved & Login Created! ";
                    //coordinator.CoordinatorID = Convert.ToInt32(dt.Rows[0][0]);
                    break;
                case "tabPageNewRequest":                   // Request* selected


                    break;
                case "tabPageNewJob":                       // Job* selected


                    break;
                case "tabPageNewContractorSkill":          // ContractorSkill* selected


                    break;
                case "tabPageNewSkill":                     // Skill* selected


                    break;
                case "tabPageNewLocation":                  // Location* selected


                    break;
                // ... unauthorized user...
                default:
                    break;
            }

            if (dt.Rows.Count > 0)
                msg = msg + "processed..."; //+ Convert.ToString(dt.Rows[0][0]);

            lblNewMessage.Text = msg;


            pictureBoxCorrect.Visible = true;
            btnNewCreateUser.Visible = false;
            btnNewSave.Visible = true;

        }

        private void btnNewNext_Click(object sender, EventArgs e)
        {
            BIT.Account.frmNewJob frm = new BIT.Account.frmNewJob();
            frm.ShowDialog();
        }

        private void btnAddNewSkill_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string msg = "MESSAGE: ";

            switch (TabPageSelected)
            {
                case "tabPageNewClient":                    // Client* selected

                    break;
                case "tabPageNewContractor":                // Contractor* selected

                    break;
                case "tabPageNewCoordinator":               // Coordinator* selected

                    break;
                case "tabPageNewRequest":                   // Request* selected


                    break;
                case "tabPageNewJob":                       // Job* selected


                    break;
                case "tabPageNewContractorSkill":          // ContractorSkill* selected


                    break;
                case "tabPageNewSkill":                     // Skill* selected
                    skill = new Skill();
                    dt = createSkilldata(populateSkillUIdata(skill), "Skill");
                    //txtNewSkillSkillType.ReadOnly = true;
                    //cmbNewSkillIsActive.Enabled = false;

                    txtNewSkillSkillType.Text = "";
                    cmbNewSkillIsActive.Text = "";
                    msg = msg + "A New Skill is ";
                    break;
                case "tabPageNewLocation":                  // Location* selected


                    break;
                // ... unauthorized user...
                default:
                    break;
            }

            if (dt.Rows.Count > 0)
                msg = msg + "processed...with ID: " + Convert.ToString(dt.Rows[0][0]);

            lblNewMessage.Text = msg;


            pictureBoxCorrect.Visible = true;
            btnNewCreateUser.Visible = false;
            btnNewSave.Visible = false;
        }

        private void btnAddNewContractorSkill_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            string msg = "MESSAGE: ";

            switch (TabPageSelected)
            {
                case "tabPageNewClient":                    // Client* selected

                    break;
                case "tabPageNewContractor":                // Contractor* selected

                    break;
                case "tabPageNewCoordinator":               // Coordinator* selected

                    break;
                case "tabPageNewRequest":                   // Request* selected


                    break;
                case "tabPageNewJob":                       // Job* selected


                    break;
                case "tabPageNewContractorSkill":          // ContractorSkill* selected
                    contractorskill = new ContractorSkill();
                    dt = createContractorSkilldata(populateContractorSkillUIdata(contractorskill), "ContractorSkill");
                    loadContractorSkillData(UserRole, UserLogin, contractorskill.ContractorID);
                    cmbContractorSkillContractor.Text = "";
                    cmbContractorSkillSkill.Text = "";
                    msg = msg + "Contractor Skill ";

                    break;
                case "tabPageNewSkill":                     // Skill* selected

                    break;
                case "tabPageNewLocation":                  // Location* selected


                    break;
                // ... unauthorized user...
                default:
                    break;
            }

            if (dt.Rows.Count > 0)
            {
                if (Convert.ToInt32(dt.Rows[0][0]) == -4)
                {
                    msg = "MESSAGE: The Contractor already has selected Skill";
                }
                else
                {
                    msg = msg + "processed...with ID: " + Convert.ToString(dt.Rows[0][0]);
                }
            }

            lblNewMessage.Text = msg;

            pictureBoxCorrect.Visible = true;
            btnNewCreateUser.Visible = false;
            btnNewSave.Visible = false;
        }



        public frmNew()
        {
            InitializeComponent();
            cmbContractorSkillContractor.SelectedIndexChanged += cmbContractorSkillContractor_SelectedIndexChanged;
            cmbNewSkillIsActive.SelectedIndexChanged += cmbNewSkillIsActive_SelectedIndexChanged;
        }


        private void frmInitialize()
        {

            //ContractorSkill tab
            DataTable dtContractor1 = new DataTable();
            DataTable dtContractor = new DataTable();
            
            dtContractor1 = Contractor.ListContractor(UserRole, UserLogin);

            dtContractor = dtContractor1;

            cmbContractorSkillContractor.BackColor = System.Drawing.Color.Green;
            cmbContractorSkillContractor.ForeColor = System.Drawing.Color.Yellow;
           
            for (int i = 0; i < dtContractor.Rows.Count; i++)
            {
                //cmbContractorSkillContractor.Items.Add(dtContractor.Rows[i][1] + " " + dtContractor.Rows[i][2] + " " + dtContractor.Rows[i][14]);
                cmbContractorSkillContractor.Items.Add(dtContractor.Rows[i][1] + " " + dtContractor.Rows[i][2]);
            }


            cmbContractorSkillContractor1.ValueMember = "person_id";
            cmbContractorSkillContractor1.DisplayMember = "lastname";
            
            cmbContractorSkillContractor1.DataSource = dtContractor1;


            DataTable dtSkill = new DataTable();
            dtSkill = Skill.ListSkill(UserRole, UserLogin);

            cmbContractorSkillSkill.BackColor = System.Drawing.Color.Green;
            cmbContractorSkillSkill.ForeColor = System.Drawing.Color.Yellow;

            cmbContractorSkillSkill.DisplayMember = "skill_type";
            cmbContractorSkillSkill.ValueMember = "skill_id";

            //datatable that contains data and column, string FieldName// name of the column based on distinct records will be calculated.
            cmbContractorSkillSkill.DataSource = BIT.frmList.SelectDistinct(dtSkill, "skill_id");


            //Skill tab
            cmbNewSkillIsActive.Items.Add("Active");
            cmbNewSkillIsActive.Items.Add("Inactive");

            cmbNewSkillIsActive.SelectedIndex = 1;


                pictureBoxCorrect.Visible = false;
                btnNewSave.Visible = false;
                btnNewApprove.Visible = false;
                btnNewCreateUser.Visible = false;
                btnNewNext.Visible = true;               
         
            txtTransactionType.Text = BIT.frmNew.TransactionType;
        }

        private void frmNew_Load(object sender, EventArgs e)
        {
            
            
            // fetch the Role* from profileType
            String s = BIT.frmMain.ProfileType;
            String userRole = string.Concat(s.TakeWhile((c) => c != ' '));

            // fetch the Login* from profileType
            string userLogin = s.Split('/').Last().Trim();

            //MessageBox.Show("Role list: " + BIT.frmMain.ProfileType);
            //MessageBox.Show("Role: " + userRole);
            //MessageBox.Show("User: " + userLogin);


            //Set Role and Login
            UserRole = userRole;
            UserLogin = userLogin;

            frmInitialize();

            routeRequest(userRole, userLogin);
        }


        private void routeRequest(string userRole, string userLogin)
        {
            tabControlNew.TabPages.Clear();

            switch (userRole)
            {
                case "Admin":           // Admin* selected
                    
                    tabControlNew.TabPages.Add(tabPageNewClient);
                    tabControlNew.TabPages.Add(tabPageNewCoordinator);
                    tabControlNew.TabPages.Add(tabPageNewContractor);
                    tabControlNew.TabPages.Add(tabPageNewRequest);
                    //tabControlNew.TabPages.Add(tabPageNewJob);
                    tabControlNew.TabPages.Add(tabPageNewSkill);
                    tabControlNew.TabPages.Add(tabPageNewContractorSkill);
                    tabControlNew.TabPages.Add(tabPageNewAvailibility);
                    break;
                case "Coordinator":      // Coordinator* selected
                    tabControlNew.TabPages.Add(tabPageNewClient);
                    tabControlNew.TabPages.Add(tabPageNewContractor);
                    tabControlNew.TabPages.Add(tabPageNewRequest);
                    //tabControlNew.TabPages.Add(tabPageNewJob);
                    //tabControlNew.TabPages.Add(tabPageNewSkill);
                    tabControlNew.TabPages.Add(tabPageNewContractorSkill);
                    tabControlNew.TabPages.Add(tabPageNewAvailibility);
                    break;
                case "Contractor":      // Contractor* selected
                    tabControlNew.TabPages.Add(tabPageNewAvailibility);
                    //tabControlNew.TabPages.Add(tabPageNewClient);
                    //tabControlNew.TabPages.Add(tabPageNewRequest);
                    //tabControlNew.TabPages.Add(tabPageNewJob);
                    //tabControlNew.TabPages.Add(tabPageNewSkill);
                    break;
                case "Client":          // Client* selected
                    tabControlNew.TabPages.Add(tabPageNewAvailibility);
                    //tabControlNew.TabPages.Add(tabPageNewRequest);
                    //tabControlNew.TabPages.Add(tabPageNewJob);
                    //tabControlNew.TabPages.Add(tabPageNewSkill);
                    break;
                // ... unauthorized user...
                default: //tabControlList.TabPages.Add(tabPageListNONE);
                    break;
            }

            // load relevant data into the authorized tabs
            //loadData(userRole, userLogin);
        }


        private DataTable insertClientData(Client client)
        {
            DataTable dt = new DataTable();
            dt = Client.InsertClient(UserRole, UserLogin, client);
            return dt;
        }

        private DataTable insertContractorData(Contractor contractor)
        {
            DataTable dt = new DataTable();
            dt = Contractor.InsertContractor(UserRole, UserLogin, contractor);
            return dt;
        }

        private DataTable insertCoordinatorData(Coordinator coordinator)
        {
            DataTable dt = new DataTable();
            dt = Coordinator.InsertCoordinator(UserRole, UserLogin, coordinator);
            return dt;
        }





        private Client populateClientUIdata(Client client)
        {
            //if (((txtNewClientTitle.Text).Length > 10) && !IsAlpha(txtNewClientTitle.Text))
            //{
            //    errorProvider1.SetError(txtNewClientTitle, "Please Enter Title");
            //    errorProvider2.SetError(txtNewClientFirstName, "");
            //    errorProvider3.SetError(txtNewClientLastName, "");
            //    errorProvider4.SetError(txtNewClientEmailP, "");
            //    errorProvider5.SetError(txtNewClientEmailA, "");
            //    errorProvider6.SetError(txtNewClientFax, "");
            //}
            //else
            //{
            //    errorProvider1.Dispose();
            //    client.ClientTitle = txtNewClientTitle.Text;
            //}

            client.ClientTitle = txtNewClientTitle.Text;
            client.ClientFirstName = txtNewClientFirstName.Text;
            client.ClientLastName = txtNewClientLastName.Text;
            client.ClientEmailPrimary = txtNewClientEmailP.Text;
            client.ClientEmailAlternate = txtNewClientEmailA.Text;
            client.ClientFax = txtNewClientFax.Text;
            client.ClientPhonePrimary = txtNewClientPhoneP.Text;
            client.ClientPhoneHome = txtNewClientPhoneH.Text;
            client.ClientPhoneMobile = txtNewClientPhoneM.Text;
            client.ClientPhoneWork = txtNewClientPhoneW.Text;
            client.ClientPhoneEmergency = txtNewClientPhoneE.Text;
            client.ClientCompanyName = txtNewClientCompany.Text;
            client.ClientPosition = txtNewClientPosition.Text;
            client.ClientDescription = txtNewClientDescription.Text;
            
            return client;
        }

        private Contractor populateContractorUIdata(Contractor contractor)
        {
            contractor.ContractorTitle = txtNewContractorTitle.Text;
            contractor.ContractorFirstName = txtNewContractorFirstName.Text;
            contractor.ContractorLastName = txtNewContractorLastName.Text;
            contractor.ContractorEmailPrimary = txtNewContractorEmailP.Text;
            contractor.ContractorEmailAlternate = txtNewContractorEmailA.Text;
            contractor.ContractorFax = txtNewContractorFax.Text;
            contractor.ContractorPhonePrimary = txtNewContractorPhoneP.Text;
            contractor.ContractorPhoneHome = txtNewContractorPhoneH.Text;
            contractor.ContractorPhoneMobile = txtNewContractorPhoneM.Text;
            contractor.ContractorPhoneWork = txtNewContractorPhoneW.Text;
            contractor.ContractorPhoneEmergency = txtNewContractorPhoneE.Text;
            contractor.ContractorCompanyName = txtNewContractorCompany.Text;
            contractor.ContractorPosition = txtNewContractorPosition.Text;
            contractor.ContractorDescription = txtNewContractorDescription.Text;

            return contractor;
        }

        private Coordinator populateCoordinatorUIdata(Coordinator coordinator)
        {
            coordinator.CoordinatorTitle = txtNewCoordinatorTitle.Text;
            coordinator.CoordinatorFirstName = txtNewCoordinatorFirstName.Text;
            coordinator.CoordinatorLastName = txtNewCoordinatorLastName.Text;
            coordinator.CoordinatorEmailPrimary = txtNewCoordinatorEmailP.Text;
            coordinator.CoordinatorEmailAlternate = txtNewCoordinatorEmailA.Text;
            coordinator.CoordinatorFax = txtNewCoordinatorFax.Text;
            coordinator.CoordinatorPhonePrimary = txtNewCoordinatorPhoneP.Text;
            coordinator.CoordinatorPhoneHome = txtNewCoordinatorPhoneH.Text;
            coordinator.CoordinatorPhoneMobile = txtNewCoordinatorPhoneM.Text;
            coordinator.CoordinatorPhoneWork = txtNewCoordinatorPhoneW.Text;
            coordinator.CoordinatorPhoneEmergency = txtNewCoordinatorPhoneE.Text;
            coordinator.CoordinatorCompanyName = txtNewCoordinatorCompany.Text;
            coordinator.CoordinatorPosition = txtNewCoordinatorPosition.Text;
            coordinator.CoordinatorDescription = txtNewCoordinatorDescription.Text;

            return coordinator;
        }

 
        private DataTable approveClientdata(Client client)
        {
            DataTable dt = new DataTable();
            dt = Client.ApproveClient(UserRole, UserLogin, client);
            return dt;
        }

        private DataTable approveContractordata(Contractor contractor)
        {
            DataTable dt = new DataTable();
            dt = Contractor.ApproveContractor(UserRole, UserLogin, contractor);
            return dt;
        }

        private DataTable approveCoordinatordata(Coordinator coordinator)
        {
            DataTable dt = new DataTable();
            dt = Coordinator.ApproveCoordinator(UserRole, UserLogin, coordinator);
            return dt;
        }  


        private DataTable createUserdata(User user, string roleData)
        {
            DataTable dt = new DataTable();
            dt = User.InsertUser(UserRole, roleData, UserLogin, user);
            return dt;
        }


        private User populateClientUserUIdata(User user)
        {
            user.UserName = client.ClientEmailPrimary;
            user.Email = client.ClientEmailPrimary;

            return user;
        }

        private User populateContractorUserUIdata(User user)
        {
            user.UserName = contractor.ContractorEmailPrimary;
            user.Email = contractor.ContractorEmailPrimary;

            return user;
        }

        private User populateCoordinatorUserUIdata(User user)
        {
            user.UserName = coordinator.CoordinatorEmailPrimary;
            user.Email = coordinator.CoordinatorEmailPrimary;

            return user;
        }



        private void tabControlNew_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlNew.SelectedTab == tabControlNew.TabPages["tabPageNewClient"])
            {
                TabPageSelected = "tabPageNewClient";
                btnNewSave.Visible = true;
                btnNewApprove.Visible = false;
                btnNewCreateUser.Visible = false;
                btnNewNext.Visible = false;
            }
            else if (tabControlNew.SelectedTab == tabControlNew.TabPages["tabPageNewContractor"])
            {
                TabPageSelected = "tabPageNewContractor";
                btnNewSave.Visible = true;
                btnNewApprove.Visible = false;
                btnNewCreateUser.Visible = false;
                btnNewNext.Visible = false;
            }
            else if (tabControlNew.SelectedTab == tabControlNew.TabPages["tabPageNewCoordinator"])
            {
                TabPageSelected = "tabPageNewCoordinator";
                btnNewSave.Visible = true;
                btnNewApprove.Visible = false;
                btnNewCreateUser.Visible = false;
                btnNewNext.Visible = false;
            }
            else if (tabControlNew.SelectedTab == tabControlNew.TabPages["tabPageNewRequest"])
            {
                TabPageSelected = "tabPageNewRequest";
                btnNewSave.Visible = false;
                btnNewApprove.Visible = false;
                btnNewCreateUser.Visible = false;
                btnNewNext.Visible = true;
            }
            else if (tabControlNew.SelectedTab == tabControlNew.TabPages["tabPageNewJob"])
            {
                TabPageSelected = "tabPageNewJob";
                btnNewSave.Visible = false;
                btnNewApprove.Visible = false;
                btnNewCreateUser.Visible = false;
                btnNewNext.Visible = true;
            }
            else if (tabControlNew.SelectedTab == tabControlNew.TabPages["tabPageNewContractorSkill"])
            {
                TabPageSelected = "tabPageNewContractorSkill";
                btnNewSave.Visible = false;
                btnNewApprove.Visible = false;
                btnNewCreateUser.Visible = false;
                btnNewNext.Visible = false;
            }
            else if (tabControlNew.SelectedTab == tabControlNew.TabPages["tabPageNewSkill"])
            {
                TabPageSelected = "tabPageNewSkill";
                btnNewSave.Visible = false;
                btnNewApprove.Visible = false;
                btnNewCreateUser.Visible = false;
                btnNewNext.Visible = false;
            }
            else if (tabControlNew.SelectedTab == tabControlNew.TabPages["tabPageNewLocation"])
            {
                TabPageSelected = "tabPageNewLocation";
                btnNewSave.Visible = false;
                btnNewApprove.Visible = false;
                btnNewCreateUser.Visible = false;
                btnNewNext.Visible = true;
            }
            else
            {
                TabPageSelected = "";
            }
        }

        private void txtNewClientTitle_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxCorrect.Visible = false;
        }

 

        private DataTable createSkilldata(Skill skill, string roleData)
        {
            DataTable dt = new DataTable();
            dt = Skill.InsertSkill(UserRole, roleData, UserLogin, skill);
            return dt;
        }

        private Skill populateSkillUIdata(Skill skill)
        {
            skill.SkillType = txtNewSkillSkillType.Text;
            
            switch (cmbNewSkillIsActiveResultIndex)
            {
                case 0:  // Active
                    skill.IsActive = true;
                    break;
                case 1:
                    skill.IsActive = false;
                    break;
                default:
                    break;
            }

            return skill;
        }



        private void cmbNewSkillIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = (string) cmbNewSkillIsActive.SelectedItem;

            cmbNewSkillIsActiveResultIndex = cmbNewSkillIsActive.FindStringExact(selectedStatus);
        }

        private void pictureBoxCorrect_Click(object sender, EventArgs e)
        {
            lblNewMessage.Text = "";
            pictureBoxCorrect.Visible = false;

        }

        private DataTable createContractorSkilldata(ContractorSkill contractorskill, string roleData)
        {
            DataTable dt = new DataTable();
            dt = ContractorSkill.InsertContractorSkill(UserRole, roleData, UserLogin, contractorskill);
            return dt;
        }

        private ContractorSkill populateContractorSkillUIdata(ContractorSkill contractorskill)
        {
            //contractorskill.ContractorID = Convert.ToInt32(cmbContractorSkillContractor1.SelectedItem);

            contractorskill.ContractorID = Convert.ToInt32(((DataRowView)cmbContractorSkillContractor1.SelectedItem)["person_id"].ToString());
            
            contractorskill.SkillID = Convert.ToInt32(cmbContractorSkillSkill.SelectedValue); ;

            return contractorskill;
        }

        private void loadContractorSkillData(string userRole, string userLogin, int contractorId)
        {

            DataTable dt = new DataTable();
            dt = ContractorSkill.ListContractorSkill(userRole, userLogin, contractorId);

            dgvNewContractorSkill.DataSource = null;

            //Set AutoGenerateColumns False of Contractor data grid
            dgvNewContractorSkill.AutoGenerateColumns = false;

            //Set Columns Count of Contractor data grid
            dgvNewContractorSkill.ColumnCount = 2;


            //Add Columns to Contractor data grid
            dgvNewContractorSkill.Columns[0].Name = "SkillType";
            dgvNewContractorSkill.Columns[0].HeaderText = "SkillType";
            dgvNewContractorSkill.Columns[0].DataPropertyName = "skill_type";
            dgvNewContractorSkill.Columns[0].Width = 240;

            dgvNewContractorSkill.Columns[1].Name = "ContractorID";
            dgvNewContractorSkill.Columns[1].HeaderText = "ID";
            dgvNewContractorSkill.Columns[1].DataPropertyName = "contractor_person_ref";

            //To hide the column on the grid view control
            dgvNewContractorSkill.Columns[1].Visible = false;

            //datatable that contains data and column, string FieldName// name of the column based on distinct records will be calculated.
            //dgvNewContractorSkill.DataSource = BIT.frmList.SelectDistinct(dt, "contractor_person_ref");
            dgvNewContractorSkill.DataSource = dt;

        }


        private void cmbContractorSkillContractor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbContractorSkillContractor1.SelectedIndex = cmbContractorSkillContractor.SelectedIndex;
        }


        

        private void txtNewClientTitle_Validating(object sender, CancelEventArgs e)
        {
              // Title is required
            if ((txtNewClientTitle.Text.Trim() == "") || ((txtNewClientTitle.Text).Length > 10) || !RegularExpressionHelper.IsAlpha(txtNewClientTitle.Text))
            {
                errorProvider1.SetError(txtNewClientTitle, "Incorrect Title");
                e.Cancel = true;
                return;
              }    
              // Title is Valid
              errorProvider1.SetError(txtNewClientTitle, "");
                    
        }

        private void txtNewClientFirstName_Validating(object sender, CancelEventArgs e)
        {
            // FirstName is required
            if (((txtNewClientFirstName.Text).Length > 50) || !RegularExpressionHelper.IsAlpha(txtNewClientFirstName.Text))
            {
                errorProvider2.SetError(txtNewClientFirstName, "Invalid FirstName");
                e.Cancel = true;
                return;
            }
            // FirstName is Valid
            errorProvider2.SetError(txtNewClientFirstName, "");
        }

        private void txtNewClientLastName_Validating(object sender, CancelEventArgs e)
        {
            // LastName is required
            if (((txtNewClientLastName.Text).Length > 50) || !RegularExpressionHelper.IsAlpha(txtNewClientLastName.Text))
            {
                errorProvider3.SetError(txtNewClientLastName, "Invalid LastName");
                e.Cancel = true;
                return;
            }
            // LastName is Valid
            errorProvider3.SetError(txtNewClientLastName, "");
        }

        private void txtNewClientEmailP_Validating(object sender, CancelEventArgs e)
        {
            RegularExpressionHelper helper = new RegularExpressionHelper();

            // Email is required
            if (((txtNewClientEmailP.Text).Length > 50) || !helper.IsValidEmail(txtNewClientEmailP.Text))
            {
                errorProvider4.SetError(txtNewClientEmailP, "Invalid Email");
                e.Cancel = true;
                return;
            }
            // Email is Valid
            errorProvider4.SetError(txtNewClientEmailP, "");
        }

        private void txtNewClientEmailA_Validating(object sender, CancelEventArgs e)
        {
            RegularExpressionHelper helper = new RegularExpressionHelper();

            // Email is required
            if (((txtNewClientEmailA.Text).Length > 50) || !helper.IsValidEmail(txtNewClientEmailA.Text))
            {
                errorProvider5.SetError(txtNewClientEmailA, "Invalid Email");
                e.Cancel = true;
                return;
            }
            // Email is Valid
            errorProvider5.SetError(txtNewClientEmailA, "");
        }

        private void txtNewClientPosition_Validating(object sender, CancelEventArgs e)
        {
            RegularExpressionHelper helper = new RegularExpressionHelper();

            // Position is required
            if (((txtNewClientPosition.Text).Length > 50) || !RegularExpressionHelper.IsAlpha(txtNewClientPosition.Text))
            {
                errorProvider8.SetError(txtNewClientPosition, "Incorrect Position Format");
                e.Cancel = true;
                return;
            }
            // Position is Valid
            errorProvider8.SetError(txtNewClientPosition, "");
        }

        private void txtNewClientPhoneP_Validating(object sender, CancelEventArgs e)
        {
            RegularExpressionHelper helper = new RegularExpressionHelper();

            // Phone is required
            if ( ((txtNewClientPhoneP.Text).Length > 15) || !helper.IsPhoneFormat(txtNewClientPhoneP.Text) )
            {
                errorProvider9.SetError(txtNewClientPhoneP, "Incorrect Phone Format");
                e.Cancel = true;
                return;
            }
            // Phone is Valid
            errorProvider9.SetError(txtNewClientPhoneP, "");
        }

        private void txtNewClientPhoneH_Validating(object sender, CancelEventArgs e)
        {
            RegularExpressionHelper helper = new RegularExpressionHelper();

            // Phone is required
            if (((txtNewClientPhoneH.Text).Length > 15) || !helper.IsPhoneFormat(txtNewClientPhoneH.Text))
            {
                errorProvider10.SetError(txtNewClientPhoneH, "Incorrect Phone Format");
                e.Cancel = true;
                return;
            }
            // Phone is Valid
            errorProvider10.SetError(txtNewClientPhoneH, "");
        }

        private void txtNewClientPhoneM_Validating(object sender, CancelEventArgs e)
        {
            RegularExpressionHelper helper = new RegularExpressionHelper();

            // Phone is required
            if (((txtNewClientPhoneM.Text).Length > 15) || !helper.IsMobileFormat(txtNewClientPhoneM.Text))
            {
                errorProvider11.SetError(txtNewClientPhoneM, "Incorrect Mobile Format");
                e.Cancel = true;
                return;
            }
            // Phone is Valid
            errorProvider11.SetError(txtNewClientPhoneM, "");
        }

        private void txtNewClientPhoneW_Validating(object sender, CancelEventArgs e)
        {
            RegularExpressionHelper helper = new RegularExpressionHelper();

            // Phone is required
            if (((txtNewClientPhoneW.Text).Length > 15) || !helper.IsPhoneFormat(txtNewClientPhoneW.Text))
            {
                errorProvider12.SetError(txtNewClientPhoneW, "Incorrect Phone Format");
                e.Cancel = true;
                return;
            }
            // Phone is Valid
            errorProvider12.SetError(txtNewClientPhoneW, "");
        }

        private void txtNewClientPhoneE_Validating(object sender, CancelEventArgs e)
        {
            RegularExpressionHelper helper = new RegularExpressionHelper();

            // Phone is required
            if (((txtNewClientPhoneE.Text).Length > 15) || !helper.IsPhoneFormat(txtNewClientPhoneE.Text))
            {
                errorProvider13.SetError(txtNewClientPhoneE, "Incorrect Phone Format");
                e.Cancel = true;
                return;
            }
            // Phone is Valid
            errorProvider13.SetError(txtNewClientPhoneE, "");
        }

        private void txtNewClientDescription_Validating(object sender, CancelEventArgs e)
        {
            RegularExpressionHelper helper = new RegularExpressionHelper();

            // Description is required
            if (((txtNewClientDescription.Text).Length > 50) || !helper.IsAlphaNumericWithUnderscore(txtNewClientDescription.Text))
            {
                errorProvider15.SetError(txtNewClientDescription, "Invalid Description Format");
                e.Cancel = true;
                return;
            }
            // Description is Valid
            errorProvider15.SetError(txtNewClientDescription, "");
        }


        private void txtNewContractorTitle_Validating(object sender, CancelEventArgs e)
        {
            // Title is required
            if ((txtNewContractorTitle.Text.Trim() == "") || ((txtNewContractorTitle.Text).Length > 10) || !RegularExpressionHelper.IsAlpha(txtNewContractorTitle.Text))
            {
                errorProvider16.SetError(txtNewContractorTitle, "Incorrect Title");
                e.Cancel = true;
                return;
            }
            // Title is Valid
            errorProvider16.SetError(txtNewContractorTitle, "");

        }

        private void txtNewContractorFirstName_Validating(object sender, CancelEventArgs e)
        {
            // FirstName is required
            if (((txtNewContractorFirstName.Text).Length > 50) || !RegularExpressionHelper.IsAlpha(txtNewContractorFirstName.Text))
            {
                errorProvider17.SetError(txtNewContractorFirstName, "Invalid FirstName");
                e.Cancel = true;
                return;
            }
            // FirstName is Valid
            errorProvider17.SetError(txtNewContractorFirstName, "");
        }

        private void txtNewContractorLastName_Validating(object sender, CancelEventArgs e)
        {
            // LastName is required
            if (((txtNewContractorLastName.Text).Length > 50) || !RegularExpressionHelper.IsAlpha(txtNewContractorLastName.Text))
            {
                errorProvider18.SetError(txtNewContractorLastName, "Invalid LastName");
                e.Cancel = true;
                return;
            }
            // LastName is Valid
            errorProvider18.SetError(txtNewContractorLastName, "");
        }

        private void txtNewContractorEmailP_Validating(object sender, CancelEventArgs e)
        {
            RegularExpressionHelper helper = new RegularExpressionHelper();

            // Email is required
            if (((txtNewContractorEmailP.Text).Length > 50) || !helper.IsValidEmail(txtNewContractorEmailP.Text))
            {
                errorProvider19.SetError(txtNewContractorEmailP, "Invalid Email");
                e.Cancel = true;
                return;
            }
            // Email is Valid
            errorProvider19.SetError(txtNewContractorEmailP, "");
        }

        private void txtNewContractorEmailA_Validating(object sender, CancelEventArgs e)
        {
            RegularExpressionHelper helper = new RegularExpressionHelper();

            // Email is required
            if (((txtNewContractorEmailA.Text).Length > 50) || !helper.IsValidEmail(txtNewContractorEmailA.Text))
            {
                errorProvider20.SetError(txtNewContractorEmailA, "Invalid Email");
                e.Cancel = true;
                return;
            }
            // Email is Valid
            errorProvider20.SetError(txtNewContractorEmailA, "");
        }

        private void txtNewContractorFax_Validating(object sender, CancelEventArgs e)
        {
            RegularExpressionHelper helper = new RegularExpressionHelper();

            // Fax is required
            if (((txtNewContractorFax.Text).Length > 15) || !helper.IsPhoneFormat(txtNewContractorFax.Text))
            {
                errorProvider21.SetError(txtNewContractorFax, "Incorrect Fax Format");
                e.Cancel = true;
                return;
            }
            // Fax is Valid
            errorProvider21.SetError(txtNewContractorFax, "");
        }

        private void txtNewContractorCompany_Validating(object sender, CancelEventArgs e)
        {
            // Company is required
            if (((txtNewContractorCompany.Text).Length > 50) || !RegularExpressionHelper.IsAlpha(txtNewContractorCompany.Text))
            {
                errorProvider22.SetError(txtNewContractorCompany, "Invalid Format");
                e.Cancel = true;
                return;
            }
            // Company is Valid
            errorProvider22.SetError(txtNewContractorCompany, "");
        }

        private void txtNewContractorPosition_Validating(object sender, CancelEventArgs e)
        {
            // Position is required
            if (((txtNewContractorPosition.Text).Length > 50) || !RegularExpressionHelper.IsAlpha(txtNewContractorPosition.Text))
            {
                errorProvider23.SetError(txtNewContractorPosition, "Invalid Format");
                e.Cancel = true;
                return;
            }
            // Position is Valid
            errorProvider23.SetError(txtNewContractorPosition, "");
        }

        private void txtNewContractorPhoneP_Validating(object sender, CancelEventArgs e)
        {
            RegularExpressionHelper helper = new RegularExpressionHelper();

            // Phone is required
            if (((txtNewContractorPhoneP.Text).Length > 15) || !helper.IsPhoneFormat(txtNewContractorPhoneP.Text))
            {
                errorProvider24.SetError(txtNewContractorPhoneP, "Incorrect Phone Format");
                e.Cancel = true;
                return;
            }
            // Phone is Valid
            errorProvider24.SetError(txtNewContractorPhoneP, "");
        }

        private void txtNewContractorPhoneH_Validating(object sender, CancelEventArgs e)
        {
            RegularExpressionHelper helper = new RegularExpressionHelper();

            // Phone is required
            if (((txtNewContractorPhoneH.Text).Length > 15) || !helper.IsPhoneFormat(txtNewContractorPhoneH.Text))
            {
                errorProvider25.SetError(txtNewContractorPhoneH, "Incorrect Phone Format");
                e.Cancel = true;
                return;
            }
            // Phone is Valid
            errorProvider25.SetError(txtNewContractorPhoneH, "");
        }

        private void txtNewContractorPhoneM_Validating(object sender, CancelEventArgs e)
        {
            RegularExpressionHelper helper = new RegularExpressionHelper();

            // Phone is required
            if (((txtNewContractorPhoneM.Text).Length > 15) || !helper.IsMobileFormat(txtNewContractorPhoneM.Text))
            {
                errorProvider26.SetError(txtNewContractorPhoneM, "Incorrect Mobile Format");
                e.Cancel = true;
                return;
            }
            // Phone is Valid
            errorProvider26.SetError(txtNewContractorPhoneM, "");
        }

        private void txtNewContractorPhoneW_Validating(object sender, CancelEventArgs e)
        {
            RegularExpressionHelper helper = new RegularExpressionHelper();

            // Phone is required
            if (((txtNewContractorPhoneW.Text).Length > 15) || !helper.IsPhoneFormat(txtNewContractorPhoneW.Text))
            {
                errorProvider27.SetError(txtNewContractorPhoneW, "Incorrect Phone Format");
                e.Cancel = true;
                return;
            }
            // Phone is Valid
            errorProvider27.SetError(txtNewContractorPhoneW, "");
        }

        private void txtNewContractorPhoneE_Validating(object sender, CancelEventArgs e)
        {
            RegularExpressionHelper helper = new RegularExpressionHelper();

            // Phone is required
            if (((txtNewContractorPhoneE.Text).Length > 15) || !helper.IsPhoneFormat(txtNewContractorPhoneE.Text))
            {
                errorProvider28.SetError(txtNewContractorPhoneE, "Incorrect Phone Format");
                e.Cancel = true;
                return;
            }
            // Phone is Valid
            errorProvider28.SetError(txtNewContractorPhoneE, "");
        }

        private void txtNewContractorIsActive_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtNewContractorDescription_Validating(object sender, CancelEventArgs e)
        {
            RegularExpressionHelper helper = new RegularExpressionHelper();

            // Description is required
            if (((txtNewContractorDescription.Text).Length > 50) || !helper.IsAlphaNumericWithUnderscore(txtNewContractorDescription.Text))
            {
                errorProvider30.SetError(txtNewContractorDescription, "Invalid Description Format");
                e.Cancel = true;
                return;
            }
            // Description is Valid
            errorProvider30.SetError(txtNewContractorDescription, "");
        }


        private void txtNewCoordinatorTitle_Validating(object sender, CancelEventArgs e)
        {
            // Title is required
            if ((txtNewCoordinatorTitle.Text.Trim() == "") || ((txtNewCoordinatorTitle.Text).Length > 10) || !RegularExpressionHelper.IsAlpha(txtNewCoordinatorTitle.Text))
            {
                errorProvider16.SetError(txtNewCoordinatorTitle, "Incorrect Title");
                e.Cancel = true;
                return;
            }
            // Title is Valid
            errorProvider16.SetError(txtNewCoordinatorTitle, "");

        }

        private void txtNewCoordinatorFirstName_Validating(object sender, CancelEventArgs e)
        {
            // FirstName is required
            if (((txtNewCoordinatorFirstName.Text).Length > 50) || !RegularExpressionHelper.IsAlpha(txtNewCoordinatorFirstName.Text))
            {
                errorProvider17.SetError(txtNewCoordinatorFirstName, "Invalid FirstName");
                e.Cancel = true;
                return;
            }
            // FirstName is Valid
            errorProvider17.SetError(txtNewCoordinatorFirstName, "");
        }

        private void txtNewCoordinatorLastName_Validating(object sender, CancelEventArgs e)
        {
            // LastName is required
            if (((txtNewCoordinatorLastName.Text).Length > 50) || !RegularExpressionHelper.IsAlpha(txtNewCoordinatorLastName.Text))
            {
                errorProvider18.SetError(txtNewCoordinatorLastName, "Invalid LastName");
                e.Cancel = true;
                return;
            }
            // LastName is Valid
            errorProvider18.SetError(txtNewCoordinatorLastName, "");
        }

        private void txtNewCoordinatorEmailP_Validating(object sender, CancelEventArgs e)
        {
            RegularExpressionHelper helper = new RegularExpressionHelper();

            // Email is required
            if (((txtNewCoordinatorEmailP.Text).Length > 50) || !helper.IsValidEmail(txtNewCoordinatorEmailP.Text))
            {
                errorProvider19.SetError(txtNewCoordinatorEmailP, "Invalid Email");
                e.Cancel = true;
                return;
            }
            // Email is Valid
            errorProvider19.SetError(txtNewCoordinatorEmailP, "");
        }

        private void txtNewCoordinatorEmailA_Validating(object sender, CancelEventArgs e)
        {
            RegularExpressionHelper helper = new RegularExpressionHelper();

            // Email is required
            if (((txtNewCoordinatorEmailA.Text).Length > 50) || !helper.IsValidEmail(txtNewCoordinatorEmailA.Text))
            {
                errorProvider20.SetError(txtNewCoordinatorEmailA, "Invalid Email");
                e.Cancel = true;
                return;
            }
            // Email is Valid
            errorProvider20.SetError(txtNewCoordinatorEmailA, "");
        }

        private void txtNewCoordinatorFax_Validating(object sender, CancelEventArgs e)
        {
            RegularExpressionHelper helper = new RegularExpressionHelper();

            // Fax is required
            if (((txtNewCoordinatorFax.Text).Length > 15) || !helper.IsPhoneFormat(txtNewCoordinatorFax.Text))
            {
                errorProvider21.SetError(txtNewCoordinatorFax, "Incorrect Fax Format");
                e.Cancel = true;
                return;
            }
            // Fax is Valid
            errorProvider21.SetError(txtNewCoordinatorFax, "");
        }

        private void txtNewCoordinatorCompany_Validating(object sender, CancelEventArgs e)
        {
            // Company is required
            if (((txtNewCoordinatorCompany.Text).Length > 50) || !RegularExpressionHelper.IsAlpha(txtNewCoordinatorCompany.Text))
            {
                errorProvider22.SetError(txtNewCoordinatorCompany, "Invalid Format");
                e.Cancel = true;
                return;
            }
            // Company is Valid
            errorProvider22.SetError(txtNewCoordinatorCompany, "");
        }

        private void txtNewCoordinatorPosition_Validating(object sender, CancelEventArgs e)
        {
            // Position is required
            if (((txtNewCoordinatorPosition.Text).Length > 50) || !RegularExpressionHelper.IsAlpha(txtNewCoordinatorPosition.Text))
            {
                errorProvider23.SetError(txtNewCoordinatorPosition, "Invalid Format");
                e.Cancel = true;
                return;
            }
            // Position is Valid
            errorProvider23.SetError(txtNewCoordinatorPosition, "");
        }

        private void txtNewCoordinatorPhoneP_Validating(object sender, CancelEventArgs e)
        {
            RegularExpressionHelper helper = new RegularExpressionHelper();

            // Phone is required
            if (((txtNewCoordinatorPhoneP.Text).Length > 15) || !helper.IsPhoneFormat(txtNewCoordinatorPhoneP.Text))
            {
                errorProvider24.SetError(txtNewCoordinatorPhoneP, "Incorrect Phone Format");
                e.Cancel = true;
                return;
            }
            // Phone is Valid
            errorProvider24.SetError(txtNewCoordinatorPhoneP, "");
        }

        private void txtNewCoordinatorPhoneH_Validating(object sender, CancelEventArgs e)
        {
            RegularExpressionHelper helper = new RegularExpressionHelper();

            // Phone is required
            if (((txtNewCoordinatorPhoneH.Text).Length > 15) || !helper.IsPhoneFormat(txtNewCoordinatorPhoneH.Text))
            {
                errorProvider25.SetError(txtNewCoordinatorPhoneH, "Incorrect Phone Format");
                e.Cancel = true;
                return;
            }
            // Phone is Valid
            errorProvider25.SetError(txtNewCoordinatorPhoneH, "");
        }

        private void txtNewCoordinatorPhoneM_Validating(object sender, CancelEventArgs e)
        {
            RegularExpressionHelper helper = new RegularExpressionHelper();

            // Phone is required
            if (((txtNewCoordinatorPhoneM.Text).Length > 15) || !helper.IsMobileFormat(txtNewCoordinatorPhoneM.Text))
            {
                errorProvider26.SetError(txtNewCoordinatorPhoneM, "Incorrect Mobile Format");
                e.Cancel = true;
                return;
            }
            // Phone is Valid
            errorProvider26.SetError(txtNewCoordinatorPhoneM, "");
        }

        private void txtNewCoordinatorPhoneW_Validating(object sender, CancelEventArgs e)
        {
            RegularExpressionHelper helper = new RegularExpressionHelper();

            // Phone is required
            if (((txtNewCoordinatorPhoneW.Text).Length > 15) || !helper.IsPhoneFormat(txtNewCoordinatorPhoneW.Text))
            {
                errorProvider27.SetError(txtNewCoordinatorPhoneW, "Incorrect Phone Format");
                e.Cancel = true;
                return;
            }
            // Phone is Valid
            errorProvider27.SetError(txtNewCoordinatorPhoneW, "");
        }

        private void txtNewCoordinatorPhoneE_Validating(object sender, CancelEventArgs e)
        {
            RegularExpressionHelper helper = new RegularExpressionHelper();

            // Phone is required
            if (((txtNewCoordinatorPhoneE.Text).Length > 15) || !helper.IsPhoneFormat(txtNewCoordinatorPhoneE.Text))
            {
                errorProvider28.SetError(txtNewCoordinatorPhoneE, "Incorrect Phone Format");
                e.Cancel = true;
                return;
            }
            // Phone is Valid
            errorProvider28.SetError(txtNewCoordinatorPhoneE, "");
        }

        private void txtNewCoordinatorIsActive_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtNewCoordinatorDescription_Validating(object sender, CancelEventArgs e)
        {
            RegularExpressionHelper helper = new RegularExpressionHelper();

            // Description is required
            if (((txtNewCoordinatorDescription.Text).Length > 50) || !helper.IsAlphaNumericWithUnderscore(txtNewCoordinatorDescription.Text))
            {
                errorProvider30.SetError(txtNewCoordinatorDescription, "Invalid Description Format");
                e.Cancel = true;
                return;
            }
            // Description is Valid
            errorProvider30.SetError(txtNewCoordinatorDescription, "");
        }

        
    }
}
