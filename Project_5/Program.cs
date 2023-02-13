Console.WriteLine("Enter your name:");
string user = Console.ReadLine()!;

if (user.ToLower() == "boris")
{
  Console.WriteLine("Ole, it's Boris!!!");
}
else
{
  Console.WriteLine("Hi, ");
  Console.WriteLine(user);
}