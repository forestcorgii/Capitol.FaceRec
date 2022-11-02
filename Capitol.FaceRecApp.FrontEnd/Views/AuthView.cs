﻿using Capitol.FaceRecApp.FrontEnd.Controllers;
using Capitol.FaceRecApp.FrontEnd.Services;
using Neurotec.Biometrics;
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
    public partial class AuthView : Form
    {
        AuthController AuthController;

        public AuthView()
        {
            InitializeComponent();

            AuthController = new AuthController(
               Program.VerilookFactory.CreateManager(MainFaceView, NBiometricCaptureOptions.Stream),
               Program.UserDbManager
            );

            BtnRetry.Visible = false;
            StartStreaming();
        }

        private async void StartStreaming()
        {
            NBiometricStatus status = NBiometricStatus.None;
            while (!Closed)
            {
                if (status != NBiometricStatus.Ok)
                    await AuthController.ForceStopCapture();
                else break;

                status = await AuthController.StartCapture();
            }

            if (await AuthController.Authenticate())
            {
                await AuthController.ForceStopCapture();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                BtnRetry.Visible = true;
        }

        private void BtnRetry_Click(object sender, EventArgs e)
        {
            BtnRetry.Visible = false;
            StartStreaming();
        }

        new bool Closed = false;
        private void AuthView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Closed = true;
        }
    }
}