using System;
using System.Data.Entity.SqlServer;
using System.Linq;
using DrMinaClinic.BLL.Infrastructure;
using DrMinaClinic.DAL.Model;

namespace DrMinaClinic.BLL
{
    public class ExaminationManager : BaseManager
    {
        #region Properties

        private ExaminationDetailManager _examinationDetailManager;

        private ExaminationDetailManager ExaminationDetailManager =>
            _examinationDetailManager ?? (_examinationDetailManager = new ExaminationDetailManager());

        #endregion

        #region Methods

        public void AddExamination(Examination examination)
        {
            UnitOfWork.ExaminationRepository.Add(examination);
            if (examination.ExaminationDetails.Any())
                ExaminationDetailManager.AddExaminationDetail(examination.ExaminationDetails.ToList(), examination.Id);
        }

        public void UpdateExamination(Examination examination)
        {
            if (examination.ExaminationDetails.Any())
                ExaminationDetailManager.AddExaminationDetail(examination.ExaminationDetails.ToList(), examination.Id);
            UnitOfWork.ExaminationRepository.Update(examination);
        }

        public int GetEngagementValueFromText(int? examinationEngagement)
        {
            switch (examinationEngagement)
            {
                case -2:
                    return 1;
                case -1:
                    return 2;
                case 0:
                    return 3;
                case 1:
                    return 4;
                case 2:
                    return 5;
                default:
                    return 0;
            }
        }

        public int GetAlbValueFromText(string examinationAlb)
        {
            switch (examinationAlb)
            {
                case "Crace":
                    return 1;
                case "+1":
                    return 2;
                case "+2":
                    return 3;
                case "+3":
                    return 4;
                default:
                    return 0;
            }
        }

        public IQueryable<Examination> GetExaminationsByDate(DateTime date)
        {
            return UnitOfWork.ExaminationRepository.Get(
                examination => SqlFunctions.DateDiff("DAY", examination.Date, date) == 0);
        }

        #endregion
    }
}