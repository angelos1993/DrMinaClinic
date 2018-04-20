using System;
using System.Linq;
using DrMinaClinic.Utility;
using DrMinaClinic.BLL.Infrastructure;
using DrMinaClinic.DAL.Model;

namespace DrMinaClinic.BLL
{
    public class PatientManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public string GetNextPatientId(string lastPatientId)
        {
            var today = DateTime.Now;
            if (!lastPatientId.IsNullOrEmptyOrWhiteSpace())
            {
                var datePartOfLastPatientIdString = lastPatientId.Substring(0, 8);
                if (int.TryParse(datePartOfLastPatientIdString.Substring(0, 4), out int year) &&
                    int.TryParse(datePartOfLastPatientIdString.Substring(4, 2), out int month) &&
                    int.TryParse(datePartOfLastPatientIdString.Substring(6, 2), out int day) &&
                    today.Date == new DateTime(year, month, day))
                {
                    var lastNumber = int.Parse(lastPatientId.Substring(8));
                    return $"{datePartOfLastPatientIdString}{lastNumber + 1}";
                }
            }
            return $"{today.Year:0000}{today.Month:00}{today.Day:00}1";
        }

        public string GetLastPatientId()
        {
            return UnitOfWork.PatientRepository.GetAll().OrderByDescending(patient => patient.CreatedOn)
                .Select(patient => patient.Id).FirstOrDefault();
        }

        public void AddNewPatient(Patient patient)
        {
            UnitOfWork.PatientRepository.Add(patient);
        }

        #endregion
    }
}