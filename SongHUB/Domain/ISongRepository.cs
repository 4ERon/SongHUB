using System.Collections.Generic;

namespace SongHUB.Domain
{
    public interface ISongRepository
    {
        List<Song> GetAllSongs();
        Song GetSongById(int id);
        int SaveSong(Song song);
        bool DeleteSong(int id);

    }
}