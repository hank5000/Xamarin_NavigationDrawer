using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationDrawer
{
	public partial class DetailView1 : ContentPage
	{
		public DetailView1()
		{
			InitializeComponent();

			button我的按鈕.Clicked += (s, e) =>
			{
				DisplayAlert("通知", "你已經按下按鈕", "確認");
			};

			editor多行文字輸入盒.Text = "這個控制項，\r\n可以輸入多行資料\r\n每行輸入後\r\n按下Enter\r\n就會自動換行";

		}
	}
}
