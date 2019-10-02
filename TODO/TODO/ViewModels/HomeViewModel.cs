using System;
using System.Collections.Generic;
using System.Text;

using TODO.Model;
using System.Collections.ObjectModel;
using SQLiteXamarin;
using GalaSoft.MvvmLight;
using Xamarin.Forms;

namespace TODO.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public ObservableCollection<ItemTask> TaskCollection { get; private set; }
        private DatabaseManagement _dataBase { get; set; }

        public Command AddTaskCommand { get; private set; }

        public HomeViewModel()
        {
            _dataBase = new DatabaseManagement();
            AddTaskCommand = new Command( AddTask );
            TaskCollection = new ObservableCollection<ItemTask>();
            
            UpdateCollection();
        }

        private void UpdateCollection()
        {
            if ( TaskCollection.Count >= 1 )
            {
                TaskCollection.Clear();
            }

            foreach ( var task in _dataBase.QueryItem() )
            {
                TaskCollection.Add(task);
            }
        }

        private void AddTask()
        {
            
        }

        private void SaveTask( ItemTask task )
        {
            _dataBase.SaveItem( task );
        }
    }
}
