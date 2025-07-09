using ApiGateway.Models.Utils.Records;

namespace ApiGateway.Models
{
    public class DeviceRecord
    {
        public Temperature? temperature { get; set; }
        public Humidity? humidity { get; set; }
        public Location? location { get; set; }
    }
}
