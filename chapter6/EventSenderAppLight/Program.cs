using LightLibEventSender;

Light light = new()
{
    Name="Living Room Light"
    
};
Light light2 = new()
{
    Name="Kitchen Light"
};


void Light_TurnedOn(object?sender,EventArgs e)
{
    if (sender is not Light L)return;

    Console.WriteLine($"{L.Name} Light was turned on!");

}

light.TurnedOn+= Light_TurnedOn;

light2.TurnedOn+=Light_TurnedOn;

light.TurnOn();

light2.TurnOn();
// event handler و یک object  با استفاده از دوتا sender  تمرین 
