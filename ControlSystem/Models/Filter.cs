namespace Simulation.Models
{
    class Filter
    {
        public double yk;
        public double Ts;
        public double Tf;


        public Filter()
        {
            this.Ts = 0.1;
            this.Tf = 0.4;
        }

        public Filter (double Ts, double Tf)
        {
            this.Ts = Ts;
            this.Tf = Tf;
        }

        public double LowPassFilter(double yFromDaq)
        {
            double a;
            double yFiltered;
            a = Ts / (Ts + Tf);
            yFiltered = (1 - a) * yk + a * yFromDaq;
            yk = yFiltered;
            return yFiltered;
        }
    }
}
