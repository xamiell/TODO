using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TODO.ViewModels;

namespace TODO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataEntryPage : ContentPage
    {
        public DataEntryPage()
        {
            InitializeComponent();
            BindingContext = new DataEntryViewModel();
        }
    }
}