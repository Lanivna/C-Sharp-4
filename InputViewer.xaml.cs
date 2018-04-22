using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using FontAwesome.WPF;

namespace C_Sharp_4
{
    /// <summary>
    /// Interaction logic for InputViewer.xaml
    /// </summary>
    public partial class InputViewer : UserControl
    {
        private ImageAwesome _loader;
        private Action showListView;

        public InputViewer(Action<object, EventArgs> action)
        {
            InitializeComponent();
            DataContext = new InputViewerViewModel(ShowLoader);
            SavePerson.Click += new RoutedEventHandler(action);
        }

        public InputViewer(Action showListView)
        {
            this.showListView = showListView;
        }

        public void ShowLoader(bool isShow)
        {
            LoaderHelper.OnRequestLoader(InputGrid, ref _loader, isShow);
        }
    }
}
