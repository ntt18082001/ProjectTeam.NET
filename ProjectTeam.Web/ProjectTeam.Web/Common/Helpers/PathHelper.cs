using Microsoft.AspNetCore.Hosting;

namespace ProjectTeam.Web.Common.Helpers
{
	public class PathHelper
	{
		static string GetFullPathNormalized(string path)
		{
			return Path.TrimEndingDirectorySeparator(Path.GetFullPath(path));
		}

		public static string MapPath(string path, string basePath = null)
		{
			//if (string.IsNullOrEmpty(basePath))
			//{
			//	basePath = Startup.WebRootPath;
			//}

			path = path.Replace("~/", "").TrimStart('/').Replace('/', '\\');
			return GetFullPathNormalized(Path.Combine(basePath, path));
		}
	}
}
