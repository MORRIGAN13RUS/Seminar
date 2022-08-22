Console.WriteLine("Введите номер дня недели");
int x=Convert.ToInt32(Console.ReadLine());
void Weekend (int x) {
if(x>5) Console.WriteLine("Ура! Бухаем!");
else Console.WriteLine("Работайте, черти!");
}
Weekend (x);