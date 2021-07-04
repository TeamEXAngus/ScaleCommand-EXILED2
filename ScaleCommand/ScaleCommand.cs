using Exiled.API.Enums;
using Exiled.API.Features;
using System;

namespace ScaleCommand
{
    public class ScaleCommand : Plugin<Config>
    {
        public static ScaleCommand Instance;
        public override PluginPriority Priority { get; } = PluginPriority.Medium;

        public override Version RequiredExiledVersion { get; } = new Version(2, 10, 0);
        public override Version Version { get; } = new Version(1, 0, 2);

        //Copied from tutorial
        private ScaleCommand()
        {
        }

        //Run startup code when plugin is enabled
        public override void OnEnabled()
        {
            Instance = this;
            RegisterEvents();
        }

        //Run shutdown code when plugin is disabled
        public override void OnDisabled()
        {
            UnregisterEvents();
        }

        //Plugin startup code
        public void RegisterEvents()
        {
        }

        //Plugin shutdown code
        public void UnregisterEvents()
        {
        }
    }
}