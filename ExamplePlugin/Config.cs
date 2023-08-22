﻿using Exiled.API.Interfaces;

namespace ExamplePlugin
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        public bool Debug { get; set; }
    }
}
