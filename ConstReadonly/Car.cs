using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstReadonly
{
    class Car
    {
        private const string ENGINE_IS_START_MESSAGE = "Двигатель запущен";
        private const string ATTEMPT_TO_START_ENGINE_MESSAGE = "Завожу двигатель";
        private const string ENGINE_IS_ALREADY_STARTED_MESSAGE = "Двигатель уже запущен!";
        private const string ATTEMPT_TO_DRIVE_MESSAGE = "Педаль газа в пол";
        private const string DRIVE_MESSAGE = "Машина поехала";
        private const string DRIVE_ERROR_MESSAGE = "Заведи двигатель!";

        // некий сервис который будет использовать Car под свои нужды
        private readonly MyLogger _myLogger;

        private bool isEngineStarted;


        public Car(MyLogger myLogger)
        {
            _myLogger = myLogger;
        }

        public void StartEngine()
        {
            _myLogger.Info(ATTEMPT_TO_START_ENGINE_MESSAGE);

            if (isEngineStarted)
            {
                _myLogger.Warning(ENGINE_IS_ALREADY_STARTED_MESSAGE);
            }
            else
            {
                isEngineStarted = true;
                _myLogger.Info(ENGINE_IS_START_MESSAGE);
            }
        }

        public void Drive()
        {
            _myLogger.Info(ATTEMPT_TO_DRIVE_MESSAGE);

            if (isEngineStarted)
            {
                _myLogger.Info(DRIVE_MESSAGE);
            }
            else
            {
                _myLogger.Error(DRIVE_ERROR_MESSAGE);
            }
        }
    }
}
