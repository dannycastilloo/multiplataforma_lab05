using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Xamarin.Forms;

namespace lab05
{
    [PreserveSig(AllMembers = true)]
    [ContentProperty(nameof(Source))]
    public class ImageResourceExtension : IMarkupExtension
    {
        public string Source { get; set; } 

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
                return null;

            var imageSource = ImageSource.FromResource(Source, Type(ImageResourceExtension).GetTypeInfo(), Assembly);
            return imageSource;
        }
    }
}
