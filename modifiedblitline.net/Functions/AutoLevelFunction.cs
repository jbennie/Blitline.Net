﻿using Newtonsoft.Json;
namespace Blitline.Net.Functions
{
    /// <summary>
    /// Automatically adjusts the levels the colour chanels of an image
    /// </summary>
      [JsonObject(MemberSerialization.OptIn)]
    public class AutoLevelFunction : BlitlineFunction
    {
        public override string Name
        {
            get { return "auto_level"; }
        }

        public override object Params { get { return new { }; } }
    }
}