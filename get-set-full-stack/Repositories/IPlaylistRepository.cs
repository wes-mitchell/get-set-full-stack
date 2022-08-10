using get_set_full_stack.Models;
using System.Collections.Generic;

namespace get_set_full_stack.Repositories
{
    public interface IPlaylistRepository
    {
        List<Playlist> GetAllPlaylists();
        Playlist GetPlaylistById(int id);
        List<Playlist> GetplaylistsByUserId(int id);
        void Add(Playlist playlist);
        void Update(Playlist playlist);
        void Delete(int id);
    }
}
