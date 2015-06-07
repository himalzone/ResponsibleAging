
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
	[Activity (Label = "Medication")]			
	public class Medication : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Medication);
			var txtView = FindViewById<TextView>(Resource.Id.textViewID);
			var Medication = FindViewById<TextView>(Resource.Id.DisplayMedication);
			DBRepository dbr = new DBRepository ();
			string task = dbr.GetTaskById (2);
			txtView.Text = task+", these are your Medicines";
			//displaying medication
			string medication = dbr.GetAllRecords();
			Medication.Text = medication;

			var mainMenu = FindViewById<Button> (Resource.Id.button4);
			mainMenu.Click += (sender, e) =>
			{
				var intent = new Intent(this, typeof(MainActivity));
				StartActivity(intent);
			};
				
		}
	}
}

