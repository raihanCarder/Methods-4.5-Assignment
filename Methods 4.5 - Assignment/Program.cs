using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Methods_4._5___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Raihan Carder, Sep 13 2023
            int selection = 0;
            int xParameter, yParameter;
            bool ascii = true, parameterValue = false, validSelection = false;

            while (ascii == true) {
                xParameter = 0;
                yParameter = 0;



                Console.Title = "ASCII Art + Joke";
                Console.SetWindowSize(120,60);

                Console.WriteLine("Main Menu");
                Console.WriteLine();
                Console.WriteLine("Which ASCII art or Joke would you like to see?");
                Console.WriteLine("Your options include: 1. Sonic, 2. Monkey, or 3. Garfield.");
                Console.WriteLine("If you'd like a joke, type 4 for a JOKE, to quit: type 5.");
                Console.Write("What would you like to see? (type the according number): ");
                while (validSelection == false)
                {
                    if (int.TryParse(Console.ReadLine(), out selection) && selection > 0 && selection < 6)
                    {
                        validSelection = true;
                    }
                    else
                    {
                        Console.Write("Please re-enter a valid value in the range of 1-5:");
                    }
                }
                validSelection = false;
                Console.WriteLine() ;
                if (selection > 0 && selection < 4)
                {
                    Console.Write("Where would you like the image to be with the X parameter? (Must be within 1-80):");
                    while (parameterValue == false)
                    {
                        if (int.TryParse(Console.ReadLine(), out xParameter) && xParameter >= 0 && xParameter <= 80)
                        {
                            parameterValue = true;
                        }
                        else
                        {
                            Console.Write("Please enter a value within the range of 1-80 that's an integer:");
                        }
                    }
                    parameterValue = false;
                    Console.Write("Where would you like the image to be with the Y parameter? (Must be within 1-60):");

                    while (parameterValue == false)
                    {
                        if (int.TryParse(Console.ReadLine(), out yParameter) && yParameter >= 0 && yParameter <= 60)
                        {
                            parameterValue = true;
                        }
                        else
                        {
                            Console.Write("Please enter a value within the range of 1-60 that's an integer:");
                        }
                    }
                    Console.Clear();
                    parameterValue = false;
                    if (selection == 1)
                    {
                        Sonic(xParameter, yParameter);
                    }
                    else if (selection == 2)
                    {
                        Monkey(xParameter, yParameter);
                    }
                    else if (selection == 3)
                    {
                        Garfield(xParameter, yParameter);
                    }

                }
                else if ( selection == 4)
                {
                    Console.Clear();
                    Joke();
                }
                else
                {
                    Console.WriteLine("Click enter one more time to quit.");
                    ascii = false;
                }
            }

            Console.ReadLine();
        }
       
        public static void Sonic(int xValue, int yValue)
        {
            Console.WriteLine("Sonic the Hedgehog");
            Console.Write("");
            Console.SetCursorPosition(xValue, yValue);
            Console.WriteLine("                 ______"); //
            Console.SetCursorPosition(xValue, yValue+1);
            Console.WriteLine("  (~~~-_  _/~~~~~  ____~~\\_");//
            Console.SetCursorPosition(xValue, yValue+2);
            Console.WriteLine("  (     \\/        /,--,)   ~\\_"); //
            Console.SetCursorPosition(xValue, yValue+3);
            Console.WriteLine("  (    /'        //   ))      \\");//
            Console.SetCursorPosition(xValue, yValue+4);
            Console.WriteLine("   \\ /~           ~\\ //  /~~~~~'");//
            Console.SetCursorPosition(xValue, yValue+5);
            Console.WriteLine("    Y       ,---,   ~/  /");//
            Console.SetCursorPosition(xValue, yValue+6);
            Console.WriteLine("   (       /     )     '~~-_"); //
            Console.SetCursorPosition(xValue, yValue+7);
            Console.WriteLine("   //\\   /~      |          ~\\");//
            Console.SetCursorPosition(xValue, yValue+8);
            Console.WriteLine("  ((  \\ /        |             \\");//
            Console.SetCursorPosition(xValue, yValue+9);
            Console.WriteLine("  ((  ( (  ,-.   |              \\");//
            Console.SetCursorPosition(xValue, yValue+10);
            Console.WriteLine("  (( ,~l)  ( )   )               \\");//
            Console.SetCursorPosition(xValue, yValue+11);
            Console.WriteLine(" _J( ( )   ( )  /           ,----)");//
            Console.SetCursorPosition(xValue, yValue+12);
            Console.WriteLine("( ~~\\`-'   `-' /-~\\     .--<");
            Console.SetCursorPosition(xValue, yValue+13);
            Console.WriteLine(" `---~~~~-----' _  )   /  _/");
            Console.SetCursorPosition(xValue, yValue+14);
            Console.WriteLine("    \\           /~ )r-/\\_/ \\_");
            Console.SetCursorPosition(xValue, yValue+15);
            Console.WriteLine("     \\_       -'  /( (,-')   \\ ");
            Console.SetCursorPosition(xValue, yValue+16);
            Console.WriteLine("      _>-.____,--' r~~L--)    \\");
            Console.SetCursorPosition(xValue, yValue+17);
            Console.WriteLine("     ///~~~~~~\\    |,-L, )     \\");
            Console.SetCursorPosition(xValue, yValue+18);
            Console.WriteLine("   ,'//        \\(~\\(V ~ / __    )");
            Console.SetCursorPosition(xValue, yValue+19);
            Console.WriteLine("  / J/          U  U\\>-~ (  ~\\  )");
            Console.SetCursorPosition(xValue, yValue+20);
            Console.WriteLine(" / /7           |\\ V )    \\   \\J'");
            Console.SetCursorPosition(xValue, yValue+21);
            Console.WriteLine("/ ( (           | \\ /      )");
            Console.SetCursorPosition(xValue, yValue+22);
            Console.WriteLine("\\ ( (           |  ~       )");
            Console.SetCursorPosition(xValue, yValue+23);
            Console.WriteLine(" \\ \\J)          / ____     )");
            Console.SetCursorPosition(xValue, yValue+24);
            Console.WriteLine("  C/,\\         /_/ <_ ~\\_ /");
            Console.SetCursorPosition(xValue, yValue+25);
            Console.WriteLine("(~Y~~ \\_____--=/     \\   V");
            Console.SetCursorPosition(xValue, yValue+26);
            Console.WriteLine("( (   ]~--z-S  \\ /\\   \\");
            Console.SetCursorPosition(xValue, yValue+27);
            Console.WriteLine(" \\\\  /~~( /A   `<  \\   \\_");
            Console.SetCursorPosition(xValue, yValue+28);
            Console.WriteLine("  ~~7    |(( >   \\  ~\\_  \\");
            Console.SetCursorPosition(xValue, yValue+29);
            Console.WriteLine("    (    )`\\Y \\   \\    ~~~'");
            Console.SetCursorPosition(xValue, yValue+30);
            Console.WriteLine("    (    `~~| (~~~~~)");
            Console.SetCursorPosition(xValue, yValue+31);
            Console.WriteLine("   (__/~~~~7,C~~~~~)");
            Console.SetCursorPosition(xValue, yValue+32);
            Console.WriteLine("    \\    ___LC~~~~~),");
            Console.SetCursorPosition(xValue, yValue+33);
            Console.WriteLine("     \\===-<~~\\~~~~~ \\");
            Console.SetCursorPosition(xValue, yValue+34);
            Console.WriteLine("   ,/~~     \\  \\      \\");
            Console.SetCursorPosition(xValue, yValue+35);
            Console.WriteLine(" /~          )  )      ) ");
            Console.SetCursorPosition(xValue, yValue+36);
            Console.WriteLine("(____________L__L______)");
            Console.WriteLine();
            Console.WriteLine("Click enter to Return to the menu");
            Console.ReadLine();
            Console.Clear();
         
        }

        public static void Monkey(int xValue, int yValue)
        {
            Console.SetCursorPosition(xValue, yValue);
            Console.WriteLine("            __,__");
            Console.SetCursorPosition(xValue, yValue+1);
            Console.WriteLine("   .--.  .-\"     \"-.  .--.");
            Console.SetCursorPosition(xValue, yValue+2);
            Console.WriteLine("  / .. \\/  .-. .-.  \\/ .. \\");
            Console.SetCursorPosition(xValue, yValue + +3);
            Console.WriteLine(" | |  '|  /   Y   \\  |'  | |");
            Console.SetCursorPosition(xValue, yValue + +4);
            Console.WriteLine(" | \\   \\  \\ 0 | 0 /  /   / |");
            Console.SetCursorPosition(xValue, yValue + +5);
            Console.WriteLine("  \\ '- ,\\.-\"`` ``\"-./, -' /");
            Console.SetCursorPosition(xValue, yValue + +6);
            Console.WriteLine("   `'-' /_   ^ ^   _\\ '-'`");
            Console.SetCursorPosition(xValue, yValue + +7);
            Console.WriteLine("       |  \\._   _./  |");
            Console.SetCursorPosition(xValue, yValue + +8);
            Console.WriteLine("       \\   \\ `~` /   /");
            Console.SetCursorPosition(xValue, yValue + +9);
            Console.WriteLine("        '._ '-=-' _.'");
            Console.SetCursorPosition(xValue, yValue + + 10);
            Console.WriteLine("           '~---~'");
            Console.WriteLine();
            Console.WriteLine("Click enter to Return to the menu");
            Console.ReadLine();
            Console.Clear();
        }

        public static void Garfield(int xValue, int yValue) 
        {
            Console.SetCursorPosition(xValue, yValue);
            Console.WriteLine("  |\\|\\");
            Console.SetCursorPosition(xValue, yValue + 1);
            Console.WriteLine(">/ ( )=<");
            Console.SetCursorPosition(xValue, yValue+2);
            Console.WriteLine("|`'o' ==");
            Console.SetCursorPosition(xValue, yValue+3);
            Console.WriteLine(" \\(^) =/");
            Console.SetCursorPosition(xValue, yValue+4);
            Console.WriteLine("  `< =\"");
            Console.SetCursorPosition(xValue, yValue+5);
            Console.WriteLine("  /  ||\"");
            Console.SetCursorPosition(xValue, yValue+6);
            Console.WriteLine(" (   /)=\"");
            Console.SetCursorPosition(xValue, yValue+7);
            Console.WriteLine("  \\ (,3=\"");
            Console.SetCursorPosition(xValue, yValue+8);
            Console.WriteLine("   `++||==");
            Console.SetCursorPosition(xValue, yValue+9);
            Console.WriteLine("  __||||`==.");
            Console.SetCursorPosition(xValue, yValue+10);
            Console.WriteLine(" (,(,___\\ \"==)");
            Console.WriteLine("");
            Console.WriteLine("Click enter to Return to the menu");
            Console.ReadLine();
            Console.Clear();
        }

        public static void Joke()
        {
            Console.WriteLine("Click enter to interact with the joke!");
            Console.WriteLine("Joker: Knock Knock");
            Console.ReadLine();
            Console.WriteLine("You: Who's There?");
            Console.WriteLine("Joker: Brighton.");
            Console.ReadLine();
            Console.WriteLine("You: Brighton Who?");
            Console.WriteLine("Joker: Brighton early, that's when I wake up.");
            Console.ReadLine();
            Console.WriteLine("You: Hahahahha");
            Console.WriteLine();
            Console.WriteLine("Click enter to return to menu.");
            Console.ReadLine();
            Console.Clear();
        }

    }
}
