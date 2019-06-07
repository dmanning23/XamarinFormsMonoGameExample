using Android.Content;
using Plugin.CurrentActivity;
using XamarinFormsMonoGame.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(NativePage))]
namespace XamarinFormsMonoGame.Droid
{
	public class NativePage : INativePage
	{
		public NativePage()
		{
		}

		public void StartNativePage()
		{
			var intent = new Intent(CrossCurrentActivity.Current.AppContext, typeof(Activity1));
			CrossCurrentActivity.Current.AppContext.StartActivity(intent);
		}

	}
}