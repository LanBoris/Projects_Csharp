Console.WriteLine("Enter username");
string username = Console.ReadLine();

if(username.ToLower() == "boris")
{
  Console.WriteLine("Ole, it's Boris!!!");
}
else
{
  Console.Write("Hi, ");
  Console.WriteLine(username);
}
