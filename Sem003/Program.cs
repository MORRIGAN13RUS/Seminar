Console.WriteLine("Введите число");
int x= Convert.ToInt32(Console.ReadLine());
int y=0-x;
while(y<=x){
    if(y<x){
    Console.Write(y+",");
    y++;}
    if (y==x)
    {Console.Write(y);
    break;}

}
