using Capitol.FaceRecApp.FrontEnd.Controllers;
using Capitol.FaceRecApp.FrontEnd.Services;
using Capitol.FaceRecApp.FrontEnd.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitol.FaceRecApp.FrontEnd.Views
{
    public partial class EnrollmentView : Form
    {
        EnrollmentController Controller;

        public EnrollmentView()
        {
            InitializeComponent();

            Controller = new EnrollmentController(Program.VerilookFactory.CreateManager(MainFaceView, Neurotec.Biometrics.NBiometricCaptureOptions.Stream));

        }

        private async void BtnCapture_Click(object sender, EventArgs e)
        {
            if (await Controller.ValidateId(TbEmployeeId.Text))
            {
                await Controller.ForceStopCapture();
                var res = await Controller.StartCapture();
                LbCaptureStatus.Text = res.ToString();
            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            var res = await Controller.EnrollFace(TbEmployeeId.Text);
            if (res)
            {
                MessageBoxes.Prompt("Saved.");
                DialogResult = DialogResult.OK;
                Close();
            }

        }
    }
}
