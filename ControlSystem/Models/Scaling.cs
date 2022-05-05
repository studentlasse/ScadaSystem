namespace Simulation.Models
{
    class Scaling
    {
        public double x1, x2, y1, y2;

        public Scaling(double x1, double x2, double y1, double y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;

        }

        public double LinearScaling(double x)
        {
            double y;
            y = y1 + (x - x1) * (y2 - y1) / (x2 - x1);
            return y;
        }
    }
}
