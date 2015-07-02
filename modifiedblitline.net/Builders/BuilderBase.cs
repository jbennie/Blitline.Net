using Blitline.Net.Request;
namespace Blitline.Net.Builders
{
    public abstract class BuilderBase<T>: Function
    {
        protected abstract T BuildImp { get; }
        internal abstract T Build();
    }
}