using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfMVVVM.View;

namespace wpfMVVVM.ViewModel
{
    public class MainViewModell
    {
		private object currentView;

		public object CurrentView
        {
			get { return currentView; }
			set { currentView = value; }
		}

		private GreenView greenView;
		private YellowView yellowView;

		public MainViewModell()
		{
			yellowView = new YellowView();
			greenView = new GreenView();
			CurrentView = greenView;
		}

	}
}
