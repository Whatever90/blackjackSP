using System.Collections.Generic;
using System;
namespace cards{
    public class Bot{
        public string name;
        public List<Card> hand = new List<Card>();
        public Bot(string _name){
            name = _name;
        }
        public void showme(){
            Console.WriteLine("+++++++++++++++++++++++++");
            Console.WriteLine("Player {0} has: ", name);
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
                if(counter()<10){
                    y.val=11;
                }
            }
            hand.Add(y);
            Card z = x.deal();
            if(z.val==1){
                if(counter()<10){
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
            if(y.val==1){
                if(counter()<10){
                    y.val=11;
                }
            }
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