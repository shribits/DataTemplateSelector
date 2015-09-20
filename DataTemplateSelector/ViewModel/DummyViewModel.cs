using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace DataTemplateSelector
{
	public class DummyViewModel
		:BaseViewModel
	{
		private List<DummyModel> dummyModelSet;
		public List<DummyModel> DummyModelSet {
			get { return dummyModelSet; } 
			set {
				dummyModelSet = value;
				OnPropertyChanged ("DummyModelSet");
			}
		}

		private List<BaseCellViewModel> dummyCellSet;
		public List<BaseCellViewModel> DummyCellSet {
			get { return dummyCellSet; } 
			set {
				dummyCellSet = value;
				OnPropertyChanged ("DummyCellSet");
			}
		}
			
		public DummyViewModel ()
		{
			DummyModelSet = new List<DummyModel> ();
			DummyCellSet = new List<BaseCellViewModel> ();
			GetDataSet ();
			DummyCellSet = CreateItemCellTemplateViewModels (DummyModelSet);
		}

		private void GetDataSet()
		{
			DummyModelSet.Add (new DummyModel{ Name="Andy", ContactNo="44334565", ProfileImage="Andy.png" ,TemplateType="RightImageTemplate"});
			DummyModelSet.Add (new DummyModel{ Name="Sandy", ContactNo="88907777", ProfileImage="Sandy.png" ,TemplateType="LeftImageTemplate"});
			DummyModelSet.Add (new DummyModel{ Name="Candy", ContactNo="72905555", ProfileImage="Candy.png" ,TemplateType="CenterImageTemplate"});
		}
			
		public List<BaseCellViewModel> CreateItemCellTemplateViewModels (List<DummyModel> items)
		{
			var vc = new List<BaseCellViewModel> ();

			foreach (var item in items) {

				var type = Type.GetType (string.Format ("DataTemplateSelector.{0}", item.TemplateType.Replace ("Template", "CellViewModel")));
				var cellItem = Activator.CreateInstance (type) as BaseCellViewModel;

				cellItem.Name = item.Name;
				cellItem.ContactNo = item.ContactNo;
				cellItem.ProfileImage = item.ProfileImage;

				vc.Add (cellItem);
			}

			return vc;
		}
	}
}

