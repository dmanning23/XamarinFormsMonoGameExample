using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace XamarinFormsMonoGame
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(true)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			Xamarin.Forms.DependencyService.Register<INativePage>();
			DependencyService.Get<INativePage>().StartNativePage();
		}
	}
}
