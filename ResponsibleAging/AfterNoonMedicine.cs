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
	[Activity (Label = "AfterNoonMedicine")]			
	public class AfterNoonMedicine : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			SetContentView (Resource.Layout.MedicationAfternoon);

			var MainMenu = FindViewById<Button> (Resource.Id.MainMenu);

			MainMenu.Click += (sender, e) =>
			{
				var HomeScreen = new Intent(this, typeof(MainActivity));
				StartActivity(HomeScreen);
			};
		}
	}
}

