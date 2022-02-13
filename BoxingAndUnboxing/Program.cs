﻿using System;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // boxing и Unboxing сильно влияют на производительность(снижение)

            // значение а в стеке
            int a = 1;
            // упаковка, выделем место в управляемой куче и копируем туда данные из а
            object b = a;
            // распаковка, из переменной б данные извлекаем из управляемой кучи в стек в переменную с
            // затем не используемые данные в упровляемой куче будут очищены сборщиком мусора, на это требуется время
            // распаковать их мы можем только в int
            int c = (int)b;

            // получаем информацию о типе данных
            a.GetType();
            // после перекомпиляции 	IL_0012: box [System.Runtime]System.Int32
            // метод вызывается для типа object поэтому происходит упаковка

            //

            // неявный boxing
            // структура и интерфейс



            Point point = new Point { X = 1, Y = 2 };
            // IL_003b: box BoxingAndUnboxing.Point
            Print(point);
            // интерфейсы должны всегда должны содержать ссылку на объект в куче
            // поэтому объект который принимается в качестве параметра тоже должен быть
            // расположен в управляемой куче и поэтом происходит box

        }
        // метод который в качестве параметров принимает объект который реализует данный интерфейс
        static void Print(IPrintable printable)
        {
            printable.Print();
        }

    }
}