using System.Threading.Tasks;

namespace Alert.ServiceInterfaces
{
    public interface IAlertService
    {
        Task ShowMessage(string header, string message);
    }

}
