using virtual_receptionist.Controllers.Exceptions;

namespace virtual_receptionist.Controllers.Validation
{
    public class FreeCapacityValidaiton
    {
        #region Adattagok

        #endregion

        #region Konstruktor

        public FreeCapacityValidaiton()
        {

        }

        #endregion

        #region Metódusok

        public void dd()
        {
            throw new InvalidCapacityException();
        }

        #endregion
    }
}
