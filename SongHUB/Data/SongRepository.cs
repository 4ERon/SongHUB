using SongHUB.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongHUB.Data
{
    public class SongRepository : ISongRepository
    {
        private readonly string _connectionString;

        public SongRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Song> GetAllSongs()
        {
            var songs = new List<Song>();

            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand("sp_GetAllSongs", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            connection.Open();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                songs.Add(MapSong(reader));
            }

            return songs;
        }

        public void Add(Song song)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand("sp_AddSong", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.AddWithValue("@Title", song.Title);
            command.Parameters.AddWithValue("@Singer", song.Singer);
            command.Parameters.AddWithValue("@SongType", song.SongType);

            connection.Open();
            command.ExecuteNonQuery();
        }

        public void Update(Song song)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand("sp_UpdateSong", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.AddWithValue("@Id", song.Id);
            command.Parameters.AddWithValue("@Title", song.Title);
            command.Parameters.AddWithValue("@Singer", song.Singer);
            command.Parameters.AddWithValue("@SongType", song.SongType);

            connection.Open();
            command.ExecuteNonQuery();
        }

        public void Delete(int songId)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand("sp_DeleteSong", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.AddWithValue("@Id", songId);

            connection.Open();
            command.ExecuteNonQuery();
        }

        private Song MapSong(SqlDataReader reader)
        {
            return new Song
            {
                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                Title = reader.GetString(reader.GetOrdinal("Title")),
                Singer = reader.GetString(reader.GetOrdinal("Singer")),
                SongType = reader.GetString(reader.GetOrdinal("SongType")),
                CreatedDate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"))
            };
        }
    }
}
