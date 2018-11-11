using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Task2Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать");
            List<Car> car = new List<Car>();
            while (true)
            {
                Console.WriteLine("Хотите добавить автомобиль или вывести всю информацию?(Если хотите добавить то просто нажмите enter иначе что-нибудь введите в строку)");
                string tab = Console.ReadLine();
                if (tab == "")
                {
                    try
                    {
                        Console.WriteLine("Введите марку машины");
                        string name = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Теперь введите мощность двигателя");
                        int enginePower = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Введите кол-во мест в вашем автомобиле");
                        int seatCount = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Какого уровня автомобиль создаем?(1 или 2-го)");
                        int choose = Convert.ToInt32(Console.ReadLine());
                        switch (choose)
                        {
                            case 1:
                                Car car1 = new Car(name, enginePower, seatCount);
                                car.Add(car1);
                                Console.WriteLine("Результат = {0}", car[car.Count - 1].GetQ());
                                Console.WriteLine();
                                break;
                            case 2:
                                Console.WriteLine("Тогда вам надо ввести год выпуска автомобиля");
                                Console.WriteLine();
                                int yearMade = Convert.ToInt32(Console.ReadLine());
                                PersonalCar personalCar = new PersonalCar(name, enginePower, seatCount, yearMade);
                                car.Add(personalCar);
                                Console.WriteLine("Результат = {0}", car[car.Count - 1].GetQ());
                                Console.WriteLine();
                                break;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Данные введены неверно, проверьте правильность введенных данных");
                        Console.WriteLine();
                    }
                }
                else
                {
                    if (car.Count == 0)
                    {
                        Console.WriteLine("Список пуст, сначала добавьте автомобили");
                        Console.WriteLine();
                    }
                    else
                    {
                        for (int i = 0; i < car.Count; i++)
                        {
                            Console.WriteLine("Марка: {0}, Мощность двигателя: {1}, Кол-во мест: {2}, Результат: {3}", car[i].Name, car[i].EnginePower, car[i].SeatsCount, car[i].GetQ());
                        }
                    }
                }
            }
        }
    }
}
