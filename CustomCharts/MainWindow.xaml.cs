using CustomCharts.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomCharts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            MainViewModel mainViewModel = new MainViewModel();
            mainViewModel.AllGraphLines = new ObservableCollection<GraphLine>();
            List<int> data = new List<int>() { 1,3,2,8,6,5,1,12,11,10};
            GraphLine graphLine = new GraphLine()
            {
                
                Height = 500,
                Start = new Point(150, 600),
                OverScore = 12,
                StepX = 70,
                Data=data[0]
            };

            graphLine.Last = graphLine.GetLastPoint();
            mainViewModel.AllGraphLines.Add(graphLine);
            for (int i = 0; i < 9; i++)
            {
                graphLine = new GraphLine();
                graphLine.Height = 500;
                graphLine.OverScore = 12;
                graphLine.StepX = 70;
                graphLine.Start = mainViewModel.AllGraphLines[i].Last;
                graphLine.Data = data[i+1];
                graphLine.Last = graphLine.GetLastPoint();
                mainViewModel.AllGraphLines.Add(graphLine);
            }
            
            DataContext = mainViewModel;
        }

    }
}
