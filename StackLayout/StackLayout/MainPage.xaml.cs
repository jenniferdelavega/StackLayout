using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StackLayout
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    private void Login(object sender, EventArgs e)
	    {
	        DisplayAlert("Welcome", "Login success!", "OK");
	        Navigation.PushAsync(new Excer2());
	    }
    }
}
