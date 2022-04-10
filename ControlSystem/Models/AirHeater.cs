namespace Simulation.Models
{
    class AirHeater
    {
        public double ThetaT { get; set; }
        public double ThetaD { get; set; }
        public double Kh { get; set; }
        public double Tenv { get; set; }
        public double Ts { get; set; }

        public AirHeater ()
        {
            ThetaT = 22;
            ThetaD = 2;
            Kh = 3.5;
            Tenv = 21.5;
            Ts = 0.1;
        }

        public AirHeater(double Ts)
        {
            ThetaT = 22;
            ThetaD = 2;
            Kh = 3.5;
            Tenv = 21.5;
            this.Ts = Ts;
        }

        public AirHeater(double ThetaT, double ThetaD, double Kh, double Tenv, double Ts)
        {
            this.ThetaT = ThetaT;
            this.ThetaD = ThetaD;
            this.Kh = Kh;
            this.Tenv = Tenv;
            this.Ts = Ts;
        }

        public double AirHeaterModel(double xk, double u)
        {
            double xk1;
            // Legg til timedelay ThetaD
            xk1 = xk * (1 - (Ts / ThetaT)) + (Ts / ThetaT) * Kh * u + (Ts / ThetaT) * Tenv;
            return xk1;
        }
    }
}
