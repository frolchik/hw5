/*Task1 Задайте массив заполненный случайными положительными трехзначными числами.
Напишите программу, которая покажет количество четных чисел в массиве.*/
/*
Console.Write("Input an array size: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] randomArray = new int [size];

void array(int size)
{
    for (int i=0; i < size; i++)
    {
        randomArray[i] = new Random().Next(99,999);
        Console.Write(randomArray[i] + " ");
    }
}

int quantity(int[] randomArray)
{
    int quantity = 0;
    for(int i=0; i < randomArray.Length; i++)
    {
    if (randomArray[i]%2 == 0)
    quantity++;    
    }
    return quantity;
}

array(size);
Console.Write($"количество четных чисел в массиве: {quantity(randomArray)}");
*/

/*Task2 Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.*/
/*
Console.Write("Input an array size: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] randomArray = new int [size];

void array(int size)
{
    for (int i=0; i < size; i++)
    {
        randomArray[i] = new Random().Next(1,9);
        Console.Write(randomArray[i] + " ");
    }
}
int quantity(int[] randomArray)
{
    int sum = 0;
    for(int i=1; i < randomArray.Length; i+=2)
    {
    sum = sum + randomArray[i];   
    }
    return sum;
}
array(size);
Console.Write($"Сумма элементов на нечетных позициях: {quantity(randomArray)}");
*/

/*Task3 Задайте массив вещественных чисел. Найдите разницу
между максимальным и минимальным элементом массива.*/

Console.Write("Input an array size: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] randomArray = new double [size];

void array(int size)
{
    Random rand = new Random();
    for (int i=0; i < size; i++)
    {
        randomArray[i] =  rand.NextDouble();
        Console.Write($" {randomArray[i]:F2} ");
    }
}
double diff(double[] randomArray)
{
     double min = randomArray[0];
     double max = randomArray[0];
      for(int i=1; i < randomArray.Length; i++)
      {
        if(max<randomArray[i])
        max = randomArray[i];
        if(min>randomArray[i])
        min = randomArray[i];
      }
      return max-min;
}
array(size);
Console.Write($"Разница: {diff(randomArray):F2}");

//не поняла как применить способ Math.Round, нашла способ
// с написанием как в 76 и 93 строках, если сделать F1-F3 - будет 1 или 3 цифры после запятой