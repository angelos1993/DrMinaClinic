namespace DrMinaClinic.DAL.Repositories.Infrastructure
{
    public interface IUnitOfWork
    {
        ExaminationRepository ExaminationRepository { get; }
        PatientRepository PatientRepository { get; }
        PregnancyDetailsRepository PregnancyDetailsRepository { get; }
        PregnancyRepository PregnancyRepository { get; }
    }
}