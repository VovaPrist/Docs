string name, Tname, weather, thing, animal, car, weird;

Console.WriteLine("Name the most dangerous kind of weather?");
weather = Console.ReadLine();
Console.WriteLine("Name something really heavy you wouldn’t want to be hit by.");
thing = Console.ReadLine();
Console.WriteLine("Name a huge animal you’d never want to run into.");
animal = Console.ReadLine();
Console.WriteLine("Name the biggest plane you know.");
car = Console.ReadLine();
Console.WriteLine("Name one weird thing you'd never see falling from the sky?");
weird = Console.ReadLine();
Console.WriteLine("What's your name?");
name = Console.ReadLine();
Console.WriteLine("What's your teacher's name?");
Tname = Console.ReadLine();

Console.WriteLine($"Dear {Tname},");
Console.WriteLine($"I couldn’t make it to school today because disaster struck. First, I got hit by {weather}.");
Console.WriteLine($"Then, out of nowhere, {thing} crushed me.");
Console.WriteLine($"As I tried to crawl away, I was attacked by a furious {animal}.");
Console.WriteLine($"Just when I thought it was all over, a {car} came crushing down on me.");
Console.WriteLine($"Miraculously, I survived, only to be smacked in the face by {weird}.");
Console.WriteLine($"That’s why I wasn’t in school. Please excuse me.");
Console.WriteLine($"Sincerely,");
Console.WriteLine($"{name}");

Console.ReadLine();
