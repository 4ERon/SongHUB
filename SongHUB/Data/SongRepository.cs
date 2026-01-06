using SongHUB.Domain;
using Microsoft.Data.SqlClient;
using System.Data;

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

        using (var connection = new SqlConnection(_connectionString))
        using (var command = new SqlCommand("sp_GetAllSongs", connection))
        {
            command.CommandType = CommandType.StoredProcedure;

            connection.Open();
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    songs.Add(MapSong(reader));
                }
            }
        }

        return songs;
    }

    public Song? GetSongById(int id)
    {
        using (var connection = new SqlConnection(_connectionString))
        using (var command = new SqlCommand("sp_GetSongById", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = id;

            connection.Open();
            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    return MapSong(reader);
                }
            }
        }

        return null;
    }

    public int SaveSong(Song song)
    {
        using var connection = new SqlConnection(_connectionString);
        using var command = new SqlCommand("sp_SaveSong", connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.Add("@Id", SqlDbType.Int).Value =
            song.Id == 0 ? DBNull.Value : song.Id;

        command.Parameters.Add("@Title", SqlDbType.NVarChar).Value = song.Title;
        command.Parameters.Add("@Singer", SqlDbType.NVarChar).Value = song.Singer;
        command.Parameters.Add("@SongType", SqlDbType.NVarChar).Value = song.SongType;
        command.Parameters.Add("@Lyrics", SqlDbType.NVarChar).Value = song.Lyrics;

        connection.Open();
        return Convert.ToInt32(command.ExecuteScalar()); // 🔥 IMPORTANT
    }


    public bool DeleteSong(int songId)
    {
        using (var connection = new SqlConnection(_connectionString))
        using (var command = new SqlCommand("sp_DeleteSong", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = songId;

            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }
    }

    private Song MapSong(SqlDataReader reader)
    {
        return new Song
        {
            Id = reader.GetInt32(reader.GetOrdinal("Id")),
            Title = reader.GetString(reader.GetOrdinal("Title")),
            Singer = reader.GetString(reader.GetOrdinal("Singer")),
            SongType = reader.GetString(reader.GetOrdinal("SongType")),
            Lyrics = reader.GetString(reader.GetOrdinal("Lyrics")),
            CreatedDate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"))
        };
    }
}
