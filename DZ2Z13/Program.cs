//вывод третьего элмента из любого целого числа
Console.WriteLine("Введите целое число: ");
char [] arr=Console.ReadLine().ToCharArray();
char GetTherdNumber( char[]array){
    char z;
if(array[0]=='-'&& array.Length>3){    
    z=array[3];
}
else if (array[0]!='-'&&array.Length>2){
       z=array[2];
}
else z='-';
return z;
}
char x=GetTherdNumber(arr);
if (x=='-') Console.WriteLine("Третьей цифры нет");
else Console.WriteLine(x);