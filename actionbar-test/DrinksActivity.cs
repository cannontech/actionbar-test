
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

namespace actionbartest
{
    [Activity(Label = "Drinks", Theme="@style/CustomActionBarTheme")]			
    public class DrinksActivity : Activity
    {
        public DrinksActivity()
        {
            var container = TinyIoC.TinyIoCContainer.Current;
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            ActionBar.SetCustomView(Resource.Layout.ActionBar);
            ActionBar.SetDisplayShowCustomEnabled(true);

            SetContentView(Resource.Layout.DrinksList);
        }

        protected override void OnStart()
        {
            base.OnStart();
        }
    }
}

