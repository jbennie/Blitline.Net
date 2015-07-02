﻿using Blitline.Net.ParamOptions;
using Newtonsoft.Json;

namespace Blitline.Net.Functions
{
    /// <summary>
    /// Resize to fit, but will pad to keep the aspect ratio. 
    /// So for example, if you are going from a 3:4 aspect ratio to a 3:2 aspect ratio, 
    /// this method will assure the result the desired output size, and pad the filled in area with a specified color.
    /// </summary>
      [JsonObject(MemberSerialization.OptIn)]
    public class PadResizeToFitFunction : BlitlineFunction
    {
        public override string Name
        {
            get { return "pad_resize_to_fit"; }
        }

        public override object Params
        {
            get
            {
                return new
                {
                    width = Width,
                    height = Height,
                    color = Colour,
                    gravity = Gravity.ToString(), 
                    only_resize_large = OnlyResizeLarge
                };
            }
        }

        public int Width { get; set; }
        public int Height { get; set; }
        public string Colour { get; set; }
        public Gravity Gravity { get; set; }
        public bool OnlyResizeLarge { get; set; }

        //public PadResizeToFitFunction()
        //{
        //    Colour = "#ffffff";
        //    Gravity = Gravity.CenterGrativty;
        //}
    }
}
