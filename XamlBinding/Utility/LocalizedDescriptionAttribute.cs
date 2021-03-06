﻿using System;
using System.ComponentModel;
using XamlBinding.Resources;

namespace XamlBinding.Utility
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    internal sealed class LocalizedDescriptionAttribute : DescriptionAttribute
    {
        private readonly string id;

        public LocalizedDescriptionAttribute(string id)
        {
            this.id = id;
        }

        public override string Description => Resource.ResourceManager.GetString(this.id) ?? string.Empty;
    }
}
