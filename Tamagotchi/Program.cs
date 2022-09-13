using System;

Shrek Shrek = new Shrek();
string named;
int day = 0;

Console.WriteLine($"Your tamagotchi is named {Shrek.name}");
Console.WriteLine("Do you want to change the name? Y/N");
named = Console.ReadLine();
named = named.ToLower();

if(named == "y"){
    Console.WriteLine("Type your name for the tamagotchi!");
    Shrek.name = Console.ReadLine();
}
else if(named == "n"){

}

Console.WriteLine($"Name: {Shrek.name}");
Console.WriteLine($"Take care of {Shrek.name} well");
Console.WriteLine("Press any key to continue...");
Console.ReadLine();
Console.Clear();

while(Shrek.Alive() == true){
Console.WriteLine("Day: " + day);
Shrek.Stats();
Console.WriteLine($"Choose something to do with {Shrek.name}");

Console.WriteLine($"1) Feed {Shrek.name} \n2) Talk to {Shrek.name} \n3) Teach {Shrek.name} a word\n4) Do nothing");
string action = Console.ReadLine();
Console.Clear();

if(action == "1"){
    Shrek.Feed();
}
else if(action == "2"){
    Shrek.Talk();
}
else if(action == "3"){
    Console.WriteLine($"Type a word to teach {Shrek.name}");
    string teached = Console.ReadLine();
    Shrek.Teach(teached);
}
else Shrek.Tick();

day++;
}