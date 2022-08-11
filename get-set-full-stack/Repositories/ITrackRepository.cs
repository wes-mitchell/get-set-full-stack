using get_set_full_stack.Models;
using System.Collections.Generic;

namespace get_set_full_stack.Repositories
{
    public interface ITrackRepository
    {
        List<Track> GetAllTracks();
        Track GetById(int id);
        List<Track> GetTracksByPlaylistId(int id);
        void Add(Track track);
        void Update(Track track);
        void Delete(int id);
    }
}
