using System;
using System.Windows.Forms;

namespace DayTradingApp.Helpers
{
    public static class ScrollManager
    {
        public static SimpleScrollBar Attach(Control container, Control content, SimpleScrollBar scroll)
        {
            ConfigureScroll(container, content, scroll);

            return scroll;
        }

        private static void ConfigureScroll(Control container, Control content, SimpleScrollBar scroll)
        {
            scroll.Scroll += (s, ev) =>
            {
                content.Top = -scroll.Value;
            };

            content.MouseWheel += (s, ev) =>
            {
                int delta = -ev.Delta / 4;
                scroll.Value = Math.Max(0, Math.Min(scroll.Maximum, scroll.Value + delta));
                content.Top = -scroll.Value;
            };

            // update when content or container changes
            content.ControlAdded += (s, ev) => Update(scroll, container, content);
            content.SizeChanged += (s, ev) => Update(scroll, container, content);
            container.SizeChanged += (s, ev) => Update(scroll, container, content);

            Update(scroll, container, content);
        }

        public static void Update(SimpleScrollBar scroll, Control container, Control content)
        {
            int max = content.Height - container.Height;
            if (max < 0) max = 0;

            scroll.Maximum = max;

            if (scroll.Value > max)
                scroll.Value = max;

            content.Top = -scroll.Value;
        }
    }
}
