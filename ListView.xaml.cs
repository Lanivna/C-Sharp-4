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

namespace C_Sharp_4
{
    /// <summary>
    /// Interaction logic for ListView.xaml
    /// </summary>
    public partial class ListView : UserControl
    {
        public ListView(Action<object, EventArgs> action)
        {
            InitializeComponent();
            DataContext = new ListViewModel(DataGrid);
            AddNewPerson.Click += new RoutedEventHandler(action);
        }

        public void Remove(object o, EventArgs e)
        {
            Person person = (Person)DataGrid.SelectedItems[0];
            DBAdapter.People.Remove(person);
        }

        internal void Update()
        {
            throw new NotImplementedException();
        }
    }
}
