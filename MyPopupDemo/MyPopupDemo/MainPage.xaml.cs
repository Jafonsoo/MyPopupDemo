using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyPopupDemo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.PushAsync(new ShowPopupDemo());
        }
        private async void Loader1_Clicked(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await PopupNavigation.PushAsync(loadingPage);
            await Task.Delay(2000);
            await PopupNavigation.RemovePageAsync(loadingPage);
        }
        private async void Loader2_Clicked(object sender, EventArgs e)
        {
            var loadingPage = new CustomLoaderPage();
            await PopupNavigation.PushAsync(loadingPage);
            await Task.Delay(2000);
            await PopupNavigation.RemovePageAsync(loadingPage);
        }
        private async void Loader3_Clicked(object sender, EventArgs e)
        {
            var loadingPage = new RandomColorLoader();
            await PopupNavigation.PushAsync(loadingPage);
            await Task.Delay(6000);
            await PopupNavigation.RemovePageAsync(loadingPage);
        }
        private async void GIF_Clicked(object sender, EventArgs e)
        {
            var loadingPage = new CustomGIFLoader();
            await PopupNavigation.PushAsync(loadingPage);
            await Task.Delay(6000);
            await PopupNavigation.RemovePageAsync(loadingPage);
        }
    }
}
