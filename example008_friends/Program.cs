int count = 1;
int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 1;
int dogSpeed = 5;
int friend = 2;
int Time = 0;

while(distance>10)
{
    if(friend == 1)
    {
        Time = distance/(firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        Time = distance/(secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    
    distance = distance-(firstFriendSpeed + secondFriendSpeed)*Time;
    count = count + 1;
}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз");