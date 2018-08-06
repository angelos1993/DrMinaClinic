using System;
using System.Linq;
using DrMinaClinic.BLL.Infrastructure;
using DrMinaClinic.DAL.Model;
using DrMinaClinic.Utility;

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
                    var newPatientId = $"{datePartOfLastPatientIdString}{lastNumber + 1}";

                    #region Double-Check -_-

                    var counter = 0;
                    var isNewPatientIdValid = false;
                    do
                    {
                        // ReSharper disable once AccessToModifiedClosure
                        if (UnitOfWork.PatientRepository.Get(patient => patient.Id == newPatientId).Any())
                        {
                            newPatientId = $"{datePartOfLastPatientIdString}{lastNumber + 1 + counter}";
                            counter++;
                        }
                        else
                            isNewPatientIdValid = true;
                    } while (!isNewPatientIdValid);

                    #endregion

                    return newPatientId;
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

        public Patient GetPatientById(string patientId)
        {
            return UnitOfWork.PatientRepository.Get(patient => patient.Id == patientId).FirstOrDefault();
        }

        public Patient GetPatientByName(string patientName)
        {
            return UnitOfWork.PatientRepository.Get(patient => patient.Name == patientName).FirstOrDefault();
        }

        public void UpdatePatient(Patient patient)
        {
            UnitOfWork.PatientRepository.Update(patient);
        }

        public IQueryable<Patient> GetAllPatients()
        {
            return UnitOfWork.PatientRepository.GetAll();
        }

        public int GetAboGroupValueFromText(string patientAboGroup)
        {
            switch (patientAboGroup)
            {
                case "A":
                    return 1;
                case "B":
                    return 2;
                case "AB":
                    return 3;
                case "O":
                    return 4;
                default:
                    return 0;
            }
        }

        #endregion
    }
}