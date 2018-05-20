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
            //TODO: check if there is pregnancy details should be saved -_-
            UnitOfWork.PregnancyRepository.Add(pregnancy);
        }

        public void DeletePregnancy(Pregnancy pregnancy)
        {
            UnitOfWork.PregnancyRepository.Delete(pregnancy);
        }

        #endregion
    }
}