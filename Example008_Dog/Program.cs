Console.Clear();
int count = 0, distance = 10000, 
    friend1Speed = 1, friend2Speed = 2, dogSpeed = 5;
int xa = 1, ya = 2,
    xb = (distance / 100), yb = 2,
    xc = 3, yc = 2;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("f1");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("f2");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("S");

int x = xa, y = xb;
int friend = new Random().Next(1, 2);
int time = 0;

while(distance > 10)
{
    if (friend == 1)
    {
       time = distance / (friend1Speed + dogSpeed);
       friend = 2;      
    }
    if (friend == 2)
    {
        time = distance / (friend2Speed + dogSpeed);
        friend = 1;        
    }
    distance = distance - (friend1Speed + friend2Speed) * time;
    count = count + 1;
    
    while(count < 10000)
{
        x = (x + xa);  
        y = (y + ya);
        
}
    Console.SetCursorPosition(x, y);
    Console.WriteLine(" ");

}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз");