﻿using static System.Console;
{
    string[] names = { "Alonso", "Zheng", "Smith", "Jones", "Smythe", "Small", "Ruiz",
        "Hsieh", "Jorgenson", "Ilyich", "Singh", "Samba", "Fatimah" };
    var queryResults =
        from n in names
        where n.StartsWith("S")
        select n;
    WriteLine("Names beginning with S:");
    foreach (var item in queryResults)
    {
        WriteLine(Item);
    }
}   Write("Program finished, press Enter/Return to continue");