using RendererExample.UWP.Renderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(Entry), typeof(CustomEntryRenderer))]
namespace RendererExample.UWP.Renderer
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.FontStyle = Windows.UI.Text.FontStyle.Italic;
                Control.PlaceholderText = "UWP";
            }
        }
    }
}
