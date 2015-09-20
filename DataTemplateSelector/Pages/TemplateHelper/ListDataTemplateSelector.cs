using System;
using Xamarin.Forms;
using System.Reflection;

namespace DataTemplateSelector
{
	public class DataTemplateSelector
		: IDataTemplateSelector
	{
		
		public DataTemplate RightImageTemplate { get; set; }
		public DataTemplate LeftImageTemplate { get; set; }
		public DataTemplate CenterImageTemplate { get; set; }
	
		public DataTemplate SelectTemplate(object view, object dataItem)
		{
			var typeName = dataItem.GetType ().Name;
			var selectorType = typeof(DataTemplateSelector);
			var templatePropertyInfo = selectorType.GetTypeInfo ().GetDeclaredProperty(typeName.Replace("CellViewModel", "Template"));
			return templatePropertyInfo.GetValue (this) as DataTemplate;
		}
	}
}

