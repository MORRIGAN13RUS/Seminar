//Вывод второй цифры в трехзначном числе
Console.WriteLine("Введите трехзначное число: ");
int x=Convert.ToInt32(Console.ReadLine());
char  GetSecondNumber ( int num){ 
    char y;
char [] arr=num.ToString().ToCharArray();
if(arr[0]=='-'){
    y=arr[2];
}
else{
    y=arr[1];
}
return y;
}
Console.WriteLine(GetSecondNumber(x));

// Второй вариант решения
/*
Console.WriteLine("Введите трехзначное число: ");
int x= Convert.ToInt32(Console.ReadLine());
int  GetSecondNumber (int num){
num=num%100/10;
if(num<0)
    num=num*-1;
return num
}
Console.WriteLine(GetSecondNumber(x));
*/
