using System;
namespace cards{
    public class Card{
        public string valueandsuit = "";
        public int val = 0;
        public Card(string x, int y){
            valueandsuit = x;
            val = y;
        }
        public string[] values = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
        public string[] suites = {"Clubs", "Spades", "Hearts", "Diamonds"};
        
    }
}