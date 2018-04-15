namespace DrMinaClinic.DAL.Repositories.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        #region IUnitOfWork Members

        private ExaminationRepository _examinationRepository;
        private PatientRepository _patientRepository;
        private PregnancyDetailsRepository _pregnancyDetailsRepository;
        private PregnancyRepository _pregnancyRepository;

        #endregion

        #region Repositries Properties

        public ExaminationRepository ExaminationRepository =>
            _examinationRepository ?? (_examinationRepository = new ExaminationRepository());

        public PatientRepository PatientRepository =>
            _patientRepository ?? (_patientRepository = new PatientRepository());

        public PregnancyDetailsRepository PregnancyDetailsRepository =>
            _pregnancyDetailsRepository ?? (_pregnancyDetailsRepository = new PregnancyDetailsRepository());

        public PregnancyRepository PregnancyRepository =>
            _pregnancyRepository ?? (_pregnancyRepository = new PregnancyRepository());

        #endregion
    }
}