namespace Simulation.Models
{
    class AirHeater
    {
        public double ThetaT { get; set; }
        public double ThetaD { get; set; }
        public double Kh { get; set; }
        public double Tenv { get; set; }
        public double Ts { get; set; }

        private double[] timeDelay;

        public AirHeater ()
        {
            ThetaT = 22;
            ThetaD = 2;
            Kh = 3.5;
            Tenv = 21.5;
            Ts = 0.1;

            InitTimeDelay();
        }



        public AirHeater(double Ts)
        {
            ThetaT = 22;
            ThetaD = 2;
            Kh = 3.5;
            Tenv = 21.5;
            this.Ts = Ts;

            InitTimeDelay();
        }

        public AirHeater(double ThetaT, double ThetaD, double Kh, double Tenv, double Ts)
        {
            this.ThetaT = ThetaT;
            this.ThetaD = ThetaD;
            this.Kh = Kh;
            this.Tenv = Tenv;
            this.Ts = Ts;

            InitTimeDelay();
        }

        public double AirHeaterModel(double xk, double u)
        {
            double xk1;
            double delayedU = timeDelay[0];
            xk1 = xk * (1 - (Ts / ThetaT)) + (Ts / ThetaT) * Kh * delayedU + (Ts / ThetaT) * Tenv;

            for (int i = 0; i < timeDelay.Length; i++)
            {
                if (i == timeDelay.Length - 1 ) 
                {
                    timeDelay[i] = u;
                }
                else
                {
                    timeDelay[i] = timeDelay[i + 1];
                }
            }
            return xk1;
        }
        private void InitTimeDelay()
        {
            int n = (int)(ThetaD / Ts);
            timeDelay = new double[n];
            for (int i = 0; i < timeDelay.Length; i++)
            {
                timeDelay[i] = 0;
            }
        }
    }
}
