using Android.App;
using Android.OS;
using Android.Runtime;
using Plugin.CurrentActivity;
using System;

namespace XamarinFormsMonoGame.Droid
{
#if DEBUG
	[Application(Debuggable = true)]
#else
	[Application(Debuggable = false)]
#endif
	public class MainApplication : Application
	{
		public MainApplication(IntPtr handle, JniHandleOwnership transer)
			: base(handle, transer)
		{
		}

		public override void OnCreate()
		{
			StrictMode.VmPolicy.Builder builder = new StrictMode.VmPolicy.Builder();
			StrictMode.SetVmPolicy(builder.Build());
			base.OnCreate();
			CrossCurrentActivity.Current.Init(this);
		}
	}
}