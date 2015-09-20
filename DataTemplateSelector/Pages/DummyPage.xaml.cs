using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DataTemplateSelector
{
	public partial class DummyPage : ContentPage
	{
		public DummyPage ()
		{
			InitializeComponent ();

			this.BindingContext = new DummyViewModel ();
		}
	}
}

