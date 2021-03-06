﻿namespace DrMinaClinic.DAL.Repositories.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        #region IUnitOfWork Members

        private ExaminationRepository _examinationRepository;
        private PatientRepository _patientRepository;
        private ExaminationDetailsRepository _examinationDetailsRepository;
        private PregnancyRepository _pregnancyRepository;
        private BackgroundImageRepository _backgroundImageRepository;

        #endregion

        #region Repositries Properties

        public ExaminationRepository ExaminationRepository =>
            _examinationRepository ?? (_examinationRepository = new ExaminationRepository());

        public PatientRepository PatientRepository =>
            _patientRepository ?? (_patientRepository = new PatientRepository());

        public ExaminationDetailsRepository ExaminationDetailsRepository =>
            _examinationDetailsRepository ?? (_examinationDetailsRepository = new ExaminationDetailsRepository());

        public PregnancyRepository PregnancyRepository =>
            _pregnancyRepository ?? (_pregnancyRepository = new PregnancyRepository());

        public BackgroundImageRepository BackgroundImageRepository =>
            _backgroundImageRepository ?? (_backgroundImageRepository = new BackgroundImageRepository());

        #endregion
    }
}