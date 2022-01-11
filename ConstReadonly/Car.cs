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



        public void StartEngine()
        {

        }

        public void Drive()
        {

        }
    }
}
