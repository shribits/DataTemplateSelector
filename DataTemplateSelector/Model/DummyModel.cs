using System;
using Xamarin.Forms;

namespace DataTemplateSelector
{
	public class DummyModel
		:BaseModel
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

		public string TemplateType {
			get;
			set;
		}
			
	}
}

