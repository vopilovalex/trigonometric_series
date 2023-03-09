using trigonometric_series;
using fIntegral_App;

namespace trigonometric_series
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Integral_App Lnteg = new Integral_App();
            Lnteg.x0 = 20;
            Lnteg.X = 100;
            Lnteg.number_of_iterations = 3000;
            Lnteg.Lntegrating();
            
        }
    }
}