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
    public partial class WeatherData : Form, ISubject
    {

        private List<IObserver> _observers = new List<IObserver>(); //List<> x = new List<>()
        private float _temp;
        private float _humidity;
        private int _pressure;

        public WeatherData()
        {

            InitializeComponent();

            CurrentConditionsDisplay currentConditionDisplay = new CurrentConditionsDisplay(this);
            currentConditionDisplay.Show();
            ForecastDisplay forecastDisplay = new ForecastDisplay(this);
            forecastDisplay.Show();
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(this);
            statisticsDisplay.Show();
        }

        public void NotifyObserver()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(_temp, _humidity, _pressure);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            if (!_observers.Contains(o))
            {
                _observers.Add(o); //add list
            }
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o); //remove list
        }

        private void generate_Click(object sender, EventArgs e)
        {
            MeasurementsChanged();
        }

        private void MeasurementsChanged()

        {
            float.TryParse(textBoxTemp.Text, out _temp);
            float.TryParse(textBoxHumidity.Text, out _humidity);
            Int32.TryParse(textBoxPressure.Text, out _pressure);

            NotifyObserver();

        }

        private void WeatherData_Load(object sender, EventArgs e)
        {

        }

       
    }
}
