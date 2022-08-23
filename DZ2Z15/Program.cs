Console.WriteLine("Введите номер дня недели");
int x=Convert.ToInt32(Console.ReadLine());
bool GetWeekend (int x) {
    bool answer=false;
if(x>5 && x<8) {answer=true;}
return answer;
}
Console.WriteLine(GetWeekend (x));
//Можно конечно выствить еще условие, которое будет 
//сравнивать булевую переменную и выводить по русски да и нет, но это не принципиально. 