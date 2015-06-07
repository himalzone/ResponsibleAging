
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
	[Activity (Label = "InsertRecordActivity")]			
	public class InsertRecordActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			SetContentView(Resource.Layout.InsertRecord);
			var txtInsert = FindViewById<TextView>(Resource.Id.txtInsert);
			var AddRecordbtn = FindViewById<Button> (Resource.Id.btnAddRecord);

			AddRecordbtn.Click += (sender, e) =>
			{
				DBRepository dbr = new DBRepository ();
				String result = dbr.InsertRecord (txtInsert.Text);
				Toast.MakeText (this, result, ToastLength.Short).Show ();
			};
		}
	}
}

