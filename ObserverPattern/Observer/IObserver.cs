using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ObserverPattern
{
    public interface IObserver
    {
        void ColorChanged(Color newColor);
    }
}
