namespace Entities
{
    public class Calculations
    {
        private double _result;

        public double Sum(params double[] values)
        {
            _result = 0;

            foreach(double value in values)
            {
                _result += value;
            }

            return _result;
        }

        public double Subtract(params double[] values)
        {
            _result = values[0];

            for(int i = 1; i < values.Length; i++)
            {
                _result -= values[i];
            }

            return _result;
        }

        public double Multiply(params double[] values)
        {
            _result = 1;

            foreach(double value in values)
            {
                _result *= value;
            }

            return _result;
        }

        public double Division(params double[] values)
        {
            _result = values[0];

            for(int i = 1; i < values.Length; i++)
            {
                _result /= values[i];
            }

            return _result;
        }

        public double SquareRoot(double value)
        {
            return Math.Sqrt(value);
        }
    }
}