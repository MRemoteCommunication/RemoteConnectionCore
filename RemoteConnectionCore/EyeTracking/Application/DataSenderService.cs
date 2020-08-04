using RemoteConnectionCore.EyeTracking.Domain;
using Zenject;
namespace RemoteConnectionCore.EyeTracking.Application
{
    public class DataSenderService
    {
        private readonly IEyeDataSender eyeDataSender;
        [Inject]
        public DataSenderService(IEyeDataSender eyeDataSender)
        {
            this.eyeDataSender = eyeDataSender;
        }

        public void Send(EyeData sendData)
        {
            eyeDataSender.Send(sendData);
        }
    }
}