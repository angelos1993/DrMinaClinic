namespace DrMinaClinic.DAL.Repositories.Infrastructure
{
    public interface IUnitOfWork
    {
        ExaminationRepository ExaminationRepository { get; }
        PatientRepository PatientRepository { get; }
        ExaminationDetailsRepository ExaminationDetailsRepository { get; }
        PregnancyRepository PregnancyRepository { get; }
        BackgroundImageRepository BackgroundImageRepository { get; }
    }
}