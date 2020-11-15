﻿using System;
using System.Windows.Forms;
using virtual_receptionist.Repositories;

namespace virtual_receptionist.Views
{
    public partial class FormLogin : Form
    {
        private readonly AccommodationRepository accommodationRepository = new AccommodationRepository();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormApplicationOpening_Load(object sender, EventArgs e)
        {
            textBoxAccomodationID.Select();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var accommodationId = textBoxAccomodationID.Text;
            var password = textBoxPassword.Text;

            try
            {
                if (!accommodationRepository.Authenticate(accommodationId, password))
                    return;

                Hide();
                var formMainMenu = new FormMainMenu(this);
                formMainMenu.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
