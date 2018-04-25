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
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-K2DSFB8\SQLEXPRESS; Initial Catalog=DiskHouse;Integrated Security=True");
        SqlCommand command;
        SqlCommandBuilder commandBuilder;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        SqlCommandBuilder builder;

        public string ReadNameFromArtist(string s)
        {
            string sr;
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = s;
            reader = command.ExecuteReader();
            if (reader.Read())
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

        public string ReadGenreFromArtist(string s)
        {
            string sr;
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = s;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                sr = Convert.ToString(reader["Genre"]);
                reader.Close();
                connection.Close();
                return sr;
            }

            reader.Close();
            connection.Close();
            return null;

        }

        public string ReadYearFromArtist(string s)
        {
            string sr;
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = s;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                sr = Convert.ToString(reader["Year"]);
                reader.Close();
                connection.Close();
                return sr;
            }

            reader.Close();
            connection.Close();
            return null;

        }

        public int GetArtistId(string numeArtist)
        {
            int i;
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select Id from artists where Name='" + numeArtist + "'";
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

        public ArrayList ReadAlbumsForArtist(string s)
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

        public ArrayList ReadAlbums()
        {

            ArrayList sr = new ArrayList();
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select name from albums";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                sr.Add(Convert.ToString(reader["Name"]));
            }
            reader.Close();
            connection.Close();
            return sr;
        }

        public ArrayList ReadArtists()
        {

            ArrayList sr = new ArrayList();
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select name from artists order by name";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                sr.Add(Convert.ToString(reader["Name"]));
            }
            reader.Close();
            connection.Close();
            return sr;
        }

        public int GetAlbumId(string numeArtist, string numeAlbum)
        {
            int i;
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select Id from Albums where (Name='" + numeAlbum + "' and [Artist.Id]=(Select Id from Artists where Name='"+numeArtist+"'))";
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

        public int CheckLogIn(string user, string pass)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select Name,Password,Rights from users";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if ((Convert.ToString(reader["Name"]) == user) && (Convert.ToString(reader["Password"]) == pass))
                {
                    if (Convert.ToInt32(reader["Rights"]) == 1)
                    {
                        reader.Close();
                        connection.Close();
                        return -1;
                    }

                    else
                    {
                        reader.Close();
                        connection.Close();
                        return 1;
                    }


                }
            }
            reader.Close();
            connection.Close();
            return 0;
        }

        public ArrayList ReadSongsForAlbum(string i)
        {

            ArrayList sr = new ArrayList();
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select Name,Length from Songs where [Album.Id]="+i;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                sr.Add(Convert.ToString(reader["Name"]+"....."+reader["Length"]));
            }
            reader.Close();
            connection.Close();
            return sr;
        }

        public int GetSongId(string songName)
        {
            int i;
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select Id from songs where Name='" + songName + "'";
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

      /*  public void AddUser(string numeArtist,string pass)
        {
            command.CommandText = "Insert into users";
        }*/

        public void AddAlbum(string albumName,DateTime year,string genre, int artistId)
        {
            adapter = new SqlDataAdapter("SELECT * FROM Albums", connection);
            commandBuilder = new SqlCommandBuilder(adapter);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Albums");
            DataRow dataRow = dataSet.Tables["Albums"].NewRow();
            dataRow["Name"] = albumName;
            dataRow["Year"] = year;
            dataRow["Genre"] = genre;
            dataRow["Artist.Id"] = artistId;
            dataSet.Tables["Albums"].Rows.Add(dataRow);
            try
            {
                adapter.Update(dataSet, "Albums");
                
                
            }
            catch (SqlException ex)
            {
                Console.WriteLine(" Nu am putut actualiza baza de date: " + ex.Message);
            }


            //command.CommandText = "Insert into Albums(Name,Year,Genre,[Artist.Id]) Values ('"+albumName+"',"+year+",'"+genre+"',"+artistId+")";

        }

        public void AddArtist(string artistName, string description, string members)
        {
            adapter = new SqlDataAdapter("SELECT * FROM Artists", connection);
            commandBuilder = new SqlCommandBuilder(adapter);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Artists");
            DataRow dataRow = dataSet.Tables["Artists"].NewRow();
            dataRow["Name"] = artistName;
            dataRow["Description"] = description;
            dataRow["Members"] = members;
            dataRow["userid"] = 3;
            
            dataSet.Tables["Artists"].Rows.Add(dataRow);
            try
            {
                adapter.Update(dataSet, "Artists");


            }
            catch (SqlException ex)
            {
                Console.WriteLine(" Nu am putut actualiza baza de date: " + ex.Message);
            }



        }

        public void AddSong(string songName,TimeSpan time,int albumId)
        {
            adapter = new SqlDataAdapter("SELECT * FROM songs", connection);
            commandBuilder = new SqlCommandBuilder(adapter);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Songs");
            DataRow dataRow = dataSet.Tables["Songs"].NewRow();
            dataRow["Name"] = songName;
            dataRow["Length"] = time;
            dataRow["Album.Id"] = albumId;
            dataSet.Tables["songs"].Rows.Add(dataRow);
            try
            {
                adapter.Update(dataSet, "songs");


            }
            catch (SqlException ex)
            {
                Console.WriteLine(" Nu am putut actualiza baza de date: " + ex.Message);
            }
        }

        public bool DeleteSong(int songIndex)
        {
            connection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM songs ORDER BY id", connection);
            
            builder = new SqlCommandBuilder(adapter);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "songs");
           
            DataColumn[] pk = new DataColumn[1];
            pk[0] = dataSet.Tables["songs"].Columns["id"];
            dataSet.Tables["songs"].PrimaryKey = pk;
            DataRow caut = null;
            while (caut == null)
            {

                caut = dataSet.Tables["songs"].Rows.Find(songIndex);
            }

            try
            {
                
                caut.Delete();
                adapter.Update(dataSet, "songs");
                connection.Close();
                Console.WriteLine("OK");
                return true;
            }
            catch (SqlException ex)
            {
                connection.Close();
                Console.WriteLine("Error: 0" + ex);
                return false;
            }
            
           
        }

        public bool DeleteAlbum(string albumName)
        {
            connection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Albums ORDER BY name", connection);

            builder = new SqlCommandBuilder(adapter);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Albums");

            DataColumn[] pk = new DataColumn[1];
            pk[0] = dataSet.Tables["Albums"].Columns["name"];
            dataSet.Tables["Albums"].PrimaryKey = pk;
            DataRow caut = null;
            while (caut == null)
            {

                caut = dataSet.Tables["Albums"].Rows.Find(albumName);
            }

            try
            {

                caut.Delete();
                adapter.Update(dataSet, "Albums");
                connection.Close();
                Console.WriteLine("OK");
                return true;
            }
            catch (SqlException ex)
            {
                connection.Close();
                Console.WriteLine("Error: 0" + ex);
                return false;
            }


        }

        public void UpdateAlbum(string numeAlbum, string genre, string year,ArrayList list,string numeAlbumVechi)
        {
            int row = 0;
            int ok = 0;
            foreach(string slist in list)
            {
                if (numeAlbumVechi == slist)
                    ok = 1;
                if (numeAlbumVechi != slist && ok == 0)
                    row++;
                
                
            }

            adapter = new SqlDataAdapter("Select * from Albums", connection);


            builder = new SqlCommandBuilder(adapter);
            DataSet dataset = new DataSet();

            adapter.Fill(dataset, "Albums");
           
            dataset.Tables["Albums"].Rows[row]["Name"] = numeAlbum;
            dataset.Tables["Albums"].Rows[row]["Year"] = Convert.ToDateTime(year);
            dataset.Tables["Albums"].Rows[row]["Genre"] = genre;
            adapter.Update(dataset, "Albums");
            
            connection.Close();
            
        }

        public string ArtistForUser(string user)
        {
            string sr;
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select Name from Artists where userid=(Select id from users where name='"+user+"')";
            reader = command.ExecuteReader();
            if (reader.Read())
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
    }

}

