namespace BIT.Account
{
    partial class frmNewJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewJob));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNewJobSubmit = new System.Windows.Forms.Button();
            this.btnNewJobLocation = new System.Windows.Forms.Button();
            this.lblNewJobStatus = new System.Windows.Forms.Label();
            this.txtNewJobStartTime = new System.Windows.Forms.TextBox();
            this.txtNewJobJobDate = new System.Windows.Forms.TextBox();
            this.txtNewJobStatus = new System.Windows.Forms.TextBox();
            this.lblNewJobJobDate = new System.Windows.Forms.Label();
            this.lblNewJobStartTime = new System.Windows.Forms.Label();
            this.lblNewJobMinutes = new System.Windows.Forms.Label();
            this.txtNewJobSkillID = new System.Windows.Forms.TextBox();
            this.txtNewJobHours = new System.Windows.Forms.TextBox();
            this.txtNewJobMinutes = new System.Windows.Forms.TextBox();
            this.lblNewJobHours = new System.Windows.Forms.Label();
            this.lblNewJobSkillID = new System.Windows.Forms.Label();
            this.lblNewJobJobID = new System.Windows.Forms.Label();
            this.txtNewJobJobID = new System.Windows.Forms.TextBox();
            this.txtNewJobClientID = new System.Windows.Forms.TextBox();
            this.txtNewJobLocationID = new System.Windows.Forms.TextBox();
            this.lblNewJobClientID = new System.Windows.Forms.Label();
            this.lblNewJobLocationID = new System.Windows.Forms.Label();
            this.lblNewMessage = new System.Windows.Forms.Label();
            this.btnNewClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnNewJobSubmit);
            this.panel1.Controls.Add(this.btnNewJobLocation);
            this.panel1.Controls.Add(this.lblNewJobStatus);
            this.panel1.Controls.Add(this.txtNewJobStartTime);
            this.panel1.Controls.Add(this.txtNewJobJobDate);
            this.panel1.Controls.Add(this.txtNewJobStatus);
            this.panel1.Controls.Add(this.lblNewJobJobDate);
            this.panel1.Controls.Add(this.lblNewJobStartTime);
            this.panel1.Controls.Add(this.lblNewJobMinutes);
            this.panel1.Controls.Add(this.txtNewJobSkillID);
            this.panel1.Controls.Add(this.txtNewJobHours);
            this.panel1.Controls.Add(this.txtNewJobMinutes);
            this.panel1.Controls.Add(this.lblNewJobHours);
            this.panel1.Controls.Add(this.lblNewJobSkillID);
            this.panel1.Controls.Add(this.lblNewJobJobID);
            this.panel1.Controls.Add(this.txtNewJobJobID);
            this.panel1.Controls.Add(this.txtNewJobClientID);
            this.panel1.Controls.Add(this.txtNewJobLocationID);
            this.panel1.Controls.Add(this.lblNewJobClientID);
            this.panel1.Controls.Add(this.lblNewJobLocationID);
            this.panel1.Controls.Add(this.lblNewMessage);
            this.panel1.Location = new System.Drawing.Point(38, 121);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(754, 396);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::BIT.Properties.Resources.jobqueue2;
            this.pictureBox1.Location = new System.Drawing.Point(27, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 52);
            this.pictureBox1.TabIndex = 122;
            this.pictureBox1.TabStop = false;
            // 
            // btnNewJobSubmit
            // 
            this.btnNewJobSubmit.Image = global::BIT.Properties.Resources.submitjobbutton;
            this.btnNewJobSubmit.Location = new System.Drawing.Point(472, 308);
            this.btnNewJobSubmit.Name = "btnNewJobSubmit";
            this.btnNewJobSubmit.Size = new System.Drawing.Size(255, 58);
            this.btnNewJobSubmit.TabIndex = 121;
            this.btnNewJobSubmit.UseVisualStyleBackColor = true;
            // 
            // btnNewJobLocation
            // 
            this.btnNewJobLocation.Image = global::BIT.Properties.Resources.locationbutton;
            this.btnNewJobLocation.Location = new System.Drawing.Point(174, 113);
            this.btnNewJobLocation.Name = "btnNewJobLocation";
            this.btnNewJobLocation.Size = new System.Drawing.Size(177, 64);
            this.btnNewJobLocation.TabIndex = 120;
            this.btnNewJobLocation.UseVisualStyleBackColor = true;
            this.btnNewJobLocation.Click += new System.EventHandler(this.btnNewJobLocation_Click);
            // 
            // lblNewJobStatus
            // 
            this.lblNewJobStatus.AutoSize = true;
            this.lblNewJobStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNewJobStatus.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewJobStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblNewJobStatus.Location = new System.Drawing.Point(475, 242);
            this.lblNewJobStatus.Name = "lblNewJobStatus";
            this.lblNewJobStatus.Size = new System.Drawing.Size(79, 20);
            this.lblNewJobStatus.TabIndex = 118;
            this.lblNewJobStatus.Text = "Status:";
            // 
            // txtNewJobStartTime
            // 
            this.txtNewJobStartTime.Location = new System.Drawing.Point(554, 183);
            this.txtNewJobStartTime.Name = "txtNewJobStartTime";
            this.txtNewJobStartTime.Size = new System.Drawing.Size(173, 28);
            this.txtNewJobStartTime.TabIndex = 108;
            // 
            // txtNewJobJobDate
            // 
            this.txtNewJobJobDate.Location = new System.Drawing.Point(554, 211);
            this.txtNewJobJobDate.Name = "txtNewJobJobDate";
            this.txtNewJobJobDate.Size = new System.Drawing.Size(173, 28);
            this.txtNewJobJobDate.TabIndex = 109;
            // 
            // txtNewJobStatus
            // 
            this.txtNewJobStatus.Location = new System.Drawing.Point(554, 239);
            this.txtNewJobStatus.Name = "txtNewJobStatus";
            this.txtNewJobStatus.Size = new System.Drawing.Size(173, 28);
            this.txtNewJobStatus.TabIndex = 110;
            // 
            // lblNewJobJobDate
            // 
            this.lblNewJobJobDate.AutoSize = true;
            this.lblNewJobJobDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNewJobJobDate.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewJobJobDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblNewJobJobDate.Location = new System.Drawing.Point(455, 216);
            this.lblNewJobJobDate.Name = "lblNewJobJobDate";
            this.lblNewJobJobDate.Size = new System.Drawing.Size(99, 20);
            this.lblNewJobJobDate.TabIndex = 117;
            this.lblNewJobJobDate.Text = "Job Date:";
            // 
            // lblNewJobStartTime
            // 
            this.lblNewJobStartTime.AutoSize = true;
            this.lblNewJobStartTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNewJobStartTime.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewJobStartTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblNewJobStartTime.Location = new System.Drawing.Point(435, 190);
            this.lblNewJobStartTime.Name = "lblNewJobStartTime";
            this.lblNewJobStartTime.Size = new System.Drawing.Size(119, 20);
            this.lblNewJobStartTime.TabIndex = 119;
            this.lblNewJobStartTime.Text = "Start Time:";
            // 
            // lblNewJobMinutes
            // 
            this.lblNewJobMinutes.AutoSize = true;
            this.lblNewJobMinutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNewJobMinutes.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewJobMinutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblNewJobMinutes.Location = new System.Drawing.Point(465, 148);
            this.lblNewJobMinutes.Name = "lblNewJobMinutes";
            this.lblNewJobMinutes.Size = new System.Drawing.Size(89, 20);
            this.lblNewJobMinutes.TabIndex = 115;
            this.lblNewJobMinutes.Text = "Minutes:";
            // 
            // txtNewJobSkillID
            // 
            this.txtNewJobSkillID.Location = new System.Drawing.Point(176, 176);
            this.txtNewJobSkillID.Name = "txtNewJobSkillID";
            this.txtNewJobSkillID.Size = new System.Drawing.Size(173, 28);
            this.txtNewJobSkillID.TabIndex = 105;
            // 
            // txtNewJobHours
            // 
            this.txtNewJobHours.Location = new System.Drawing.Point(554, 113);
            this.txtNewJobHours.Name = "txtNewJobHours";
            this.txtNewJobHours.Size = new System.Drawing.Size(173, 28);
            this.txtNewJobHours.TabIndex = 106;
            // 
            // txtNewJobMinutes
            // 
            this.txtNewJobMinutes.Location = new System.Drawing.Point(554, 141);
            this.txtNewJobMinutes.Name = "txtNewJobMinutes";
            this.txtNewJobMinutes.Size = new System.Drawing.Size(173, 28);
            this.txtNewJobMinutes.TabIndex = 107;
            // 
            // lblNewJobHours
            // 
            this.lblNewJobHours.AutoSize = true;
            this.lblNewJobHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNewJobHours.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewJobHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblNewJobHours.Location = new System.Drawing.Point(485, 120);
            this.lblNewJobHours.Name = "lblNewJobHours";
            this.lblNewJobHours.Size = new System.Drawing.Size(69, 20);
            this.lblNewJobHours.TabIndex = 114;
            this.lblNewJobHours.Text = "Hours:";
            // 
            // lblNewJobSkillID
            // 
            this.lblNewJobSkillID.AutoSize = true;
            this.lblNewJobSkillID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNewJobSkillID.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewJobSkillID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblNewJobSkillID.Location = new System.Drawing.Point(107, 184);
            this.lblNewJobSkillID.Name = "lblNewJobSkillID";
            this.lblNewJobSkillID.Size = new System.Drawing.Size(69, 20);
            this.lblNewJobSkillID.TabIndex = 116;
            this.lblNewJobSkillID.Text = "Skill:";
            // 
            // lblNewJobJobID
            // 
            this.lblNewJobJobID.AutoSize = true;
            this.lblNewJobJobID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNewJobJobID.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewJobJobID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblNewJobJobID.Location = new System.Drawing.Point(107, 93);
            this.lblNewJobJobID.Name = "lblNewJobJobID";
            this.lblNewJobJobID.Size = new System.Drawing.Size(69, 20);
            this.lblNewJobJobID.TabIndex = 112;
            this.lblNewJobJobID.Text = "Job #:";
            // 
            // txtNewJobJobID
            // 
            this.txtNewJobJobID.Location = new System.Drawing.Point(176, 85);
            this.txtNewJobJobID.Name = "txtNewJobJobID";
            this.txtNewJobJobID.Size = new System.Drawing.Size(173, 28);
            this.txtNewJobJobID.TabIndex = 102;
            // 
            // txtNewJobClientID
            // 
            this.txtNewJobClientID.Location = new System.Drawing.Point(176, 204);
            this.txtNewJobClientID.Name = "txtNewJobClientID";
            this.txtNewJobClientID.Size = new System.Drawing.Size(173, 28);
            this.txtNewJobClientID.TabIndex = 103;
            // 
            // txtNewJobLocationID
            // 
            this.txtNewJobLocationID.Location = new System.Drawing.Point(355, 142);
            this.txtNewJobLocationID.Name = "txtNewJobLocationID";
            this.txtNewJobLocationID.Size = new System.Drawing.Size(30, 28);
            this.txtNewJobLocationID.TabIndex = 104;
            this.txtNewJobLocationID.Visible = false;
            // 
            // lblNewJobClientID
            // 
            this.lblNewJobClientID.AutoSize = true;
            this.lblNewJobClientID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNewJobClientID.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewJobClientID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblNewJobClientID.Location = new System.Drawing.Point(97, 212);
            this.lblNewJobClientID.Name = "lblNewJobClientID";
            this.lblNewJobClientID.Size = new System.Drawing.Size(79, 20);
            this.lblNewJobClientID.TabIndex = 111;
            this.lblNewJobClientID.Text = "Client:";
            // 
            // lblNewJobLocationID
            // 
            this.lblNewJobLocationID.AutoSize = true;
            this.lblNewJobLocationID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNewJobLocationID.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewJobLocationID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblNewJobLocationID.Location = new System.Drawing.Point(77, 155);
            this.lblNewJobLocationID.Name = "lblNewJobLocationID";
            this.lblNewJobLocationID.Size = new System.Drawing.Size(99, 20);
            this.lblNewJobLocationID.TabIndex = 113;
            this.lblNewJobLocationID.Text = "Location:";
            // 
            // lblNewMessage
            // 
            this.lblNewMessage.AutoSize = true;
            this.lblNewMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNewMessage.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewMessage.ForeColor = System.Drawing.Color.Red;
            this.lblNewMessage.Location = new System.Drawing.Point(21, 40);
            this.lblNewMessage.Name = "lblNewMessage";
            this.lblNewMessage.Size = new System.Drawing.Size(0, 20);
            this.lblNewMessage.TabIndex = 15;
            // 
            // btnNewClose
            // 
            this.btnNewClose.Image = global::BIT.Properties.Resources.closebutton;
            this.btnNewClose.Location = new System.Drawing.Point(665, 554);
            this.btnNewClose.Name = "btnNewClose";
            this.btnNewClose.Size = new System.Drawing.Size(127, 40);
            this.btnNewClose.TabIndex = 7;
            this.btnNewClose.UseVisualStyleBackColor = true;
            this.btnNewClose.Click += new System.EventHandler(this.btnNewClose_Click);
            // 
            // frmNewJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 608);
            this.Controls.Add(this.btnNewClose);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNewJob";
            this.Opacity = 0.9D;
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Job Queue";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNewMessage;
        private System.Windows.Forms.Label lblNewJobStatus;
        private System.Windows.Forms.TextBox txtNewJobStartTime;
        private System.Windows.Forms.TextBox txtNewJobJobDate;
        private System.Windows.Forms.TextBox txtNewJobStatus;
        private System.Windows.Forms.Label lblNewJobJobDate;
        private System.Windows.Forms.Label lblNewJobStartTime;
        private System.Windows.Forms.Label lblNewJobMinutes;
        private System.Windows.Forms.TextBox txtNewJobSkillID;
        private System.Windows.Forms.TextBox txtNewJobHours;
        private System.Windows.Forms.TextBox txtNewJobMinutes;
        private System.Windows.Forms.Label lblNewJobHours;
        private System.Windows.Forms.Label lblNewJobSkillID;
        private System.Windows.Forms.Label lblNewJobJobID;
        private System.Windows.Forms.TextBox txtNewJobJobID;
        private System.Windows.Forms.TextBox txtNewJobClientID;
        private System.Windows.Forms.TextBox txtNewJobLocationID;
        private System.Windows.Forms.Label lblNewJobClientID;
        private System.Windows.Forms.Label lblNewJobLocationID;
        private System.Windows.Forms.Button btnNewJobLocation;
        private System.Windows.Forms.Button btnNewClose;
        private System.Windows.Forms.Button btnNewJobSubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}