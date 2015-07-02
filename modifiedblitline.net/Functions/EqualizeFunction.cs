using System.Text.RegularExpressions;
using System;
using Newtonsoft.Json;

namespace Blitline.Net.Functions
{
    /// <summary>
    /// Equalizes an image (Auto-adjust image).
    /// </summary>
     [JsonObject(MemberSerialization.OptIn)]
    public class EqualizeFunction : BlitlineFunction
    {
        public override string Name
        {
            get { return "equalize"; }
        }

        public override object Params { get { return new {}; } }
    }

}
