﻿using System;

namespace WebJobs.Script.Cli
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class ActionAttribute : Attribute
    {
        public Context Context { get; set; }

        public Context SubContext { get; set; }

        public string Name { get; set; }
    }
}
