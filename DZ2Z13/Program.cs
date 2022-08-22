//вывод третьего элмента из любого целого числа
Console.WriteLine("Введите целое число: ");
char [] arr=Console.ReadLine().ToCharArray();
if(arr[0]=='-'){
    if(arr.Length<4)
    Console.WriteLine("Третьего числа нет");
    else Console.WriteLine(arr[3]);
}
else{
    if(arr.Length<3)
    Console.WriteLine("Третьего числа нет");
    else
    Console.WriteLine(arr[2]);
}