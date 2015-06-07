using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ResponsibleAging
{
	[Activity (Label = "Responsible Aging", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		//int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			//creating the DataBase
			DBRepository dbr = new DBRepository ();
			var result = dbr.CreateDB ();
			Toast.MakeText (this, result, ToastLength.Short).Show ();

			// creating table
				//DBRepository dbr = new DBRepository ();
				result = dbr.CreateTable ();
				Toast.MakeText (this, result, ToastLength.Short).Show ();


			// Get our button from the layout resource,
			//and attach an event to it
			var button = FindViewById<ImageButton> (Resource.Id.imageButton1);
			var button2 = FindViewById<ImageButton> (Resource.Id.imageButton2);
			var button3 = FindViewById<ImageButton> (Resource.Id.imageButton3);
			var button4 = FindViewById<ImageButton> (Resource.Id.imageButton4);
			var button5 = FindViewById<ImageButton> (Resource.Id.imageButton5);
			var button6 = FindViewById<ImageButton> (Resource.Id.imageButton6);
			var button7 = FindViewById<ImageButton> (Resource.Id.imageButton7);
			var button8 = FindViewById<ImageButton> (Resource.Id.imageButton8);

			button.Click += (sender, e) =>
			{
				var intent = new Intent(this, typeof(Medication));
				StartActivity(intent);
			};

			button2.Click += (sender, e) =>
			{
				var Exercise = new Intent(this, typeof(Exercise));
				StartActivity(Exercise);
			};

			button3.Click += (sender, e) =>
			{
				var ConnectToWatch = new Intent(this, typeof(ConnectToWatch));
				StartActivity(ConnectToWatch);
			};

			button4.Click += (sender, e) =>
			{
				var HeartRate = new Intent(this, typeof(HeartRate));
				StartActivity(HeartRate);
			};

			button5.Click += (sender, e) =>
			{
				var Distance = new Intent(this, typeof(Distance));
				StartActivity(Distance);
			};

			button6.Click += (sender, e) =>
			{
				var Distance = new Intent(this, typeof(SendToDoctor));
				StartActivity(Distance);
			};

			button7.Click += (sender, e) =>
			{
				var DoctorsSugestion = new Intent(this, typeof(DoctorsSugestion));
				StartActivity(DoctorsSugestion);
			};

			button8.Click += (sender, e) =>
			{
				//loading the login AXML
				var Register = new Intent(this, typeof(SignIn));
				StartActivity(Register);
			};
			}
		}
	}



