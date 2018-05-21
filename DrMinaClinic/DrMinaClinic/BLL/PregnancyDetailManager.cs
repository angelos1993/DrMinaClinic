using System.Collections.Generic;
using System.Linq;
using DrMinaClinic.BLL.Infrastructure;
using DrMinaClinic.DAL.Model;

namespace DrMinaClinic.BLL
{
    public class PregnancyDetailManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public void AddPregnancyDetail(List<PregnancyDetail> pregnancyDetailsList, int pregnancyId)
        {
            DeletePregnancyDetailsForPregnancy(pregnancyId);
            pregnancyDetailsList.ForEach(pregnancyDetail => UnitOfWork.PregnancyDetailsRepository.Add(pregnancyDetail));
        }

        public void DeletePregnancyDetailsForPregnancy(int pregnancyId)
        {
            UnitOfWork.PregnancyDetailsRepository.Get(pregnancyDetail => pregnancyDetail.PregnancyId == pregnancyId)
                .ToList().ForEach(pregnancyDetail => UnitOfWork.PregnancyDetailsRepository.Delete(pregnancyDetail));
        }

        #endregion
    }
}