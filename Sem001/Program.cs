
Console.WriteLine("Введите первое число: ");
int x= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int y=Convert.ToInt32(Console.ReadLine());
if (y*y==x){
    Console.WriteLine(y+" является квадратным корнем из "+x);
}
else{
    Console.WriteLine(y+"  не является квадратным коренем из " + x);
}