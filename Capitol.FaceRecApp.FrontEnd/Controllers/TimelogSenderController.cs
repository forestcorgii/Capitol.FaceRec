using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capitol.FaceRecApp.FrontEnd.Domain;
using Capitol.FaceRecApp.FrontEnd.Persistence;
using Capitol.FaceRecApp.FrontEnd.Services;
using Capitol.FaceRecApp.FrontEnd.Shared;
using Neurotec.Biometrics;

namespace Capitol.FaceRecApp.FrontEnd.Controllers
{
    public class TimelogSenderController 
    {
        TimelogDbManager TimelogDbManager;

        public TimelogSenderController(TimelogDbManager timelogDbManager)
        {
            TimelogDbManager = timelogDbManager;
        }


    }
}
