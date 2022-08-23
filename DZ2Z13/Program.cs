//вывод третьего элмента из любого целого числа
Console.WriteLine("Введите целое число: ");
int number= Convert.ToInt32(Console.ReadLine());

char GetTherdNumber( int num){
    if (num<0){
    num=num*-1;}
    char [] array=num.ToString().ToCharArray();
    char z='-';
if(array.Length>2){    
    z=array[2];
}
return z;
}
char x=GetTherdNumber(number);
if (x=='-') Console.WriteLine("Третьей цифры нет");
else Console.WriteLine(x);