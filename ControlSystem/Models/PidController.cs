namespace Simulation.Models
{
    class PidController
    {
        public double Ts { get; set; }
        public double Kp { get; set; }
        public double Ti { get; set; }
        public double r { get; set; }
        private double z = 0;

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

            e = r - y;
            u = Kp * e + (Kp / Ti) * z;
            z = z + Ts * e;
            return u;
        }

    }
}
