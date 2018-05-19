using DrMinaClinic.BLL.Infrastructure;
using DrMinaClinic.DAL.Model;

namespace DrMinaClinic.BLL
{
    public class ExaminationManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public void AddExamination(Examination examination)
        {
            UnitOfWork.ExaminationRepository.Add(examination);
        }

        public void UpdateExamination(Examination examination)
        {
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

        #endregion
    }
}