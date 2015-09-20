using System;
using Xamarin.Forms;

namespace DataTemplateSelector
{
	public class CustomListView
		: ListView
	{
		public CustomListView()
		{
			ItemTemplate = new DataTemplate(GetHookedCell);
		}

		Cell GetHookedCell()
		{
			var content = new ViewCell();
			content.BindingContextChanged += OnBindingContextChanged;
			return content;
		}

		public IDataTemplateSelector TemplateSelector
		{
			get { return (IDataTemplateSelector)GetValue(TemplateSelectorProperty); }
			set { SetValue(TemplateSelectorProperty, value); }
		}

		public static readonly BindableProperty TemplateSelectorProperty = BindableProperty.Create<CustomListView, IDataTemplateSelector>(p => p.TemplateSelector, null);

		private void OnBindingContextChanged(object sender, EventArgs e)
		{
			var cell = (ViewCell)sender;
			if (TemplateSelector != null)
			{
				var template = TemplateSelector.SelectTemplate(cell, cell.BindingContext);
				cell.View = ((ViewCell)template.CreateContent()).View;
			}
		}
	}
}