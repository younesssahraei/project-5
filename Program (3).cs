



//Younes Sahraie Project









int x;
string answer;
int Numbers;
ConsoleKeyInfo click;

do
{
    Console.Write("\n Enter Number(scores):    ");
    Numbers = 0;
    do
    {
        keyboard();

        Calculate();

    } while (click.Key.ToString() != "Enter");

    Console.WriteLine();

    x = Numbers * 5;

    percent();

    Console.WriteLine("\n Do you want to continue? ( Press y Or n)");

    choice();

} while (answer.ToLower() == "y");

Console.WriteLine(" \n thanks costumer");



void keyboard()
{
    do
    {

        click = Console.ReadKey(true);

    } while (click.KeyChar.ToString() != "0" && click.KeyChar.ToString() != "1" && click.KeyChar.ToString() != "2" &&
            click.KeyChar.ToString() != "3" && click.KeyChar.ToString() != "4" && click.KeyChar.ToString() != "5" &&
            click.KeyChar.ToString() != "6" && click.KeyChar.ToString() != "7" && click.KeyChar.ToString() != "8" &&
            click.KeyChar.ToString() != "9" && click.Key.ToString() != "Enter");
}

void Calculate()
{
    if (click.Key.ToString() != "Enter")
    {
        Numbers = Numbers * 10 + Convert.ToInt32(click.KeyChar.ToString());

        Console.Write(click.KeyChar);
    }
}
void choice()
{
    do
    {
        answer = Console.ReadKey(true).KeyChar.ToString();


    } while (answer.ToLower() != "y" & answer.ToLower() != "n");
}

void percent()
{


    if (Numbers < 0 || Numbers > 20)
    {
        Console.WriteLine("this isn't verified"); ;
    }
    else if (Numbers > 17 && Numbers <= 20)
    {

        Console.WriteLine("Your score:   " + Numbers);
        Console.WriteLine("Your percentage:  " + x);
        Console.WriteLine("You are in A rank");

    }
    else if (Numbers > 15 && Numbers <= 17)
    {

        Console.WriteLine("Your score:   " + Numbers);
        Console.WriteLine("Your percentage:  " + x);
        Console.WriteLine("You are in B rank");


    }
    else if (Numbers >= 10 && Numbers <= 15)
    {

        Console.WriteLine("Your score:   " + Numbers);
        Console.WriteLine("Your percentage:  " + x);
        Console.WriteLine("You are in C rank");

    }
    else if (Numbers > 0 && Numbers < 10)
    {

        Console.WriteLine("Your score:   " + Numbers);
        Console.WriteLine("Your percentage:  " + x);
        Console.WriteLine("You are in Failed rank");
    }
}


Console.ReadKey();

