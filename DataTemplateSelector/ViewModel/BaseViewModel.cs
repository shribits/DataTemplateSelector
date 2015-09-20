using System;
using System.ComponentModel;

namespace DataTemplateSelector
{
	public class BaseViewModel
		:INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void OnPropertyChanged (string propertyName)
		{
			try {
				if (PropertyChanged != null) {
					PropertyChanged (this, new PropertyChangedEventArgs (propertyName));
				}
			} catch {
				//catch error here
			}
		}

	}
}

