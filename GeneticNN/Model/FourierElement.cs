namespace GeneticNN.Model
{
    public struct FourierElement
    {
        public readonly double Amplitude;
        public readonly double Phase;

        public FourierElement(double amplitude, double phase)
        {
            Amplitude = amplitude;
            Phase = phase;
        }

        public override bool Equals(object obj)
        {
            if (obj is FourierElement other)
            {
                return Amplitude == other.Amplitude && Phase == other.Phase;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return (int) Amplitude * 37 + (int) Phase;
        }

        public override string ToString()
        {
            return $"A: {Amplitude:F4}, P: {Phase:F4}";
        }
    }
}