using System;

using Xamarin.Forms;

namespace NavigationDrawer
{
	public class DetailView3 : ContentPage
	{
		public DetailView3()
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

