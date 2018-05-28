using System.Linq;
using DrMinaClinic.BLL.Infrastructure;
using DrMinaClinic.DAL.Model;

namespace DrMinaClinic.BLL
{
    public class BackgroundImageManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public BackgroundImage GetTheBackgroundImage()
        {
            return UnitOfWork.BackgroundImageRepository.GetAll().FirstOrDefault();
        }

        public void SaveTheBackgroundImage(BackgroundImage backgroundImage)
        {
            UnitOfWork.BackgroundImageRepository.DeleteRange(UnitOfWork.BackgroundImageRepository.GetAll().ToList());
            UnitOfWork.BackgroundImageRepository.Add(backgroundImage);
        }

        #endregion
    }
}