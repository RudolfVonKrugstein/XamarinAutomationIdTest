using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AutmationIdTest
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<String> ItemsSource { get; set; } = new ObservableCollection<string> { "1", "2", "3" };

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
    }
}
