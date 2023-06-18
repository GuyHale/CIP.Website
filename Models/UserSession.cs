namespace CIP.Website.Models
{
    public class UserSession
    {
        public AuthenticatedUser? AuthenticatedUser { get; set; } = null;
        public bool IsAuthenticated { get; set; } = false;
    }
}
