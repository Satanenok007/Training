using System;

namespace PassingParametersByReferenceAndValueOutputParameters
{
    class PassingParametersByReferenceAndValueOutputParameters
    {
        static void F17()
        {
            int x = 5;
            int result;
            Sum(ref x, 12, out result);
        }

        static int Sum(ref int x, int n2, out int result)
        {
            result = x + n2;
            return result;
        }
    }
}