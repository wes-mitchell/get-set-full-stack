using get_set_full_stack.Models;
using get_set_full_stack.Utils;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace get_set_full_stack.Repositories
{
    public class PlaylistRepository : BaseRepository, IPlaylistRepository
    {
        public PlaylistRepository(IConfiguration configuration) : base(configuration) { }

        public void Add(Playlist playlist)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Playlist> GetAllPlaylists()
        {
            throw new System.NotImplementedException();
        }

        public Playlist GetPlaylistById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Playlist> GetplaylistsByUserId(int id)
        {
            using (var conn = Connection)
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                                    SELECT p.Id AS PlaylistId, p.Description,
                                           up.Id AS UserProfileId, up.FirstName, up.LastName, up.Email, up.IsAdmin, up.IsActive,
                                           b.Id AS BandId, b.Name as BandName
                                    FROM Playlist p
                                    JOIN UserProfile up ON up.Id = p.UserProfileId
                                    JOIN Band b ON b.Id = p.BandId
                                    WHERE up.Id = @id";
                    DbUtils.AddParameter(cmd, "@id", id);

                    var reader = cmd.ExecuteReader();

                    List<Playlist> playlists = new List<Playlist>();

                    while (reader.Read())
                    {
                        Playlist playlist = new Playlist
                        {
                            Id = DbUtils.GetInt(reader, "PlaylistId"),
                            Description = DbUtils.GetString(reader, "Description"),
                            UserProfileId = DbUtils.GetInt(reader, "UserProfileId"),
                            UserProfile = new UserProfile
                            {
                                Id = DbUtils.GetInt(reader, "UserProfileId"),
                                FirstName = DbUtils.GetString(reader, "FirstName"),
                                LastName = DbUtils.GetString(reader, "LastName"),
                                Email = DbUtils.GetString(reader, "Email"),
                                IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                IsAdmin = reader.GetBoolean(reader.GetOrdinal("IsAdmin"))
                            },
                            BandName = DbUtils.GetString(reader, "BandName"),
                            BandId = DbUtils.GetInt(reader, "BandId")
                        };
                        playlists.Add(playlist);
                    }
                    return playlists;
                }
            }
        }

        public void Update(Playlist playlist)
        {
            throw new System.NotImplementedException();
        }
    }
}
