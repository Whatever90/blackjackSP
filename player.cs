using System.Collections.Generic;
using System;
namespace cards{
    public class Player{
        public string name;
        public List<Card> hand = new List<Card>();
        public Player(string _name){
            name = _name;
        }
        public void showme(){
            Console.WriteLine("+++++++++++++++++++++++++");
            Console.WriteLine("{0} has: ", name);
            foreach(Card x in hand){
                Console.WriteLine(x.valueandsuit);
            }
        }
        public int counter(){
            int sum = 0;
            foreach(Card k in hand){
                sum+=k.val;
            }
            return sum;
        }
        public void enterthegame(Deck x){
            Card y = x.deal();
            if(y.val==1){
                Console.WriteLine("Seems like you've got an Ace. What value do you want it to be? 1 or 11?");
                string res = Console.ReadLine();
                if(res=="11"){
                    y.val=11;
                }
            }
            hand.Add(y);
            Card z = x.deal();
            if(z.val==1){
                Console.WriteLine("Seems like you've got an Ace. What value do you want it to be? 1 or 11?");
                string res = Console.ReadLine();
                if(res=="11"){
                    z.val=11;
                }
            }
            hand.Add(z);
            int sum = 0;
            foreach(Card k in hand){
                sum+=k.val;
            }
            
        }
        public Card draw(Deck x){
            Card y = x.deal();
            Console.WriteLine("+++++++++++++++++++++++++");
            
            Console.WriteLine(y.valueandsuit);
            if(y.val==1){
                Console.WriteLine("Seems like you've got an Ace. What value do you want it to be? 1 or 11?");
                string res = Console.ReadLine();
                if(res=="11"){
                    y.val=11;
                }
            }
            Console.WriteLine("+++++++++++++++++++++++++");
            hand.Add(y);
            return y;
        }

        public Card discard(int dis){
            Card temp = null;
            if(hand[dis]!=null){
                temp = hand[dis];
                hand.RemoveAt(dis);
            }
            return temp;
        }
    }
}