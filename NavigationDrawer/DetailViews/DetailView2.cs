using System;

using Xamarin.Forms;

namespace NavigationDrawer
{
	public class DetailView2 : ContentPage
	{
		public DetailView2()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}

