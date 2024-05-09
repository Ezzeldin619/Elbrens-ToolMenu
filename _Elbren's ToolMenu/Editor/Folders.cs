using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using static System.IO.Directory;
using static System.IO.Path;
using static UnityEngine.Application;

namespace Elbrens
{
	public static class Folders
	{

		//okay ! i just coded a system for unity that auto creates a folder structure and another one that imports custom unity packages
		//you want to see it ?

		public static void CreateDirectories(string root, params string[] dir)
		{
			var fullpath = Combine(dataPath, root);
			foreach (var newDirectory in dir)
				CreateDirectory(Combine(fullpath, newDirectory));

		}
	}
}