using Capitol.FaceRecApp.FrontEnd.Controllers;
using Capitol.FaceRecApp.FrontEnd.Domain;
using Capitol.FaceRecApp.FrontEnd.Services;
using Capitol.FaceRecApp.FrontEnd.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitol.FaceRecApp.FrontEnd.Views
{
    public partial class AdministratorView : Form
    {
        AdministratorController Controller;

        public AdministratorView()
        {
            InitializeComponent();

            Controller = new AdministratorController(
                Program.VerilookFactory.CreateManager(MainFaceView, Neurotec.Biometrics.NBiometricCaptureOptions.Stream),
                Program.AdministratorDbManager
            );


            LoadPreview();
        }

        List<Administrator> Admins { get; set; }
        private void LoadPreview()
        {
            Admins = Controller.LoadAdministrators().ToList();
            dgvAdminUsers.DataSource = Admins;
        }


        private async void BtnCapture_Click(object sender, EventArgs e)
        {
            await Controller.ForceStopCapture();
            var res = await Controller.StartCapture();
            LbCaptureStatus.Text = res.ToString();
        }

        private async void BtnSaveFaceSubject_Click(object sender, EventArgs e)
        {
            bool res = false;
            if (await Controller.ValidateId(TbEmployeeId.Text))
                res = await Controller.EnrollFace(TbEmployeeId.Text);
            else
                if (MessageBoxes.Inquire("Id is already registered in our system, Do you want to overwrite?"))
                res = await Controller.EnrollFace(TbEmployeeId.Text);

            if (res)
            {
                MessageBoxes.Prompt("Saved.");
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private async void BtnSaveUsers_Click(object sender, EventArgs e)
        {
            foreach (var rowObject in dgvAdminUsers.Rows)
            {
                if (rowObject is DataGridViewRow row)
                    if (row.DataBoundItem is Administrator admin)
                        if (!await Controller.ValidateId(admin.EEId))
                            Controller.Save(admin);
                        else
                            MessageBoxes.Error($"Cannot set Id {admin.EEId}, face subject does not exist.");
            }
            LoadPreview();
        }

        private void BtnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (dgvAdminUsers.SelectedRows.Count > 0 && dgvAdminUsers.SelectedRows[0].DataBoundItem is Administrator admin)
                Controller.Delete(admin);
            LoadPreview();
        }

        private void BtnReload_Click(object sender, EventArgs e) => LoadPreview();

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            Admins.Add(new Administrator());
            dgvAdminUsers.DataSource = new ObservableCollection<Administrator>(Admins);
        }
    }
}
