using System;
namespace cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Card kard = new Card("",0);
            
            Deck table = new Deck(kard.values, kard.suites);
            table.shuffle();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~Enter your name~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            string player1 = Console.ReadLine();
            
            Player p1 = new Player(player1);
            Bot p2 = new Bot("Dealer");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("       {0} VS {1}", p1.name, p2.name);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("       {0} GET READY   ", p1.name);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            p1.enterthegame(table);
            // p1.showme();
            // p2.showme();
            Boolean p1isDone = false;
            while(!p1isDone){
                p1.showme();
                Console.WriteLine("++++++++++++++++++");
                Console.WriteLine("{0}, do you want to take any more cards?", p1.name);
                Console.WriteLine("1) Take one more card");
                Console.WriteLine("2) Discard");
                Console.WriteLine("3) Calculate my points");
                Console.WriteLine("4) no, i'm good");
                string player1decision = Console.ReadLine();
                if(player1decision=="1"){
                    p1.draw(table);
                }else if(player1decision=="2"){
                    Console.WriteLine("What card?");
                    string player1descard = Console.ReadLine();
                    int tempdescard = Convert.ToInt32(player1descard);
                    p1.discard(tempdescard);
                }else if(player1decision=="3"){
                    Console.WriteLine("++++++++++++++++++");
                    Console.WriteLine("YOUR SCORE IS {0}", p1.counter());
                    Console.WriteLine("++++++++++++++++++");
                }else if(player1decision=="4"){
                    p1isDone = true;
                }else{
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("-------YOUR BRAIN IS INVALID--------");
                    Console.WriteLine("--------------TRY AGAIN-------------");
                }
            }
            Console.WriteLine("{0} IS GETTING CARDS!", p2.name);
            p2.enterthegame(table);
            Boolean p2isDone = false;
            while(!p2isDone){
                int sum = p2.counter();
                Random rand = new Random();
                int checker = rand.Next(14, 20);
                if(sum<checker){
                    p2.draw(table);
                }else{
                    p2isDone = true;
                }
                
            }
            
            Console.WriteLine("Player {0}: {1}", p1.name, p1.counter());
            Console.WriteLine("{0}: {1}", p2.name, p2.counter());
            if(p1.counter()>p2.counter() && p1.counter()<=21 || p2.counter()>21){
                Console.WriteLine("Congratulations, {0}! You won!", p1.name);
                Console.WriteLine("{0}, you loose!", p2.name);
                Console.WriteLine("-=-=-=-=-");
                Console.WriteLine("Dealer's hand:");
                foreach (Card item in p2.hand)
                {
                    Console.WriteLine(item.valueandsuit);;
                }
                Console.WriteLine("-=-=-=-=-");
            }else if(p1.counter()<=p2.counter() && p2.counter()<=21 || p1.counter()>21){
                
                Console.WriteLine("{0} won!", p2.name);
                Console.WriteLine("{0}, you loose!", p1.name);
                Console.WriteLine("-=-=-=-=-");
                Console.WriteLine("Dealer's hand:");
                foreach (Card item in p2.hand)
                {
                    Console.WriteLine(item.valueandsuit);;
                }
                Console.WriteLine("-=-=-=-=-");
            }else{
                Console.WriteLine("Tight!");
                
            }
            Console.WriteLine("GAME OVER");
            Console.WriteLine("GOOD BYE!");
            }
            
        }
        
    }

