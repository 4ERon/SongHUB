using System.Collections.Generic;

namespace SongHUB.Domain
{
    public interface ISongRepository
    {
        List<Song> GetAllSongs();
        Song GetSongById(int id);
        int AddSong(Song song);
        bool UpdateSong(Song song);
        bool DeleteSong(int id);
    }
}