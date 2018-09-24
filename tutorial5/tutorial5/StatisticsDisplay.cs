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
    public partial class StatisticsDisplay : Form, IObserver, IDisplayElement
    {

        private ISubject _subject;
        
        private float _avgtemp;
        private float _mintemp;
        private float _maxtemp;
        private int _countUpdate = 0;
        private float _sumOfTemp;

        public StatisticsDisplay(ISubject s)
        {
            InitializeComponent();
            _subject = s;

        }

        public void Display()


        {
            lblAvgTemp.Text = _avgtemp.ToString();
            lblMaxTemp.Text = _maxtemp.ToString();
            lblMinTemp.Text = _mintemp.ToString();
        }

        public void Update(float temp, float humidity, int pressure)
        {
            if (_countUpdate == 0)
            {
                _maxtemp = _mintemp = temp ;
            }

            _countUpdate += 1;
            
            if (_maxtemp < temp)
            {
                _maxtemp = temp;
            }
            

            if (_mintemp > temp)
            {
                _mintemp = temp;
            }

            _sumOfTemp += temp;
            _avgtemp = _sumOfTemp / _countUpdate;

                Display();
        }

        private void StatisticsDisplay_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            _subject.RegisterObserver(this);
        }

        private void btnDeRegister_Click(object sender, EventArgs e)
        {
            _subject.RemoveObserver(this);
        }
    }
}
