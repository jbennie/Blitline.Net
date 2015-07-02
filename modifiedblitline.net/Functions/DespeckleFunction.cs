using Newtonsoft.Json;
namespace Blitline.Net.Functions
{
    /// <summary>
    /// Reduces the speckle noise while preserving edges
    /// </summary>
      [JsonObject(MemberSerialization.OptIn)]
    public class DespeckleFunction : BlitlineFunction
    {
        public override string Name
        {
            get { return "despeckle"; }
        }

        public override dynamic Params
        {
            get { return new {}; }
        }
    }
}