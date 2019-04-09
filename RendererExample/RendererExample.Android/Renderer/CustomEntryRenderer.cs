using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using RendererExample;
using RendererExample.Droid.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MyCustomEntry), typeof(CustomEntryRenderer))]
namespace RendererExample.Droid.Renderer
{
#pragma warning disable CS0618 // Type or member is obsolete
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(Android.Graphics.Color.Blue);
                Control.SetTextColor(Android.Graphics.Color.Yellow);

                Control.Touch += Control_Touch;
            }            
        }

        private void Control_Touch(object sender, TouchEventArgs e)
        {
            Control.Text = "Xamarin.Android";
        }
    }
#pragma warning restore CS0618 // Type or member is obsolete
}