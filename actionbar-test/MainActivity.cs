using Android.App;
using Android.OS;
using Android.Widget;

namespace actionbartest
{
    [Activity(Label = "actionbar-test", MainLauncher = true, Icon = "@drawable/icon", Theme="@style/CustomActionBarTheme")]
    public class MainActivity : Activity
    {
        public IPersonRespository PersonRepository { get; set; }

        public MainActivity()
        {
            var container = TinyIoC.TinyIoCContainer.Current;

            //add all the repositories to the container
            container.Register<IPersonRespository, PersonRespository>();
            container.Register<ITest, Test>();

            //pull out the repo we need
            PersonRepository = TinyIoC.TinyIoCContainer.Current.Resolve<IPersonRespository>();
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            ActionBar.SetCustomView(Resource.Layout.ActionBar);
            ActionBar.SetDisplayShowCustomEnabled(true);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var addButton = (LinearLayout)ActionBar.CustomView.FindViewById<LinearLayout>(Resource.Id.add);
            var field = FindViewById<TextView>(Resource.Id.tmp);

            field.Text = PersonRepository.GetPerson(1).FirstName;

            addButton.Click += delegate 
                {
                    StartActivity(typeof(AddPerson));
                };  
        }
    }
}


