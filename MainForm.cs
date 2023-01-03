using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ObserverPattern.ObserverPattern.Subject;
using ObserverPattern.ObserverPattern.Observer;

namespace ObserverPattern
{
    public partial class MainForm : Form
    {
        private ColorSubject _subject = new ColorSubject();

        public MainForm()
        {
            InitializeComponent();

            // Initialize
            nextLeft = 0;
            ColorCombo.SelectedColor = _subject.Color;
            Application.DoEvents();
            Add3ObserverForms();
        }

        private int nextTop = 0;
        private int nextLeft = 0;

        private void Add3ObserverForms()
        {
            for (int i = 1; i <= 5; i++)
            {
                SetCommonProperties(new BallObserver());
                SetCommonProperties(new SimpleObserver());
                SetCommonProperties(new MovingBallObserver());
                nextLeft += 300;
                nextTop = 0;
            }
        }

        private void SetCommonProperties(Form form)
        {
            form.Left = nextLeft;
            form.Top = nextTop;
            form.StartPosition = FormStartPosition.Manual;
            (form as IObserver).ColorChanged(_subject.Color);
            form.Show();

            _subject.Register(form as IObserver);

            nextTop += form.Height;
        }

        private void ColorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _subject.Color = ColorCombo.SelectedColor;
        }
    }
}
