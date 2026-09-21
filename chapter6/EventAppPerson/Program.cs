using PersonLibEvent;

Person person=new();

void Person_shout(object? sender,EventArgs e)
{
    Console.WriteLine("Person shouted!");

}
person.shout += Person_shout;

person.Poke();