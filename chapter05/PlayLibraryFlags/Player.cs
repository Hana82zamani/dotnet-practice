using System;

namespace PlayLibrary;

[Flags]
public enum PlayerPower : byte
{
Sword =1,

Shield =2,

Magic =4,

Bow =8
}

public class Player
{
public string Name = "";
public PlayerPower Powers;
}