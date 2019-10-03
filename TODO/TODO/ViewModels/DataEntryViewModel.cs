using System;
using System.Collections.Generic;
using System.Text;

using GalaSoft.MvvmLight;
using Xamarin.Forms;
using TODO.Model;
using SQLiteXamarin;

namespace TODO.ViewModels
{
    public class DataEntryViewModel : ViewModelBase
    {
        private string _taskTitle;
        public string TaskTitle
        {
            get { return _taskTitle; }

            set
            {
                if (value != _taskTitle)
                {
                    _taskTitle = value;
                    RaisePropertyChanged();
                }
            }
        }

        private string _taskDescription;
        public string TaskDescription
        {
            get { return _taskDescription;  }

            set
            {
                if (value != _taskDescription)
                {
                    _taskDescription = value;
                    RaisePropertyChanged();
                }
            }
        }

        public Command SaveCommand { get; private set; }

        private DatabaseManagement _database;

        public DataEntryViewModel()
        {
            SaveCommand = new Command(OnSave);
            _database = new DatabaseManagement();
        }

        private void OnSave()
        {
            if (!string.IsNullOrEmpty(_taskTitle))
            {
                _database.SaveItem(new ItemTask
                {
                    Title = _taskTitle,
                    Date = _taskDescription
                });
            }
        }
    }
}
