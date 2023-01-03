using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ObserverPattern
{
    public partial class BallObserver : Form, IObserver
    {
        public BallObserver()
        {
            InitializeComponent();
        }

        #region IObserver Members

        public void ColorChanged(Color newColor)
        {
            circleShape1.FillColor = newColor;
            circleShape2.FillColor = newColor;
            circleShape3.FillColor = newColor;
        }

        #endregion
    }
}
