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
        public ObservableCollection<String> ItemsSource { get; set; } = new ObservableCollection<string> { };

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
            this.AddButton.Clicked += OnAddButtonClicked;
            this.RemoveButton.Clicked += OnRemoveButtonClicked;
        }

        void OnAddButtonClicked(object sender, EventArgs e) {
            ItemsSource.Add("");
        }

        void OnRemoveButtonClicked(object sender, EventArgs e)
        {
            ItemsSource.Remove("");
        }
    }
}
