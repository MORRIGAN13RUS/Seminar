Console.WriteLine("Введите трехзначное число: ");
char [] arr=Console.ReadLine().ToCharArray();
if(arr[0]=='-'){
    Console.WriteLine(arr[3]);
}
else{
    Console.WriteLine(arr[2]);
}
