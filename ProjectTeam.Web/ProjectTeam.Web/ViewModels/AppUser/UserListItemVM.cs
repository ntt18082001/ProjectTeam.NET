namespace ProjectTeam.Web.ViewModels.AppUser
{
    public class UserListItemVM
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber1 { get; set; }
        public string Email { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string RoleName { get; set; }
        public DateTime? BlockedTo { get; set; }
        public bool IsBlock
        {
            get
            {
                var now = DateTime.Now;
                if (BlockedTo.HasValue && BlockedTo > now)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
