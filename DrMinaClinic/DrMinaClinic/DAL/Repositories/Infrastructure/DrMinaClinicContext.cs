using DrMinaClinic.DAL.Model;

namespace DrMinaClinic.DAL.Repositories.Infrastructure
{
    public class DrMinaClinicContext
    {
        private static DrMinaClinicEntities _instance;

        private DrMinaClinicContext()
        {
        }

        public static DrMinaClinicEntities Instance => _instance ?? (_instance = new DrMinaClinicEntities());
    }
}