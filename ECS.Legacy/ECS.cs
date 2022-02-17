using System;

namespace ECS.Legacy
{
    public class ECS
    {
        private int _threshold;
        private readonly ITempSensor _tempSensor;
        private readonly IHeater _heater;
        private readonly IWindow _window;

        public ECS(int thr, ITempSensor tempSensor, IHeater heater, IWindow window)
        {
            SetThreshold(thr);
            _tempSensor = tempSensor;
            _heater = heater;
            _window = window;
        }

        public bool Regulate()
        {
            var t = GetCurTemp();
            Console.WriteLine($"Temperature measured was {t}");
            if (t < _threshold)
                _heater.TurnOn();
            else
                _heater.TurnOff();

            if (t < _threshold + 15)
            {
                _window.OpenWindow();
            }
            else
            {
                _window.CloseWindow();
            }

            return true;
        }

        public void SetThreshold(int thr)
        {
            _threshold = thr;
        }

        public int GetThreshold()
        {
            return _threshold;
        }

        public int GetCurTemp()
        {
            return _tempSensor.GetTemp();
        }
    }
}
