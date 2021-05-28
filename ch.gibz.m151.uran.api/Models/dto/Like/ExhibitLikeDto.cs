namespace ch.gibz.m151.uran.api.Models.dto
{
    /// <summary>
    /// DTO for an exhibit-like entity
    /// Has intel about which comment was liked by which user
    /// </summary>
    public class ExhibitLikeDto
    {
        public int Id { get; set; }
        public int ExhibitId { get; set; }
        public int UserId { get; set; }
    }
}
