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
using Game1.Android;
using Xamarin.Forms.MonoGame;
using Xamarin.Forms.MonoGame.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(NativePage))]
namespace Xamarin.Forms.MonoGame.Droid
{
		public class NativePage : INativePage
		{
			public NativePage()
			{
			}

			public void StartNativePage()
			{
				var intent = new Intent(Forms.Context, typeof(Activity1));
				Forms.Context.StartActivity(intent);
			}

		}
}