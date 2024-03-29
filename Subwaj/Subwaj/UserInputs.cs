﻿using System;
using System.Threading;

namespace Subwaj
{
    
    class UserInputs
    {
       
        public static void Nothing()
        {
            Console.Clear();
            Program.SpeakFile("Halls/nothing.txt");
            Thread.Sleep(1000);
            Console.Clear();
            BackToCurrentRoom();
        }
        public static void Hall14Text()
        {
            Console.Clear();
            Program.SpeakFile("Halls/Hall14/Hall14.txt");
            Thread.Sleep(13000);
            Console.Clear();
            BackToCurrentRoom();
        }
        public static bool FirstRun = true;
        //Checks UserInput
        public static void UserInput()
        {
            Program.DrawBottom();
            Console.SetCursorPosition(Console.CursorLeft, 28);
            Program.Cki = Console.ReadKey();
            string strCki = Program.Cki.Key.ToString();
            switch (Program.CurrentRoom)
            {
                case "MainMenu":
                    {
                        switch (strCki)
                        {
                            case "NumPad1":
                            case "D1":
                                {
                                    if (FirstRun)
                                    {
                                        FirstRun = false;
                                        Program.MainMenuStart();
                                    }
                                    else
                                    {
                                        BackToCurrentRoom();
                                    }
                                    break;
                                }

                            case "NumPad2":
                            case "D2":
                                {
                                    Program.MainMenuHelp();
                                    break;
                                }

                            case "NumPad3":
                            case "D3":
                                {
                                    Program.MainMenuOptions();
                                    break;
                                }

                            case "NumPad4":
                            case "D4":
                                {
                                    Program.MainMenuCode();
                                    break;
                                }

                            case "NumPad5":
                            case "D5":
                                {
                                    BackToCurrentRoom();
                                    break;
                                }
                            case "NumPad6":
                            case "D6":
                                {
                                    Program.MainMenuDlc();
                                    break;
                                }
                            case "NumPad0":
                            case "D0":
                                {
                                    Program.MainMenuExit();
                                    break;
                                }

                            default:
                                {
                                    Program.MainMenu();
                                    break;
                                }

                            case "Oem3":
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("ControlKeyInfo output DebugMode");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.ForegroundColor = ConsoleColor.White;
                                    do
                                    {

                                        Program.Cki = Console.ReadKey();
                                        strCki = Program.Cki.Key.ToString();
                                        Console.WriteLine("");
                                        Console.WriteLine("OUTPUT:" + strCki);
                                    } while (true);
                                }

                        }
                        break;
                    }
                case "InGameMenu":
                    {
                        switch (strCki)
                        {
                            case "Escape":
                            case "D1":
                            case "NumPad1":
                                {
                                    //escape gaat terug naar de room
                                    Program.CurrentRoom = Program.InGameMenuTempRoom;
                                    Program.InGameMenuTempRoom = string.Empty;
                                    BackToCurrentRoom();
                                    break;
                                }
                            case "D2":
                            case "NumPad2":
                                {
                                    Program.InGameMap();
                                    break;
                                }
                            case "D3":
                            case "NumPad3":
                                {
                                    Program.MainMenuHelp();
                                    break;
                                }
                            case "D4":
                            case "NumPad4":
                                {
                                    Program.MainMenuOptions();
                                    break;
                                }
                            case "D5":
                            case "NumPad5":
                                {
                                    Program.MainMenu();
                                    break;
                                }
                            case "D6":
                            case "NumPad6":
                            {
                                Program.MainMenuCode();
                                break;
                            }
                            case "D0":
                            case "NumPad0":
                                {
                                    Program.MainMenuExit();
                                    break;
                                }
                            default:
                                {
                                    UserInput();
                                    break;
                                }
                        }
                        break;
                    }
                case "SHOP":
                    {
                        switch (strCki)
                        {
                            case "Escape":
                                {
                                    Program.InGameMenu();
                                    break;
                                }
                            case "NumPad0":
                            case "D0":
                            {

                                Program.BlnShopStory = false;
                                BackToCurrentRoom();
                                break;
                            }
                            case "D1":
                            case "NumPad1":
                                {
                                    if (!Program.Sword)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Congratulations you found a Fancy sword.");
                                        Program.Sword = true;
                                        Thread.Sleep(1000);
                                        Program.SpeakFile("Rooms/Shop/Shop2.txt");
                                        Thread.Sleep(1000);
                                        Console.Clear();

                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You already own a sword");
                                        Thread.Sleep(1000);
                                    }
                                    BackToCurrentRoom();
                                    break;
                                }
                            case "D2":
                            case "NumPad2":
                                {
                                    Program.Hall3();
                                    break;
                                }
                            default:
                                {
                                    UserInput();
                                    break;
                                }
                        }
                        break;
                    }
                case "ROOM1":
                    {
                        switch (strCki)
                        {
                            case "Escape":
                                {
                                    Program.InGameMenu();
                                    break;
                                }
                            case "NumPad0":
                            case "D0":
                                {

                                    Program.BlnRoom1Story = false;
                                    BackToCurrentRoom();
                                    break;
                                }
                            case "NumPad1":
                            case "D1":
                                {
                                    Program.Hall1();
                                    break;
                                }
                            case "NumPad2":
                            case "D2":
                                {
                                    Program.Wallrun();
                                    break;
                                }
                            case "NumPad3":
                            case "D3":
                                {
                                    Console.Clear();
                                    Console.WriteLine("Note This");
                                    Program.WallPosition(Puzzle3.Room1.ToString());
                                    break;
                                }
                            case "NumPad4":
                            case "D4":
                                {
                                Nothing();
                                break;
                                }
                            default:
                                {
                                    BackToCurrentRoom();
                                    break;
                                }
                        }
                        break;
                    }
                case "ROOM2":
                    {
                        switch (strCki)
                        {
                            case "Escape":
                                {
                                    Program.InGameMenu();
                                    break;
                                }
                            case "NumPad1":
                            case "D1":
                                if (Program.BlnPuzzle1Complete == false)
                                {
                                    Console.Clear();
                                    Console.WriteLine("You must finish the puzzle first.");
                                    Thread.Sleep(1000);
                                }
                                else
                                {
                                    Program.Hall2();
                                }
                                break;
                    
                            case "NumPad2":
                            case "D2":
                                {
                                    Program.Hall1();
                                    break;
                                }
                            case "NumPad3":
                            case "D3":
                                {
                                    Console.Clear();
                                    Console.WriteLine("Note This");
                                    Program.WallPosition(Puzzle3.Room2.ToString());
                                    break;
                                }
                            case "NumPad4":
                            case "D4":
                                {
                                    Nothing();
                                    break;
                                }
                            case "NumPad5":
                            case "D5":
                            {
                                if (Program.BlnPuzzle1Complete == false)
                                {
                                    Puzzle1.StartPuzzle1();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("You already completed this puzzle");
                                    Thread.Sleep(1000);
                                }
                                    break;
                                }
                            default:
                                {
                                    BackToCurrentRoom();
                                    break;
                                }
                        }
                        break;
                    }
                case "ROOM3":
                    {
                        switch (strCki)
                        {
                            case "Escape":
                                {
                                    Program.InGameMenu();
                                    break;
                                }
                            case "NumPad1":
                            case "D1":
                                if (!Program.BlnPuzzle2Complete)
                                {
                                    Console.Clear();
                                    Console.WriteLine("You must finish the puzzle first.");
                                    Thread.Sleep(1000);
                                }
                                else
                                {
                                    Program.Hall4();
                                }
                                break;
                            case "NumPad2":
                            case "D2":
                                {
                                    Program.Hall2();
                                    break;
                                }
                            case "NumPad3":
                            case "D3":
                                {
                                    Console.Clear();
                                    Console.WriteLine("Note This");
                                    Program.WallPosition(Puzzle3.Room3.ToString());
                                    break;
                                }
                            case "NumPad4":
                            case "D4":
                                {
                                    Nothing();
                                    break;
                                }
                            case "NumPad5":
                            case "D5":
                                {
                                    if (!Program.BlnPuzzle2Complete)
                                    {
                                        Puzzle2.StartPuzzle2();
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You already completed this puzzle");
                                        Thread.Sleep(1000);
                                    }
                                    break;
                                }
                            case "NumPad6":
                            case "D6":
                            {
                                if (!Program.BlnPuzzle2Complete)
                                {
                                    Console.Clear();
                                    Console.WriteLine("You must finish the puzzle first.");
                                    Thread.Sleep(1000);
                                }
                                else
                                {
                                    Program.Hall3();
                                }
                                break;
                            }
                            default:
                                {
                                    BackToCurrentRoom();
                                    break;
                                }
                        }
                        break;
                    }
                case "ROOM4":
                    {
                        switch (strCki)
                        {
                            case "Escape":
                                {
                                    Program.InGameMenu();
                                    break;
                                }
                            case "NumPad0":
                            case "D0":
                                {

                                    Program.BlnRoom4Story = false;
                                    BackToCurrentRoom();
                                    break;
                                }
                            case "NumPad1":
                            case "D1":
                                {
                                    Program.Hall6();
                                    break;
                                }
                            case "NumPad2":
                            case "D2":
                                {
                                    Program.Hall5();
                                    break;
                                }
                            case "NumPad3":
                            case "D3":
                                {
                                    Console.Clear();
                                    Console.WriteLine("Note This");
                                    Program.WallPosition(Puzzle3.Room4.ToString());
                                    break;
                                }
                            case "NumPad4":
                            case "D4":
                                {
                                    Nothing();
                                    break;
                                }
                            default:
                                {
                                    BackToCurrentRoom();
                                    break;
                                }
                        }
                        break;
                    }
                case "ROOM5":
                    {
                        switch (strCki)
                        {
                            case "Escape":
                                {
                                    Program.InGameMenu();
                                    break;
                                }
                            case "NumPad1":
                            case "D1":
                                if (Program.BlnPuzzle3Complete == false)
                                {
                                    Console.Clear();
                                    Console.WriteLine("You must finish the puzzle first.");
                                    Thread.Sleep(1000);
                                }
                                else
                                {
                                    Program.Hall7();
                                }
                                break;
                            case "NumPad2":
                            case "D2":
                                {
                                    Program.Hall6();
                                    break;
                                }
                            case "NumPad3":
                            case "D3":
                                {
                                    Program.WallPosition("");
                                    break;
                                }
                            case "NumPad4":
                            case "D4":
                                {
                                    Nothing();
                                    break;
                                }
                            case "NumPad5":
                            case "D5":
                                {
                                    if (Program.BlnPuzzle3Complete == false)
                                    {
                                        Puzzle3.StartPuzzle3();
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You already completed this puzzle");
                                        Thread.Sleep(1000);
                                    }
                                    break;
                                }
                            default:
                                {
                                    BackToCurrentRoom();
                                    break;
                                }
                        }
                        break;
                    }
                case "ROOM6":
                    {
                        switch (strCki)
                        {
                            case "Escape":
                                {
                                    Program.InGameMenu();
                                    break;
                                }
                            case "NumPad1":
                            case "D1":
                                if (Program.BlnPuzzle4Complete == false)
                                {
                                    Console.Clear();
                                    Console.WriteLine("You must finish the puzzle first.");
                                    Thread.Sleep(1000);
                                }
                                else
                                {
                                    Program.Hall13();
                                }
                                break;
                            case "NumPad2":
                            case "D2":
                                {
                                    Program.Hall12();
                                    break;
                                }
                            case "NumPad3":
                            case "D3":
                                {
                                    Program.WallPosition("");
                                    break;
                                }
                            case "NumPad4":
                            case "D4":
                                {
                                    Nothing();
                                    break;
                                }
                            case "NumPad5":
                            case "D5":
                                {
                                    if (Program.BlnPuzzle4Complete == false)
                                    {
                                        Puzzle4.StartPuzzle4();
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You already completed this puzzle");
                                        Thread.Sleep(1000);
                                    }
                                    break;
                                }
                            default:
                                {
                                    BackToCurrentRoom();
                                    break;
                                }
                        }
                        break;
                    }
                case "ROOM7":
                    {
                        switch (strCki)
                        {
                            case "Escape":
                                {
                                    Program.InGameMenu();
                                    break;
                                }
                            case "NumPad0":
                            case "D0":
                                {

                                    Program.BlnRoom7Story = false;
                                    BackToCurrentRoom();
                                    break;
                                }
                            case "D1":
                            case "NumPad1":
                                {
                                    // is tijdelijk
                                    if (Program.Sword)
                                    {
                                        Console.Clear();
                                        Program.SpeakFile("Rooms/Room7/KilledTheBoss.txt");
                                        Program.Credits();
                                        Thread.Sleep(3000);
                                        Environment.Exit(0);
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Program.SpeakFile("Rooms/Room7/ShopHint.txt");
                                        Thread.Sleep(2000);
                                        BackToCurrentRoom();
                                    }
                                    Console.ReadKey();
                                    Environment.Exit(0);
                                    break;
                                }
                            case "D2":
                            case "NumPad2":
                                {
                                    Program.Hall14();
                                    break;
                                }
                            default:
                                {
                                    BackToCurrentRoom();
                                    break;
                                }
                        }
                        break;
                    }
                case "HALL1":
                    {
                        switch (strCki)
                        {
                            case "Escape":
                            {
                                Program.InGameMenu();
                                break;
                            }

                            case "NumPad1":
                            case "D1":
                            {
                                Program.Room2();
                                break;
                            }
                            case "NumPad2":
                            case "D2":
                            {
                                Program.Room1();
                                break;
                            }
                            case "NumPad3":
                            case "D3":
                            {
                                Program.WallPosition("This is a Wall");
                                break;
                            }
                            default:
                            {
                                BackToCurrentRoom();
                                break;
                            }
                        }
                        break;
                    }
                case "HALL2":
                    {
                        switch (strCki)
                        {
                            case "Escape":
                            {
                                Program.InGameMenu();
                                break;
                            }
                            case "NumPad1":
                            case "D1":
                            {
                                Program.Room3();
                                break;
                            }
                            case "NumPad2":
                            case "D2":
                            {
                                Program.Room2();
                                break;
                            }
                            case "NumPad3":
                            case "D3":
                            {
                                Program.WallPosition("Nothing here!");
                                break;
                            }
                            default:
                            {
                                BackToCurrentRoom();
                                break;
                            }
                        }
                        break;
                    }
                case "HALL3":
                    {
                        switch (strCki)
                        {
                            case "Escape":
                            {
                                Program.InGameMenu();
                                break;
                            }
                            case "NumPad1":
                                case "D1":
                                {
                                    if (!Program.BlnShop)
                                    {
                                        if (!Program.BlnBoss)
                                        {
                                            Console.Clear();
                                            Program.SpeakFile("Rooms/Shop/ShopClosed.txt");
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Program.SpeakFile("Rooms/Shop/ShopClosed2.0.txt");
                                        }
                                    }
                                    else
                                    {
                                        Program.Shop();
                                    }
                                    break;

                                }
                            case "NumPad2":
                            case "D2":
                            {
                                Program.Room3();
                                break;
                            }
                            case "NumPad3":
                            case "D3":
                            {
                                Program.WallPosition("Another wall");
                                break;
                            }
                            default:
                            {
                                BackToCurrentRoom();
                                break;
                            }
                        }
                        break;
                    }
                case "HALL4":
                    {
                        switch (strCki)
                        {
                            case "Escape":
                            {
                                Program.InGameMenu();
                                break;
                            }
                            case "NumPad1":
                            case "D1":
                            {
                                Program.Hall5();
                                break;
                            }
                            case "NumPad2":
                            case "D2":
                            {
                                Program.Room3();
                                break;
                            }
                            case "NumPad3":
                            case "D3":
                            {
                                Program.WallPosition("Go away!!!");
                                break;
                            }  
                            case "NumPad4":
                            case "D4":
                            {
                                    if (Program.IntKey == 1)
                                    {
                                        Program.Hall10();
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You need a key to open this door.");
                                        Thread.Sleep(1000);
                                    }
                                    break;
                                }
                            default:
                            {
                                BackToCurrentRoom();
                                break;
                            }
                        }
                        break;
                    }
                case "HALL5":
                    {
                        switch (strCki)
                        {
                            case "Escape":
                            {
                                Program.InGameMenu();
                                break;
                            }
                            case "NumPad1":
                            case "D1":
                            {
                                Program.Room4();
                                break;
                            }
                            case "NumPad2":
                            case "D2":
                            {
                                Program.Hall4();
                                break;
                            }
                            case "NumPad3":
                            case "D3":
                            {
                                Program.WallPosition("Hello???");
                                break;
                            }
                            case "NumPad4":
                            case "D4":
                            {
                                Program.Hall11();
                                break;
                            }
                            case "NumPad5":
                            case "D5":
                            {
                                    if (Program.IntKey == 1)
                                    {
                                        Program.Hall8();
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You need a key to open this door.");
                                        Thread.Sleep(1000);
                                    }
                                    break;
                            }
                            default:
                            {
                                BackToCurrentRoom();
                                break;
                            }
                        }
                        break;
                    }
                case "HALL6":
                    {
                        switch (strCki)
                        {
                            case "Escape":
                            {
                                Program.InGameMenu();
                                break;
                            }
                            case "NumPad1":
                            case "D1":
                            {
                                Program.Room5();
                                break;
                            }
                            case "NumPad2":
                            case "D2":
                            {
                                Program.Room4();
                                break;
                            }
                            case "NumPad3":
                            case "D3":
                            {
                                Program.WallPosition("Ah, there you are");
                                break;
                            }
                            default:
                            {
                                BackToCurrentRoom();
                                break;
                            }
                        }
                        break;
                    }
                case "HALL7":
                    {
                        switch (strCki)
                        {
                            case "Escape":
                            {
                                Program.InGameMenu();
                                break;
                            }
                            case "NumPad1":
                            case "D1":
                            {
                                Program.Hall8();
                                break;
                            }
                            case "NumPad2":
                            case "D2":
                            {
                                Program.Room5();
                                break;
                            }
                            case "NumPad3":
                            case "D3":
                            {
                                Program.WallPosition("Something was here");
                                break;
                            }
                            default:
                            {
                                BackToCurrentRoom();
                                break;
                            }
                        }
                        break;
                    }
                case "HALL8":
                    {
                        switch (strCki)
                        {
                            case "Escape":
                                {
                                    Program.InGameMenu();
                                    break;
                                }
                            case "NumPad1":
                            case "D1":
                                {
                                    Program.Hall12();
                                    break;
                                }
                            case "NumPad2":
                            case "D2":
                                {
                                    Program.Hall7();
                                    break;
                                }
                            case "NumPad3":
                            case "D3":
                                {
                                    Program.WallPosition("Chicken!!! :)");
                                    break;
                                }
                            case "NumPad4":
                            case "D4":
                                {
                                    Program.Hall9();
                                    break;
                                }
                            case "NumPad5":
                            case "D5":
                                {
                                    Program.Hall5();
                                    break;
                                }
                            default:
                                {
                                    BackToCurrentRoom();
                                    break;
                                }
                        }
                        break;
                    }
                case "HALL9":
                    {
                        switch (strCki)
                        {
                            case "Escape":
                            {
                                Program.InGameMenu();
                                break;
                            }
                            case "NumPad1":
                            case "D1":
                            {
                                Program.Hall10();
                                break;
                            }
                            case "NumPad2":
                            case "D2":
                            {
                                Program.Hall8();
                                break;
                            }
                            case "NumPad3":
                            case "D3":
                            {
                                Program.WallPosition("HAHA, I'm gonna win");
                                break;
                            }
                            default:
                            {
                                BackToCurrentRoom();
                                break;
                            }
                        }
                        break;
                    }
                case "HALL10":
                    {
                        switch (strCki)
                        {
                            case "Escape":
                            {
                                Program.InGameMenu();
                                break;
                            }
                            case "NumPad1":
                            case "D1":
                            {
                                Program.Hall4();
                                break;
                            }
                            case "NumPad2":
                            case "D2":
                            {
                                Program.Hall9();
                                break;
                            }
                            case "NumPad3":
                            case "D3":
                            {
                                Program.WallPosition("Good luck");
                                break;
                            }
                            default:
                            {
                                BackToCurrentRoom();
                                break;
                            }
                        }
                        break;
                    }
                case "HALL11":
                    {
                        switch (strCki)
                        {
                            case "Escape":
                            {
                                Program.InGameMenu();
                                break;
                            }
                            case "NumPad1":
                            case "D1":
                            {
                                Program.Wallrun();
                                break;
                            }
                            case "NumPad2":
                            case "D2":
                            {
                                Program.Hall5();
                                break;
                            }
                            case "NumPad3":
                            case "D3":
                            {
                                Program.WallPosition("Hey, watch it!!!");
                                break;
                            }
                            default:
                            {
                                BackToCurrentRoom();
                                break;
                            }
                        }
                        break;
                    }
                case "HALL12":
                    {
                        switch (strCki)
                        {
                            case "Escape":
                            {
                                Program.InGameMenu();
                                break;
                            }
                            case "NumPad1":
                            case "D1":
                            {
                                Program.Room6();
                                break;
                            }
                            case "NumPad2":
                            case "D2":
                            {
                                Program.Hall8();
                                break;
                            }
                            case "NumPad3":
                            case "D3":
                            {
                                Program.WallPosition("Still not a game!");
                                break;
                            }
                            default:
                            {
                                BackToCurrentRoom();
                                break;
                            }
                        }
                        break;
                    }
                case "HALL13":
                    {
                        switch (strCki)
                        {
                            case "Escape":
                            {
                                Program.InGameMenu();
                                break;
                            }
                            case "NumPad0":
                            case "D0":
                                {

                                    Program.BlnHall13Story = false;
                                    BackToCurrentRoom();
                                    break;
                                }
                            case "NumPad1":
                            case "D1":
                            {
                                Program.Hall14();
                                break;
                            }
                            case "NumPad2":
                            case "D2":
                            {
                                Program.Room6();
                                break;
                            }
                            case "NumPad3":
                            case "D3":
                            {
                                Program.WallPosition("nice wall");
                                break;
                            }
                            case "NumPad4":
                            case "D4":
                            {
                                Program.Wallrun();
                                break;
                            }
                            default:
                            {
                                BackToCurrentRoom();
                                break;
                            }
                        }
                        break;
                    }
                case "HALL14":
                    {
                        switch (strCki)
                        {
                            case "Escape":
                            {
                                Program.InGameMenu();
                                break;
                            }
                            case "NumPad0":
                            case "D0":
                                {

                                    Program.BlnHall14Story = false;
                                    BackToCurrentRoom();
                                    break;
                                }
                            case "NumPad1":
                            case "D1":
                            {
                                    if (Program.BlnBoss)
                                    {
                                       
                                        Program.Room7();
                                    }
                                    else
                                    {
                                        Hall14Text();
                                    }
                                    break;
                            }
                            case "NumPad2":
                            case "D2":
                            {
                                Program.Hall13();
                                break;
                            }
                            case "NumPad3":
                            case "D3":
                            {
                                 Program.WallPosition("Just quit already");
                                 break;
                            }
                            default:
                            {
                                BackToCurrentRoom();
                                break;
                            }
                        }
                        break;
                    }
                default:
                    {
                        Errors.ErrorHandlerStart();
                        Console.WriteLine("ERROR: ROOM NOT KNOWN");
                        Console.WriteLine("ERROR ID:0001");
                        Errors.ErrorFinisher();
                        break;
                    }
            }
            BackToCurrentRoom();
        }

        //Back to current room
        public static void BackToCurrentRoom()
        {
            if (Program.CurrentRoom == Program.StrMainMenu)
            {
                Program.CurrentRoom = Program.InGameMenuTempRoom;
            }
            switch (Program.CurrentRoom)
            {
                case "ROOM1":
                    {
                        Program.Room1();
                        break;
                    }
                case "ROOM2":
                    {
                        Program.Room2();
                        break;
                    }
                case "ROOM3":
                    {
                        Program.Room3();
                        break;
                    }
                case "ROOM4":
                    {
                        Program.Room4();
                        break;
                    }
                case "ROOM5":
                    {
                        Program.Room5();
                        break;
                    }
                case "ROOM6":
                    {
                        Program.Room6();
                        break;
                    }
                case "ROOM7":
                    {
                        Program.Room7();
                        break;
                    }
                case "HALL1":
                    {
                        Program.Hall1();
                        break;
                    }
                case "HALL2":
                    {
                        Program.Hall2();
                        break;
                    }
                case "HALL3":
                    {
                        Program.Hall3();
                        break;
                    }
                case "HALL4":
                    {
                        Program.Hall4();
                        break;
                    }
                case "HALL5":
                    {
                        Program.Hall5();
                        break;
                    }
                case "HALL6":
                    {
                        Program.Hall6();
                        break;
                    }
                case "HALL7":
                    {
                        Program.Hall7();
                        break;
                    }
                case "HALL8":
                    {
                        Program.Hall8();
                        break;
                    }
                case "HALL9":
                    {
                        Program.Hall9();
                        break;
                    }
                case "HALL10":
                    {
                        Program.Hall10();
                        break;
                    }
                case "HALL11":
                    {
                        Program.Hall11();
                        break;
                    }
                case "HALL12":
                    {
                        Program.Hall12();
                        break;
                    }
                case "HALL13":
                    {
                        Program.Hall13();
                        break;
                    }
                case "HALL14":
                    {
                        Program.Hall14();
                        break;
                    }
                case "SHOP":
                    {
                        Program.Shop();
                        break;
                    }
                case "InGameMenu":
                    {
                        Program.InGameMenu();
                        break;
                    }
                case "MainMenu":
                    {
                        //moet value uit ingametemproom pakken.
                        Program.MainMenu();
                        break;
                    }
            }
        }

    }
}
