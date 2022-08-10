﻿namespace get_set_full_stack.Models
{
    public class Playlist
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int UserProfileId { get; set; }

        public UserProfile UserProfile { get; set; }
    }
}
