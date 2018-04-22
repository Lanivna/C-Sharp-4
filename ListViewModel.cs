using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace C_Sharp_4
{
    class ListViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Person> _users;
        private DataGrid _dataGrid;
        private DataRowView _dataRow;

        public ObservableCollection<Person> Users
        {
            get => _users;
            private set
            {
                _users = value;
                OnPropertyChanged();
            }
        }

        internal ListViewModel(DataGrid dataGrid)
        {
            _users = new ObservableCollection<Person>(DBAdapter.People);
            _dataGrid = dataGrid;
            _dataGrid.CellEditEnding += DataGrid_CellEditEnding;

        }

        private void DataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            _dataRow = e.Row.Item as DataRowView;
            string text = ((TextBox)e.EditingElement).Text;
            string column = e.Column.Header.ToString();
            switch (column)
            {


                case "Date of birth":

                    string[] date = text.Split('/');
                    if (Int32.Parse(date[0]) > 31 || Int32.Parse(date[0]) < 1 || Int32.Parse(date[1]) > 12 || Int32.Parse(date[1]) < 1 || Int32.Parse(date[2]) < 1883 || Int32.Parse(date[2]) > 2018)
                        e.Cancel = true;
                    string b = date[2].ToString();
                    DateTime dateNew = new DateTime(Int32.Parse(date[2]), Int32.Parse(date[1]), Int32.Parse(date[0]));
                    try
                    {
                        Person.AgeCount();
                    }
                    catch (Exception exception)
                    {
                        e.Cancel = true;
                    }

                    break;

            }

        }

        #region Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
