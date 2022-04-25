using System;


public class Program
{
    public static void Main()
    {
        /* 	
          14. Написать программу, которая вычисляет скорость, с которой
          спортсмен пробежал дистанцию.
          Рекомендуемый вид экрана программы приведен ниже.
          Вычисление скорости бега
          Введите длину дистанции (метров) -> 1000
          Введите время (минут.секунд)-> 3.25
          Дистанция: 1000
          Время: 3 мин 25 сек = 205 сек
          Скорость: 17.56 км/час
        */
        double distance, time, speed, min, sec, time_2;

        Console.WriteLine("Input distance (in meters) :");
            distance = Double.Parse(Console.ReadLine());
        Console.WriteLine("Input time(min.sec) :");
            time = Double.Parse(Console.ReadLine());
            sec = (time - Convert.ToInt16(time)) * 100;
            min = Convert.ToInt16(time);
            time_2 = min * 60 + sec;
            speed = ((distance / 1000) / (time_2 / 3600));

        Console.WriteLine("Distance : {0}", distance);
        Console.WriteLine("Time : {0}min {1}sec = {2} sec", min, sec, time_2);
        Console.WriteLine("Your speed was {0:f2} km/h", speed);

    }
}
