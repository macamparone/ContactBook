﻿using ContactBook.Persistence;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ContactBook
{

	public partial class MainPage : ContentPage
	{
	
		public MainPage()
		{
			InitializeComponent();		
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushModalAsync(new ContactsPage());
        }
    }
}