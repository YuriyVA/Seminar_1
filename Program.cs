Console.WriteLine("Введите первое число  ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число  "); 
int num2 = int.Parse(Console.ReadLine()!);
if (num1 >num2){
    Console.WriteLine(num1);
}
else {
    Console.Write(num2);
}



Console.WriteLine("Введите первое число  ");
int num_f = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число  ");
int num_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число  ");
int num_3 = int.Parse(Console.ReadLine()!);

int [] array_max = {num_f, num_2, num_3};

Console.WriteLine(array_max.Max());


Console.WriteLine("Введите число ");
int num_a = int.Parse(Console.ReadLine()!);
if (num_a % 2 == 0){
    Console.WriteLine("Число четное");
}
else {Console.WriteLine("Число нечетное");}


Console.WriteLine("Введите число n ");
int n = int.Parse(Console.ReadLine()!);
int a = 1;
while (a < n){
    if (a % 2 == 0){
        Console.Write($", {a}");
    }
    a++;
}