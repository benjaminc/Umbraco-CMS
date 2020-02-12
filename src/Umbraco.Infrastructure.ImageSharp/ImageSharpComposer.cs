using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.Models;

namespace Umbraco.Infrastructure.ImageSharp
{
    public class ImageSharpComposer : ICoreComposer
    {
        public void Compose(Composition composition)
        {
            composition.RegisterUnique<IImageUrlGenerator, ImageSharpImageUrlGenerator>();
        }
    }
}
