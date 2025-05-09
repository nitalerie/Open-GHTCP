using System.Drawing;
using GHNamespace9;
using GHNamespaceB;

namespace GHNamespaceC
{
    public abstract class ProbablyRootNode : ZzUnkNode260
    {
        public abstract byte vmethod_16();

        public override void vmethod_13(Stream26 stream260)
        {
            Int0 = stream260.ReadInt();
            Int1 = stream260.ReadInt();
            int num = stream260.ReadInt();
            stream260.ReadInt();
            if (num != 0)
            {
                AbstractTreeNode1 @class = vmethod_12(stream260.ReadIntAt(num, true));
                Nodes.Add(@class);
                @class.method_4(stream260);
            }
        }

        public override void vmethod_14(Stream26 stream260)
        {
            byte[] array = new byte[4];
            array[1] = (vmethod_7() ? (byte) 32 : (byte) 4);
            array[2] = vmethod_16();
            stream260.WriteByteArray(array, false);
            stream260.WriteInt(Int0);
            stream260.WriteInt(Int1);
            stream260.WriteInt((Nodes.Count != 0) ? ((int) stream260.Position + 8) : 0);
            stream260.WriteInt(0);
            foreach (AbstractTreeNode1 @class in Nodes)
            {
                @class.vmethod_14(stream260);
            }
        }

        public override void vmethod_2(ref int int2)
        {
            int2 += 20;
            foreach (AbstractTreeNode1 @class in Nodes)
            {
                @class.vmethod_2(ref int2);
            }
        }

        public override Color vmethod_15()
        {
            return GetColor2IfPrevNodeIsColor1(Color.Lime, Color.SpringGreen);
        }
    }
}