using System.Collections.Generic;

namespace VBoxVdiManager
{
    public class EnumerableComparer<T> :
        IComparer<IEnumerable<T>>
    {
        public static EnumerableComparer<T> Default => new EnumerableComparer<T>();

        private IComparer<T> comparer = Comparer<T>.Default;

        public EnumerableComparer(IComparer<T> comparer)
        {
            this.comparer = comparer;
        }

        public EnumerableComparer()
        {
        }

        public int Compare(IEnumerable<T> x, IEnumerable<T> y)
        {
            var xe = x.GetEnumerator();
            var ye = y.GetEnumerator();

            bool hasX, hasY;

            while ((hasX = xe.MoveNext()) & (hasY = ye.MoveNext()))
            {
                var xv = xe.Current;
                var yv = ye.Current;

                var cmp = this.comparer.Compare(xv, yv);
                if (cmp != 0) return cmp;
            }

            if (hasX) return -1;
            if (hasY) return +1;
            return 0;
        }
    }
}
