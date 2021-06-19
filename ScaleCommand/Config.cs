﻿using Exiled.API.Interfaces;
using System.ComponentModel;

namespace ScaleCommand
{
    public sealed class Config : IConfig
    {
        [Description("Whether or not the plugin is enabled on this server.")]
        public bool IsEnabled { get; set; } = true;
    }
}