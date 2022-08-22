Console.WriteLine("Введите трехзначное число: ");
char [] arr=Console.ReadLine().ToCharArray();
if(arr[0]=='-'){
    Console.WriteLine(arr[2]);
}
else{
    Console.WriteLine(arr[1]);
}
// Женькино решение
/*int x= Convert.ToInt32(Console.ReadLine());
x=x%100/10;
if(x<0){
    x=x*-1;
}
Console.ReadLine(x);*/