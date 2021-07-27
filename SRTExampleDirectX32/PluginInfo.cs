using SRTPluginBase;
using System;

namespace SRTExampleDirectX32
{
    internal class PluginInfo : IPluginInfo
    {
        public string Name => "DirectX Overlay UI (Dino Crisis 1)";

        public string Description => "A DirectX-based Overlay User Interface for displaying Dino Crisis 1 game memory values.";

        public string Author => "VideoGameRoulette";

        public Uri MoreInfoURL => new Uri("https://github.com/SpeedrunTooling/SRTPluginUIDinoCrisis1DirectXOverlay");

        public int VersionMajor => assemblyFileVersion.ProductMajorPart;

        public int VersionMinor => assemblyFileVersion.ProductMinorPart;

        public int VersionBuild => assemblyFileVersion.ProductBuildPart;

        public int VersionRevision => assemblyFileVersion.ProductPrivatePart;

        private System.Diagnostics.FileVersionInfo assemblyFileVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
    }
}
