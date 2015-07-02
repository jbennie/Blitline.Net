using Newtonsoft.Json;
namespace Blitline.Net.Functions
{
    /// <summary>
    /// Resize the image to fit within the specified dimensions while retaining the original aspect ratio. 
    /// The image may be shorter or narrower than specified in the smaller dimension but will not be larger than the specified values
    /// Common English Translation: This is probably the crop you want if you need to rescale a photo down to a smaller size while keeping the same height to width ratio.
    /// </summary>
      [JsonObject(MemberSerialization.OptIn)]
    public class ResizeToFitFunction : BlitlineFunction
    {
        public override string Name
        {
            get { return "resize_to_fit"; }
        }

        public override object @Params
        {
            get
            {
                return new
                {
                    width = Width,
                    height = Height,
                    only_shrink_larger = OnlyShrinkLarger
                };
            }
        }

        /// <summary>
        /// Width of desired image
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Height of desired image
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Don't upsize image
        /// </summary>
        public bool OnlyShrinkLarger { get; set; }
    }
}