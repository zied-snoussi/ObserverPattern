using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ObserverPattern
{
    public partial class MovingBallObserver : Form, IObserver
    {
        public MovingBallObserver()
        {
            InitializeComponent();

            Application.DoEvents();
            StartThread();
        }

        private void StartThread()
        {
            circleShape1.Left = new Random().Next(this.Width - 100);
            circleShape1.Top = new Random().Next(this.Height - 100);

            ThreadStart threadStart = new ThreadStart(MoveBall);
            Thread thread = new Thread(threadStart);
            thread.Start();
        }

        #region IObserver Members

        public void ColorChanged(Color newColor)
        {
            circleShape1.FillColor = newColor;
        }

        #endregion

        private int _changeX = 5, _changeY = 5;
        
        public void MoveBall()
        {
            Thread.Sleep(500);
            Application.DoEvents();
            
            while (true)
            {
                try
                {
                    circleShape1.Left += _changeX;
                    circleShape1.Top += _changeY;
                }catch{}

                if ((circleShape1.Left + circleShape1.Width > this.Width - 15)
                    ||
                (circleShape1.Left < 0))
                    _changeX = _changeX * (-1);

                if ((circleShape1.Top + circleShape1.Height > this.Height - circleShape1.Height)
                    ||
                (circleShape1.Top < 0))
                    _changeY = _changeY * (-1);

                Thread.Sleep(50);
            }
        }
    }
}
