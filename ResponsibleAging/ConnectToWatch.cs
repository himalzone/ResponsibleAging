
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
	[Activity (Label = "ConnectToWatch")]			
	public class ConnectToWatch : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			SetContentView (Resource.Layout.ConnectToWatch);

			var mainMenu = FindViewById<Button> (Resource.Id.button4);

			mainMenu.Click += (sender, e) =>
			{
				var intent = new Intent(this, typeof(MainActivity));
				StartActivity(intent);
			};
		}
	}
}

