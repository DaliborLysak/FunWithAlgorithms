namespace Ackerman
{
    public static class AckermanFunction
    {
        // definition
        // A(0, n) = n + 1
        // A(m + 1, 0) = A(m, 1)
        // A(m + 1, n + 1) = A(m, A(m + 1, n))
        public static int Execute(int m, int n)
        {
            var result = 0;

            if (m == 0)
            {
                result = n + 1;
            }
            else if (n == 0)
            {
                result = Execute(m - 1, 1);
            }
            else
            {
                result = Execute(m - 1, Execute(m, n - 1));
            }

            return result;
        }
    }
}
