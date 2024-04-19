using System.ServiceModel;
using System.Threading.Tasks;

namespace Models
{
    public interface ICelciusFaren
    {
        [ServiceContract]

        string celcius(double c) {get, set};

        [ServiceContract]
        string fahrenheit(double f) {get, set};

    }
}