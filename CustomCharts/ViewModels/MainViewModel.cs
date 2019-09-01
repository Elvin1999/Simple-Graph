using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCharts.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private ObservableCollection<GraphLine> allGraphLines;

        public ObservableCollection<GraphLine> AllGraphLines
        {
            get
            {
                return allGraphLines;
            }
            set
            {
                allGraphLines = value;
                OnPropertyChanged(nameof(AllGraphLines));
            }
        }

    }
}
