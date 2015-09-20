using System;
using Xamarin.Forms;

namespace DataTemplateSelector
{
	public class BaseCellViewModel
		:BaseViewModel
	{
		public string Name {
			get;
			set;
		}

		public string ContactNo {
			get;
			set;
		}

		public ImageSource ProfileImage {
			get;
			set;
		}
	}
}

