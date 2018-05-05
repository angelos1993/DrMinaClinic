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

        #endregion
    }
}