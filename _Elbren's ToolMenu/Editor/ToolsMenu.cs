using UnityEditor;

#region Static Code References
	using static System.IO.Directory;
    using static System.IO.Path;
    using static UnityEngine.Application;
    using static UnityEditor.AssetDatabase;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using UnityEngine;
#endregion

namespace Elbrens
{
    public static class ToolsMenu
	{

        static string[] default2DFolderStructure = new string[] { "Sprites", "_Scripts", "Scene" };
        static string[] default3DFolderStructure = new string[] { "Images", "_Scripts", "Scene" };
        
        [MenuItem("Tools/Setup/Folder Structure/Create Default 2D Folders")]
        public static void Create2dDefaultFolder() {
			Folders.CreateDirectories("_Project", default2DFolderStructure);
            Refresh();
        }

		[MenuItem("Tools/Setup/Folder Structure/Create Default 3D Folders")]
		public static void Create3dDefaultFolder()
		{
			Folders.CreateDirectories("_Project", default3DFolderStructure);
			Refresh();
		}



        [MenuItem("Tools/Setup/Packages/New Input System")]
        static async void AddNewInputSystem() => Packages.InstallUnityPackages("inputsystem");

		[MenuItem("Tools/Setup/Packages/Post Processing")]
		static async void AddPostProcessing() => Packages.InstallUnityPackages("postprocessing");

		[MenuItem("Tools/Setup/Packages/Cinemachine")]
		static async void AddCinemachine() => Packages.InstallUnityPackages("cinemachine");
	}
}
