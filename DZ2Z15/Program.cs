Console.WriteLine("Введите номер дня недели");
int x=Convert.ToInt32(Console.ReadLine());
bool GetWeekend (int x) {
    bool answer;
if(x>5) answer=true;
else answer=false;
return answer;
}
Console.WriteLine(GetWeekend (x));
//Можно конечно ввствить еще условие, которое будет 
//сравнивать булевую переменную и выводить по русски да и нет, но лень. 
//А это писать не лень. :)