using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tutorial5
{
    public interface IObserver
    {
        void Update(float temp, float humidity, int pressure);
    }
}