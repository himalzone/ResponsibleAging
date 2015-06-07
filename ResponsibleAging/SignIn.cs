
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

namespace ResponsibleAging
{
	[Activity (Label = "SignIn")]			
	public class SignIn : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			SetContentView (Resource.Layout.Login);
			var txtView = FindViewById<TextView>(Resource.Id.textViewID8);
			DBRepository dbr = new DBRepository ();
			string task = dbr.GetTaskById (2);
			//Toast.MakeText (this, task, ToastLength.Short).Show ();

			txtView.Text = task+", Fill in your details below";

			var mainMenu = FindViewById<Button> (Resource.Id.button4);
			var Register = FindViewById<Button> (Resource.Id.btnTask);
			var AddRecord = FindViewById<Button> (Resource.Id.InsertRecord);

			Register.Click += (sender, e) =>
			{
				
				EditText txtTask = FindViewById<EditText> (Resource.Id.txtTask);
				string result = dbr.updateRecord (2 , txtTask.Text);
				Toast.MakeText (this, result, ToastLength.Short).Show ();
			};

			AddRecord.Click += (sender, e) =>
			{
				var intent = new Intent(this, typeof(InsertRecordActivity));
				StartActivity(intent);
			};

			mainMenu.Click += (sender, e) =>
			{
				var intent = new Intent(this, typeof(MainActivity));
				StartActivity(intent);
			};

			Register.Click += (sender, e) => {
				var intent = new Intent (this, typeof(InsertRecordActivity));
				StartActivity (intent);
			};
		}
	}
}

