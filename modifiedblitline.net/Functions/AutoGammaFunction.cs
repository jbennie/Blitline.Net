﻿using Newtonsoft.Json;
namespace Blitline.Net.Functions
{
    /// <summary>
    /// Automatically adjusts the brightness levels of the channels of an image
    /// </summary>
      [JsonObject(MemberSerialization.OptIn)]
    public class AutoGammaFunction : BlitlineFunction
    {
        public override string Name
        {
            get { return "auto_gamma"; }
        }

        public override object Params { get { return new { }; } }
    }
}