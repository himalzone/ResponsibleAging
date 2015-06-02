
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

			var mainMenu = FindViewById<Button> (Resource.Id.button4);
			var morning = FindViewById<Button> (Resource.Id.Morning);
			var Afternoon = FindViewById<Button> (Resource.Id.AfterNoon);
			var Night = FindViewById<Button> (Resource.Id.Night);
			mainMenu.Click += (sender, e) =>
			{
				var intent = new Intent(this, typeof(MainActivity));
				StartActivity(intent);
			};

			morning.Click += (sender, e) =>
			{
				var MorningMedicine = new Intent(this, typeof(MedicineMorning));
				StartActivity(MorningMedicine);
			};

			Afternoon.Click += (sender, e) =>
			{
				var AfterNoonMedicine = new Intent(this, typeof(AfterNoonMedicine));
				StartActivity(AfterNoonMedicine);
			};

			Night.Click += (sender, e) =>
			{
				var NightMedicine = new Intent(this, typeof(NightMedicine));
				StartActivity(NightMedicine);
			};
		}
	}
}

