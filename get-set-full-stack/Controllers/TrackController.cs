using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using get_set_full_stack.Models;
using get_set_full_stack.Repositories;
using System.Collections.Generic;
using System.Security.Claims;

namespace get_set_full_stack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackController : ControllerBase
    {
        private readonly ITrackRepository _trackRepo;
        private readonly IPlaylistRepository _playlistRepo;
        private readonly IUserProfileRepository _userProfileRepository;

        public TrackController(IPlaylistRepository playlistRepo, ITrackRepository trackRepo, IUserProfileRepository userProfileRepository)
        {
            _trackRepo = trackRepo;
            _playlistRepo = playlistRepo;
            _userProfileRepository = userProfileRepository;
        }

        [HttpGet("playlist/{id}")]
        public IActionResult GetTracksByPlaylist(int id)
        {
            List<Track> tracks = _trackRepo.GetTracksByPlaylistId(id);
            if (tracks.Count == 0)
            {
                return NotFound();
            }
            return Ok(tracks);
        }
    }
}
