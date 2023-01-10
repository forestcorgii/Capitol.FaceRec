using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capitol.FaceRecApp.FrontEnd.Controllers;
using Capitol.FaceRecApp.FrontEnd.Domain;
using Capitol.FaceRecApp.FrontEnd.Persistence;
using Capitol.FaceRecApp.FrontEnd.Services;
using Capitol.FaceRecApp.FrontEnd.Views;
using Neurotec.Biometrics;

namespace Capitol.FaceRecApp.FrontEnd
{
    public partial class MainView : Form
    {
        MainController MainController;

        public MainView()
        {
            InitializeComponent();

            MainController = new MainController(
                Program.VerilookFactory.CreateManager(MainFaceView, NBiometricCaptureOptions.Manual),
                Program.TimelogDbManager
            );


            LoadPreview();

            StartStreaming();
        }

        private void LoadPreview()
        {
            IEnumerable<Timelog> timelogs = MainController.LoadPreviewTimelogs();
            dataGridView1.DataSource = timelogs;

            LbSubjectCount.Text = $" Total Subject Registered: {timelogs.Count()}";
        }

        private async void StartStreaming()
        {
            FsTimer.Start();
            await MainController.StartCapture();
        }
        private async void StopStreaming()
        {
            FsTimer.Stop();
            await MainController.ForceStopCapture();
        }

        private async void FsTimer_Tick(object sender, EventArgs e)
        {
            FsTimer.Stop();

            var result = await MainController.IdentifyFace();
            if (result is string[] idsFound)
                foreach (string ids in idsFound)
                {
                    Timelog timelog = MainController.SaveTimelog(ids, DateTime.Now);
                    if (timelog != null)
                    {
                        LoadPreview();
                        lbStatusMessage.Text = $"Logged {ids}";
                    }
                }

            if (result is string statusMsg)
                if (statusMsg == "NOFACE")
                    lbStatusMessage.Text = "Stand By...";
                else if (statusMsg == "NOMATCH")
                    lbStatusMessage.Text = "No match found, please try again.";

            FsTimer.Start();
        }

        private void MbtnEnroll_Click(object sender, EventArgs e)
        {
            StopStreaming();

            if (new AuthView().ShowDialog() == DialogResult.OK)
                new AdministratorView().ShowDialog();

            LoadPreview();
            
            StartStreaming();
        }


    }
}
