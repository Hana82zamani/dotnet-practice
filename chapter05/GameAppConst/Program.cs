using GameLib;

Game game = new()
{
    name="GTA5",

};

Game.PlayerCount=12;

Console.WriteLine($"game name:{game.name}");
Console.WriteLine($"players count:{Game.PlayerCount}");
Console.WriteLine($"company name :{Game.Company}");

///ک جدول طلایی ⭐

//ویژگی	                     |    Instance|	Static   	|     Const	     |    Readonly          |	Required
//متعلق به Object            |        ✅  |    	❌	 |       ❌      |	نباشه static اگر✅|       ❌ ✅  
// متعلق به کلاس              |        ❌  |      ✅    |       ✅      |  static اگر باشه  ✅|static اگر باشه ✅
//قابل تغییر بعد از ساخت؟   |        ✅  |      ✅	|       ❌      |  	      ❌          |    	✅
//باید موقع ساخت مقدار بگیز؟ |      ❌   |      ✅    |       ✅      |          ❌          |      ✅