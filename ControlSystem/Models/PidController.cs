namespace Simulation.Models
{
    class PidController
    {
        public double Ts { get; set; }
        public double Kp { get; set; }
        public double Ti { get; set; }
        public double r { get; set; }
        private double z = 0;

        double minControlValue = 0;
        double maxControlValue = 5;

        public PidController ()
        {
            Ts = 0.01;
            Kp = 0.3;
            Ti = 5;
            r = 4;
        }

        public PidController (double Ts, double Kp, double Ti, double r)
        {
            this.Ts = Ts;
            this.Kp = Kp;
            this.Ti = Ti;
            this.r = r;
        }

        public double PiController(double y)
        {
            double e;
            double u;
            double P;
            double I;

            e = r - y;
            P = Kp * e;
            I = (Kp / Ti) * z;
            u = P + I;
            

            if (u < minControlValue)
            {
                u = minControlValue;
                z = z + Ts * e;
            }
            else if (u > maxControlValue)
            {
                u = maxControlValue;
                z = z + Ts * e * 0;
            }
            else
            {
                z = z + Ts * e;
            }

            return u;
        }

    }
}
