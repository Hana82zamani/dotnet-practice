using TupleLibSales;

var Result=SalesReport.SaleFactor("laptop",100,2);

Console.WriteLine(Result.Name);
Console.WriteLine(Result.number);
Console.WriteLine(Result.income);
Console.WriteLine(Result.average);
Console.WriteLine("----------------");

var (name, number, income, average) = // دراین مدل اگه ترتیب رعایت نشه خطا میده
    SalesReport.SaleFactor("Phone", 50, 4);

Console.WriteLine(name);
Console.WriteLine(number);
Console.WriteLine(income);
Console.WriteLine(average);