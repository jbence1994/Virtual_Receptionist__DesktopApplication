using System;
using System.Xml;
using System.Collections.Generic;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.IO;

namespace virtual_receptionist
{
    public partial class DataRepository
    {
        #region Adattagok

        /// <summary>
        /// XML állomány olvasó osztály egy példánya
        /// </summary>
        private static XmlTextReader xmlTextReader;
        /// <summary>
        /// Adatbázis szerver neve
        /// </summary>
        private static string server;
        /// <summary>
        /// Adatbázis neve
        /// </summary>
        private static string database;
        /// <summary>
        /// Adatbázis szerver felhasználóneve
        /// </summary>
        private static string username;
        /// <summary>
        /// Adatbázis szerver jelszava
        /// </summary>
        private static string password;
        /// <summary>
        /// Adatbázis szerver elérésére szolgáló hálózati port
        /// </summary>
        private static string port;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Konstruktor, amely beállítja az adatbázis elérésének útvonalát
        /// </summary>
        /// <param name="connectTo">Szerver típusa (helyi otthoni vagy távoli iskolai)</param>
        public DataRepository(string connectTo)
        {
            switch (connectTo)
            {
                case "otthoni":
                    InitializeLocalServerPath();
                    break;

                case "iskolai":
                    InitializeRemoteServerPath();
                    break;
                default:
                    return;
            }

            mySqlConnection = new MySqlConnection()
            {
                ConnectionString = $"SERVER={server}; DATABASE={database};UID={username}; PASSWORD={password}; PORT={port}; SslMode=None;"
            };
        }

        #endregion

        #region Bejelentkezés-hitelesítési és adatbázis-konfigurációs folyamatokat vezérlő metódusok

        /// <summary>
        /// Metódus, amely helyi adatbázis kiszolgáló útvonalát adja vissza XML állományból
        /// </summary>
        /// <returns>A kiszolgáló útvonalát adja vissza karakterláncként</returns>
        private void InitializeLocalServerPath()
        {
            try
            {
                xmlTextReader = new XmlTextReader("dbconfig.xml");
                
                while (xmlTextReader.Read())
                {
                    switch (xmlTextReader.NodeType)
                    {
                        case XmlNodeType.Text:

                            Debug.WriteLine(xmlTextReader);
                            break;
                    }
                }

                server = "";
                database = "";
                username = "";
                password = "";
                port = "";

            }
            catch (FileNotFoundException e)
            {
                Debug.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// Metódus, amely távoli adatbázis kiszolgáló útvonalát adja vissza XML állományból
        /// </summary>
        /// <returns>A kiszolgáló útvonalát adja vissza karakterláncként</returns>
        private void InitializeRemoteServerPath()
        {
            try
            {
                xmlTextReader = new XmlTextReader("dbconfig.xml");

                server = "";
                database = "";
                username = "";
                password = "";
                port = "";
            }
            catch (FileNotFoundException e)
            {
                Debug.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// Metódus, amely ellenőrzi van-e felhasználói fiók létrehozva
        /// </summary>
        /// <returns>Ha van felhasználói fiók logikai true-val tér vissza, ellenkező esetben logikai false-szal tér vissza</returns>
        public bool IsAnyAccountExist()
        {
            bool existAnyAccount = false;

            Dictionary<string, string> account = new Dictionary<string, string>();

            string username = string.Empty;
            string password = string.Empty;

            try
            {
                mySqlConnection.Open();
                Debug.WriteLine("Sikeres adatbázis kapcsolódás...");

                mySqlCommand = new MySqlCommand()
                {
                    CommandText = "SELECT * FROM account",
                    Connection = mySqlConnection
                };

                mySqlDataReader = mySqlCommand.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    username = mySqlDataReader["username"].ToString();
                    password = mySqlDataReader["password"].ToString();
                    account.Add(username, password);
                }
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
                mySqlDataReader.Close();
                Debug.WriteLine("MySqlDataReader olvasás sikeresen befejeződött...");

                mySqlConnection.Close();
                Debug.WriteLine("Adatbázis kapcsolat sikeresen lezárult...");
            }

            if (account.Count != 0)
            {
                existAnyAccount = true;
            }

            return existAnyAccount;
        }
        /// <summary>
        /// Metódus, amely összehasonlítja a felhasználó által megadott felhasználónevet és jelszót, egyezik-e az érvényes, előre regisztrált felhasználói fiókkal
        /// </summary>
        /// <param name="username">Felhasználó által megadott felhasználónév</param>
        /// <param name="password">Felhasználó által megadott jelszó</param>
        /// <param name="usernameTableField">Felhasználónevet tartalmazó mező neve</param>
        /// <param name="passwordTableField">Jelszót tartalmazó mező neve</param>
        /// <returns>Egyezés esetén logikai igazzal tér vissza a függvény, ellenkező esetben logikai hamissal</returns>
        public bool Authentication(string username, string password, string usernameTableField, string passwordTableField)
        {
            bool validEntry = false;

            try
            {
                mySqlConnection.Open();
                Debug.WriteLine("Sikeres adatbázis kapcsolódás...");

                mySqlDataReader = mySqlCommand.ExecuteReader();
                Debug.WriteLine("MySqlDataReader olvasás sikeresen elindult...");

                while (mySqlDataReader.Read())
                {
                    string validUsername = string.Empty;
                    string validPassword = string.Empty;

                    validUsername = mySqlDataReader[usernameTableField].ToString();
                    validPassword = mySqlDataReader[passwordTableField].ToString();

                    if (username == validUsername && password == validPassword)
                    {
                        validEntry = true;
                        break;
                    }
                }
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
                mySqlDataReader.Close();
                Debug.WriteLine("MySqlDataReader olvasás sikeresen befejeződött...");

                mySqlConnection.Close();
                Debug.WriteLine("Adatbázis kapcsolat sikeresen lezárult...");
            }

            return validEntry;
        }
        /// <summary>
        /// Metódus, amely az alkalmazásba belépési és kilépési dtáumot, számítógépnévvel naplózza adatbázisba
        /// </summary>
        public void Logging()
        {
            try
            {
                mySqlConnection.Open();
                Debug.WriteLine("Sikeres adatbázis kapcsolódás...");

                mySqlCommand = new MySqlCommand()
                {
                    CommandText = "INSERT INTO log (MachineName, LoginDate, LogoutDate) VALUES (@MachineName, @LoginDate, @LogoutDate)",
                    Connection = mySqlConnection
                };

                mySqlCommand.Prepare();
                mySqlCommand.Parameters.AddWithValue("@MachineName", Client);
                mySqlCommand.Parameters.AddWithValue("@LoginDate", DateTime.Now);
                mySqlCommand.Parameters.AddWithValue("@LogoutDate", DateTime.Now); //<- Refaktor: Kilépési aktuális ponton történjen logolás a jelenlegi időről
                mySqlCommand.ExecuteNonQuery();
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
