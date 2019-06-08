using UIKit;
using Xamarin.Forms;
using XamarinFormsMonoGame.iOS;

[assembly: Dependency(typeof(NativePage))]
namespace XamarinFormsMonoGame.iOS
{
	public class NativePage : INativePage
	{
		const string MainStoryboardName = "GameViewController";

		public NativePage()
		{
		}

		public void StartNativePage()
		{
			var storyboard = UIStoryboard.FromName(MainStoryboardName, null);
			var mainViewController = storyboard.InstantiateInitialViewController();

			var window = UIApplication.SharedApplication.KeyWindow;
			window.RootViewController.PresentViewController(mainViewController, false, null);
		}
	}
}
