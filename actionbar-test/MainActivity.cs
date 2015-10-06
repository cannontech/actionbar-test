using Android.App;
using Android.OS;
using Android.Widget;

namespace actionbartest
{
    [Activity(Label = "actionbar-test", MainLauncher = true, Icon = "@drawable/icon", Theme="@style/CustomActionBarTheme")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            ActionBar.SetCustomView(Resource.Layout.ActionBar);
            ActionBar.SetDisplayShowCustomEnabled(true);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var addButton = (LinearLayout)ActionBar.CustomView.FindViewById<LinearLayout>(Resource.Id.add);

            addButton.Click += (object sender, System.EventArgs e) => 
            {
                var x = 5;
            };  
        }
    }
}


