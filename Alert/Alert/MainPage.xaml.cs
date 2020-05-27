using Alert.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Alert
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var vm = new MainPageViewModel();
            BindingContext = vm;
        }
    }
}
