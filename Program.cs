/*
 * Program Name: Example
 * Programmer: Madison Giurbino
 * Date: 12/19/2022
 *
 * Description: You can adopt a cat or a dog as your own
 */

List<dog>dogs = new List<dog>();
List<cat> cats = new List<cat>();
Console.WriteLine("Press 1 To obtain a dog");
Console.WriteLine("Press 2 To obtain a Cat");
int selection = int.Parse(Console.ReadLine());

if (selection == 1)
{
    CreateDog();
}

if (selection == 2)
{
    CreateCat();
}

void CreateDog()
{
   bool isLooping = true;

    Console.WriteLine("Enter a name");
    Console.ReadLine();

    Console.WriteLine("Enter dog or cat");

    Console.WriteLine("Press 1 for a dog");
    Console.WriteLine("Press 2 for a cat");
    int selection = int.Parse(Console.ReadLine());

    Console.Clear();

    if (selection == 1)
    {
        dogs.Add(new dog);
        Console.WriteLine("You have obtained a dog");
    }
    else
    {
        Console.WriteLine("You can not buy a fish");
    }
    Console.WriteLine("Dogs : ");
    foreach (Dog dog in dog)
    {
        Console.WriteLine("");
    }

}

void CreateCat()
{
    bool isLooping = true;

    Console.WriteLine("Enter a name");
    Console.ReadLine();

    Console.WriteLine("Enter dog or cat");

    Console.WriteLine("Press 1 for a dog");
    Console.WriteLine("Press 2 for a cat");
    int selection = int.Parse(Console.ReadLine());

    else if (selection == 2)
    {
        cat.Add(new Cat);
        Console.WriteLine("You have obtained a cat");
    }
    else
    {
        Console.WriteLine("You can not buy a fish");
    }
    Console.WriteLine("Cats : ");
    foreach (Cat cat in cat) ;

}

