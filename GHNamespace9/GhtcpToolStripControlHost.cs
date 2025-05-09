using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace GHNamespace9
{
    public class GhtcpToolStripControlHost : ToolStripControlHost
    {
        private EventHandler _eventHandler0;

        protected override Size DefaultSize => new Size(200, 16);

        public GhtcpToolStripControlHost() : base(smethod_0())
        {
        }

        public TrackBar method_0()
        {
            return Control as TrackBar;
        }

        private static Control smethod_0()
        {
            return new TrackBar
            {
                AutoSize = false,
                Height = 16
            };
        }

        public int method_1()
        {
            return method_0().Minimum;
        }

        public void method_2(int int0)
        {
            method_0().Minimum = int0;
        }

        public void method_3(int int0)
        {
            method_0().Maximum = int0;
        }

        public int method_4()
        {
            return method_0().Value;
        }

        public void method_5(int int0)
        {
            method_0().Value = int0;
        }

        protected override void OnSubscribeControlEvents(Control control)
        {
            base.OnSubscribeControlEvents(control);
            if (control is TrackBar trackBar)
            {
                trackBar.ValueChanged += method_6;
            }
        }

        protected override void OnUnsubscribeControlEvents(Control control)
        {
            base.OnUnsubscribeControlEvents(control);
            if (control is TrackBar trackBar)
            {
                trackBar.ValueChanged -= method_6;
            }
        }

        private void method_6(object sender, EventArgs e)
        {
            _eventHandler0?.Invoke(sender, e);
        }

        public void method_7(EventHandler eventHandler1)
        {
            EventHandler eventHandler = _eventHandler0;
            EventHandler eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler value = (EventHandler) Delegate.Combine(eventHandler2, eventHandler1);
                eventHandler = Interlocked.CompareExchange(ref _eventHandler0, value, eventHandler2);
            } while (eventHandler != eventHandler2);
        }
    }
}