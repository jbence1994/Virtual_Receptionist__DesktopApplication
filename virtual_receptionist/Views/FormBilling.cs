﻿using System;
using System.Data;
using System.Windows.Forms;
using virtual_receptionist.Controllers;

namespace virtual_receptionist.Views
{
    /// <summary>
    /// Számlázó modul ablak
    /// </summary>
    public partial class FormBilling : Form
    {
        #region Adattagok

        /// <summary>
        /// Számlázó modul vezérlő egy példánya
        /// </summary>
        private BillingController controller;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Számlázó modul ablak konstruktora
        /// </summary>
        public FormBilling()
        {
            InitializeComponent();
            controller = new BillingController();
        }

        #endregion

        #region UI események

        private void FormBilling_Load(object sender, EventArgs e)
        {
            InitializeListView();
        }

        private void checkBoxIsCompany_CheckedChanged(object sender, EventArgs e)
        {
            textBoxVATNumber.Clear();
            textBoxVATNumber.Enabled = checkBoxIsCompany.Checked;
        }

        private void listViewToBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewToBill.SelectedItems.Count > 0)
            {
                string name = listViewToBill.SelectedItems[0].SubItems[1].Text;
                string[] data = controller.GetGuestData(name);

                textBoxBillingName.Text = data[0];
                comboBoxBillingCountry.SelectedItem = data[1];
                textBoxBillingCity.Text = data[2];
                textBoxBillingZipCode.Text = data[3];
                textBoxBillingAddress.Text = data[4];

                buttonAddItem.Enabled = true;
                buttonUpdateItem.Enabled = true;
                buttonDeleteItem.Enabled = true;
            }
            else
            {
                textBoxBillingName.Clear();
                comboBoxBillingCountry.DataSource = null;
                comboBoxBillingCountry.DataSource = controller.GetCountries();
                comboBoxBillingCountry.SelectedItem = controller.GetCountries()[0];
                textBoxBillingCity.Clear();
                textBoxBillingZipCode.Clear();
                textBoxBillingAddress.Clear();
                textBoxVATNumber.Clear();

                buttonAddItem.Enabled = false;
                buttonUpdateItem.Enabled = false;
                buttonDeleteItem.Enabled = false;
            }
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            FormBillingItems billingItems = new FormBillingItems("", "", "", "", 1, "", "", "");

            if (billingItems.ShowDialog() == DialogResult.OK)
            {
                object[] items = billingItems.BillingItems;
                dataGridViewItems.Rows.Add(items);
            }
        }

        private void buttonUpdateItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewItems.SelectedRows.Count > 0)
            {
                object item = dataGridViewItems.SelectedRows[0].Cells[0].Value;
                object price = dataGridViewItems.SelectedRows[0].Cells[1].Value;
                object discountPrice = dataGridViewItems.SelectedRows[0].Cells[2].Value;
                object discount = dataGridViewItems.SelectedRows[0].Cells[3].Value;
                object quantity = dataGridViewItems.SelectedRows[0].Cells[4].Value;
                object unit = dataGridViewItems.SelectedRows[0].Cells[5].Value;
                object vat = dataGridViewItems.SelectedRows[0].Cells[6].Value;
                object category = dataGridViewItems.SelectedRows[0].Cells[7].Value;

                FormBillingItems billingItems =
                    new FormBillingItems(item, price, discountPrice, discount, quantity, unit, vat, category);

                if (billingItems.ShowDialog() == DialogResult.OK)
                {
                    dataGridViewItems.SelectedRows[0].Cells[0].Value = billingItems.BillingItems[0];
                    dataGridViewItems.SelectedRows[0].Cells[1].Value = billingItems.BillingItems[1];
                    dataGridViewItems.SelectedRows[0].Cells[2].Value = billingItems.BillingItems[2];
                    dataGridViewItems.SelectedRows[0].Cells[3].Value = billingItems.BillingItems[3];
                    dataGridViewItems.SelectedRows[0].Cells[4].Value = billingItems.BillingItems[4];
                    dataGridViewItems.SelectedRows[0].Cells[5].Value = billingItems.BillingItems[5];
                    dataGridViewItems.SelectedRows[0].Cells[6].Value = billingItems.BillingItems[6];
                }
            }
            else
            {
                MessageBox.Show("Nincs kijelölt elem!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewItems.SelectedRows.Count > 0)
            {
                int row = dataGridViewItems.SelectedRows[0].Index;
                dataGridViewItems.Rows.RemoveAt(row);
            }
            else
            {
                MessageBox.Show("Nincs kijelölt elem!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            double total = 0;

            for (int i = 0; i < dataGridViewItems.Rows.Count; i++)
            {
                total += Convert.ToDouble(dataGridViewItems.Rows[i].Cells[2].Value);
            }

            textBoxTotalPrice.Text = total.ToString();

            if (dataGridViewItems.Rows.Count > 0 && textBoxBillingName.Text != string.Empty)
            {
                buttonPrintInvoice.Enabled = true;
            }
        }

        private void dataGridViewItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            double total = 0;

            for (int i = 0; i < dataGridViewItems.Rows.Count; i++)
            {
                total += Convert.ToDouble(dataGridViewItems.Rows[i].Cells[2].Value);
            }

            textBoxTotalPrice.Text = total.ToString();

            if (dataGridViewItems.Rows.Count == 0)
            {
                buttonPrintInvoice.Enabled = false;
            }
        }

        private void buttonPrintInvoice_Click(object sender, EventArgs e)
        {
            int bookingID = Convert.ToInt32(listViewToBill.SelectedItems[0].Text);

            /**
             * Csak átállítja adatbázisban fizetettre a foglalást!
             */
            controller.PrintInvoice(bookingID);

            DialogResult ok = MessageBox.Show("PDF számla generálás fejlesztése folyamatban...", "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            if (ok == DialogResult.OK)
            {
                listViewToBill.Items.Clear();
                dataGridViewItems.Rows.Clear();

                InitializeListView();
            }
        }

        private void InitializeListView()
        {
            DataTable bookingsToBillDataTable = controller.GetUnpaidBookings();

            foreach (DataRow row in bookingsToBillDataTable.Rows)
            {
                ListViewItem bookingsToBill = new ListViewItem(row[0].ToString());

                for (int i = 1; i < bookingsToBillDataTable.Columns.Count; i++)
                {
                    bookingsToBill.SubItems.Add(row[i].ToString());
                }

                listViewToBill.Items.Add(bookingsToBill);
            }

            comboBoxBillingCountry.DataSource = controller.GetCountries();
        }

        #endregion
    }
}
