using System;

namespace GHNamespaceH
{
    public class Class44
    {
        private static readonly uint[] Uint0 = new uint[256];

        private static uint smethod_0(uint uint1)
        {
            uint num = uint1 << 24;
            for (int i = 0; i < 8; i++)
            {
                if ((num & 2147483648u) != 0u)
                {
                    num = (num << 1 ^ 79764919u);
                }
                else
                {
                    num <<= 1;
                }
            }
            return num & 4294967295u;
        }

        public Class44()
        {
            uint num = 0u;
            while (num < (ulong) Uint0.Length)
            {
                Uint0[(int) ((UIntPtr) num)] = smethod_0(num);
                num += 1u;
            }
        }
    }
}