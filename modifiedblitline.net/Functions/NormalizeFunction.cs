using Newtonsoft.Json;
namespace Blitline.Net.Functions
{
    /// <summary>
    /// Changes the contrast of a color image by adjusting the pixel color to span the entire range of colors available.
    /// </summary>
      [JsonObject(MemberSerialization.OptIn)]
    public class NormalizeFunction : BlitlineFunction
    {
        public override string Name
        {
            get { return "normalize"; }
        }

        public override dynamic Params
        {
            get { return new {}; }
        }
    }
}