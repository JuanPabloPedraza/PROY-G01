using DataAccessLayer;
using Entities;

namespace BussinessLogicLayer
{
    public class BusTitular
    {
        #region Instancias
        private DataTitular _dataTitular;
        #endregion

        public BusTitular()
        {
            _dataTitular = new DataTitular();
        }

        public int SaveTitular(Titular _titular)
        {
            return _dataTitular.SaveTitular(_titular);
        }

        public int SavePosibleTitular(Titular _titular)
        {
            return _dataTitular.SavePosibleTitular(_titular);
        }
    }
}