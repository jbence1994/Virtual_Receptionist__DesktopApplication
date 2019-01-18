using System.Data;
using System.Windows.Forms;

namespace virtual_receptionist.SupervisingController
{
    public partial class Presenter
    {
        #region Vendégadatbázis-kezelő nézetfrissítései

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listView"></param>
        public void InitalizeGuestTable(ListView listView)
        {
            DataTable guestDataTable = dataRepository.GetGuests();

            foreach (DataRow row in guestDataTable.Rows)
            {
                ListViewItem guests = new ListViewItem(row[0].ToString());

                for (int i = 1; i < guestDataTable.Columns.Count; i++)
                {
                    guests.SubItems.Add(row[i].ToString());
                }

                listView.Items.Add(guests);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public void AddNewRecordInGuestTable()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        public void DeleteRecordInGuestTable()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        public void UpdateRecordInGuestTable()
        {

        }

        #endregion
    }
}
