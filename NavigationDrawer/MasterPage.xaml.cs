using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationDrawer
{
	public partial class MasterPage : ContentPage
	{

		public ListView MyListView
		{
			get
			{
				return this.listView;
			}
		}

		public MasterPage()
		{
			InitializeComponent();

			var masterPageItems = new List<MasterPageItem>();
			masterPageItems.Add(new MasterPageItem
			{
				Title = "XF Control Item1",
				Icon = "\uf00b",
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "XF Control Item2",
				Icon = "\uf044",
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Grid Layout",
				Icon = "\uf085",
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Stack And Scroll Layout",
				Icon = "\uf009",
			});

			listView.ItemsSource = masterPageItems;

		}
	}
}
