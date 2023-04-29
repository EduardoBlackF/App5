using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms.Internals;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [Preserve(AllMembers = true)]
    [ContentProperty (nameof(Source))]
    
    public class ImageResourceExtension : IMarkupExtension
    {
        public string Source { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        { 
        
            if (Source == null)
             return null;
            
        return ImageSource.FromResource(Source, typeof(ImageResourceExtension).GetTypeInfo().Assembly);
        }
    }
}
