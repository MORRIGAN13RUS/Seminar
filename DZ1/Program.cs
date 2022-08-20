Console.WriteLine("Введите первое число: ");
int x= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int y= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int z= Convert.ToInt32(Console.ReadLine());
int max=x,min=x;
if (x>y){
    min=y;
}
else{
    max=y;
}
if (max<z){
    max=z;
}
if(min>z){
    min=z;
}
Console.WriteLine("min= "+ min+" ,max= "+max);
