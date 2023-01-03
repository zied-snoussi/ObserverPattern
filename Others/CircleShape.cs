using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ObserverPattern.Others
{
    public class CircleShape : Control
    {
        private Color _FillColor = Color.Blue;
        private SolidBrush _brush;

        public CircleShape()
        {
            _brush = new SolidBrush(_FillColor);
        }

        public Color FillColor
        {
            get { return _FillColor; }
            set 
            { 
                _FillColor = value;
                _brush.Color = value;

                this.Invalidate();  
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillEllipse(_brush, 0, 0, this.Width - 1, this.Height - 1);
        }
    }
}
