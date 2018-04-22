using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using FontAwesome.WPF;

namespace C_Sharp_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ImageAwesome _loader;
        private ListView _listView;
        private InputViewer _inputViewer;

        public MainWindow()
        {
            InitializeComponent();
            ShowListView();
        }

        public void ShowLoader(bool isShow)
        {
            LoaderHelper.OnRequestLoader(MainGrid, ref _loader, isShow);
        }

        private void ShowListView()
        {
            if (_listView == null)
            {
                _listView = new ListView(ShowInputViewer);
            }
            else
                _listView.Update();

            ShowView(_listView);
        }



        private void ShowInputViewer(object o, EventArgs e)
        {
            if (_inputViewer == null)
            {
                _inputViewer = new InputViewer(ShowListView);
            }
            ShowView(_inputViewer);
        }

        private void ShowView(UIElement element)
        {
            MainGrid.Children.Clear();
            MainGrid.Children.Add(element);
        }

        protected void OnCLosing(CancelEventArgs e)
        {
            DBAdapter.Save();
            base.OnClosing(e);
        }
    }
}
