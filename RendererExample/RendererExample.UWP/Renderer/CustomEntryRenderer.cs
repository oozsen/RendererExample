using RendererExample;
using RendererExample.UWP.Renderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(MyCustomEntry), typeof(CustomEntryRenderer))]
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

                Control.GotFocus += Control_GotFocus;
            }
        }

        private void Control_GotFocus(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Control.Text = "Xamarin UWP";
        }
    }
}
