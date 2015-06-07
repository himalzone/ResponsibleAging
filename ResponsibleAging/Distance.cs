﻿
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
	[Activity (Label = "Distance")]			
	public class Distance : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			SetContentView (Resource.Layout.Distance);
			var txtView = FindViewById<TextView>(Resource.Id.textViewID3);
			DBRepository dbr = new DBRepository ();
			string task = dbr.GetTaskById (2);
			//Toast.MakeText (this, task, ToastLength.Short).Show ();

			txtView.Text = task+", this is you Distance";
			var mainMenu = FindViewById<Button> (Resource.Id.button4);
			mainMenu.Click += (sender, e) =>
			{
				var intent = new Intent(this, typeof(MainActivity));
				StartActivity(intent);
			};
		}
	}
}

