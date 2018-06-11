using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace myApp.MarkupExtensions
{
    // makes it so you don't have to type ResourceId=myApp.images.troll.jpg in XAML
    [ContentProperty("ResourceId")]
    class EmbeddedImage : IMarkupExtension
    {
        public string ResourceId { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (String.IsNullOrEmpty(ResourceId))
                return null;
            return ImageSource.FromResource(ResourceId);
        }
    }
}
