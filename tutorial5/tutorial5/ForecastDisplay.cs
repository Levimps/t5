using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tutorial5
{
    public partial class ForecastDisplay : Form, IObserver, IDisplayElement
    {
        private ISubject _subject;
        private int _pressure;
     
        public ForecastDisplay(ISubject s)
        {
            InitializeComponent();
            _subject = s;
        }

        public void Display()
        {
            if (_pressure < 1000)
            {
                lblExpected.Text = "Rain";
            }
            else
            {
                lblExpected.Text = "Sunshine";
            }
        }

        public void Update(float temp, float humidity, int pressure)
        {
            _pressure = pressure;
            Display();
        }

        private void ForecastDisplay_Load(object sender, EventArgs e)
        {
            _subject.RegisterObserver(this);

        }

        private void lblExpected_Click(object sender, EventArgs e)
        {
            _subject.RemoveObserver(this);
        }
    }
}
