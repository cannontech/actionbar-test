
using Android.App;
using Android.OS;
using System;
using Android.Widget;

namespace actionbartest
{
    [Activity(Label = "AddPerson")]			
    public class AddPerson : Activity
    {
        public IPersonRespository Repo { get; set; }
        //public ITest Test { get; set; }
     
        public AddPerson()
        {
            try
            {
                //Test = TinyIoC.TinyIoCContainer.Current.Resolve<ITest>();
                Repo = TinyIoC.TinyIoCContainer.Current.Resolve<IPersonRespository>();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.AddPerson);

            var saveButton = FindViewById<Button>(Resource.Id.saveButton);
            var firstName = FindViewById<EditText>(Resource.Id.firstName);
            var lastName = FindViewById<EditText>(Resource.Id.lastName);

            saveButton.Click += delegate
                {
                    Repo.SavePerson(new Person
                        {
                            FirstName = firstName.Text,
                            LastName = lastName.Text
                        }); 

                    firstName.Text = lastName.Text = string.Empty;
                };
        }
    }
}

