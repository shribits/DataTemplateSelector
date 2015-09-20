using System;
using Xamarin.Forms;

namespace DataTemplateSelector
{
	public interface IDataTemplateSelector
	{
		DataTemplate SelectTemplate(object view, object dataItem);
	}
}

