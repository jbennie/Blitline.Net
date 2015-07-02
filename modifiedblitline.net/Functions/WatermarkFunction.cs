﻿using Blitline.Net.ParamOptions;
using Newtonsoft.Json;

namespace Blitline.Net.Functions
{
      [JsonObject(MemberSerialization.OptIn)]
    public class WatermarkFunction : BlitlineFunction
    {
        public override string Name
        {
            get { return "watermark"; }
        }

        public override object Params
        {
            get
            {
                return new
                {
                    text = Text,
                    gravity = Gravity,
                    point_size = PointSize,
                    font_family = FontFamily,
                    opacity = Opacity
                };
            }
        }

        public string Text { get; set; }
        public Gravity Gravity { get; set; }
        public int PointSize { get; set; }
        public string FontFamily { get; set; }
        public decimal Opacity { get; set; }


	    public WatermarkFunction()
        {
            Gravity = Gravity.CenterGrativty;
            PointSize = 94;
            FontFamily = "Helvetica";
            Opacity = 0.45m;
        }
    }
}
