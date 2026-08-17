using PhonebookIndex;

Phonebook phonebook=new();

Contact ali=new()
{
    Name="Ali",
    Number= "0910..."
};
Contact hana=new()
{
    Name="Hana",
    Number= "0912..."
};
Contact sara=new()
{
    Name="Sara",
    Number= "0914..."
};
phonebook.Contacts.Add(ali);
phonebook.Contacts.Add(hana);
phonebook.Contacts.Add(sara);

Console.WriteLine(phonebook["Hana"].Number);