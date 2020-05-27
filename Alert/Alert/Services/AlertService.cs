using Acr.UserDialogs;
using Alert.ServiceInterfaces;
using Alert.Services;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(AlertService))]
namespace Alert.Services
{
    public class AlertService : IAlertService
    {
        public async Task ShowMessage(string header, string message)
        {
            var config = new AlertConfig()
            {
                Title   = header,
                Message = message,
                OkText  = "OK",
            };
            await UserDialogs.Instance.AlertAsync(config);
        }
    }

}
