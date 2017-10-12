﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Subwaj
{

    class Program
    {

        //Here we will place the public static variables
        public static Random _randomforeground = new Random();  //Gets used for random foregroundcolor.
        public static ConsoleColor originalForegroundColor;     //Sets the old foreground to a variable to make sure it isn't the same.

        public static ConsoleKeyInfo cki; //uses cki to use readkey.

        //Rooms
        public static string CurrentRoom = "MainMenu"; //Makes sure the program knows in what room the user is.
        public static string InGameMenuTempRoom = string.Empty; //Makes a temporary room when you go to the ingame menu

        //BGM
        public static int intReadSong;
        public static int intReadDuration;
        public static int intSongCounter;
        public static string BGMFileTone = "Tone.txt";
        public static string BGMFolder = "BGM subwaj/";
        public static string BGMFileDuration = "Duration.txt";
        public static ThreadStart ts = new ThreadStart(BGM);
        public static Thread BGMThread = new Thread(ts);
        public static bool blnPlayMusic = true;

        //Puzzle complete bools
        public static bool blnPuzzle1Complete = false;
        public static bool blnPuzzle2Complete = false;
        public static bool blnPuzzle3Complete = false;
        public static bool blnPuzzle4Complete = false;

        //Makes it easier to change rooms
        public static string strMainMenu = "MainMenu";
        public static string strInGameMenu = "InGameMenu";
        public static string strROOM1 = "ROOM1";
        public static string strROOM2 = "ROOM2";
        public static string strROOM3 = "ROOM3";
        public static string strROOM4 = "ROOM4";
        public static string strROOM5 = "ROOM5";
        public static string strROOM6 = "ROOM6";
        public static string strROOM7 = "ROOM7";
        public static string strHALL1 = "HALL1";
        public static string strHALL2 = "HALL2";
        public static string strHALL3 = "HALL3";
        public static string strHALL4 = "HALL4";
        public static string strHALL5 = "HALL5";
        public static string strHALL6 = "HALL6";
        public static string strHALL7 = "HALL7";
        public static string strHALL8 = "HALL8";
        public static string strHALL9 = "HALL9";
        public static string strHALL10 = "HALL10";
        public static string strHALL11 = "HALL11";
        public static string strHALL12 = "HALL12";
        public static string strHALL13 = "HALL13";
        public static string strHALL14 = "HALL14";

        //HUD STUFF
        public static int intTimer = 3600;
        public static ThreadStart tsTimer = new ThreadStart(TimerFunction);
        public static Thread TimerThread = new Thread(tsTimer);
        public static int intCursorpositionLeft;
        public static int intCursorpositionTop;

        //TTS
        public static System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public static bool blnBGMCancel = false;

        //boolean's for code menu
        public static bool blnBoss = false;
        public static bool blnShop = false;

        static void Main(string[] args)
        {
            Console.Title = "NOT A GAME";
            //Loops the program
            do
            {
                Console.WriteLine("\t\t\t\tPlease turn on the volume for best user experience");
                Console.Beep(800, 200); //default beep settings
                Console.Beep(600, 200);
                Console.Beep(400, 200);
                Thread.Sleep(1000);
                BGMThread.Start();
                Program.MAINMENU();
            }
            while (true);
        }
        //Back to current room
        public static void BackToCurrentRoom()
        {
            switch (CurrentRoom)
            {
                case "ROOM1":
                    {
                        Program.ROOM1();
                        break;
                    }
                case "ROOM2":
                    {
                        Program.ROOM2();
                        break;
                    }
                case "ROOM3":
                    {
                        Program.ROOM3();
                        break;
                    }
                case "ROOM4":
                    {
                        Program.ROOM4();
                        break;
                    }
                case "ROOM5":
                    {
                        Program.ROOM5();
                        break;
                    }
                case "ROOM6":
                    {
                        Program.ROOM6();
                        break;
                    }
                case "ROOM7":
                    {
                        Program.ROOM7();
                        break;
                    }
                case "HALL1":
                    {
                        Program.HALL1();
                        break;
                    }
                case "HALL2":
                    {
                        Program.HALL2();
                        break;
                    }
                case "HALL3":
                    {
                        Program.HALL3();
                        break;
                    }
                case "HALL4":
                    {
                        Program.HALL4();
                        break;
                    }
                case "HALL5":
                    {
                        Program.HALL5();
                        break;
                    }
                case "HALL6":
                    {
                        Program.HALL6();
                        break;
                    }
                case "HALL7":
                    {
                        Program.HALL7();
                        break;
                    }
                case "HALL8":
                    {
                        Program.HALL8();
                        break;
                    }
                case "HALL9":
                    {
                        Program.HALL9();
                        break;
                    }
                case "HALL10":
                    {
                        Program.HALL10();
                        break;
                    }
                case "HALL11":
                    {
                        Program.HALL11();
                        break;
                    }
                case "HALL12":
                    {
                        Program.HALL12();
                        break;
                    }
                case "HALL13":
                    {
                        Program.HALL13();
                        break;
                    }
                case "HALL14":
                    {
                        Program.HALL14();
                        break;
                    }
            }
        }

        //Checks UserInput
        public static void UserInput()
        {
            Program.cki = Console.ReadKey();
            string strCKI = cki.Key.ToString();
            switch (CurrentRoom)
            {
                case "MainMenu":
                    {
                        switch (strCKI)
                        {
                            case "NumPad1":
                            case "D1":
                                {
                                    Program.MainMenuStart();
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
                                    Program.MainMenuAchievements();
                                    break;
                                }

                            case "NumPad6":
                            case "D6":
                                {
                                    Program.MainMenuLoadSaveGame();
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
                                    Program.MAINMENU();
                                    break;
                                }

                            case "Oem3":
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("ControlKeyInfo output debug");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.ForegroundColor = ConsoleColor.White;
                                    do
                                    {

                                        cki = Console.ReadKey();
                                        strCKI = cki.Key.ToString();
                                        Console.WriteLine("");
                                        Console.WriteLine("OUTPUT:" + strCKI);
                                    } while (true);
                                }

                        }
                        break;
                    }
                case "InGameMenu":
                    {
                        switch (strCKI)
                        {
                            case "Escape":
                            case "D1":
                            case "NumPad1":
                                {
                                    //escape gaat terug naar de room
                                    CurrentRoom = InGameMenuTempRoom;
                                    InGameMenuTempRoom = string.Empty;
                                    Program.BackToCurrentRoom();
                                    break;
                                }
                            case "D2":
                            case "NumPad2":
                                {
                                    Program.MainMenuHelp();
                                    break;
                                }
                            case "D3":
                            case "NumPad3":
                                {
                                    Program.MainMenuOptions();
                                    break;
                                }
                            case "D4":
                            case "NumPad4":
                                {
                                    //achievment options
                                    Program.ErrorNotYetCreated();
                                    break;
                                }
                            case "D5":
                            case "NumPad5":
                                {
                                    //save game option
                                    Program.ErrorNotYetCreated();
                                    break;
                                }
                            case "D6":
                            case "NumPad6":
                                {
                                    Program.MAINMENU();
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
                                 
                                    break;
                                }
                        }
                        break;
                    }
                case "ROOM1":
                    {
                        switch (strCKI)
                        {
                            case "Escape":
                                {
                                    Program.InGameMenu();
                                    break;
                                }
                            default:
                                {
                                    Program.HALL1();
                                    break;
                                }
                        }
                        break;
                    }
                case "ROOM2":
                    {
                        switch (strCKI)
                        {
                            default:
                                {
                                    break;
                                }
                        }
                        break;
                    }
                case "ROOM3":
                    {
                        switch (strCKI)
                        {
                            default:
                                {
                                    break;
                                }
                        }
                        break;
                    }
                case "ROOM4":
                    {
                        switch (strCKI)
                        {
                            default:
                                {
                                    break;
                                }
                        }
                        break;
                    }
                case "ROOM5":
                    {
                        switch (strCKI)
                        {
                            default:
                                {
                                    break;
                                }
                        }
                        break;
                    }
                case "ROOM6":
                    {
                        switch (strCKI)
                        {
                            default:
                                {
                                    break;
                                }
                        }
                        break;
                    }
                case "ROOM7":
                    {
                        switch (strCKI)
                        {
                            default:
                                {
                                    break;
                                }
                        }
                        break;
                    }
                case "HALL1":
                    {
                        switch (strCKI)
                        {
                            default:
                                {
                                    break;
                                }
                        }
                        break;
                    }
                case "HALL2":
                    {
                        switch (strCKI)
                        {
                            default:
                                {
                                    break;
                                }
                        }
                        break;
                    }
                case "HALL3":
                    {
                        switch (strCKI)
                        {
                            default:
                                {
                                    break;
                                }
                        }
                        break;
                    }
                case "HALL4":
                    {
                        switch (strCKI)
                        {
                            default:
                                {
                                    break;
                                }
                        }
                        break;
                    }
                case "HALL5":
                    {
                        switch (strCKI)
                        {
                            default:
                                {
                                    break;
                                }
                        }
                        break;
                    }
                case "HALL6":
                    {
                        switch (strCKI)
                        {
                            default:
                                {
                                    break;
                                }
                        }
                        break;
                    }
                case "HALL7":
                    {
                        switch (strCKI)
                        {
                            default:
                                {
                                    break;
                                }
                        }
                        break;
                    }
                case "HALL8":
                    {
                        switch (strCKI)
                        {
                            default:
                                {
                                    break;
                                }
                        }
                        break;
                    }
                case "HALL9":
                    {
                        switch (strCKI)
                        {
                            default:
                                {
                                    break;
                                }
                        }
                        break;
                    }
                case "HALL10":
                    {
                        switch (strCKI)
                        {
                            default:
                                {
                                    break;
                                }
                        }
                        break;
                    }
                case "HALL11":
                    {
                        switch (strCKI)
                        {
                            default:
                                {
                                    break;
                                }
                        }
                        break;
                    }
                case "HALL12":
                    {
                        switch (strCKI)
                        {
                            default:
                                {
                                    break;
                                }
                        }
                        break;
                    }
                case "HALL13":
                    {
                        switch (strCKI)
                        {
                            default:
                                {
                                    break;
                                }
                        }
                        break;
                    }
                case "HALL14":
                    {
                        switch (strCKI)
                        {
                            default:
                                {
                                    break;
                                }
                        }
                        break;
                    }
                default:
                    {
                        Program.ErrorHandlerStart();
                        Console.WriteLine("ERROR: ROOM NOT KNOWN");
                        Console.WriteLine("ERROR ID:0001");
                        Program.ErrorFinisher();
                        break;
                    }
            }
            Program.ErrorHandlerStart();
            Console.WriteLine("ERROR: OUT OF ROOM EXCEPTION");
            Console.WriteLine("ERROR ID: 0002");
            Program.ErrorFinisher();
        }

        // BEGIN OF MAINMENU
        public static void MAINMENU()
        {
            Console.Clear();
            //Loops the main menu.
            do
            {
                CurrentRoom = strMainMenu;

                //makes the text a random color and prevents the foregroundcolor to be the same as the backgroundcolor.
                
                Program.GetRandomConsoleColor();

                Console.Clear();
                string strFilenamee = "files/menu/mainmenu.txt";
                Console.WriteLine(File.ReadAllText(strFilenamee));
                Console.ForegroundColor = ConsoleColor.White;
                Program.UserInput();

            } while (true);
        }
        public static void MainMenuStart()
        {
            Console.Clear();
            //story
            string strUserStart;
            bool blnLoopQuestion = true;
            blnBGMCancel = true;
            player.SoundLocation = "files/story/TTS/Intro/intro1.wav";
            player.Play();

            string strIntroTextName = "Ah, you're Finally here: " + Environment.UserName + "!\r\n";
            for (int x = 0; x < strIntroTextName.Length; x++)
            {
                Console.Write(strIntroTextName[x]);
                if (strIntroTextName[x] == ',' || strIntroTextName[x] == ':')
                {
                    Thread.Sleep(4); //400
                }
                Thread.Sleep(4); //40

            }
            string strFilename = "files/story/intro/intro.txt";

            int intIntroTTS = 1; //Used to count the file

            string[] IntroText = File.ReadAllLines(strFilename);
            for (int i = 0; i < IntroText.Length; i++)
            {

                //Makes the TTS speak when int i is on 1, 3, 5, 7, 9, 11, 13 This way, it will speak at the same way as the text appears on the screen.
                //The location of the TTS changes  based on intIntroTTS
                if (i == 1 || i == 3 || i == 5 || i == 7 || i == 9 || i == 11 || i == 13)
                {
                    intIntroTTS += 1;
                    player.SoundLocation = "files/story/TTS/Intro/intro" + intIntroTTS + ".wav";
                    player.Play();
                }


                string strIntroText = IntroText[i];
                for (int x = 0; x < strIntroText.Length; x++)
                {
                    Console.Write(strIntroText[x]);
                    if (strIntroText[x] == ',')
                    {
                        Thread.Sleep(4); //400
                    }
                    Thread.Sleep(4); //40

                    //This had to be added to make line 8 of the text file (byte 7) in sync with the audio. Because the audio would else be interrupted.
                    if (i == 7 && x == 47) 
                    {
                        Thread.Sleep(6); //600
                    }
                }
                Console.Write("\r\n");
                Thread.Sleep(4); //400

            }
            Console.WriteLine("\r\n");
            do
            {
                strUserStart = Console.ReadLine().ToLower();
                if (strUserStart == "start" || strUserStart == "exit")
                {
                    blnLoopQuestion = false;
                }
            } while (blnLoopQuestion == true);

            if (strUserStart == "start")
            {
                Program.ROOM1();
            }
            else
            {
                Console.Clear();
                strFilename = "files/story/intro/exit.txt";
                IntroText = File.ReadAllLines(strFilename);
                for (int i = 0; i < IntroText.Length; i++)
                {
                    string strIntroText = IntroText[i];
                    for (int x = 0; x < strIntroText.Length; x++)
                    {
                        Console.Write(strIntroText[x]);
                        if (strIntroText[x] == ',')
                        {
                            Thread.Sleep(400);
                        }
                        Thread.Sleep(40);

                    }
                    Console.Write("\r\n");
                    Thread.Sleep(400);

                }
                Thread.Sleep(3000);
                Environment.Exit(0);
            }
        }
        public static void MainMenuHelp()
        {

            do
            {
                Console.Clear();
                GetRandomConsoleColor();
                string strFilename = "files/help.txt";
                Console.WriteLine(File.ReadAllText(strFilename));
                Console.ForegroundColor = ConsoleColor.White;
                cki = Console.ReadKey();
                string strCKI = cki.Key.ToString();
                switch (strCKI)
                {
                    case "Enter":
                    case "Escape":
                        {
                            if (CurrentRoom == strMainMenu)
                            {
                                Program.MAINMENU();
                            }
                            else if (CurrentRoom == strInGameMenu)
                            {
                                Program.InGameMenu();
                            }
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            while (true);
        }
        public static void MainMenuOptions()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Press Esc to go back to Main Menu\r\n");
                Console.WriteLine("1.)\tToggle BGM(BackGroundMusic)");
                cki = Console.ReadKey();
                string strCKI = cki.Key.ToString();
                switch (strCKI)
                {
                    case "NumPad1":
                    case "D1":
                        {
                            if (blnPlayMusic == true)
                            {
                                blnPlayMusic = false;
                            }
                            else
                            {
                                blnPlayMusic = true;
                            }
                            break;
                        }
                    case "Escape":
                        {
                            Program.MAINMENU();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            while (true);
        }
        public static void MainMenuCode()
        {

            int intCode = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Press Enter to go back to Main Menu");
                while (intCode == 0)
                {
                    string strAnswer = Console.ReadLine();
                    if (strAnswer == "boss" || strAnswer == "BOSS" || strAnswer == "Boss")
                    {
                        blnBoss = true;
                        string strFilename = "files/mainmenucodes/BossEnabled.txt";
                        Console.WriteLine(File.ReadAllText(strFilename));
                        Thread.Sleep(1000);
                        Console.Clear();
                        Program.MAINMENU();
                    }
                    else if (strAnswer == "shop" || strAnswer == "SHOP" || strAnswer == "Shop")
                    {
                        blnShop = true;
                        string strFilename = "files/mainmenucodes/ShopEnabled.txt";
                        Console.WriteLine(File.ReadAllText(strFilename));
                        Thread.Sleep(1000);
                        Console.Clear();
                        Program.MAINMENU();
                    }
                    else if (strAnswer == "konami" || strAnswer == "KONAMI" || strAnswer == "Konami")
                    {
                        intCode = 1;
                    }
                    else
                    {
                        Program.MAINMENU();
                    }
                }
                while (intCode == 0) ;
                int Konamicode = 0;
                Console.Clear();
                Console.WriteLine("Please enter the Konami Code (START = ENTER)");
                do
                {
                    cki = Console.ReadKey();
                    string strCKI = cki.Key.ToString();
                    switch (strCKI)
                    {
                        case "UpArrow":
                            {
                                if (Konamicode == 0 || Konamicode == 1)
                                {
                                    Konamicode += 1;
                                }
                                else
                                {
                                    Konamicode = 0;
                                }
                                break;
                            }
                        case "DownArrow":
                            {
                                if (Konamicode == 2 || Konamicode == 3)
                                {
                                    Konamicode += 1;
                                }
                                else
                                {
                                    Konamicode = 0;
                                }
                                break;
                            }
                        case "LeftArrow":
                            {
                                if (Konamicode == 4 || Konamicode == 6)
                                {
                                    Konamicode += 1;
                                }
                                else
                                {
                                    Konamicode = 0;
                                }
                                break;
                            }
                        case "RightArrow":
                            {
                                if (Konamicode == 5 || Konamicode == 7)
                                {
                                    Konamicode += 1;
                                }
                                else
                                {
                                    Konamicode = 0;
                                }
                                break;
                            }
                        case "B":
                            {
                                if (Konamicode == 8)
                                {
                                    Konamicode += 1;
                                }
                                else
                                {
                                    Konamicode = 0;
                                }
                                break;
                            }
                        case "A":
                            {
                                if (Konamicode == 9)
                                {
                                    Konamicode += 1;
                                }
                                else
                                {
                                    Konamicode = 0;
                                }
                                break;
                            }
                        case "Enter":
                            {
                                if (Konamicode == 10)
                                {
                                    string strFilename = "files/Achievements/Konami.txt";
                                    Console.WriteLine(File.ReadAllText(strFilename));
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    Program.MAINMENU();
                                }
                                else
                                {
                                    Konamicode = 0;
                                }
                                break;
                            }
                        case "Escape":
                            {
                                Program.MAINMENU();
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                } while (true);
            }
            while (true);

        }
        public static void MainMenuAchievements()
        {
            Program.ErrorNotYetCreated();
        }
        public static void MainMenuLoadSaveGame()
        {
            Program.ErrorNotYetCreated();
        }
        public static void MainMenuExit()
        {
            Environment.Exit(0);
        }
        //END OF MAINMENU

        //BEGIN OF InGameMenu
        public static void InGameMenu()
        {
            InGameMenuTempRoom = CurrentRoom;
            CurrentRoom = strInGameMenu;
            Console.Clear();
            GetRandomConsoleColor();
            string strFilename = "files/menu/ingamenu.txt";
            Console.WriteLine(File.ReadAllText(strFilename));
            Program.UserInput();
            Console.ForegroundColor = ConsoleColor.White;

        }
        //END OF InGameMenu

        //BEGIN OF HUD
        public static void HUD()
        {
            if (CurrentRoom != strMainMenu && CurrentRoom != strInGameMenu)
            {
                Console.SetCursorPosition(Console.CursorLeft = 30, Console.CursorTop = 0);
                Console.WriteLine("║\tTIME:\t{0}\tCurrent location:   {1}\t╠═╦╗:\t0\t║", intTimer, CurrentRoom);
                Console.SetCursorPosition(Console.CursorLeft = 30, Console.CursorTop = 1);
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════╝");
            }
        }

        public static void TimerFunction()
        {
            while (intTimer > 0)
            {
                intTimer -= 1;
                    intCursorpositionLeft = Console.CursorLeft;
                    intCursorpositionTop = Console.CursorTop;
                    Program.HUD();
                    Console.SetCursorPosition(intCursorpositionLeft, intCursorpositionTop);
                Thread.Sleep(1000);
            }
            Program.GameOver();

        }
        //END OF HUD


        //BEGIN OF ROOMS
        public static void ROOM1()
        {

            CurrentRoom = strROOM1;
            Console.Clear();
            if (TimerThread.IsAlive == false)
            {
                TimerThread.Start();
            }
                //story
            blnBGMCancel = true;
            string strFilename = "files/story/Room1/Room1.txt";
            string[] IntroText = File.ReadAllLines(strFilename);
            for (int i = 0; i < IntroText.Length; i++)
            {
                string strIntroText = IntroText[i];
                for (int x = 0; x < strIntroText.Length; x++)
                {
                    Console.Write(strIntroText[x]);
                    if (strIntroText[x] == ',')
                    {
                        Thread.Sleep(4); //400
                    }
                    Thread.Sleep(4); //40

                }
                Console.Write("\r\n");
                Thread.Sleep(4); //400

            }
            Thread.Sleep(1000);
            blnBGMCancel = false;
            Console.WriteLine("\r\n");
            Program.UserInput();
            Program.HALL1();
            Program.ErrorOutOfBounds();
        }
        public static void ROOM2()
        {
            CurrentRoom = strROOM2;
            Console.Clear();
            if (blnPuzzle1Complete == false)
            {
                Puzzle1.StartPuzzle1();
            }
            Console.WriteLine("Going to " + strHALL2);
            Program.NextRoom();
            Program.HALL2();
            Program.ErrorOutOfBounds();
        }
        public static void ROOM3()
        {
            CurrentRoom = strROOM3;
            Console.Clear();
            Console.WriteLine("Going to " + strHALL4);
            Program.NextRoom();
            Program.HALL4();
            Program.ErrorOutOfBounds();
        }
        public static void ROOM4()
        {
            CurrentRoom = strROOM5;
            Console.Clear();
            Console.WriteLine("Going to " + strHALL6);
            Program.NextRoom();
            Program.HALL6();
            Program.ErrorOutOfBounds();
        }
        public static void ROOM5()
        {
            CurrentRoom = strROOM5;
            Console.Clear();
            Console.WriteLine("Going to " + strHALL7);
            Program.NextRoom();
            Program.HALL7();
            Program.ErrorOutOfBounds();
        }
        public static void ROOM6()
        {
            CurrentRoom = strROOM6;
            Console.Clear();
            Console.WriteLine("Going to " + strHALL13);
            Program.NextRoom();
            Program.HALL13();
            Program.ErrorOutOfBounds();
        }
        public static void ROOM7()
        {
            CurrentRoom = strROOM7;
            Console.WriteLine("BOSSROOM");
            Console.ReadLine();
            Program.ErrorNotYetCreated();
        }
        //END OF ROOMS

        //BEGIN OF HALLS
        public static void HALL1()
        {
            CurrentRoom = strHALL1;
            Console.Clear();
            Console.WriteLine("There is nothing to see here");
            Program.NextRoom();
            Program.ROOM2();
            Program.ErrorOutOfBounds();
        }
        public static void HALL2()
        {
            CurrentRoom = strHALL2;
            Console.Clear();
            Console.WriteLine("Going to " + strROOM3);
            Program.NextRoom();
            Program.ROOM3();
            Program.ErrorOutOfBounds();
        }
        public static void HALL3()
        {
            CurrentRoom = strHALL3;
            Program.ErrorNotYetCreated();
        }
        public static void HALL4()
        {
            CurrentRoom = strHALL4;
            Console.Clear();
            Console.WriteLine("Going to " + strHALL5);
            Program.NextRoom();
            Program.HALL5();
            Program.ErrorOutOfBounds();
        }
        public static void HALL5()
        {
            CurrentRoom = strHALL5;
            Console.Clear();
            Console.WriteLine("Going to " + strROOM4);
            Program.NextRoom();
            Program.ROOM4();
            Program.ErrorOutOfBounds();
        }
        public static void HALL6()
        {
            CurrentRoom = strHALL6;
            Console.Clear();
            Console.WriteLine("Going to " + strROOM5);
            Program.NextRoom();
            Program.ROOM5();
            Program.ErrorOutOfBounds();
        }
        public static void HALL7()
        {
            CurrentRoom = strHALL7;
            Console.Clear();
            Console.WriteLine("Going to " + strHALL8);
            Program.NextRoom();
            Program.HALL8();
            Program.ErrorOutOfBounds();
        }
        public static void HALL8()
        {
            CurrentRoom = strHALL8;
            Console.Clear();
            Console.WriteLine("Going to " + strHALL12);
            Program.NextRoom();
            Program.HALL12();
            Program.ErrorOutOfBounds();
        }
        public static void HALL9()
        {
            CurrentRoom = strHALL9;
            Program.ErrorNotYetCreated();
        }
        public static void HALL10()
        {
            CurrentRoom = strHALL10;
            Program.ErrorNotYetCreated();
        }
        public static void HALL11()
        {
            CurrentRoom = strHALL11;
            Program.ErrorNotYetCreated();
        }
        public static void HALL12()
        {
            CurrentRoom = strHALL12;
            Console.Clear();
            Console.WriteLine("Going to " + strROOM6);
            Program.NextRoom();
            Program.ROOM6();
            Program.ErrorOutOfBounds();
        }
        public static void HALL13()
        {
            CurrentRoom = strHALL13;
            Console.Clear();
            Console.WriteLine("Going to " + strHALL14);
            Program.NextRoom();
            Program.HALL14();
            Program.ErrorOutOfBounds();
        }
        public static void HALL14()
        {
            CurrentRoom = strHALL14;
            Console.Clear();
            Console.WriteLine("Going to " + strROOM7);
            Program.NextRoom();
            Program.ROOM7();
            Program.ErrorOutOfBounds();
        }
        //END OF HALLS

        public static void NextRoom()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

        }


        //Random ConsoleColor Generator
        public static void GetRandomConsoleColor()
        {
            Array consoleColors = Enum.GetValues(typeof(ConsoleColor));
            originalForegroundColor = Console.ForegroundColor;
            do
            {
                Console.ForegroundColor = (ConsoleColor)consoleColors.GetValue(_randomforeground.Next(consoleColors.Length));
            } while (Console.ForegroundColor == Console.BackgroundColor || Console.ForegroundColor == originalForegroundColor || Console.ForegroundColor == ConsoleColor.Gray || Console.ForegroundColor == ConsoleColor.DarkGray || Console.ForegroundColor == ConsoleColor.DarkRed || Console.ForegroundColor == ConsoleColor.DarkMagenta || Console.ForegroundColor == ConsoleColor.DarkYellow || Console.ForegroundColor == ConsoleColor.DarkBlue || Console.ForegroundColor == ConsoleColor.DarkGreen || Console.ForegroundColor == ConsoleColor.Blue || Console.ForegroundColor == ConsoleColor.DarkCyan);
            originalForegroundColor = Console.ForegroundColor;
        }

        //BGM
        public static void BGM()
        {
            do
            {
                if (CurrentRoom != strMainMenu && CurrentRoom != string.Empty && blnPlayMusic == true && blnBGMCancel ==false) //BGM In Game
                {
                    do
                    {
                        string[] strReadSong = File.ReadAllLines(BGMFolder + BGMFileTone);
                        string[] strReadDuration = File.ReadAllLines(BGMFolder + BGMFileDuration);
                        intSongCounter = 0;
                        if (CurrentRoom != string.Empty && CurrentRoom != strMainMenu)

                            do
                            {
                                for (int i = 0; i < strReadSong.Length; i++)
                                {
                                    intReadSong = Convert.ToInt32(strReadSong[intSongCounter]);
                                }

                                for (int i = 0; i < strReadDuration.Length; i++)
                                {
                                    intReadDuration = Convert.ToInt32(strReadDuration[intSongCounter]);
                                }
                                intSongCounter++;
                                if (intReadSong != 0)
                                {
                                    Console.Beep(intReadSong, intReadDuration);
                                }
                                else
                                {
                                    Thread.Sleep(intReadDuration);
                                }
                            } while (intSongCounter < strReadSong.Length && CurrentRoom != strMainMenu && blnPlayMusic == true && blnBGMCancel == false);
                        intSongCounter = 0;
                    } while (CurrentRoom != string.Empty || CurrentRoom != strMainMenu && blnPlayMusic == true && blnBGMCancel == false);
                }
                else if (CurrentRoom != string.Empty && CurrentRoom == strMainMenu && blnPlayMusic == true && blnBGMCancel == false) //BGM Main Menu
                {
                    do
                    {
                        string[] strReadSong = File.ReadAllLines(BGMFolder + "MainMenu/" + BGMFileTone);
                        string[] strReadDuration = File.ReadAllLines(BGMFolder + "MainMenu/" + BGMFileDuration);
                        intSongCounter = 0;
                        do
                        {
                            for (int i = 0; i < strReadSong.Length; i++)
                            {
                                intReadSong = Convert.ToInt32(strReadSong[intSongCounter]);
                            }

                            for (int i = 0; i < strReadDuration.Length; i++)
                            {
                                intReadDuration = Convert.ToInt32(strReadDuration[intSongCounter]);
                            }
                            intSongCounter++;
                            if (intReadSong != 0)
                            {
                                Console.Beep(intReadSong, intReadDuration);
                            }
                            else
                            {
                                Thread.Sleep(intReadDuration);
                            }
                        } while (intSongCounter < strReadSong.Length && CurrentRoom == strMainMenu && blnPlayMusic == true && blnBGMCancel == false);
                        intSongCounter = 0;
                    } while (CurrentRoom == strMainMenu && blnPlayMusic == true && blnBGMCancel == false);
                }
            } while (true);
        }

        //GAMEOVER
        public static void GameOver()
        {
            Console.Clear();
            Console.WriteLine("How did you even manage to lose? this isn't even a game.\r\nPress any key to exit");
            Console.ReadKey();
            Environment.Exit(0);
        }

        //Error color
        public static void ErrorHandlerStart()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
        }
        //Error preventor
        public static void ErrorFinisher()
        {
            Console.WriteLine("\r\nInformation:\r\nCurrentRoom = {0}\r\n", CurrentRoom);
            Console.WriteLine("An unexpected error occured, please contact me at nando.kools@hotmail.com and give me the error ID");
            CurrentRoom = string.Empty;
            Thread.Sleep(500);
            Console.Beep(500, 1200);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.ReadLine();
            Console.ReadLine();// made 2 readlines to make sure the user doesnt skip the error.
        }
        //If code isn't created yet
        public static void ErrorNotYetCreated()
        {
            Program.ErrorHandlerStart();
            Console.WriteLine("ERROR: CODE DOESN'T EXIST");
            Console.WriteLine("ERROR ID: 0003");
            Program.ErrorFinisher();
            Console.WriteLine("Press any button to return to Main Menu");
            Console.ReadKey();
            Program.MAINMENU();

        }
        //Error code out of bounds
        public static void ErrorOutOfBounds()
        {
            Program.ErrorHandlerStart();
            Console.WriteLine("ERROR: CODE OUT OF BOUNDS");
            Console.WriteLine("ERROR ID: 0004");
            Program.ErrorFinisher();
            Console.WriteLine("Press any button to return to Main Menu");
            Console.ReadKey();
            Program.MAINMENU();
        }

    }
}
