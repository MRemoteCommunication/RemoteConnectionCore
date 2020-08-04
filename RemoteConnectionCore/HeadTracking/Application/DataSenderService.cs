using RemoteConnectionCore.HeadTracking.Domain;
using Zenject;
namespace RemoteConnectionCore.HeadTracking.Application
{
    public class DataSenderService
    {
        private readonly IHeadDataSender dataSender;
        [Inject]
        public DataSenderService(IHeadDataSender dataSender)
        {
            this.dataSender = dataSender;
        }

        public void Send(HeadData sendData)
        {
            dataSender.Send(sendData);
        }
    }
}