using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using fIntegral_App;

namespace fIntegral_App
{
    public class Integral_App
    {
        private double _formula;
        private double _x0;
        private double _X;
        private Partitioning_method _partitioning_method;
        private int _number_of_iterations;

        public double Formula
        {
            get { return _formula; }
            set { _formula = value; }
        }

        public double x0
        {
            get { return _x0; }
            set { _x0 = value; }
        }

        public double X
        {
            get { return _X; }
            set { _X = value; }
        }

        public Partitioning_method partitioning_method
        {
            get { return _partitioning_method;}
            set { _partitioning_method = value; }
        }

        public int number_of_iterations
        {

            get { return _number_of_iterations; }
            set
            {
                if (value > 2) { _number_of_iterations = value; }
                else { Console.WriteLine("error! number_of_iterations cannot be less than two"); }

                _number_of_iterations = value;
            }
        }

        public Integral_App(double P_Formula = 0, double P_x0 = 0, double P_X = 0, Partitioning_method P_partitioning_method = Partitioning_method.Basic, int P_number_of_iterations = 3)
        {
            Formula = P_Formula;
            x0 = P_x0;
            X = P_X;
            partitioning_method = P_partitioning_method;
            number_of_iterations = P_number_of_iterations;
        }

        public void Lntegrating()
        {
            Double interval = X - x0;
            Double delta = interval / number_of_iterations;
            Double S = 0;
            Double current_x = x0;



            for (int i = 0; i < number_of_iterations; i++)
            {
                Double Function_Result = Functions._01053_plus_0000142_multiply_x(current_x);
                Double old_current_x = current_x;
                current_x = current_x + delta;
                S = S + (current_x - old_current_x)* Function_Result;
            }
            Console.WriteLine(S);
        }



    public enum Partitioning_method
        {
            Basic,
            Other
        }


    }
}