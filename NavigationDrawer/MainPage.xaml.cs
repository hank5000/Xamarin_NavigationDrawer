using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace NavigationDrawer
{
	public partial class MainPage : MasterDetailPage
	{
		MasterPage masterPage = new MasterPage();
		public MainPage()
		{
			InitializeComponent();
			this.Master = masterPage;
			this.Detail = new NavigationPage(new DetailView1());

			masterPage.MyListView.ItemSelected += OnItemSelected;
		
		}

		private void OnItemSelected(Object sender, SelectedItemChangedEventArgs args)
		{
			var item = args.SelectedItem as MasterPageItem;
			if (item != null)
			{
				if (item.Title == "XF Control Item1")
				{
					Detail = new NavigationPage(new DetailView1());
					var fooPage = this.Master;

					masterPage.MyListView.SelectedItem = null;
					IsPresented = false;
				}
				else if (item.Title == "XF Control Item2")
				{
					Detail = new NavigationPage(new DetailView2());
					var fooPage = this.Master;

					masterPage.MyListView.SelectedItem = null;
					IsPresented = false;
				}
				else if (item.Title == "Grid Layout")
				{
					Detail = new NavigationPage(new DetailView3());
					var fooPage = this.Master;

					masterPage.MyListView.SelectedItem = null;
					IsPresented = false;
				}
				else if (item.Title == "Stack And Scroll Layout")
				{
					Detail = new NavigationPage(new DetailView4());
					var fooPage = this.Master;

					masterPage.MyListView.SelectedItem = null;
					IsPresented = false;
				}
			}

		}
	}
}
