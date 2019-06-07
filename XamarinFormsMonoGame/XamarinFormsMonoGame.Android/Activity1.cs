using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace XamarinFormsMonoGame.Droid
{
	[Activity(Label = "Game1.Android"
		, AlwaysRetainTaskState = true
		, ScreenOrientation = ScreenOrientation.FullUser
		, ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.Keyboard | ConfigChanges.KeyboardHidden | ConfigChanges.ScreenSize | ConfigChanges.ScreenLayout)]
	public class Activity1 : Microsoft.Xna.Framework.AndroidGameActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			var g = new Game1(OnBackPressed);
			SetContentView((View)g.Services.GetService(typeof(View)));
			g.Run();
		}

		public override void OnBackPressed()
		{
			Finish();
		}
	}
}

