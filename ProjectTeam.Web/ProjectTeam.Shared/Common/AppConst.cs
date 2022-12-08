using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTeam.Share.Common
{
	public static class AppConst
	{
		// Các code page cho các view của các controller
		public static class Home
		{
			public const string HOME_CODE_PAGE = "HomeIndex";
			public const string PRIVACY_CODE_PAGE = "PrivacyIndex";
		}
		public static class Test
		{
			public const string TEST_CODE_PAGE = "IndexTest";
			public const string TEST_VIEW_CODE_PAGE = "TestView";
		}
		public static class Game
		{
			public const string GAME_CODE_PAGE = "IndexGame";
		}
	}
}
