// Задача с собакой бегующей от одного друга к другому.

Console.Clear();
Console.Write("Введите расстояние между друзьми: ");
int dist = Convert.ToInt32(Console.ReadLine());
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int count = 0;
int time = 0;

while (dist > 10)
{
  if (friend == 1)
  {
    time = dist / (firstFriendSpeed + dogSpeed);
    friend = 2;
  }
  else
  {
    time = dist / (secondFriendSpeed + dogSpeed);
    friend = 1;
  }
  dist = dist - (firstFriendSpeed + secondFriendSpeed) * time;
  count = count + 1;
}
Console.WriteLine("Собака пробежит " + count + " раз.");
