//Задача 41: 
//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.WriteLine("Введите количество, сколько чисел вы хотите ввести:");
int M = int.Parse(Console.ReadLine()!);
int[] massive = GetArray(M);
Console.WriteLine("Массив из введенных чисел: " + String.Join(" ", massive));
int count = PositiveCount(massive, M);
Console.WriteLine($"Количество введенных положительных чисел = {count}");

int PositiveCount(int[] mas, int size){
    int counter = 0;
    for (int i = 0; i < size; i++){
        if (mas[i] > 0) counter++;
    }
    return counter;    
}

int[] GetArray(int size){
    int[] mas = new int[size];
    for (int i = 0; i < size; i++){
        Console.Write($"Введите ваше {i+1} число: ");
        mas[i] += int.Parse(Console.ReadLine()!);
}
    return mas;
}
*/

//Задача 43:
//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
/*
Console.WriteLine("Введите угловой коэф. k1 и " + 
                  "свободный член b1 для первой прямой ");
double k1 =int.Parse(Console.ReadLine()!);
double b1 =int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите угловой коэф. k2 и " + 
                  "свободный член b2 для второй прямой ");
double k2 =int.Parse(Console.ReadLine()!);
double b2 =int.Parse(Console.ReadLine()!);

string location = LocationStraights(k1, b1, k2, b2);
Console.WriteLine(location);

string LocationStraights(double k1, double b1, double k2, double b2){
    double x;
    double y;
    string res;
    if (k1 == k2 && b1 != b2) return "Прямые паралельны и " + 
                                     "не имеют точек пересеч";
    else if (k1 == k2 && b1 == b2) return "Прямые совпадают и имеют " + 
                                          "множество точек пересеч";
    else {
        x = (b2-b1) / (k1-k2);
        y = k1 * x + b1;
        res = Convert.ToString(x)+ ", " + Convert.ToString(y);
        return $"Точка пересечения прямых = ({res})";
    }
}
*/