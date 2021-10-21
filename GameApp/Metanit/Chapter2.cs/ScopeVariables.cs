using System;

namespace ScopeVariables
{
    class ScopeVariables
    {
        static int x = 17;
        static void F19()
        {
            int x = 2;
            int y = x - 10;
            {
                int z = y - 15 + x;
            }
        }
        void Info()
        {
            int j = x + 1000;
        }
    }
}