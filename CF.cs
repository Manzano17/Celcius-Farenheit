using Models;

namespace CF {

    public class CF : ICelciusFaren {

        public double celcius(double c) {
            return (c * 9 / 5) + 32;
        }
        public double fahrenheit(double f) {
            return (f - 32) * 5 / 9;
    
    }
}