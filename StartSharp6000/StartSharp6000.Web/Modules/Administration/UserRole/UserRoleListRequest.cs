using Serenity.Services;

namespace StartSharp6000.Administration
{
    public class UserRoleListRequest : ServiceRequest
    {
        public int? UserID { get; set; }
    }
}