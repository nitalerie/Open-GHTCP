using System;
using System.IO;
using System.Text;
using GHNamespaceK;
using GHNamespaceL;

namespace GHNamespace4
{
    public class Class134 : Class131
    {
        private readonly Class137 _class1370;

        private readonly int _int1;

        private readonly int[] _int2 = new int[4];

        private readonly int[] _int3;

        public Class134(Class144 class1440, Class140 class1401, Class136 class1360, int int4, int int5,
            int int6) : base(class1401, int5)
        {
            _int3 = class1360.vmethod_2();
            _int1 = int6;
            for (int i = 0; i < int6; i++)
            {
                _int2[i] = class1440.vmethod_12(int4);
            }
            int num = class1440.vmethod_10(2);
            int num2 = num;
            if (num2 == 0)
            {
                int int7 = class1440.vmethod_10(4);
                Class138 @class = new Class138();
                _class1370 = @class;
                @class.Int0 = int7;
                @class.Class1430 = class1360.vmethod_1();
                @class.vmethod_0(class1440, int6, @class.Int0, class1401, class1360.vmethod_2());
                Buffer.BlockCopy(_int2, 0, class1360.vmethod_0(), 0, int6 << 2);
                BlackMagic.CopyArrayOffset(_int3, class1401.Int0 - int6, int6, class1360.vmethod_0(), int6);
                return;
            }
            throw new IOException("STREAM_DECODER_UNPARSEABLE_STREAM");
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder(string.Concat("FLACSubframe_Fixed: Order=", _int1, " PartitionOrder=",
                ((Class138) _class1370).Int0, " WastedBits=", Int0));
            for (int i = 0; i < _int1; i++)
            {
                stringBuilder.Append(string.Concat(" warmup[", i, "]=", _int2[i]));
            }
            return stringBuilder.ToString();
        }
    }
}