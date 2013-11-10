﻿// FFXIVAPP.Client
// ArmoryHelper.cs
// 
// © 2013 Ryan Wilson

#region Usings

using System.Collections;
using SmartAssembly.Attributes;

#endregion

namespace FFXIVAPP.Client.Plugins.Parse.Helpers
{
    [DoNotObfuscate]
    public static class ArmoryHelper
    {
        public static string GetClassOrJob(string key)
        {
            Hashtable offsets;
            switch (Constants.CultureInfo.TwoLetterISOLanguageName)
            {
                case "ja":
                case "de":
                case "fr":
                default:
                    offsets = new Hashtable();
                    break;
            }
            return offsets[key] as string;
        }
    }
}