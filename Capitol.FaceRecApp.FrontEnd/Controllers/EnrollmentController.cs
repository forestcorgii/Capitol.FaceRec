using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capitol.FaceRecApp.FrontEnd.Domain;
using Capitol.FaceRecApp.FrontEnd.Services;
using Capitol.FaceRecApp.FrontEnd.Shared;
using Neurotec.Biometrics;

namespace Capitol.FaceRecApp.FrontEnd.Controllers
{
    public class EnrollmentController : VerilookControllerBase
    {
        public EnrollmentController(VerilookManager verilookManager) :
            base(verilookManager)
        {

        }


        public async Task<bool> EnrollFace(string id)
        {
            string res = await Manager.EnrollAsync(CurrentSubject, id);
            return res != string.Empty;
        }

    }
}
