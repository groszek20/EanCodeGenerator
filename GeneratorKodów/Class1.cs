using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace GeneratorKodów
{
    class jodb
    {
        private SqlConnection połączenie; //Obiekt połączenia

        /// <summary>
        /// Konstruktor do tworzenia połączenia za pomocą autoryzacji Windows
        /// </summary>
        /// <param name="user">użytkownik</param>
        /// <param name="pass">hasło</param>
        /// <param name="instance">nazwa instancji</param>
        /// <param name="dbdir">nazwa bazy danych</param>
        public jodb(String user, String pass, String instance, String dbdir)
        {
            połączenie = new SqlConnection();
            połączenie.ConnectionString = "user id=" + user + ";" + "password=" + pass +
                ";Data Source=" + instance + ";" + "Trusted_Connection=no;" + "database=" + dbdir + ";" +
                "connection timeout=3";
            połączenie.Open();
        }
        /// <summary>
        /// Konstruktor do tworzenia połączenia za pomocą autoryzacji Windows
        /// </summary>
        /// <param name="instance">nazwa instancji</param>
        /// <param name="dbdir">nazwa bazy danych</param>
        public jodb(String instance, String dbdir)
        {
            połączenie = new SqlConnection();
            połączenie.ConnectionString = "Data Source=" + instance + ";" +
                "Trusted_Connection=yes;" + "database=" + dbdir + "; " +
                "connection timeout=3";
            połączenie.Open();
        }

        /// Metoda do pobierania danych z bazy danych
        /// Zapytanie SQL
        /// Zwraca dane w obiekcie DataTable
        
        public DataTable pobierzDane(String q)
        {

            DataTable dt = new DataTable(); // Deklaracja i utworzenie obiektu DataTable
            SqlDataReader sdr;
            SqlCommand sqlc;

            sqlc = new SqlCommand(q); // tworzenie instancji SqlCommand do wykonania intrukcji przekazanego w zmiennej q
            sqlc.Connection = this.połączenie; // wskazanie polaczenia do bazy danych
            sdr = sqlc.ExecuteReader(); //wykonanie zapytanie i utworzenie wskaznika sdr
            dt.Load(sdr); //zaladowanie danych do obiektu DataTAble
            return dt; // zwrocenie danych
        }

        public void ZapiszDane(int id, string kod)
        {
            string test = string.Format("{0} - {1}: {2}", id, kod, "Wynik");
            string t2 = id.ToString() + " - " + kod + ": " + "Wyniki";

            StringBuilder q = new StringBuilder();
            q.Append(" update tw__Towar ") ;
            q.AppendFormat( "set tw_PodstKodKresk = '{0}'", kod);
            q.AppendFormat( "where tw_id = {0}", id);
            SqlCommand sqlc;
            sqlc = new SqlCommand(q.ToString()); // tworzenie instancji SqlCommand do wykonania intrukcji przekazanego w zmiennej q
            sqlc.Connection = this.połączenie; // wskazanie polaczenia do bazy danych
            sqlc.ExecuteNonQuery(); //wykonanie zapytanie
        }


    }
}
