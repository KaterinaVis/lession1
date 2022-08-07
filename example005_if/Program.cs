Console.WriteLine("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "маша") //оператор для если/то, задается условие, тулоуер для перевода регистрова в нижний
{
Console.WriteLine("Ура, это же Маша ");
}
else //иначе
{
    Console.Write("Привет, ");
     Console.WriteLine(username);
}