using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ObserverPattern.ObserverPattern.Observer
{
    public partial class SimpleObserver : Form, IObserver
    {
        public SimpleObserver()
        {
            InitializeComponent();
        }

        #region IObserver Members

        public void ColorChanged(Color newColor)
        {
            this.BackColor = newColor;
        }

        #endregion
    }
}
