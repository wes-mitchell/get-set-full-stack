using get_set_full_stack.Models;
using get_set_full_stack.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;

namespace get_set_full_stack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaylistController : ControllerBase
    {
        private readonly IPlaylistRepository _playlistRepo;
        private readonly IUserProfileRepository _userProfileRepository;

        public PlaylistController(IPlaylistRepository playlistReop, IUserProfileRepository userProfileRepository)
        {
            _playlistRepo = playlistReop;
            _userProfileRepository = userProfileRepository;
        }

        [HttpGet("userplaylists")]
        public IActionResult GetUserPlaylists()
        {
            var currentUser = GetCurrentUserProfile();
            List<Playlist> playlists = _playlistRepo.GetplaylistsByUserId(currentUser.Id);
            if (playlists.Count == 0)
            {
                return NotFound();
            }
            return Ok(playlists);
        }
        private UserProfile GetCurrentUserProfile()
        {
            var firebaseUserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return _userProfileRepository.GetByFirebaseUserId(firebaseUserId);
        }

    }
}
