
namespace Capitol.FaceRecApp.FrontEnd.Views
{
    partial class AdministratorView
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
            this.MainFaceView = new Neurotec.Biometrics.Gui.NFaceView();
            this.TbEmployeeId = new System.Windows.Forms.TextBox();
            this.BtnCapture = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LbCaptureStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAdminUsers = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSaveUsers = new System.Windows.Forms.Button();
            this.BtnDeleteSelected = new System.Windows.Forms.Button();
            this.BtnReload = new System.Windows.Forms.Button();
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminUsers)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFaceView
            // 
            this.MainFaceView.BackColor = System.Drawing.Color.Black;
            this.MainFaceView.Face = null;
            this.MainFaceView.FaceIds = null;
            this.MainFaceView.IcaoArrowsColor = System.Drawing.Color.Red;
            this.MainFaceView.Location = new System.Drawing.Point(5, 46);
            this.MainFaceView.Margin = new System.Windows.Forms.Padding(2);
            this.MainFaceView.Name = "MainFaceView";
            this.MainFaceView.ShowIcaoArrows = true;
            this.MainFaceView.ShowTokenImageRectangle = true;
            this.MainFaceView.Size = new System.Drawing.Size(460, 284);
            this.MainFaceView.TabIndex = 19;
            this.MainFaceView.TokenImageRectangleColor = System.Drawing.Color.White;
            // 
            // TbEmployeeId
            // 
            this.TbEmployeeId.Location = new System.Drawing.Point(128, 337);
            this.TbEmployeeId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TbEmployeeId.Name = "TbEmployeeId";
            this.TbEmployeeId.Size = new System.Drawing.Size(173, 29);
            this.TbEmployeeId.TabIndex = 20;
            // 
            // BtnCapture
            // 
            this.BtnCapture.Location = new System.Drawing.Point(351, 337);
            this.BtnCapture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCapture.Name = "BtnCapture";
            this.BtnCapture.Size = new System.Drawing.Size(112, 37);
            this.BtnCapture.TabIndex = 21;
            this.BtnCapture.Text = "Capture";
            this.BtnCapture.UseVisualStyleBackColor = true;
            this.BtnCapture.Click += new System.EventHandler(this.BtnCapture_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(351, 418);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(112, 37);
            this.BtnSave.TabIndex = 22;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSaveFaceSubject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 342);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Employee Id:";
            // 
            // LbCaptureStatus
            // 
            this.LbCaptureStatus.AutoSize = true;
            this.LbCaptureStatus.Location = new System.Drawing.Point(123, 374);
            this.LbCaptureStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbCaptureStatus.Name = "LbCaptureStatus";
            this.LbCaptureStatus.Size = new System.Drawing.Size(30, 21);
            this.LbCaptureStatus.TabIndex = 24;
            this.LbCaptureStatus.Text = "Ok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 30);
            this.label2.TabIndex = 25;
            this.label2.Text = "Face Enrollment";
            // 
            // dgvAdminUsers
            // 
            this.dgvAdminUsers.AllowUserToDeleteRows = false;
            this.dgvAdminUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clUser,
            this.clDateAdded});
            this.dgvAdminUsers.Location = new System.Drawing.Point(12, 58);
            this.dgvAdminUsers.MultiSelect = false;
            this.dgvAdminUsers.Name = "dgvAdminUsers";
            this.dgvAdminUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdminUsers.Size = new System.Drawing.Size(441, 361);
            this.dgvAdminUsers.TabIndex = 27;
            // 
            // clId
            // 
            this.clId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clId.DataPropertyName = "Id";
            this.clId.HeaderText = "Id";
            this.clId.Name = "clId";
            this.clId.ReadOnly = true;
            this.clId.Width = 48;
            // 
            // clUser
            // 
            this.clUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clUser.DataPropertyName = "EEId";
            this.clUser.HeaderText = "EE Id";
            this.clUser.Name = "clUser";
            // 
            // clDateAdded
            // 
            this.clDateAdded.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clDateAdded.DataPropertyName = "DateAdded";
            this.clDateAdded.HeaderText = "Date Added";
            this.clDateAdded.Name = "clDateAdded";
            this.clDateAdded.ReadOnly = true;
            this.clDateAdded.Width = 116;
            // 
            // BtnSaveUsers
            // 
            this.BtnSaveUsers.Location = new System.Drawing.Point(322, 427);
            this.BtnSaveUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSaveUsers.Name = "BtnSaveUsers";
            this.BtnSaveUsers.Size = new System.Drawing.Size(131, 37);
            this.BtnSaveUsers.TabIndex = 28;
            this.BtnSaveUsers.Text = "Save";
            this.BtnSaveUsers.UseVisualStyleBackColor = true;
            this.BtnSaveUsers.Click += new System.EventHandler(this.BtnSaveUsers_Click);
            // 
            // BtnDeleteSelected
            // 
            this.BtnDeleteSelected.Location = new System.Drawing.Point(178, 427);
            this.BtnDeleteSelected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDeleteSelected.Name = "BtnDeleteSelected";
            this.BtnDeleteSelected.Size = new System.Drawing.Size(136, 37);
            this.BtnDeleteSelected.TabIndex = 29;
            this.BtnDeleteSelected.Text = "Delete Selected";
            this.BtnDeleteSelected.UseVisualStyleBackColor = true;
            this.BtnDeleteSelected.Click += new System.EventHandler(this.BtnDeleteSelected_Click);
            // 
            // BtnReload
            // 
            this.BtnReload.Location = new System.Drawing.Point(371, 15);
            this.BtnReload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnReload.Name = "BtnReload";
            this.BtnReload.Size = new System.Drawing.Size(82, 37);
            this.BtnReload.TabIndex = 31;
            this.BtnReload.Text = "Reload";
            this.BtnReload.UseVisualStyleBackColor = true;
            this.BtnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.Location = new System.Drawing.Point(12, 15);
            this.BtnAddUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(82, 37);
            this.BtnAddUser.TabIndex = 32;
            this.BtnAddUser.Text = "Add";
            this.BtnAddUser.UseVisualStyleBackColor = true;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(478, 508);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.MainFaceView);
            this.tabPage1.Controls.Add(this.TbEmployeeId);
            this.tabPage1.Controls.Add(this.BtnCapture);
            this.tabPage1.Controls.Add(this.BtnSave);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.LbCaptureStatus);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(470, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enrollment";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnAddUser);
            this.tabPage2.Controls.Add(this.dgvAdminUsers);
            this.tabPage2.Controls.Add(this.BtnReload);
            this.tabPage2.Controls.Add(this.BtnSaveUsers);
            this.tabPage2.Controls.Add(this.BtnDeleteSelected);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(470, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Admnistrators";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AdministratorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 533);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdministratorView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administrator";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminUsers)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal Neurotec.Biometrics.Gui.NFaceView MainFaceView;
        private System.Windows.Forms.TextBox TbEmployeeId;
        private System.Windows.Forms.Button BtnCapture;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbCaptureStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAdminUsers;
        private System.Windows.Forms.Button BtnSaveUsers;
        private System.Windows.Forms.Button BtnDeleteSelected;
        private System.Windows.Forms.Button BtnReload;
        private System.Windows.Forms.Button BtnAddUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDateAdded;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}