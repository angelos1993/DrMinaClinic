using System.Collections.Generic;
using System.Linq;
using DrMinaClinic.BLL.Infrastructure;
using DrMinaClinic.DAL.Model;

namespace DrMinaClinic.BLL
{
    public class ExaminationDetailManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public void AddExaminationDetail(List<ExaminationDetail> examinationDetailsList, int pregnancyId)
        {
            DeleteExaminationDetailsForPregnancy(pregnancyId);
            UnitOfWork.ExaminationDetailsRepository.AddRange(examinationDetailsList);
        }

        public void DeleteExaminationDetailsForPregnancy(int examinationId)
        {
            UnitOfWork.ExaminationDetailsRepository
                .Get(examinationDetail => examinationDetail.ExaminationId == examinationId)
                .ToList().ForEach(examinationDetail => UnitOfWork.ExaminationDetailsRepository.Delete(examinationDetail));
        }

        public void DeleteExaminationDetailsList(List<ExaminationDetail> examinationDetailsliList)
        {
            UnitOfWork.ExaminationDetailsRepository.DeleteRange(examinationDetailsliList);
        }

        #endregion
    }
}