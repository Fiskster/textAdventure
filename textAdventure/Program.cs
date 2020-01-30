using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace textAdventure
{
    class Program
    {
        //Universal array that i can grab any time i will need it.
        static string[] mathProblems =
        {
            "Solve 6 * 14 = ","Find the derivative of f(x)=6x^3−9x+4","Solve 52+78","solve 18/6"
        };
        //Universal array that i can grab any time i will need it.
        static string[] solutions =
        {
            "84","f'(x)=18x^2-9","130","3"
        };
        //A bool Value that remains relevant throughout the game
        static bool keycard = false;
        //this bool declares if the boss is alive or dead
        static bool bossAlive = true;
        //this bool declares if you have had the dialogue with the gambler.
        static bool visitedMicke = false;
        //main title method. only calling for the title screen
        static void Main(string[] args)
        {
            titleScreen();
            

        }

        public static void titleScreen()
        {
            Console.WriteLine(@"
            
████████╗██╗  ██╗███████╗    ██╗  ██╗ ██████╗ ███████╗██████╗ ██╗████████╗ █████╗ ██╗         
╚══██╔══╝██║  ██║██╔════╝    ██║  ██║██╔═══██╗██╔════╝██╔══██╗██║╚══██╔══╝██╔══██╗██║         
   ██║   ███████║█████╗      ███████║██║   ██║███████╗██████╔╝██║   ██║   ███████║██║         
   ██║   ██╔══██║██╔══╝      ██╔══██║██║   ██║╚════██║██╔═══╝ ██║   ██║   ██╔══██║██║         
   ██║   ██║  ██║███████╗    ██║  ██║╚██████╔╝███████║██║     ██║   ██║   ██║  ██║███████╗    
   ╚═╝   ╚═╝  ╚═╝╚══════╝    ╚═╝  ╚═╝ ╚═════╝ ╚══════╝╚═╝     ╚═╝   ╚═╝   ╚═╝  ╚═╝╚══════╝    
                                                                                              
 
            
                                                                                                                                   


                                    ");
            Console.WriteLine("Welcome to the Hospital!");
            Console.WriteLine("Press enter to begin.");
            Console.ReadLine();
            Console.Clear();
            first();

        }
        //lobbyroom method, will be needed when you get escorded back.
        public static void first()
        {
            string direction;
            bool correctAnswer = false; 
            Console.WriteLine("You have entered the hospital.");
           //While loop for deciding which direction to walk towards. Not using a for-loop because you might want to go back and forward. 
            while (correctAnswer != true)
            {
                Console.Clear();
                Console.WriteLine("You see three doors, one ahead of you, one to the left and one the right." );
                 Console.WriteLine("Which one would you like to enter?");
                 Console.Write("direction:");
                 
            
                direction = Console.ReadLine().ToLower();
                Console.Clear();
                if (direction == "left")
                {  
                    second();
                }
                if (direction == "right")
                {
                    third();
                }
                if (direction == "forward")
                {
                    door();
                }
                else
                {
                    Console.WriteLine("please answer a correct direction...");
                    
                }
            }
            
            
        }
        //second room method.
        public static void second()
        {
            Console.WriteLine("You have now entered the bathroom");
            Console.WriteLine("It appears to be someone living here!");
            Thread.Sleep(1000);

            if (visitedMicke == false)
            {
                //RPG text using foreach char in the string text with a delay between each character to give it a more game-like feeling.
                string text = "???: Greetings! I am the bathroom gambler Ekcim!";

                foreach (char c in text)

                {

                    Console.Write(c);

                    Thread.Sleep(50);

                }
                //Player instructions
                Console.WriteLine("\n Press enter to continue.");
                Console.ReadLine();
                string text2 = "Ekcim!: i shall now give you a few options to choose from!";
                foreach (char a in text2)
                {

                    Console.Write(a);

                    Thread.Sleep(50);

                }
                visitedMicke = true;
            }
            else if (visitedMicke == true)
            {
                string text5 = "Ekcim: Welcome back! What would you like to do today?";
                foreach (char b in text5)
                {

                    Console.Write(b);

                    Thread.Sleep(50);

                }
            }
            Thread.Sleep(1500);
           
            Console.Clear();
            string text3 = "Ekcim: Here are your options..";
            foreach (char b in text3)
            {

                Console.Write(b);

                Thread.Sleep(50);

            }
            Console.WriteLine("\n Press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("1. Roll the dice for a chance to win a special prize!");
            Console.WriteLine("2. Roll the dice for a chance to instantly win the game! *WARNING* this option may cause you to instantly lose the game >:)");
            Console.WriteLine("3. Leave the bathroom.");
            string text4 = "Ekcim: Now, which option would you like?";
            foreach (char b in text4)
            {

                Console.Write(b);

                Thread.Sleep(50);

            }
            //Using console.write here to make it look cooler when you type in your choice next to the text *shrug*
           
            Console.Write(" \n Choice:");
            string secChoice;
            secChoice = Console.ReadLine().ToLower();
            Random number = new Random();
            int roll = number.Next(1, 100);
            //Random number generator for the gambling roll.
            
            //Using switch just to make sure a "correct" answer dosent get recognized as a wrong answer. Couldve used if/else but i wanted to switch it up.
            switch (secChoice)
            {
                case "1": 
                case "Roll the dice for a special prize":
                    {
                        if (roll<11)
                        {
                            Console.WriteLine("Ekcim: WOW!! YOU JUST WON THE SPECIAL PRIZE! CONGRATULATIONS!");
                            Console.WriteLine("You acquired a Keycard.");
                            Console.WriteLine("\n Press enter to continue.");
                            Console.ReadLine();
                            keycard = true;
                        }
                        else if (roll>11 && roll<50)
                        {
                            Console.WriteLine("Ekcim: CONGRATULATIONS! You did not win the special prize but this will still help you out!");
                            Console.WriteLine("You acquired the passcode for the codelock. The code is 4967");
                            Console.WriteLine("\n Press enter to continue.");
                            Console.ReadLine();
                        }
                        else if (roll>50)
                        {
                            Console.WriteLine("Ekcim: Tough luck buddy, you did not win anything today..");
                            Thread.Sleep(2000);
                            Console.WriteLine("Ekcim: I will help you out back to the lobby.");
                            Thread.Sleep(2000);
                            Console.Clear();
                            first();
                        }

                    }
                    //do something if the player chooses option A
                    break;
                case "2":
                case "roll the dice for instant win":
                    {
                        if (roll<10)
                        {
                            youWin();
                        }
                        else
                        {
                            gameOver();
                        }
                    }
                    //do some different stuff if the player chooses option B
                    break;
                case "3":
                case "leave": 
                    {
                        string text5 = "Ekcim: Acceptable, i will escort you back to the lobby.";
                        foreach (char b in text5)
                        {

                            Console.Write(b);

                            Thread.Sleep(50);

                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        first();
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Ekcim: If you cant answer a simple question ill kick you out myself!");
                        Thread.Sleep(2000);
                        Console.Clear();
                        first();
                    }
                    //default stuff, send them back to the lobby.
                    break;
            }
            

        }
        //first actual boss room 
        public static void third()
        {
            Console.WriteLine("You have now entered the break room.");
            Thread.Sleep(1500);
            Console.WriteLine("You see someone with a really fresh-looking outfit by the coffee machine.");
            Thread.Sleep(1500);
            Console.WriteLine(@"                            
                                 ..
                          /`,,,,,,*,,*.           
                        .(.,,,,,,,,****/#*         
                       ..* *,,,,,,, *****/#%#,       
                       .* **,,,,,,,, **/'/((#%(,      
                       .* **,,,,,,, ***/'/(((((/      
                       , *,,,,,,,,, ***/'/(((//,      
                      .,/#/(#(,/(#%(//(##(((.      
                      **/'/*///*#((/%##((#((/,      
                      ******/'//#(*/((/'/####((,     
                      */'/**//,/((/'*/'/(###(#/      
                       */'/*//(%##(//(#####(/       
                       */'*/%%####%(*((###          
                        /(*/(((((/'/(#(###          
                         //**/*/'//(#(%%%(          
                         #(((/((#%%%%%###.        
                       /@% (#%%%%%%%%%%####(%&/     
                  ,###//(###(###%%####(#%%#####* 
              / (######%&(((###########((#%#######
            ###########%/(#(#####(#&&%###########
            ###########%%#%&%((##%##%#%%#######%###
            ######%###%#%%#&&/(%%%##%#########%%%##
            %##########%%#%/%/(%%%%#############%##
            %#####%########%%#####%%%%%#####%%%%%##
            %#########%%%&%#####%%%#%%%%%%####%##%# ");
            string text = "\n Bjorn: WHO ARE YOU?! AND WHAT ARE YOU DOING IN THE BREAK ROOM!";
            //ASCII Art generated from image. 
            foreach (char c in text)

            {

                Console.Write(c);

                Thread.Sleep(50);

            }
            Console.WriteLine("\n Press enter to continue.");
            Console.ReadLine();
            Console.Clear();
            if (bossAlive == true)
            {
                Console.Clear();
                fight();
            }
            else if (bossAlive != true)
            {
                Console.Clear();
                Console.WriteLine(@"                            
                                 ..
                          /`,,,,,,*,,*.           
                        .(.,,,,,,,,****/#*         
                       ..* *,,,,,,, *****/#%#,       
                       .* **,,,,,,,, **/'/((#%(,      
                       .* **,,,,,,, ***/'/(((((/      
                       , *,,,,,,,,, ***/'/(((//,      
                      .,/#/(#(,/(#%(//(##(((.      
                      **/'/*///*#((/%##((#((/,      
                      ******/'//#(*/((/'/####((,     
                      */'/**//,/((/'*/'/(###(#/      
                       */'/*//(%##(//(#####(/       
                       */'*/%%####%(*((###          
                        /(*/(((((/'/(#(###          
                         //**/*/'//(#(%%%(          
                         #(((/((#%%%%%###.        
                       /@% (#%%%%%%%%%%####(%&/     
                  ,###//(###(###%%####(#%%#####* 
              / (######%&(((###########((#%#######
            ###########%/(#(#####(#&&%###########
            ###########%%#%&%((##%##%#%%#######%###
            ######%###%#%%#&&/(%%%##%#########%%%##
            %##########%%#%/%/(%%%%#############%##
            %#####%########%%#####%%%%%#####%%%%%##
            %#########%%%&%#####%%%#%%%%%%####%##%# ");
                string text5 = "\n Bjorn: Challenger. You have already passed my test. Get out of here!";

                foreach (char c in text5)
                {

                    Console.Write(c);

                    Thread.Sleep(50);

                }
                Thread.Sleep(2000);
                Console.Clear();
                first();
            }
            
        }
        //Fight against bjorn method, makes code more clear and easier to understand. 
        public static void fight()
        {
            Console.WriteLine("INSTRUCTIONS: Bjorn will give you math problems. If you solve the problem, Bjorn will take damage. If your answer is incorrect, you will take damage.");
            Console.WriteLine("Press enter if you understand.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("The fight against bjorn will now begin..");
            Thread.Sleep(1500);
            Console.WriteLine("You have been challenged by Teacher Bjorn!");
            int playerHP = 100;
            int boss = 100;
            while (playerHP > 0||boss > 0)
            {
                //It chooses a random problem from the array.
                Random solution = new Random();
                int problem = solution.Next(0, 4);
                Console.WriteLine(mathProblems[problem]);
                Console.Write(" \n Answer:");
                
                string Answer;
                Answer = Console.ReadLine();
                //if the answer is the same as the solution to the problem you deal 25 dmg and you have 100HP respectively :)
                if (Answer == solutions[problem])
                {
                    Console.WriteLine("Correct! You deal 25 DMG to bjorn");
                    boss = boss - 25;
                    Console.WriteLine("Bjorn now has " + boss + " HP ");
                }
                else if (Answer != solutions[problem])
                {
                    Console.WriteLine("Incorrect! You take 25 DMG");
                    playerHP = playerHP - 25;
                    Console.WriteLine("You now have " + playerHP + " HP ");
                }
                //Well this this is what happens and when the player dies or the boss dies respectively
                if (playerHP == 0)
                {
                    Console.Clear();
                    Console.WriteLine(@"                            
                                 ..
                          /`,,,,,,*,,*.           
                        .(.,,,,,,,,****/#*         
                       ..* *,,,,,,, *****/#%#,       
                       .* **,,,,,,,, **/'/((#%(,      
                       .* **,,,,,,, ***/'/(((((/      
                       , *,,,,,,,,, ***/'/(((//,      
                      .,/#/(#(,/(#%(//(##(((.      
                      **/'/*///*#((/%##((#((/,      
                      ******/'//#(*/((/'/####((,     
                      */'/**//,/((/'*/'/(###(#/      
                       */'/*//(%##(//(#####(/       
                       */'*/%%####%(*((###          
                        /(*/(((((/'/(#(###          
                         //**/*/'//(#(%%%(          
                         #(((/((#%%%%%###.        
                       /@% (#%%%%%%%%%%####(%&/     
                  ,###//(###(###%%####(#%%#####* 
              / (######%&(((###########((#%#######
            ###########%/(#(#####(#&&%###########
            ###########%%#%&%((##%##%#%%#######%###
            ######%###%#%%#&&/(%%%##%#########%%%##
            %##########%%#%/%/(%%%%#############%##
            %#####%########%%#####%%%%%#####%%%%%##
            %#########%%%&%#####%%%#%%%%%%####%##%# ");
                    string text = "\n Bjorn: HAHAHA! You have failed the test! I'd Advice you to go back to the studyhall on mondays.";

                    foreach (char c in text)
                    {

                        Console.Write(c);

                        Thread.Sleep(50);

                    }
                    Thread.Sleep(1500);
                    string text2 = "\n Bjorn: I will escort you back to the lobby now. You may retake the test anytime.";

                    foreach (char c in text2)
                    {

                        Console.Write(c);

                        Thread.Sleep(50);

                    }
                    Thread.Sleep(1500);
                    Console.Clear();
                    first();
                }
                if (boss == 0)
                {
                    Console.Clear();
                    Console.WriteLine(@"                            
                                 ..
                          /`,,,,,,*,,*.           
                        .(.,,,,,,,,****/#*         
                       ..* *,,,,,,, *****/#%#,       
                       .* **,,,,,,,, **/'/((#%(,      
                       .* **,,,,,,, ***/'/(((((/      
                       , *,,,,,,,,, ***/'/(((//,      
                      .,/#/(#(,/(#%(//(##(((.      
                      **/'/*///*#((/%##((#((/,      
                      ******/'//#(*/((/'/####((,     
                      */'/**//,/((/'*/'/(###(#/      
                       */'/*//(%##(//(#####(/       
                       */'*/%%####%(*((###          
                        /(*/(((((/'/(#(###          
                         //**/*/'//(#(%%%(          
                         #(((/((#%%%%%###.        
                       /@% (#%%%%%%%%%%####(%&/     
                  ,###//(###(###%%####(#%%#####* 
              / (######%&(((###########((#%#######
            ###########%/(#(#####(#&&%###########
            ###########%%#%&%((##%##%#%%#######%###
            ######%###%#%%#&&/(%%%##%#########%%%##
            %##########%%#%/%/(%%%%#############%##
            %#####%########%%#####%%%%%#####%%%%%##
            %#########%%%&%#####%%%#%%%%%%####%##%# ");
                    string text = "\n Bjorn: Congratulations. You have passed my test challenger. I will now give you a keycard.";

                    foreach (char c in text)
                    {

                        Console.Write(c);

                        Thread.Sleep(50);

                    }
                    keycard = true;
                    Thread.Sleep(1500);
                    string text2 = "\n Bjorn: I will escort you back to the lobby now.";

                    foreach (char c in text2)
                    {

                        Console.Write(c);

                        Thread.Sleep(50);

                    }
                    bossAlive = false;
                    Thread.Sleep(1500);
                    Console.Clear();
                    first();
                }


            }
            
                      
            



        }
        //here is the third "room" but there is a door! 
        public static void door()
        {
            Console.WriteLine(@"  
            __________
           |  __  __  |
           | |  ||  | |
           | |  ||  | |
           | |__||__| |
           |  __  __()|
           | |  ||  | |
           | |  ||  | |
           | |  ||  | |
           | |  ||  | |
           | |__||__| |
           |__________|");
            string text = "Jarvis: Greetings! I am Jarvis, the AI robot that acts like a lock!";

            foreach (char c in text)
            {

                Console.Write(c);

                Thread.Sleep(50);

            }
            Console.WriteLine("\n Press enter to continue.");
            Console.ReadLine();
            string text2 = "Jarvis: Let me see if you have the keycard that you will need to open the door..";
            foreach (char c in text2)
            {

                Console.Write(c);

                Thread.Sleep(50);

            }
            Thread.Sleep(2000);
            //Checking if the global variable has changed from false to true.
            if (keycard == true)
            {
                Console.Clear();
                Console.WriteLine(@"  
            __________
           |  __  __  |
           | |  ||  | |
           | |  ||  | |
           | |__||__| |
           |  __  __()|
           | |  ||  | |
           | |  ||  | |
           | |  ||  | |
           | |  ||  | |
           | |__||__| |
           |__________|");
                string text3 = "Jarvis: Ah! You do have a keycard! Perfect. ";

                foreach (char c in text3)
                {

                    Console.Write(c);

                    Thread.Sleep(50);

                }
                Thread.Sleep(1000);
                Console.WriteLine("\n Press enter to continue.");
                Console.ReadLine();
                finalRoom();
            }
            else if (keycard == false)
            {
                Console.Clear();
                Console.WriteLine(@"  
            __________
           |  __  __  |
           | |  ||  | |
           | |  ||  | |
           | |__||__| |
           |  __  __()|
           | |  ||  | |
           | |  ||  | |
           | |  ||  | |
           | |  ||  | |
           | |__||__| |
           |__________|");
                string text3 = "Jarvis: It appears you do not have the keycard..";

                foreach (char c in text3)
                {

                    Console.Write(c);

                    Thread.Sleep(50);

                }
                Console.WriteLine("\n Press enter to continue.");
                Console.ReadLine();
                string text4 = "Jarvis: You might still have the code though... ill give you four chances to enter the correct code.";

                foreach (char c in text4)
                {

                    Console.Write(c);

                    Thread.Sleep(50);

                }
                Console.WriteLine("\n Press enter to continue.");
                Console.ReadLine();
                Console.Write("Enter the code here:");
                //Using a for-loop here because you only get 4 chances to guess the code before jarvis kicks you out. 
                for (int i = 0; i < 4; i++)
                {
                    string code;
                    code = Console.ReadLine();
                    if (code == "4967")
                    {
                        Console.WriteLine("Jarvis: That's correct! I will let you through.");
                        Thread.Sleep(2000);
                        finalRoom();
                        break;
                    }
                    else if (code != "4967")
                    {
                        Console.WriteLine("Jarvis: That's Incorrect. Please try again.");
                    }
                    else if (i == 4)
                    {
                        Console.WriteLine("Jarvis: Ok, you dont know the code. Find the code or the keycard and then you may enter.");
                        Thread.Sleep(1000);
                        first();
                    }
                }
            }
           

        }
        public static void finalRoom()
        {
            //Two Arrays for the final battle which is a quiz. 
            string[] questions =
            {
                 "What do you always eat?","What Training exercise do you always do?","What do you always drink?","What do you snus?"
            };
             string[] answers =
             {
                "chicken","benchpress","nocco","loose"
             };

            Console.Clear();
            Console.WriteLine(@"                                      
               /####(                  
             &%%%%&%%%%%(#,            
           %&&%#(#(%#&%&%%#/           
          %%#(*,,/*(/(#%%#%#(          
          ##,,......,*/((#%&%*         
          */,.......,,/((#%%%/         
          ,.,,,....,*/((((#%%#         
          .,*#%&(.#&@%%#####%(         
          /,,/*,,,##(//(#((/##         
          .,...,.*#(*,,/((//(&         
           **#,*/%&%(//(##(((          
           ,*(/(#%#%####(            
            //*(#%#%%##%##(            
             /**,**(#%%%%%%@           
             *(#%%#%%&&&&&@&%          
            &@(#%&&&&@@@@@@@(        
            &@%(##%&&@@@@@@@%%##(*     
        .////&@##%%@@@@@@%#%%###(((/*  
     *///((/((#@@#@@@&&%%####(#(((((((*
  ,/(((((/((((((###((#(##(((##((#(#((/(
 /(####(((((((#((((#((###(#(#(###((((##
/((((((((#(#(((((((##(##((###((((#(((##
(##(((##(##(((#(((((####(###(#####(##%#
#(##%#############((#(#(######%#%/%#%%&
#%%&%############(############%#%%%%#&%");
            string text = "Karwan: Greetings! I am Karwan, the principal and the final guardian of the hospital.";

            foreach (char c in text)
            {

                Console.Write(c);

                Thread.Sleep(50);

            }
            Console.WriteLine("\n Press enter to continue.");
            Console.ReadLine();
            int foodLocations = 4;
            int bossHP = 4;
            string text2 = "Karwan: I will now quiz you on how the be the perfect man.";

            foreach (char c in text2)
            {

                Console.Write(c);

                Thread.Sleep(50);

            }
            Console.WriteLine("\n Press enter if you understand.");
            Console.ReadLine();
            Console.Clear();
            //very similar to the previous bossbattle, using the same concepts which different words and variables to make it more clear for someone looking at the code.
            while (foodLocations > 0 || bossHP > 0)
            {
               
                Random Generator = new Random();
                int question = Generator.Next(0, 4);
                
                Console.WriteLine(questions[question]);
                Console.Write(" \n Answer:");
                string Answer;
                Answer = Console.ReadLine().ToLower();
                // Console.ReadLine();
                if (Answer == answers[question].ToLower())
                {
                    Console.WriteLine("Correct! You take one foodlocation from Karwan!");
                    bossHP = bossHP - 1;
                    Console.WriteLine("Karwan now has " + bossHP + " Food locations left!");
                }
                else if (Answer != answers[question])
                {
                    Console.WriteLine("Incorrect! Karwan takes one of your food locations away!");
                    foodLocations = foodLocations - 1;
                    Console.WriteLine("You now have " + foodLocations + " Food locations left!");
                }
                if (foodLocations == 0)
                {
                    Console.Clear();
                    Console.WriteLine(@"                                      
               /####(                  
             &%%%%&%%%%%(#,            
           %&&%#(#(%#&%&%%#/           
          %%#(*,,/*(/(#%%#%#(          
          ##,,......,*/((#%&%*         
          */,.......,,/((#%%%/         
          ,.,,,....,*/((((#%%#         
          .,*#%&(.#&@%%#####%(         
          /,,/*,,,##(//(#((/##         
          .,...,.*#(*,,/((//(&         
           **#,*/%&%(//(##(((          
           ,*(/(#%#%####(            
            //*(#%#%%##%##(            
             /**,**(#%%%%%%@           
             *(#%%#%%&&&&&@&%          
            &@(#%&&&&@@@@@@@(        
            &@%(##%&&@@@@@@@%%##(*     
        .////&@##%%@@@@@@%#%%###(((/*  
     *///((/((#@@#@@@&&%%####(#(((((((*
  ,/(((((/((((((###((#(##(((##((#(#((/(
 /(####(((((((#((((#((###(#(#(###((((##
/((((((((#(#(((((((##(##((###((((#(((##
(##(((##(##(((#(((((####(###(#####(##%#
#(##%#############((#(#(######%#%/%#%%&
#%%&%############(############%#%%%%#&%");
                    string text3 = "Karwan: HAHA! It appears you are not the ideal man! Better luck next time student!";

                    foreach (char c in text3)
                    {

                        Console.Write(c);

                        Thread.Sleep(50);

                    }
                    Thread.Sleep(1500);
                    gameOver();

                }
                if (bossHP == 0) 
                {
                    Console.Clear();
                    Console.WriteLine(@"                                      
               /####(                  
             &%%%%&%%%%%(#,            
           %&&%#(#(%#&%&%%#/           
          %%#(*,,/*(/(#%%#%#(          
          ##,,......,*/((#%&%*         
          */,.......,,/((#%%%/         
          ,.,,,....,*/((((#%%#         
          .,*#%&(.#&@%%#####%(         
          /,,/*,,,##(//(#((/##         
          .,...,.*#(*,,/((//(&         
           **#,*/%&%(//(##(((          
           ,*(/(#%#%####(            
            //*(#%#%%##%##(            
             /**,**(#%%%%%%@           
             *(#%%#%%&&&&&@&%          
            &@(#%&&&&@@@@@@@(        
            &@%(##%&&@@@@@@@%%##(*     
        .////&@##%%@@@@@@%#%%###(((/*  
     *///((/((#@@#@@@&&%%####(#(((((((*
  ,/(((((/((((((###((#(##(((##((#(#((/(
 /(####(((((((#((((#((###(#(#(###((((##
/((((((((#(#(((((((##(##((###((((#(((##
(##(((##(##(((#(((((####(###(#####(##%#
#(##%#############((#(#(######%#%/%#%%&
#%%&%############(############%#%%%%#&%");
                    string text3 = "Karwan: Huh.. you have beaten my quiz. Congratulations i guess. ";

                    foreach (char c in text3)
                    {

                        Console.Write(c);

                        Thread.Sleep(50);

                    }
                    Thread.Sleep(1500);
                    youWin();
                }



            }



        }
        public static void gameOver()
        {
            Console.Clear();
            Console.WriteLine(@"
  ▄████  ▄▄▄       ███▄ ▄███▓▓█████     ▒█████   ██▒   █▓▓█████  ██▀███  
 ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀    ▒██▒  ██▒▓██░   █▒▓█   ▀ ▓██ ▒ ██▒
▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███      ▒██░  ██▒ ▓██  █▒░▒███   ▓██ ░▄█ ▒
░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄    ▒██   ██░  ▒██ █░░▒▓█  ▄ ▒██▀▀█▄  
░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒   ░ ████▓▒░   ▒▀█░  ░▒████▒░██▓ ▒██▒
 ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░   ░ ▒░▒░▒░    ░ ▐░  ░░ ▒░ ░░ ▒▓ ░▒▓░
  ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░     ░ ▒ ▒░    ░ ░░   ░ ░  ░  ░▒ ░ ▒░
░ ░   ░   ░   ▒   ░      ░      ░      ░ ░ ░ ▒       ░░     ░     ░░   ░ 
      ░       ░  ░       ░      ░  ░       ░ ░        ░     ░  ░   ░     
                                                     ░                   
");
            keycard = false;
                Console.WriteLine("Would you like to play again? Y/N: ");
            ConsoleKeyInfo UI = Console.ReadKey();
                if (UI.Key == ConsoleKey.Y)
                {
                Console.Clear();
                visitedMicke = false;
                bossAlive = true;
                    titleScreen();
                }
                else 
                {
                    Console.WriteLine("\n Thank you for playing.");
                    Console.ReadKey();
                }
           
         

            Console.ReadLine();
            
        }
        public static void youWin()
        {

            Console.Clear();
            Console.WriteLine(@"
██╗   ██╗ ██████╗ ██╗   ██╗    ██╗    ██╗██╗███╗   ██╗
╚██╗ ██╔╝██╔═══██╗██║   ██║    ██║    ██║██║████╗  ██║
 ╚████╔╝ ██║   ██║██║   ██║    ██║ █╗ ██║██║██╔██╗ ██║
  ╚██╔╝  ██║   ██║██║   ██║    ██║███╗██║██║██║╚██╗██║
   ██║   ╚██████╔╝╚██████╔╝    ╚███╔███╔╝██║██║ ╚████║
   ╚═╝    ╚═════╝  ╚═════╝      ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝
                                                      
");
            Thread.Sleep(3000);
            Console.WriteLine("the program will now exit.");
            Thread.Sleep(1000);
            Environment.Exit(0);
            Console.ReadLine();
        }

    }
}
