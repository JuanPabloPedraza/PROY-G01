using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
