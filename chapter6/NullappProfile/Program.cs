using ProfileLibNull;

Profile profile=new("hana");

int Length =profile.Bio?.Length ?? 0;

Console.WriteLine(profile.Username);
Console.WriteLine(Length);