using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace DiscHouse
{
    class DbConnect
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-FRVD8PN; Initial Catalog=DiskHouse;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;
        SqlDataAdapter adapter;


        public string ReadNameFromArtist(string s)
        {
            string sr;
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = s;
            reader = command.ExecuteReader();
            if(reader.Read())
            {
                sr = Convert.ToString(reader["Name"]);
                reader.Close();
                connection.Close();
                return sr;
            }
            
            reader.Close();
            connection.Close();
            return null;

        }
        public int GetArtistId(string s)
        {
            int i;
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select Id from artists where Name='"+s+"'";
            reader = command.ExecuteReader();
           if( reader.Read())
            {
                i = Convert.ToInt32(reader["Id"]);

                reader.Close();
                connection.Close();
                return i;
            }
            

            reader.Close();
            connection.Close();
            return 0;

        }
        public ArrayList ReadAlbumsForArtist(string s)
        {
            
            ArrayList sr = new ArrayList();
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = s;
            reader = command.ExecuteReader();
            while(reader.Read())
            {
                sr.Add( Convert.ToString(reader["Name"]));
            }
            reader.Close();
            connection.Close();
            return sr;
        }

        public int GetAlbumId(string s2, string s)
        {
            int i;
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select Id from albums where Name='" + s + "'";
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                i = Convert.ToInt32(reader["Id"]);

                reader.Close();
                connection.Close();
                return i;
            }


            reader.Close();
            connection.Close();
            return 0;

        }

        public ArrayList ReadSongsForAlbum(string s)
        {

            ArrayList sr = new ArrayList();
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = s;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                sr.Add(Convert.ToString(reader["Name"]));
            }
            reader.Close();
            connection.Close();
            return sr;
        }





    }
}
