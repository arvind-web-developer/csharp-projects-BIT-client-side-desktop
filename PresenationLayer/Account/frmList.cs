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
    public partial class frmList : Form
    {
        private static string UserRole { get; set; }
        private static string UserLogin { get; set; }

        
        private Client client;
        private Contractor contractor;
        private Coordinator coordinator;


        private DataGridViewRow row;

        private DataTable dt;
       
        public frmList()
        {
            InitializeComponent();
        }

        private void btnListClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmList_Load(object sender, EventArgs e)
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

            routeRequest(userRole, userLogin);
        }

        private void routeRequest(string userRole, string userLogin)
        {
                tabControlList.TabPages.Clear();

                switch (userRole)
                {
                    case "Admin":           // Admin* selected
                        tabControlList.TabPages.Add(tabPageListRequest);
                        tabControlList.TabPages.Add(tabPageListClient);
                        tabControlList.TabPages.Add(tabPageListCoordinator);
                        tabControlList.TabPages.Add(tabPageListContractor);
                        tabControlList.TabPages.Add(tabPageListJob);
                        tabControlList.TabPages.Add(tabPageListSkill);
                        tabControlList.TabPages.Add(tabPageListContractorSkill);
                        break;
                    case "Coordinator":      // Coordinator* selected
                        tabControlList.TabPages.Add(tabPageListRequest);
                        tabControlList.TabPages.Add(tabPageListClient);
                        tabControlList.TabPages.Add(tabPageListContractor);
                        tabControlList.TabPages.Add(tabPageListJob);
                        tabControlList.TabPages.Add(tabPageListSkill);
                        tabControlList.TabPages.Add(tabPageListContractorSkill);
                        break;
                    case "Contractor":      // Contractor* selected
                        tabControlList.TabPages.Add(tabPageListRequest);
                        tabControlList.TabPages.Add(tabPageListClient);
                        tabControlList.TabPages.Add(tabPageListJob);
                        tabControlList.TabPages.Add(tabPageListSkill);
                        btnListEdit.Visible = false;

                        break;
                    case "Client":          // Client* selected
                        tabControlList.TabPages.Add(tabPageListRequest);
                        //tabControlList.TabPages.Add(tabPageListJob);
                        tabControlList.TabPages.Add(tabPageListSkill);
                        btnListEdit.Visible = false;
                        break;
                    // ... unauthorized user...
                    default: //tabControlList.TabPages.Add(tabPageListNONE);
                        break;
                }

            // load relevant data into the authorized tabs
                loadData(userRole, userLogin);
        }

        private void loadData(string userRole, string userLogin)
        {
            switch (userRole)
            {
                case "Admin":           // Admin* selected
                    loadClientData(userRole, userLogin);
                    loadCoordinatorData(userRole, userLogin);
                    loadContractorData(userRole, userLogin);
                    loadRequestData(userRole, userLogin);
                    loadJobData(userRole, userLogin);
                    loadContractorSkillData(userRole, userLogin);
                    loadSkillData(userRole, userLogin);
                    break;
                case "Coordinator":      // Coordinator* selected
                    loadClientData(userRole, userLogin);
                    loadContractorData(userRole, userLogin);
                    loadRequestData(userRole, userLogin);
                    loadJobData(userRole, userLogin);
                    loadContractorSkillData(userRole, userLogin);
                    loadSkillData(userRole, userLogin);
                    break;
                case "Contractor":      // Contractor* selected
                    loadClientData(userRole, userLogin);
                    loadRequestData(userRole, userLogin);
                    loadJobData(userRole, userLogin);
                    loadSkillData(userRole, userLogin);
                    btnListDelete.Visible = false;
                    break;
                case "Client":          // Client* selected
                    loadRequestData(userRole, userLogin);
                    //loadJobData(userRole, userLogin);
                    loadSkillData(userRole, userLogin);
                    btnListDelete.Visible = false;
                    break;
                // ... unauthorized user...
                default: //tabControlList.TabPages.Add(tabPageListNONE);
                    break;
            }
        }

        private void loadClientData(string userRole, string userLogin)
        {
            //MessageBox.Show("Loading Data for: " + userRole + " ");
            dt = new DataTable();

            dt = Client.ListClient(userRole, userLogin);

            //Set AutoGenerateColumns False
            dgvListClient.AutoGenerateColumns = false;

            //Set Columns Count
            dgvListClient.ColumnCount = 10;


            //Add Columns
            dgvListClient.Columns[0].Name = "ClientCompany";
            dgvListClient.Columns[0].HeaderText = "Company";
            dgvListClient.Columns[0].DataPropertyName = "companyname";

            dgvListClient.Columns[1].Name = "ClientPosition";
            dgvListClient.Columns[1].HeaderText = "Position";
            dgvListClient.Columns[1].DataPropertyName = "position";

            dgvListClient.Columns[2].Name = "ClientTitle";
            dgvListClient.Columns[2].HeaderText = "Title";
            dgvListClient.Columns[2].DataPropertyName = "title";

            dgvListClient.Columns[3].Name = "ClientFirstName";
            dgvListClient.Columns[3].HeaderText = "FirstName";
            dgvListClient.Columns[3].DataPropertyName = "firstname";

            dgvListClient.Columns[4].Name = "ClientLastName";
            dgvListClient.Columns[4].HeaderText = "LastName";
            dgvListClient.Columns[4].DataPropertyName = "lastname";

            dgvListClient.Columns[5].Name = "ClientEmailPrimary";
            dgvListClient.Columns[5].HeaderText = "EmailPrimary";
            dgvListClient.Columns[5].DataPropertyName = "emailprimary";
            //dgvListClient.Columns[5].ReadOnly = true;

            dgvListClient.Columns[6].Name = "ClientFax";
            dgvListClient.Columns[6].HeaderText = "Fax";
            dgvListClient.Columns[6].DataPropertyName = "fax";

            dgvListClient.Columns[7].Name = "ClientPhonePrimary";
            dgvListClient.Columns[7].HeaderText = "PhonePrimary";
            dgvListClient.Columns[7].DataPropertyName = "phoneprimary";

            dgvListClient.Columns[8].Name = "ClientMobile";
            dgvListClient.Columns[8].HeaderText = "Mobile";
            dgvListClient.Columns[8].DataPropertyName = "phonemobile";

            dgvListClient.Columns[9].Name = "ClientID";
            dgvListClient.Columns[9].HeaderText = "ID";
            dgvListClient.Columns[9].DataPropertyName = "person_id";
            dgvListClient.Columns[9].Visible = false;


            dgvListClient.DataSource = dt;

        }

        private void loadContractorData(string userRole, string userLogin)
        {
            DataTable dt = new DataTable();

            dt = Contractor.ListContractor(userRole, userLogin);

            //Set AutoGenerateColumns False
            dgvListContractor.AutoGenerateColumns = false;

            //Set Columns Count
            dgvListContractor.ColumnCount = 9;


            //Add Columns
            dgvListContractor.Columns[0].Name = "ContractorPosition";
            dgvListContractor.Columns[0].HeaderText = "Specialist";
            dgvListContractor.Columns[0].DataPropertyName = "position";

            dgvListContractor.Columns[1].Name = "ContractorPhonePrimary";
            dgvListContractor.Columns[1].HeaderText = "Phone";
            dgvListContractor.Columns[1].DataPropertyName = "phoneprimary";

            dgvListContractor.Columns[2].Name = "ContractorMobile";
            dgvListContractor.Columns[2].HeaderText = "Mobile";
            dgvListContractor.Columns[2].DataPropertyName = "phonemobile";

            dgvListContractor.Columns[3].Name = "ContractorFirstName";
            dgvListContractor.Columns[3].HeaderText = "FirstName";
            dgvListContractor.Columns[3].DataPropertyName = "firstname";

            dgvListContractor.Columns[4].Name = "ContractorLastName";
            dgvListContractor.Columns[4].HeaderText = "LastName";
            dgvListContractor.Columns[4].DataPropertyName = "lastname";

            dgvListContractor.Columns[5].Name = "ContractorEmailPrimary";
            dgvListContractor.Columns[5].HeaderText = "Email";
            dgvListContractor.Columns[5].DataPropertyName = "emailprimary";
            //dgvListContractor.Columns[5].ReadOnly = true;

            dgvListContractor.Columns[6].Name = "ContractorFax";
            dgvListContractor.Columns[6].HeaderText = "Fax";
            dgvListContractor.Columns[6].DataPropertyName = "fax";

            dgvListContractor.Columns[7].Name = "ContractorCompany";
            dgvListContractor.Columns[7].HeaderText = "Company";
            dgvListContractor.Columns[7].DataPropertyName = "companyname";

            dgvListContractor.Columns[8].Name = "ContractorID";
            dgvListContractor.Columns[8].HeaderText = "ID";
            dgvListContractor.Columns[8].DataPropertyName = "person_id";
            dgvListContractor.Columns[8].Visible = false;

            dgvListContractor.DataSource = dt;
        }

        private void loadCoordinatorData(string userRole, string userLogin)
        {
            DataTable dt = new DataTable();

            dt = Coordinator.ListCoordinator(userRole, userLogin);

            //Set AutoGenerateColumns False
            dgvListCoordinator.AutoGenerateColumns = false;

            //Set Columns Count
            dgvListCoordinator.ColumnCount = 7;


            //Add Columns
            dgvListCoordinator.Columns[0].Name = "CoordinatorPosition";
            dgvListCoordinator.Columns[0].HeaderText = "Position";
            dgvListCoordinator.Columns[0].DataPropertyName = "position";

            dgvListCoordinator.Columns[1].Name = "CoordinatorPhonePrimary";
            dgvListCoordinator.Columns[1].HeaderText = "Phone";
            dgvListCoordinator.Columns[1].DataPropertyName = "phoneprimary";

            dgvListCoordinator.Columns[2].Name = "CoordinatorMobile";
            dgvListCoordinator.Columns[2].HeaderText = "Mobile";
            dgvListCoordinator.Columns[2].DataPropertyName = "phonemobile";

            dgvListCoordinator.Columns[3].Name = "CoordinatorFirstName";
            dgvListCoordinator.Columns[3].HeaderText = "FirstName";
            dgvListCoordinator.Columns[3].DataPropertyName = "firstname";

            dgvListCoordinator.Columns[4].Name = "CoordinatorLastName";
            dgvListCoordinator.Columns[4].HeaderText = "LastName";
            dgvListCoordinator.Columns[4].DataPropertyName = "lastname";

            dgvListCoordinator.Columns[5].Name = "CoordinatorEmailPrimary";
            dgvListCoordinator.Columns[5].HeaderText = "Email";
            dgvListCoordinator.Columns[5].DataPropertyName = "emailprimary";
            //dgvListCoordinator.Columns[5].ReadOnly = true;

            dgvListCoordinator.Columns[6].Name = "CoordinatorID";
            dgvListCoordinator.Columns[6].HeaderText = "ID";
            dgvListCoordinator.Columns[6].DataPropertyName = "person_id";
            dgvListCoordinator.Columns[6].Visible = false;

            dgvListCoordinator.DataSource = dt;
        }

        private void loadRequestData(string userRole, string userLogin)
        {
            DataTable dt = new DataTable();

            dt = Request.ListRequest(userRole, userLogin);


            //Set AutoGenerateColumns False
            dgvListRequest.AutoGenerateColumns = false;
            //dgvListRequest.AutoSize = true;

            //Set Columns Count
            dgvListRequest.ColumnCount = 6;


            //Add Columns
            dgvListRequest.Columns[0].Name = "RequestContractorID";
            dgvListRequest.Columns[0].HeaderText = "ContractorID";
            dgvListRequest.Columns[0].DataPropertyName = "contractor_person_ref";

            dgvListRequest.Columns[1].Name = "RequestClientID";
            dgvListRequest.Columns[1].HeaderText = "ClientID";
            dgvListRequest.Columns[1].DataPropertyName = "client_person_ref";

            dgvListRequest.Columns[2].Name = "RequestJobID";
            dgvListRequest.Columns[2].HeaderText = "JobID";
            dgvListRequest.Columns[2].DataPropertyName = "job_ref";

            dgvListRequest.Columns[3].Name = "RequestDateRequested";
            dgvListRequest.Columns[3].HeaderText = "Date";
            dgvListRequest.Columns[3].DataPropertyName = "date_requested";

            dgvListRequest.Columns[4].Name = "RequestTimeRequested";
            dgvListRequest.Columns[4].HeaderText = "Time";
            dgvListRequest.Columns[4].DataPropertyName = "time_requested";

            dgvListRequest.Columns[5].Name = "RequestStatusType";
            dgvListRequest.Columns[5].HeaderText = "Status";
            dgvListRequest.Columns[5].DataPropertyName = "status_type";



            dgvListRequest.DataSource = dt;
        }

        private void loadJobData(string userRole, string userLogin)
        {
            //MessageBox.Show("Loading Data for: " + userRole + " ");
        }

        private void loadSkillData(string userRole, string userLogin)
        {

            DataTable dt = new DataTable();
            dt = Skill.ListSkill(userRole, userLogin);

            //Set AutoGenerateColumns False of Contractor data grid
            dgvListSkill.AutoGenerateColumns = false;

            //Set Columns Count of Contractor data grid
            dgvListSkill.ColumnCount = 3;


            //Add Columns to Contractor data grid
            dgvListSkill.Columns[0].Name = "SkillID";
            dgvListSkill.Columns[0].HeaderText = "SkillID";
            dgvListSkill.Columns[0].DataPropertyName = "skill_id";
            dgvListSkill.Columns[0].Width = 130;

            dgvListSkill.Columns[1].Name = "SkillType";
            dgvListSkill.Columns[1].HeaderText = "SkillType";
            dgvListSkill.Columns[1].DataPropertyName = "skill_type";
            dgvListSkill.Columns[1].Width = 130;

            dgvListSkill.Columns[2].Name = "IsActive";
            dgvListSkill.Columns[2].HeaderText = "IsActive";
            dgvListSkill.Columns[2].DataPropertyName = "isactive";

            //To hide the column on the grid view control
            dgvListSkill.Columns[2].Visible = false;

            //datatable that contains data and column, string FieldName// name of the column based on distinct records will be calculated.
            dgvListSkill.DataSource = SelectDistinct(dt, "skill_id");
        }

        private void loadContractorSkillData(string userRole, string userLogin)
        {
            
            DataTable dt = new DataTable();
            dt = ContractorSkill.ListContractorSkill(userRole, userLogin, 0);

            //Set AutoGenerateColumns False of Contractor data grid
            dgvListContractorSkill_1.AutoGenerateColumns = false;

            //Set Columns Count of Contractor data grid
            dgvListContractorSkill_1.ColumnCount = 3;


            //Add Columns to Contractor data grid
            dgvListContractorSkill_1.Columns[0].Name = "ContractorFirstName";
            dgvListContractorSkill_1.Columns[0].HeaderText = "FirstName";
            dgvListContractorSkill_1.Columns[0].DataPropertyName = "firstname";
            dgvListContractorSkill_1.Columns[0].Width = 130;

            dgvListContractorSkill_1.Columns[1].Name = "ContractorLastName";
            dgvListContractorSkill_1.Columns[1].HeaderText = "LastName";
            dgvListContractorSkill_1.Columns[1].DataPropertyName = "lastname";
            dgvListContractorSkill_1.Columns[1].Width = 130;

            dgvListContractorSkill_1.Columns[2].Name = "ContractorID";
            dgvListContractorSkill_1.Columns[2].HeaderText = "ID";
            dgvListContractorSkill_1.Columns[2].DataPropertyName = "contractor_person_ref";
            
            //To hide the column on the grid view control
            dgvListContractorSkill_1.Columns[2].Visible = false;

            //datatable that contains data and column, string FieldName// name of the column based on distinct records will be calculated.
            dgvListContractorSkill_1.DataSource = SelectDistinct(dt, "contractor_person_ref");


        }

        private void frmList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.X)
            {
                btnListClose_Click(sender, e);

            }
            else if (e.Alt && e.KeyCode == Keys.X)
            {
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
            else if (e.Control && e.Shift && e.KeyCode == Keys.I)
            {
                tabControlList.SelectTab("tabPageListClient");

            }
            else if (e.Control && e.Shift && e.KeyCode == Keys.N)
            {
                tabControlList.SelectTab("tabPageListContractor");

            }
            else if (e.Control && e.Shift && e.KeyCode == Keys.D)
            {
                tabControlList.SelectTab("tabPageListCoordinator");

            }
            else if (e.Control && e.Shift && e.KeyCode == Keys.R)
            {
                tabControlList.SelectTab("tabPageListRequest");

            }
            else if (e.Control && e.Shift && e.KeyCode == Keys.J)
            {
                tabControlList.SelectTab("tabPageListJob");

            }          
        }
        
        public static DataTable SelectDistinct(DataTable SourceTable, string col)
        {
            DataTable dtbl = new DataTable();
            for(int i=0;i<SourceTable.Columns.Count;i++)
            {
                dtbl.Columns.Add(SourceTable.Columns[i].ColumnName, SourceTable.Columns[i].DataType);
            }
       
            for (int i = 0; i < SourceTable.Rows.Count;i++)
            {
                bool chk = false;
                for (int j = 0; j < dtbl.Rows.Count; j++)
                {
                    if (dtbl.Rows[j][col].ToString() == SourceTable.Rows[i][col].ToString())
                    {
                        chk = true;
                    }
                }
                if (chk == false)
                {
                    dtbl.Rows.Add(SourceTable.Rows[i].ItemArray);
                }
            }
            return dtbl;
        }

        private void dgvListClient_SelectionChanged(object sender, EventArgs e)
        {
            int IndexSelected = dgvListClient.CurrentRow.Index;
            row = dgvListClient.Rows[IndexSelected];
            BIT.frmEdit.TabPageSelected = "tabPageEditClient";

            client = new Client();
            client.ClientID = Convert.ToInt32(row.Cells[9].Value.ToString());
            client.ClientCompanyName = row.Cells[0].Value.ToString();
            client.ClientPosition = row.Cells[1].Value.ToString();
            client.ClientTitle = row.Cells[2].Value.ToString();
            client.ClientFirstName = row.Cells[3].Value.ToString();
            client.ClientLastName = row.Cells[4].Value.ToString();
            client.ClientEmailPrimary = row.Cells[5].Value.ToString();
            client.ClientFax = row.Cells[6].Value.ToString();
            client.ClientPhonePrimary = row.Cells[7].Value.ToString();
            client.ClientPhoneMobile = row.Cells[8].Value.ToString();

        }

        private void dgvListContractor_SelectionChanged(object sender, EventArgs e)
        {
            int IndexSelected = dgvListContractor.CurrentRow.Index;
            row = dgvListContractor.Rows[IndexSelected];
            BIT.frmEdit.TabPageSelected = "tabPageEditContractor";

            contractor = new Contractor();
            contractor.ContractorID = Convert.ToInt32(row.Cells[8].Value.ToString());
            contractor.ContractorPosition = row.Cells[0].Value.ToString();
            contractor.ContractorPhonePrimary = row.Cells[1].Value.ToString();
            contractor.ContractorPhoneMobile = row.Cells[2].Value.ToString();
            contractor.ContractorFirstName = row.Cells[3].Value.ToString();
            contractor.ContractorLastName = row.Cells[4].Value.ToString();
            contractor.ContractorEmailPrimary = row.Cells[5].Value.ToString();
            contractor.ContractorFax = row.Cells[6].Value.ToString();
            contractor.ContractorCompanyName = row.Cells[7].Value.ToString();
        }

        private void dgvListContractorSkill_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvListContractorSkill_1.SelectedCells[0].RowIndex;

            if (e.RowIndex != -1)
            {
                // data grid of Contractor's Skill

                foreach (DataGridViewRow row in dgvListContractorSkill_2.Rows)
                {
                    string RowType = row.Cells[0].Value.ToString();

                    if (RowType == "Type A")
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.DefaultCellStyle.ForeColor = Color.LightYellow;
                    }
                    else if (RowType == "Type B")
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.ForeColor = Color.LightBlue;
                    }
                }



                int selectedContractorId = Convert.ToInt32(dgvListContractorSkill_1.Rows[i].Cells[2].Value.ToString());

                if (this.dgvListContractorSkill_2.DataSource != null)
                {
                    this.dgvListContractorSkill_2.DataSource = null;
                }
                else
                {
                    this.dgvListContractorSkill_2.Rows.Clear();
                }

                DataTable dt = new DataTable();
                dt = ContractorSkill.ListContractorSkill(UserRole, UserLogin, selectedContractorId);

                //Set AutoGenerateColumns False of Contractor data grid
                dgvListContractorSkill_2.AutoGenerateColumns = false;

                //Set Columns Count of Contractor data grid
                dgvListContractorSkill_2.ColumnCount = 1;


                //Add Columns to Contractor data grid
                dgvListContractorSkill_2.Columns[0].Name = "ContractorSkill";
                dgvListContractorSkill_2.Columns[0].HeaderText = "SkillType";
                dgvListContractorSkill_2.Columns[0].DataPropertyName = "skill_type";
                dgvListContractorSkill_2.Columns[0].Width = 200;


                //datatable that contains data and column, string FieldName// name of the column based on distinct records will be calculated.
                dgvListContractorSkill_2.DataSource = SelectDistinct(dt, "skill_type");
            }
        }

        private void dgvListCoordinator_SelectionChanged(object sender, EventArgs e)
        {
            int IndexSelected = dgvListCoordinator.CurrentRow.Index;
            row = dgvListCoordinator.Rows[IndexSelected];
            BIT.frmEdit.TabPageSelected = "tabPageEditCoordinator";

            coordinator = new Coordinator();
            coordinator.CoordinatorID = Convert.ToInt32(row.Cells[6].Value.ToString());
            coordinator.CoordinatorPosition = row.Cells[0].Value.ToString();
            coordinator.CoordinatorPhonePrimary = row.Cells[1].Value.ToString();
            coordinator.CoordinatorPhoneMobile = row.Cells[2].Value.ToString();
            coordinator.CoordinatorFirstName = row.Cells[3].Value.ToString();
            coordinator.CoordinatorLastName = row.Cells[4].Value.ToString();
            coordinator.CoordinatorEmailPrimary = row.Cells[5].Value.ToString();
        }

        private void btnListEdit_Click(object sender, EventArgs e)
        {
            frmEdit frm = new frmEdit();
            // frm.NewObject = false;    //Existing Object

            try
            {
                //DataTable dt = new DataTable();
                string msg = "MESSAGE: ";


                switch (BIT.frmEdit.TabPageSelected)
                {
                    case "tabPageEditClient":                    // Client* selected
                        //dt = approveClientdata(client);
                        //tabControlList.SelectTab("tabPageListClient");
                        //tabControlList.SelectTab(BIT.frmNew.TabPageSelected);
                        frm.populateUIClientdata(client);
                        msg = msg + "Client Edited! ";
                        break;
                    case "tabPageEditContractor":                // Contractor* selected
                        //dt = approveContractordata(contractor);
                        frm.populateUIContractordata(contractor);
                        msg = msg + "Contractor Edited! ";
                        break;
                    case "tabPageEditCoordinator":               // Coordinator* selected
                        //dt = approveCoordinatordata(coordinator);
                        frm.populateUICoordinatordata(coordinator);
                        msg = msg + "Coordinator Edited! ";
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

                //    if (dt.Rows.Count > 0)
                //        msg = msg + "with ID: " + Convert.ToString(dt.Rows[0][0]);

                BIT.frmEdit.msgOutput(frm, msg);


                //  btnNewApprove.Visible = false;
                //   btnNewCreateUser.Visible = true;


                frm.ShowDialog();


                //MessageBox.Show(row.Cells[9].Value.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.GetType() + ex.Message);
            }
        }

        private DataTable deleteUserData(string roleData, User user)
        {
            DataTable dt = new DataTable();
            dt = User.DeactivateUser(UserRole, roleData, UserLogin, user);
            return dt;
        }

        private void btnListDelete_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                DataTable dtUser = new DataTable();
                string msg = "MESSAGE: ";
                int IndexSelected;

                switch (BIT.frmEdit.TabPageSelected)
                {
                    case "tabPageEditClient":                    // Client* selected
                        user.UserName = client.ClientEmailPrimary;
                        dtUser = deleteUserData("Client", user);
                         IndexSelected = dgvListClient.CurrentRow.Index;
                         dt.Rows[IndexSelected].Delete();
                         dgvListClient.Refresh();
                         msg = msg + "Client Deactivated! ";
                        break;
                    case "tabPageEditContractor":                // Contractor* selected
                        user.UserName = contractor.ContractorEmailPrimary;
                        dtUser = deleteUserData("Contractor", user);
                        IndexSelected = dgvListContractor.CurrentRow.Index;
                        dt.Rows[IndexSelected].Delete();
                        dgvListContractor.Refresh();
                        msg = msg + "Contractor Deactivated! ";
                        break;
                    case "tabPageEditCoordinator":               // Coordinator* selected
                        user.UserName = coordinator.CoordinatorEmailPrimary;
                        dtUser = deleteUserData("Coordinator", user);
                        IndexSelected = dgvListCoordinator.CurrentRow.Index;
                        dt.Rows[IndexSelected].Delete();
                        dgvListCoordinator.Refresh();
                        msg = msg + "Coordinator Deactivated! ";
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

                if (dtUser.Rows.Count > 0)
                    msg = msg + "with ID: " + Convert.ToString(dtUser.Rows[0][0]);

                MessageBox.Show(msg);

                //lblNewMessage.Text = msg;
                //btnListEdit.Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.GetType() + ex.Message);
            }
        }
     
    }
}
