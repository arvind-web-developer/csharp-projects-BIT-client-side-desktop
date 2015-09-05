namespace BIT
{
    partial class frmList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmList));
            this.btnListClose = new System.Windows.Forms.Button();
            this.tabPageListJob = new System.Windows.Forms.TabPage();
            this.dgvListJob = new System.Windows.Forms.DataGridView();
            this.tabPageListRequest = new System.Windows.Forms.TabPage();
            this.dgvListRequest = new System.Windows.Forms.DataGridView();
            this.tabPageListCoordinator = new System.Windows.Forms.TabPage();
            this.dgvListCoordinator = new System.Windows.Forms.DataGridView();
            this.tabPageListContractor = new System.Windows.Forms.TabPage();
            this.dgvListContractor = new System.Windows.Forms.DataGridView();
            this.tabPageListClient = new System.Windows.Forms.TabPage();
            this.dgvListClient = new System.Windows.Forms.DataGridView();
            this.tabControlList = new System.Windows.Forms.TabControl();
            this.tabPageListContractorSkill = new System.Windows.Forms.TabPage();
            this.dgvListContractorSkill_2 = new System.Windows.Forms.DataGridView();
            this.dgvListContractorSkill_1 = new System.Windows.Forms.DataGridView();
            this.tabPageListSkill = new System.Windows.Forms.TabPage();
            this.dgvListSkill = new System.Windows.Forms.DataGridView();
            this.imageListTabIcons = new System.Windows.Forms.ImageList(this.components);
            this.btnListEdit = new System.Windows.Forms.Button();
            this.btnListDelete = new System.Windows.Forms.Button();
            this.tabPageListJob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListJob)).BeginInit();
            this.tabPageListRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRequest)).BeginInit();
            this.tabPageListCoordinator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCoordinator)).BeginInit();
            this.tabPageListContractor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListContractor)).BeginInit();
            this.tabPageListClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListClient)).BeginInit();
            this.tabControlList.SuspendLayout();
            this.tabPageListContractorSkill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListContractorSkill_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListContractorSkill_1)).BeginInit();
            this.tabPageListSkill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSkill)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListClose
            // 
            this.btnListClose.Image = global::BIT.Properties.Resources.closebutton;
            this.btnListClose.Location = new System.Drawing.Point(870, 537);
            this.btnListClose.Name = "btnListClose";
            this.btnListClose.Size = new System.Drawing.Size(127, 40);
            this.btnListClose.TabIndex = 1;
            this.btnListClose.UseVisualStyleBackColor = true;
            this.btnListClose.Click += new System.EventHandler(this.btnListClose_Click);
            // 
            // tabPageListJob
            // 
            this.tabPageListJob.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPageListJob.Controls.Add(this.dgvListJob);
            this.tabPageListJob.ImageKey = "job.png";
            this.tabPageListJob.Location = new System.Drawing.Point(4, 29);
            this.tabPageListJob.Name = "tabPageListJob";
            this.tabPageListJob.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListJob.Size = new System.Drawing.Size(949, 366);
            this.tabPageListJob.TabIndex = 4;
            this.tabPageListJob.Text = "Job";
            // 
            // dgvListJob
            // 
            this.dgvListJob.AllowUserToAddRows = false;
            this.dgvListJob.AllowUserToDeleteRows = false;
            this.dgvListJob.AllowUserToResizeColumns = false;
            this.dgvListJob.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvListJob.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListJob.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListJob.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvListJob.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListJob.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvListJob.ColumnHeadersHeight = 40;
            this.dgvListJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListJob.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvListJob.Location = new System.Drawing.Point(2, 1);
            this.dgvListJob.Name = "dgvListJob";
            this.dgvListJob.RowHeadersVisible = false;
            this.dgvListJob.RowTemplate.Height = 24;
            this.dgvListJob.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListJob.Size = new System.Drawing.Size(944, 366);
            this.dgvListJob.TabIndex = 0;
            // 
            // tabPageListRequest
            // 
            this.tabPageListRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tabPageListRequest.Controls.Add(this.dgvListRequest);
            this.tabPageListRequest.ImageKey = "request.png";
            this.tabPageListRequest.Location = new System.Drawing.Point(4, 29);
            this.tabPageListRequest.Name = "tabPageListRequest";
            this.tabPageListRequest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListRequest.Size = new System.Drawing.Size(949, 366);
            this.tabPageListRequest.TabIndex = 3;
            this.tabPageListRequest.Text = "Request";
            // 
            // dgvListRequest
            // 
            this.dgvListRequest.AllowUserToAddRows = false;
            this.dgvListRequest.AllowUserToDeleteRows = false;
            this.dgvListRequest.AllowUserToResizeColumns = false;
            this.dgvListRequest.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvListRequest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListRequest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvListRequest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListRequest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListRequest.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvListRequest.ColumnHeadersHeight = 40;
            this.dgvListRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListRequest.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvListRequest.Location = new System.Drawing.Point(3, 6);
            this.dgvListRequest.Name = "dgvListRequest";
            this.dgvListRequest.ReadOnly = true;
            this.dgvListRequest.RowHeadersVisible = false;
            this.dgvListRequest.RowTemplate.Height = 24;
            this.dgvListRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListRequest.Size = new System.Drawing.Size(940, 354);
            this.dgvListRequest.TabIndex = 0;
            // 
            // tabPageListCoordinator
            // 
            this.tabPageListCoordinator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tabPageListCoordinator.Controls.Add(this.dgvListCoordinator);
            this.tabPageListCoordinator.ImageKey = "coordinator.png";
            this.tabPageListCoordinator.Location = new System.Drawing.Point(4, 29);
            this.tabPageListCoordinator.Name = "tabPageListCoordinator";
            this.tabPageListCoordinator.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListCoordinator.Size = new System.Drawing.Size(949, 366);
            this.tabPageListCoordinator.TabIndex = 2;
            this.tabPageListCoordinator.Text = "Coordinator";
            // 
            // dgvListCoordinator
            // 
            this.dgvListCoordinator.AllowUserToAddRows = false;
            this.dgvListCoordinator.AllowUserToDeleteRows = false;
            this.dgvListCoordinator.AllowUserToResizeColumns = false;
            this.dgvListCoordinator.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvListCoordinator.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListCoordinator.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListCoordinator.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvListCoordinator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListCoordinator.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListCoordinator.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvListCoordinator.ColumnHeadersHeight = 40;
            this.dgvListCoordinator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListCoordinator.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvListCoordinator.Location = new System.Drawing.Point(3, 6);
            this.dgvListCoordinator.Name = "dgvListCoordinator";
            this.dgvListCoordinator.ReadOnly = true;
            this.dgvListCoordinator.RowHeadersVisible = false;
            this.dgvListCoordinator.RowTemplate.Height = 24;
            this.dgvListCoordinator.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListCoordinator.Size = new System.Drawing.Size(940, 357);
            this.dgvListCoordinator.TabIndex = 0;
            this.dgvListCoordinator.SelectionChanged += new System.EventHandler(this.dgvListCoordinator_SelectionChanged);
            // 
            // tabPageListContractor
            // 
            this.tabPageListContractor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tabPageListContractor.Controls.Add(this.dgvListContractor);
            this.tabPageListContractor.ImageKey = "contractor.png";
            this.tabPageListContractor.Location = new System.Drawing.Point(4, 29);
            this.tabPageListContractor.Name = "tabPageListContractor";
            this.tabPageListContractor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListContractor.Size = new System.Drawing.Size(949, 366);
            this.tabPageListContractor.TabIndex = 1;
            this.tabPageListContractor.Text = "Contractor";
            // 
            // dgvListContractor
            // 
            this.dgvListContractor.AllowUserToAddRows = false;
            this.dgvListContractor.AllowUserToDeleteRows = false;
            this.dgvListContractor.AllowUserToResizeColumns = false;
            this.dgvListContractor.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvListContractor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListContractor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListContractor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvListContractor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListContractor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListContractor.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvListContractor.ColumnHeadersHeight = 40;
            this.dgvListContractor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListContractor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvListContractor.Location = new System.Drawing.Point(6, 3);
            this.dgvListContractor.Name = "dgvListContractor";
            this.dgvListContractor.ReadOnly = true;
            this.dgvListContractor.RowHeadersVisible = false;
            this.dgvListContractor.RowTemplate.Height = 24;
            this.dgvListContractor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListContractor.Size = new System.Drawing.Size(937, 359);
            this.dgvListContractor.TabIndex = 0;
            this.dgvListContractor.SelectionChanged += new System.EventHandler(this.dgvListContractor_SelectionChanged);
            // 
            // tabPageListClient
            // 
            this.tabPageListClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tabPageListClient.Controls.Add(this.dgvListClient);
            this.tabPageListClient.ImageKey = "client.png";
            this.tabPageListClient.Location = new System.Drawing.Point(4, 29);
            this.tabPageListClient.Name = "tabPageListClient";
            this.tabPageListClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListClient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPageListClient.Size = new System.Drawing.Size(949, 366);
            this.tabPageListClient.TabIndex = 0;
            this.tabPageListClient.Text = "Client";
            // 
            // dgvListClient
            // 
            this.dgvListClient.AllowUserToAddRows = false;
            this.dgvListClient.AllowUserToDeleteRows = false;
            this.dgvListClient.AllowUserToResizeColumns = false;
            this.dgvListClient.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvListClient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListClient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvListClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListClient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListClient.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvListClient.ColumnHeadersHeight = 40;
            this.dgvListClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListClient.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListClient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvListClient.Location = new System.Drawing.Point(3, 6);
            this.dgvListClient.Name = "dgvListClient";
            this.dgvListClient.ReadOnly = true;
            this.dgvListClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvListClient.RowHeadersVisible = false;
            this.dgvListClient.RowTemplate.Height = 24;
            this.dgvListClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListClient.Size = new System.Drawing.Size(940, 354);
            this.dgvListClient.TabIndex = 0;
            this.dgvListClient.SelectionChanged += new System.EventHandler(this.dgvListClient_SelectionChanged);
            // 
            // tabControlList
            // 
            this.tabControlList.Controls.Add(this.tabPageListClient);
            this.tabControlList.Controls.Add(this.tabPageListContractor);
            this.tabControlList.Controls.Add(this.tabPageListCoordinator);
            this.tabControlList.Controls.Add(this.tabPageListRequest);
            this.tabControlList.Controls.Add(this.tabPageListJob);
            this.tabControlList.Controls.Add(this.tabPageListContractorSkill);
            this.tabControlList.Controls.Add(this.tabPageListSkill);
            this.tabControlList.ImageList = this.imageListTabIcons;
            this.tabControlList.Location = new System.Drawing.Point(40, 123);
            this.tabControlList.Name = "tabControlList";
            this.tabControlList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControlList.SelectedIndex = 0;
            this.tabControlList.Size = new System.Drawing.Size(957, 399);
            this.tabControlList.TabIndex = 0;
            // 
            // tabPageListContractorSkill
            // 
            this.tabPageListContractorSkill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tabPageListContractorSkill.Controls.Add(this.dgvListContractorSkill_2);
            this.tabPageListContractorSkill.Controls.Add(this.dgvListContractorSkill_1);
            this.tabPageListContractorSkill.ImageKey = "contractorskill.png";
            this.tabPageListContractorSkill.Location = new System.Drawing.Point(4, 29);
            this.tabPageListContractorSkill.Name = "tabPageListContractorSkill";
            this.tabPageListContractorSkill.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListContractorSkill.Size = new System.Drawing.Size(949, 366);
            this.tabPageListContractorSkill.TabIndex = 5;
            this.tabPageListContractorSkill.Text = "ContractorSkill";
            // 
            // dgvListContractorSkill_2
            // 
            this.dgvListContractorSkill_2.AllowUserToAddRows = false;
            this.dgvListContractorSkill_2.AllowUserToDeleteRows = false;
            this.dgvListContractorSkill_2.AllowUserToResizeColumns = false;
            this.dgvListContractorSkill_2.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGray;
            this.dgvListContractorSkill_2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvListContractorSkill_2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvListContractorSkill_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListContractorSkill_2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListContractorSkill_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListContractorSkill_2.ColumnHeadersVisible = false;
            this.dgvListContractorSkill_2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvListContractorSkill_2.Location = new System.Drawing.Point(422, 51);
            this.dgvListContractorSkill_2.Name = "dgvListContractorSkill_2";
            this.dgvListContractorSkill_2.ReadOnly = true;
            this.dgvListContractorSkill_2.RowHeadersVisible = false;
            this.dgvListContractorSkill_2.RowTemplate.Height = 24;
            this.dgvListContractorSkill_2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvListContractorSkill_2.Size = new System.Drawing.Size(290, 233);
            this.dgvListContractorSkill_2.TabIndex = 1;
            // 
            // dgvListContractorSkill_1
            // 
            this.dgvListContractorSkill_1.AllowUserToAddRows = false;
            this.dgvListContractorSkill_1.AllowUserToDeleteRows = false;
            this.dgvListContractorSkill_1.AllowUserToResizeColumns = false;
            this.dgvListContractorSkill_1.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightGray;
            this.dgvListContractorSkill_1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvListContractorSkill_1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListContractorSkill_1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvListContractorSkill_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListContractorSkill_1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListContractorSkill_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListContractorSkill_1.ColumnHeadersVisible = false;
            this.dgvListContractorSkill_1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvListContractorSkill_1.Location = new System.Drawing.Point(54, 51);
            this.dgvListContractorSkill_1.Name = "dgvListContractorSkill_1";
            this.dgvListContractorSkill_1.ReadOnly = true;
            this.dgvListContractorSkill_1.RowHeadersVisible = false;
            this.dgvListContractorSkill_1.RowTemplate.Height = 24;
            this.dgvListContractorSkill_1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvListContractorSkill_1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListContractorSkill_1.Size = new System.Drawing.Size(290, 233);
            this.dgvListContractorSkill_1.TabIndex = 0;
            this.dgvListContractorSkill_1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListContractorSkill_1_CellContentClick);
            // 
            // tabPageListSkill
            // 
            this.tabPageListSkill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tabPageListSkill.Controls.Add(this.dgvListSkill);
            this.tabPageListSkill.ImageKey = "skill.png";
            this.tabPageListSkill.Location = new System.Drawing.Point(4, 29);
            this.tabPageListSkill.Name = "tabPageListSkill";
            this.tabPageListSkill.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListSkill.Size = new System.Drawing.Size(949, 366);
            this.tabPageListSkill.TabIndex = 6;
            this.tabPageListSkill.Text = "Skill";
            // 
            // dgvListSkill
            // 
            this.dgvListSkill.AllowUserToAddRows = false;
            this.dgvListSkill.AllowUserToDeleteRows = false;
            this.dgvListSkill.AllowUserToResizeColumns = false;
            this.dgvListSkill.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvListSkill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvListSkill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListSkill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvListSkill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListSkill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListSkill.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvListSkill.ColumnHeadersHeight = 40;
            this.dgvListSkill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListSkill.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListSkill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvListSkill.Location = new System.Drawing.Point(3, 6);
            this.dgvListSkill.Name = "dgvListSkill";
            this.dgvListSkill.ReadOnly = true;
            this.dgvListSkill.RowHeadersVisible = false;
            this.dgvListSkill.RowHeadersWidth = 40;
            this.dgvListSkill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListSkill.RowTemplate.Height = 24;
            this.dgvListSkill.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvListSkill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListSkill.Size = new System.Drawing.Size(940, 357);
            this.dgvListSkill.TabIndex = 2;
            // 
            // imageListTabIcons
            // 
            this.imageListTabIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTabIcons.ImageStream")));
            this.imageListTabIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTabIcons.Images.SetKeyName(0, "client.png");
            this.imageListTabIcons.Images.SetKeyName(1, "contractor.png");
            this.imageListTabIcons.Images.SetKeyName(2, "coordinator.png");
            this.imageListTabIcons.Images.SetKeyName(3, "request.png");
            this.imageListTabIcons.Images.SetKeyName(4, "job.png");
            this.imageListTabIcons.Images.SetKeyName(5, "contractorskill.png");
            this.imageListTabIcons.Images.SetKeyName(6, "skill.png");
            // 
            // btnListEdit
            // 
            this.btnListEdit.Image = global::BIT.Properties.Resources.editbutton;
            this.btnListEdit.Location = new System.Drawing.Point(737, 537);
            this.btnListEdit.Name = "btnListEdit";
            this.btnListEdit.Size = new System.Drawing.Size(127, 40);
            this.btnListEdit.TabIndex = 2;
            this.btnListEdit.UseVisualStyleBackColor = true;
            this.btnListEdit.Click += new System.EventHandler(this.btnListEdit_Click);
            // 
            // btnListDelete
            // 
            this.btnListDelete.Image = global::BIT.Properties.Resources.deletebutton;
            this.btnListDelete.Location = new System.Drawing.Point(40, 537);
            this.btnListDelete.Name = "btnListDelete";
            this.btnListDelete.Size = new System.Drawing.Size(127, 40);
            this.btnListDelete.TabIndex = 3;
            this.btnListDelete.UseVisualStyleBackColor = true;
            this.btnListDelete.Click += new System.EventHandler(this.btnListDelete_Click);
            // 
            // frmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BIT.Properties.Resources.list;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1053, 592);
            this.ControlBox = false;
            this.Controls.Add(this.btnListDelete);
            this.Controls.Add(this.btnListEdit);
            this.Controls.Add(this.btnListClose);
            this.Controls.Add(this.tabControlList);
            this.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmList";
            this.Opacity = 0.95D;
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "List All Objects";
            this.Load += new System.EventHandler(this.frmList_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmList_KeyUp);
            this.tabPageListJob.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListJob)).EndInit();
            this.tabPageListRequest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRequest)).EndInit();
            this.tabPageListCoordinator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCoordinator)).EndInit();
            this.tabPageListContractor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListContractor)).EndInit();
            this.tabPageListClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListClient)).EndInit();
            this.tabControlList.ResumeLayout(false);
            this.tabPageListContractorSkill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListContractorSkill_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListContractorSkill_1)).EndInit();
            this.tabPageListSkill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSkill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListClose;
        private System.Windows.Forms.TabPage tabPageListJob;
        private System.Windows.Forms.DataGridView dgvListJob;
        private System.Windows.Forms.TabPage tabPageListRequest;
        private System.Windows.Forms.DataGridView dgvListRequest;
        private System.Windows.Forms.TabPage tabPageListCoordinator;
        private System.Windows.Forms.DataGridView dgvListCoordinator;
        private System.Windows.Forms.TabPage tabPageListContractor;
        private System.Windows.Forms.DataGridView dgvListContractor;
        private System.Windows.Forms.TabPage tabPageListClient;
        private System.Windows.Forms.DataGridView dgvListClient;
        private System.Windows.Forms.TabControl tabControlList;
        private System.Windows.Forms.TabPage tabPageListContractorSkill;
        private System.Windows.Forms.TabPage tabPageListSkill;
        private System.Windows.Forms.DataGridView dgvListContractorSkill_1;
        private System.Windows.Forms.DataGridView dgvListContractorSkill_2;
        private System.Windows.Forms.DataGridView dgvListSkill;
        private System.Windows.Forms.ImageList imageListTabIcons;
        private System.Windows.Forms.Button btnListEdit;
        private System.Windows.Forms.Button btnListDelete;
    }
}