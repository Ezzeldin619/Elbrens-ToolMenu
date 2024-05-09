using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using UnityEngine;
using static UnityEditor.AssetDatabase;

namespace Elbrens
{
	public static class Packages
	{

		public static void InstallUnityPackages(string packageName)
		{
			UnityEditor.PackageManager.Client.Add($"com.unity.{packageName}");
			Refresh();

		}
	}
}