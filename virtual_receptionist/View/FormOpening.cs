using System.Windows.Forms;
using virtual_receptionist.Presenter;

namespace virtual_receptionist.View
{
    /// <summary>
    /// Nyitóablak
    /// </summary>
    public partial class FormOpening : Form
    {
        #region Adattagok

        /// <summary>
        /// nyitóablak prezenter egy példánya
        /// </summary>
        private OpeningPresenter presenter;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Nyitóablak konstruktora
        /// </summary>
        public FormOpening()
        {
            InitializeComponent();
            presenter = new OpeningPresenter(this);
        }

        #endregion

        #region UI események

        private void FormApplicationOpening_Load(object sender, System.EventArgs e)
        {
            presenter.ApplicationStarting();
        }

        #endregion
    }
}
