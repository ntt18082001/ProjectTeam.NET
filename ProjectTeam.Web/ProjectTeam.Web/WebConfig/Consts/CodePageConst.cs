namespace ProjectTeam.Web.WebConfig.Consts
{
	public class CodePageConst
	{
		// Các code page cho các view của các controller
		public static class Home
		{
			public const string HOME_CODE_PAGE = "HomeIndex";
			public const string PRIVACY_CODE_PAGE = "PrivacyIndex";
		}
        public static class AppUser
        {
            public const string INDEX_USER_CODE_PAGE = "IndexUser";
            public const string CREATE_USER_CODE_PAGE = "CreateUser";
        }
		public static class AppRole
		{
			public const string INDEX_ROLE_CODE_PAGE = "IndexRole";
		}
    }
}
