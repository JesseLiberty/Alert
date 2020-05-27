using Alert.ServiceInterfaces;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Alert.ViewModels
{
    public class MainPageViewModel
    {
        public ICommand ShowAlertCommand => 
            new Command(async () => await ShowAlert());

        private async Task ShowAlert()
        {
            var message = "Hello World!";
            var alertService = DependencyService.Resolve<IAlertService>();
            await alertService.ShowMessage("Hello", message);
        }

    }
}
