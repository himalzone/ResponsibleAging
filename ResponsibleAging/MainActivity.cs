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

			}
		}
	}



