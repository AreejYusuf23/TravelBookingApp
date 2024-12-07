namespace TravelBookingApp
{
    partial class UserManagmentListAdmin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FisrtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupAdminAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destinationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postUpcomingFlightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.FisrtName,
            this.Type});
            this.dataGridView1.Location = new System.Drawing.Point(222, 178);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(515, 231);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UserID
            // 
            this.UserID.HeaderText = "User ID";
            this.UserID.MinimumWidth = 8;
            this.UserID.Name = "UserID";
            this.UserID.Width = 150;
            // 
            // FisrtName
            // 
            this.FisrtName.HeaderText = "First Name";
            this.FisrtName.MinimumWidth = 8;
            this.FisrtName.Name = "FisrtName";
            this.FisrtName.Width = 150;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 8;
            this.Type.Name = "Type";
            this.Type.Width = 150;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.destinationsToolStripMenuItem,
            this.flightsToolStripMenuItem,
            this.systemToolStripMenuItem,
            this.servicesToolStripMenuItem,
            this.messagesToolStripMenuItem,
            this.bookingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(957, 87);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "NavigationBar";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 83);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageProfilesToolStripMenuItem,
            this.setupAdminAccountsToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(71, 83);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // manageProfilesToolStripMenuItem
            // 
            this.manageProfilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfUsersToolStripMenuItem,
            this.addUseToolStripMenuItem,
            this.deleteUserToolStripMenuItem,
            this.editUserToolStripMenuItem});
            this.manageProfilesToolStripMenuItem.Name = "manageProfilesToolStripMenuItem";
            this.manageProfilesToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.manageProfilesToolStripMenuItem.Text = "Manage Profiles";
            this.manageProfilesToolStripMenuItem.Click += new System.EventHandler(this.manageProfilesToolStripMenuItem_Click);
            // 
            // listOfUsersToolStripMenuItem
            // 
            this.listOfUsersToolStripMenuItem.Name = "listOfUsersToolStripMenuItem";
            this.listOfUsersToolStripMenuItem.Size = new System.Drawing.Size(210, 34);
            this.listOfUsersToolStripMenuItem.Text = "List of Users";
            // 
            // addUseToolStripMenuItem
            // 
            this.addUseToolStripMenuItem.Name = "addUseToolStripMenuItem";
            this.addUseToolStripMenuItem.Size = new System.Drawing.Size(210, 34);
            this.addUseToolStripMenuItem.Text = "Add User";
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(210, 34);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(210, 34);
            this.editUserToolStripMenuItem.Text = "Edit User";
            // 
            // setupAdminAccountsToolStripMenuItem
            // 
            this.setupAdminAccountsToolStripMenuItem.Name = "setupAdminAccountsToolStripMenuItem";
            this.setupAdminAccountsToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.setupAdminAccountsToolStripMenuItem.Text = "Setup Admin Accounts";
            // 
            // destinationsToolStripMenuItem
            // 
            this.destinationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageCategoriesToolStripMenuItem});
            this.destinationsToolStripMenuItem.Name = "destinationsToolStripMenuItem";
            this.destinationsToolStripMenuItem.Size = new System.Drawing.Size(126, 83);
            this.destinationsToolStripMenuItem.Text = "Destinations";
            // 
            // manageCategoriesToolStripMenuItem
            // 
            this.manageCategoriesToolStripMenuItem.Name = "manageCategoriesToolStripMenuItem";
            this.manageCategoriesToolStripMenuItem.Size = new System.Drawing.Size(267, 34);
            this.manageCategoriesToolStripMenuItem.Text = "Manage Categories";
            this.manageCategoriesToolStripMenuItem.Click += new System.EventHandler(this.manageCategoriesToolStripMenuItem_Click);
            // 
            // flightsToolStripMenuItem
            // 
            this.flightsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.postUpcomingFlightsToolStripMenuItem,
            this.manageBookingsToolStripMenuItem});
            this.flightsToolStripMenuItem.Name = "flightsToolStripMenuItem";
            this.flightsToolStripMenuItem.Size = new System.Drawing.Size(80, 83);
            this.flightsToolStripMenuItem.Text = "Flights";
            // 
            // postUpcomingFlightsToolStripMenuItem
            // 
            this.postUpcomingFlightsToolStripMenuItem.Name = "postUpcomingFlightsToolStripMenuItem";
            this.postUpcomingFlightsToolStripMenuItem.Size = new System.Drawing.Size(293, 34);
            this.postUpcomingFlightsToolStripMenuItem.Text = "Post Upcoming Flights";
            this.postUpcomingFlightsToolStripMenuItem.Click += new System.EventHandler(this.postUpcomingFlightsToolStripMenuItem_Click);
            // 
            // manageBookingsToolStripMenuItem
            // 
            this.manageBookingsToolStripMenuItem.Name = "manageBookingsToolStripMenuItem";
            this.manageBookingsToolStripMenuItem.Size = new System.Drawing.Size(293, 34);
            this.manageBookingsToolStripMenuItem.Text = "Manage Bookings";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupDatabaseToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(85, 83);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // backupDatabaseToolStripMenuItem
            // 
            this.backupDatabaseToolStripMenuItem.Name = "backupDatabaseToolStripMenuItem";
            this.backupDatabaseToolStripMenuItem.Size = new System.Drawing.Size(250, 34);
            this.backupDatabaseToolStripMenuItem.Text = "Backup Database";
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addServiceToolStripMenuItem,
            this.removeServiceToolStripMenuItem});
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(91, 83);
            this.servicesToolStripMenuItem.Text = "Services";
            // 
            // addServiceToolStripMenuItem
            // 
            this.addServiceToolStripMenuItem.Name = "addServiceToolStripMenuItem";
            this.addServiceToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.addServiceToolStripMenuItem.Text = "Add Service";
            this.addServiceToolStripMenuItem.Click += new System.EventHandler(this.addServiceToolStripMenuItem_Click);
            // 
            // removeServiceToolStripMenuItem
            // 
            this.removeServiceToolStripMenuItem.Name = "removeServiceToolStripMenuItem";
            this.removeServiceToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.removeServiceToolStripMenuItem.Text = "Remove Service";
            // 
            // messagesToolStripMenuItem
            // 
            this.messagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendMessageToolStripMenuItem,
            this.inboxToolStripMenuItem});
            this.messagesToolStripMenuItem.Name = "messagesToolStripMenuItem";
            this.messagesToolStripMenuItem.Size = new System.Drawing.Size(106, 83);
            this.messagesToolStripMenuItem.Text = "Messages";
            // 
            // sendMessageToolStripMenuItem
            // 
            this.sendMessageToolStripMenuItem.Name = "sendMessageToolStripMenuItem";
            this.sendMessageToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.sendMessageToolStripMenuItem.Text = "Send Message";
            this.sendMessageToolStripMenuItem.Click += new System.EventHandler(this.sendMessageToolStripMenuItem_Click);
            // 
            // inboxToolStripMenuItem
            // 
            this.inboxToolStripMenuItem.Name = "inboxToolStripMenuItem";
            this.inboxToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.inboxToolStripMenuItem.Text = "Inbox";
            this.inboxToolStripMenuItem.Click += new System.EventHandler(this.inboxToolStripMenuItem_Click);
            // 
            // bookingsToolStripMenuItem
            // 
            this.bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            this.bookingsToolStripMenuItem.Size = new System.Drawing.Size(102, 83);
            this.bookingsToolStripMenuItem.Text = "Bookings";
            this.bookingsToolStripMenuItem.Click += new System.EventHandler(this.bookingsToolStripMenuItem_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(778, 115);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(146, 35);
            this.button7.TabIndex = 43;
            this.button7.Text = "Manage User";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // UserManagmentListAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 574);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserManagmentListAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserManagmentListAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FisrtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destinationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupAdminAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postUpcomingFlightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.Button button7;
    }
}