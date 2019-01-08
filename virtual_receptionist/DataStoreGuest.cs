using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;
using System;

namespace virtual_receptionist
{
    public partial class DataStore
    {
        #region Vendégadatbázis-kezelő modul metódusai

        /// <summary>
        /// Metódus, amely visszaadja az adatbázisban tárolt összes vendéget egy DataTable adatszerkezetben
        /// </summary>
        /// <returns>Adatokkal feltöltött DataTable-t adja vissza</returns>
        public DataTable GetGuests()
        {
            DataTable guests = new DataTable();

            try
            {
                mySqlConnection.Open();
                Debug.WriteLine("Sikeres adatbázis kapcsolódás...");

                mySqlCommand = new MySqlCommand()
                {
                    CommandText = "SELECT * FROM guest",
                    Connection = mySqlConnection
                };

                mySqlDataAdapter = new MySqlDataAdapter()
                {
                    SelectCommand = mySqlCommand
                };

                mySqlCommandBuilder = new MySqlCommandBuilder()
                {
                    DataAdapter = mySqlDataAdapter
                };

                mySqlDataAdapter.Fill(guests);
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                mySqlConnection.Close();
                Debug.WriteLine("Adatbázis kapcsolat sikeresen lezárult...");
            }

            return guests;
        }
        /// <summary>
        /// Vendég törlése
        /// </summary>
        public void DeleteGuest(Guest guest)
        {
            try
            {
                mySqlConnection.Open();
                Debug.WriteLine("Sikeres adatbázis kapcsolódás...");

                mySqlCommand = new MySqlCommand()
                {
                    CommandText = "DELETE FROM members WHERE id=@id",
                    Connection = mySqlConnection
                };

                mySqlCommand.Prepare();
                mySqlCommand.Parameters.AddWithValue("id@", guest);
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.Parameters.Clear();
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                mySqlConnection.Close();
                Debug.WriteLine("Adatbázis kapcsolat sikeresen lezárult...");
            }
        }
        /// <summary>
        /// Vendég módosítása
        /// </summary>
        public void UpdateGuest(Guest guest)
        {
            try
            {
                mySqlConnection.Open();
                Debug.WriteLine("Sikeres adatbázis kapcsolódás...");

                mySqlCommand = new MySqlCommand()
                {
                    CommandText = "UPDATE members SET valami=@valami WHERE id=@id",
                    Connection = mySqlConnection
                };

                mySqlCommand.Prepare();
                mySqlCommand.Parameters.AddWithValue("@", guest);
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.Parameters.Clear();
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                mySqlConnection.Close();
                Debug.WriteLine("Adatbázis kapcsolat sikeresen lezárult...");
            }
        }
        /// <summary>
        /// Vendég létrehozása
        /// </summary>
        public void CreateGuest(Guest guest)
        {
            try
            {
                mySqlConnection.Open();
                Debug.WriteLine("Connecting to database successfully!");

                mySqlCommand = new MySqlCommand()
                {
                    CommandText = "INSERT INTO guest () VALUES (@, )",
                    Connection = mySqlConnection
                };

                mySqlCommand.Prepare();
                mySqlCommand.Parameters.AddWithValue("@", guest);
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.Parameters.Clear();
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                mySqlConnection.Close();
                Debug.WriteLine("Adatbázis kapcsolat sikeresen lezárult...");
            }
        }

        #endregion
    }
}
