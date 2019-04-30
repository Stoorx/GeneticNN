using System.Collections;
using System.Collections.Generic;

namespace GeneticNN.Model
{
    public class FourierSeriesEnumerator : IEnumerator<FourierElement>
    {
        public FourierSeriesEnumerator(FourierSeries fs)
        {
            _series = fs;
            _enumerator = fs.Elements.GetEnumerator();
            Current = (FourierElement) _enumerator.Current;
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            return _enumerator.MoveNext();
        }

        public void Reset()
        {
            _enumerator.Reset();
        }

        public FourierElement Current { get; protected set; }

        object IEnumerator.Current => Current;

        private FourierSeries _series = null;
        private IEnumerator _enumerator = null;
    }
}