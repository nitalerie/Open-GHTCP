using System;
using System.Collections.Generic;
using System.Drawing;

namespace GHNamespaceB
{
    public abstract class AbsTreeNode11 : AbstractTreeNode1
    {
        public override int CompareTo(object target)
        {
            if (!target.GetType().Equals(GetType()))
            {
                return -1;
            }
            if (((AbsTreeNode11) target).Text == Text)
            {
                return 0;
            }
            return 1;
        }

        public T[] method_7<T>()
        {
            return method_8<T>().ToArray();
        }

        public List<T> method_8<T>()
        {
            List<T> list = new List<T>();
            if (Nodes[0] is AbstractTreeNode1)
            {
                System.Collections.IEnumerator enumerator = Nodes.GetEnumerator();
                try
                {
                    while (enumerator.MoveNext())
                    {
                        T item = (T) enumerator.Current;
                        list.Add(item);
                    }
                    return list;
                }
                finally
                {
                    if (enumerator is IDisposable disposable)
                    {
                        disposable.Dispose();
                    }
                }
            }
            foreach (AbstractTreeNode2 @class in Nodes)
            {
                list.Add((T) @class.vmethod_7());
            }
            return list;
        }

        public override Color GetColor()
        {
            return GetColor2IfPrevNodeIsColor1(Color.PowderBlue, Color.PaleTurquoise);
        }

        public override string GetText()
        {
            return string.Concat(GetNodeText(), " (", Nodes.Count, ")");
        }
    }
}