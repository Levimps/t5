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
    public partial class CurrentConditionsDisplay : Form, IObserver, IDisplayElement
    {

        private ISubject _subject;
        private float _temp;
        private float _humidity;
        private int _pressure;
        public CurrentConditionsDisplay(ISubject s)
        {
            InitializeComponent();
            _subject = s;
        }

        public void Display()
        {
            lbltemp.Text = _temp.ToString();
            lblhumidity.Text = _humidity.ToString();
            lblpressure.Text = _pressure.ToString();
        }

        public void Update(float temp, float humidity, int pressure)
        {
            _temp = temp;
            _humidity = humidity;
            _pressure = pressure;
            Display();
        }

        private void CurrentConditionsDisplay_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            _subject.RegisterObserver(this);
        }

        private void btnUnsubscribe_Click(object sender, EventArgs e)
        {
            _subject.RemoveObserver(this);
        }
    }
}
