using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using TODO.ViewModels;

namespace TODO.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            BindingContext = new HomeViewModel();
            imageProfile.Source = "http://nyarafashion.com/images/profile-picture-big.jpg";
        }
    }
}
