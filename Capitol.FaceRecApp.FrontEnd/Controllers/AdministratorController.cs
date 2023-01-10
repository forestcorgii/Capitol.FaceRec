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
    public class AdministratorController : VerilookControllerBase
    {
        AdministratorDbManager AdministratorDbManager;

        public AdministratorController(VerilookManager verilookManager, AdministratorDbManager administratorDbManager) :
            base(verilookManager)
        {
            AdministratorDbManager = administratorDbManager;
        }


        public IEnumerable<Administrator> LoadAdministrators() => AdministratorDbManager.LoadAdministrators();
        public void Save(Administrator admin) => AdministratorDbManager.SaveAdmin(admin);
        public void Delete(Administrator admin) => AdministratorDbManager.DeleteAdmin(admin);


        public async Task<bool> EnrollFace(string id)
        {
            string res = await Manager.EnrollAsync(CurrentSubject, id);
            return res != string.Empty;
        }

        public async Task<bool> UpdateFace(string id)
        {
            string res = await Manager.UpdateAsync(CurrentSubject, id);
            return res != string.Empty;
        }

    }
}
