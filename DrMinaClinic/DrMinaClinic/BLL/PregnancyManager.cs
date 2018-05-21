using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DrMinaClinic.BLL.Infrastructure;
using DrMinaClinic.DAL.Model;

namespace DrMinaClinic.BLL
{
    public class PregnancyManager : BaseManager
    {
        #region Properties

        private PregnancyDetailManager _pregnancyDetailManager;

        private PregnancyDetailManager PregnancyDetailManager =>
            _pregnancyDetailManager ?? (_pregnancyDetailManager = new PregnancyDetailManager());

        #endregion

        #region Methods

        public List<Pregnancy> GetAllPregnanciesForPatient(string patientId)
        {
            return UnitOfWork.PregnancyRepository.Get(pregnancy => pregnancy.PatientId == patientId)
                .Include(pregnancy => pregnancy.Examinations).ToList();
        }

        public void UpdatePregnancy(Pregnancy pregnancy)
        {
            UnitOfWork.PregnancyRepository.Update(pregnancy);
        }

        public void AddPregnancy(Pregnancy pregnancy)
        {
            UnitOfWork.PregnancyRepository.Add(pregnancy);
            if (pregnancy.PregnancyDetails.Any())
                PregnancyDetailManager.AddPregnancyDetail(pregnancy.PregnancyDetails.ToList(), pregnancy.Id);
        }

        public void DeletePregnancy(Pregnancy pregnancy)
        {
            if (pregnancy.PregnancyDetails.Any())
                PregnancyDetailManager.DeletePregnancyDetailsForPregnancy(pregnancy.Id);
            UnitOfWork.PregnancyRepository.Delete(pregnancy);
        }

        #endregion
    }
}