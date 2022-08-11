using get_set_full_stack.Models;
using get_set_full_stack.Utils;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace get_set_full_stack.Repositories
{
    public class TrackRepository : BaseRepository, ITrackRepository
    {

        public TrackRepository(IConfiguration configuration) : base(configuration) { }
        public void Add(Track track)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Track> GetAllTracks()
        {
            throw new System.NotImplementedException();
        }

        public Track GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Track> GetTracksByPlaylistId(int id)
        {
            using (var conn = Connection)
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                                    SELECT pt.Id, pt.SequenceOrder, pt.PlaylistId, pt.TrackId,
                                           t.Name, t.Bpm, t.Notes, t.UserProfileId, t.BandId, t.RunTime, b.Name AS BandName
                                    FROM PlaylistTrack pt
                                    JOIN Track t ON t.Id = pt.TrackId
                                    JOIN Band b ON b.Id = t.BandId
                                    WHERE pt.PlaylistId = @id
                                    ORDER BY pt.SequenceOrder";
                    DbUtils.AddParameter(cmd, "@id", id);

                    var reader = cmd.ExecuteReader();

                    List<Track> tracks = new List<Track>();

                    while (reader.Read())
                    {
                        Track track = new Track
                        {
                            Id = DbUtils.GetInt(reader, "TrackId"),
                            Name = DbUtils.GetString(reader, "Name"),
                            Bpm = DbUtils.GetInt(reader, "Bpm"),
                            UserProfileId = DbUtils.GetInt(reader, "UserProfileId"),
                            BandId = DbUtils.GetInt(reader, "BandId"),
                            BandName = DbUtils.GetString(reader, "BandName")
                        };
                        tracks.Add(track);
                    }
                    return tracks;
                }
            }
        }

        public void Update(Track track)
        {
            throw new System.NotImplementedException();
        }
    }
}
