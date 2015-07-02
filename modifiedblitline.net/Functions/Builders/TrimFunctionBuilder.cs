namespace Blitline.Net.Functions.Builders
{
    public class TrimFunctionBuilder : FunctionBuilder<TrimFunction>
    {
        /// <summary>
        /// Fuzz the trimming edge. For JPEGs, due to compression or anti-aliasing often times edges aren’t a clean line. The “fuzz” values allows you to trim with a slight extra fuzz around the trim area.
        /// </summary>
        /// <param name="fuzz">0-100</param>
        /// <returns>self</returns>
        public TrimFunctionBuilder WithParams(int fuzz)
        {
            fuzz = (fuzz > 100) ? 100 : fuzz; // not more than 100;
            BuildImp.Fuzz = (fuzz < 0) ? 0 : fuzz;  // not less than 0;            
            return this;
        }
    }
}
