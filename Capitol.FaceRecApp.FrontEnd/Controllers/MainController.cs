using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capitol.FaceRecApp.FrontEnd.Domain;
using Capitol.FaceRecApp.FrontEnd.Persistence;
using Capitol.FaceRecApp.FrontEnd.Services;
using Capitol.FaceRecApp.FrontEnd.Services.Sender;
using Capitol.FaceRecApp.FrontEnd.Shared;
using Neurotec.Biometrics;

namespace Capitol.FaceRecApp.FrontEnd.Controllers
{
    public class MainController : VerilookControllerBase
    {
        TimelogDbManager TimelogDbManager;

        public MainController(VerilookManager verilookManager, TimelogDbManager timelogDbManager) : base(verilookManager)
        {
            TimelogDbManager = timelogDbManager;
        }


        public IEnumerable<Timelog> LoadPreviewTimelogs() => TimelogDbManager.GetTimelogs();

        private bool ValidateTimelog(string id, DateTime timestamp)
        {
            Timelog latestTimelog = TimelogDbManager.FindLatestTimelogByEEId(id);
            if (latestTimelog != null)
            {
                TimeSpan gap = timestamp - latestTimelog.Timestamp;
                if (gap.TotalMinutes >= 1)
                    return true;
            }
            else
                return true;
            return false;
        }

        public Timelog AddTimelogToQueue(string id, DateTime timestamp)
        {
            if (ValidateTimelog(id, timestamp))
            {
                Timelog newTimelog = new Timelog() { EEId = id, Timestamp = timestamp };
                TimelogDbManager.AddToQueue(newTimelog);
                return newTimelog;
            }

            return null;
        }


        public async Task<string> IdentifyFace()
        {
            if (CurrentSubject != null && CurrentSubject.Faces.Any())
            {
                NFace[] result = await Manager.DetectAsync(CurrentSubject);
                if (result.Any())
                {
                    NSubject subjectFound = new NSubject();
                    subjectFound.Faces.Add(result[0]);
                    return await Manager.IdentifyAsync(subjectFound);
                }
            }
            return string.Empty;
        }

    }
}
