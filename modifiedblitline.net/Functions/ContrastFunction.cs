﻿using Newtonsoft.Json;
namespace Blitline.Net.Functions
{
    /// <summary>
    /// Adjusts contrasts within the image.
    /// </summary>
      [JsonObject(MemberSerialization.OptIn)]
    public class ContrastFunction : BlitlineFunction
    {
        public override string Name
        {
            get { return "contrast"; }
        }

        public override object Params
        {
            get
            {
                return new
                           {
                               sharpen = Sharpen
                           };
            }
        }

        /// <summary>
        /// Contrast is increased if true (defaults to false)
        /// </summary>
        public bool Sharpen { get; set; }
    }
}
