namespace get_set_full_stack.Models
{
    public class Track
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Bpm { get; set; }
        public int UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }
        public int BandId { get; set; }
        public string BandName { get; set; }
    }
}
