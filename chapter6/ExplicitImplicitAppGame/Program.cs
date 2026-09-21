using GameLibExplicitImplicit;

Game game=new();

IOnline online=game;
online.Connect();

IOffline offline=game;
offline.Connect();

