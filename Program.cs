// Developer: Nnachi, Joseph Otu
// copyright(c)2024


// ADVENTURERS GAME
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("                                       ADVENTURERS     ");
        Console.WriteLine("                           You are welcome to try something new!  ");
        Console.WriteLine();
        Console.WriteLine();

        // Setting the game instructions
        Console.WriteLine(@"                                       INSTRUCTION: 
                Try not to die or delay and waste time until you FINISH the game,
                If you die or if your time runs out, then it's GAME OVER, 
                So do your best to arrive home as a WONDERFUL ADVENTURER.
                
                    PLEASE TYPE ONLY ANY OF THE CAPITILIZED OPTIONS  ");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(@"                                        STAGE 1
            Imagine yourself on a mysterious island with your team of adventurers
            who are skilled and armed. In fact, as the leader of the group
            the survival of your team lies on the decisions you make. 
            As you travel down a steep hill you are ambushed by a 
            pack of hyenas and your options are to RUN, ATTACK the hyenas,
            HIDE or to SCREAM aloud for help even though no help is assured
            since you are on a mysterious island. what do you do?                     ");
            Console.WriteLine();
            Console.WriteLine();
        Console.Write("             Enter your choice? ");
        string level1 = Console.ReadLine();

        // Using Conditional Statements
        if (level1.ToLower() == "run")
        {

            Console.WriteLine();
            Console.WriteLine(@"                        You chose to run then the hyenas chased and
            captured some of your team members since they were faster but those who survived have gotten to this new stage. ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Stage_1 response leads into Stage_2
            Console.Write(@"                                    STAGE 2
            Your journey continues, and you and your team members stumble upon a hidden treasure that 
            will be useful to you as you progress in the game; it's a luggage full of gold and precious stones, 
            but it's guarded by venomous snakes and your options are to KILL the snakes, LEAVE the luggage of gold,
            or SACRIFICE one of your team members to the snake, maybe your self, and it's game over if you die.");
        }
        else if (level1.ToLower() == "attack")
        {
            Console.WriteLine();
            Console.WriteLine(@"                        You and your team decided to attack then your survival
                depended on the strength of your weapons and those who survived have gotten to this new stage");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(@"                                    STAGE 2
            Your journey continues, and you and your team members stumble upon a hidden treasure that 
            will be useful to you as you progress in the game; it's a luggage full of gold and precious stones, 
            but it's guarded by venomous snakes and your options are to KILL the snakes, LEAVE the luggage of gold,
            or SACRIFICE one of your team members to the snake.");
        }
        else if (level1.ToLower() == "hide")
        {
            Console.WriteLine();
            Console.WriteLine(@"                Your team hid so that they might survive;
                maybe not everyone did, but those who survived have gotten to this stage  ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(@"                                    STAGE 2
            Your journey continues, and you and your team members stumble upon a hidden treasure that 
            will be useful to you as you progress in the game; it's a luggage full of gold and precious stones, 
            but it's guarded by venomous snakes and your options are to KILL the snakes, LEAVE the luggage of gold,
            or SACRIFICE one of your team members to the snake, maybe your self, and it's game over if you die.");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine(@"                All of you just screamed and did otherwise, so you were eaten by the hyenas since there is no help in the jungle.
                                    GAME OVER
                                Please Try Again  ");
            return;
        }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("             Enter your choice? ");
            string level2 = Console.ReadLine();
        if (level2.ToLower() == "kill")
        {
            Console.WriteLine();
            Console.WriteLine(@"                        You killed the snake after much hassle; those who survived have gotten to this new stage. ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Stage_2 response leads into Stage_3
            Console.Write(@"                                    STAGE 3
            As you and your team members got through STAGE_2, you walked two miles down the hill
            only to find a lake that you need to cross to get to the other side of the jungle and,
            at the shore you're expected to MAKE your own canoe, PAY a canoe person with the precious stone you have to cross you,  
            SWIM across or decide to wait. What do you do?  ");
        }
        else if (level2.ToLower() == "leave")
        {
            Console.WriteLine();
            Console.WriteLine(@"                        You and your team decided to leave without getting the precious stone so your survival in the next stage is dicey");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(@"                                    STAGE 3
            As you and your team members got through STAGE_2, you walked two miles down the hill
            only to find a lake that you need to cross to get to the other side of the jungle and,
            at the shore you're expected to MAKE your own canoe, PAY a canoe person with the precious stone you have to cross you, 
            SWIM across or decide to wait. What do you do?  ");
        }
        else if (level2.ToLower() == "sacrifice")
        {
            Console.WriteLine();
            Console.WriteLine(@"                You sacrificed one of your crew members;
            maybe not everyone did, but those who survived have gotten to this new stage  ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(@"                                    STAGE 3
            As you and your team members got through STAGE_2, you walked two miles down the hill
            only to find a lake that you need to cross to get to the other side of the jungle and,
            at the shore you're expected to MAKE your own canoe, PAY a canoe person with the precious stone you have to cross you, 
            SWIM across or decide to wait. What do you do?  ");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine(@"                 All of you did nothing so you were
                            eaten by the venomous snakes since there is no help in the jungle.
                            GAME OVER
                        Please Try Again  ");
                return;
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("             Enter your choice? ");
        string level3 = Console.ReadLine();
        if (level3.ToLower() == "make")
        {
            Console.WriteLine();
            Console.WriteLine(@"                Your and your team made your canoe to cross the lake 
                                            but it took time, however, you made it to the new stage ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            // Stage_3 response leads into Stage_4 which is the final stage
            Console.Write(@"                                   FINAL STAGE 
                Your choices in this adventure has brought you to this last stage
                where you decide how you and your remaining team members will get home and,
                the choices available to you are; to TREK home, SAIL home, FLY home or STAY on the island
                What do you choose    ");
        }
        else if (level3.ToLower() == "pay")
        {
            Console.WriteLine();
            Console.WriteLine(@"                 You paid the canoe person with your precious stone and they crossed you and your team.  ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(@"                                    FINAL STAGE 
                Your choices in this adventure has brought you to this last stage
                where you decide how you and your remaining team members will get home and,
                the choices available to you are; to TREK home, SAIL home, FLY home or STAY on the island
                What do you choose?   ");
        }
        else if (level3.ToLower() == "swim")
        {
            Console.WriteLine();
            Console.WriteLine(@"       You and your team swam although some of you were eaten by crocodiles but you survived. ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(@"                                    FINAL STAGE 
                            Your choices in this adventure has brought you to this last stage
                            where you decide how you and your remaining team members will get home and,
                            the choices available to you are; to TREK home, SAIL home, FLY home or STAY on the island
                            What do you choose     ");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine(@" You all decide to wait or chose otherwise, then your time was up. 
                                    GAME OVER
                                Please try again.       ");
            return;
        }
                Console.WriteLine();
                Console.WriteLine();

                
        // Final Stage
        Console.Write("               Enter your choice? ");
        string level4 = Console.ReadLine();
        Console.WriteLine();
        if (level4.ToLower() == "trek" || level4.ToLower() == "sail" || level4.ToLower() == "fly")
        {
            Console.WriteLine();
            Console.WriteLine("                   CONGRATULATIONS! YOU'RE A WONDERFUL ADVENTURER ");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine(@"              You and your team stayed on the island and died of hunger since there's no food in the jungle.
    
                                                                GAME OVER
                    Please try again because you didn't finish as a Wonderful Adventurer. ");
        }
    }
}