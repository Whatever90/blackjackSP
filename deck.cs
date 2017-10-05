using System.Collections.Generic;
using System;
namespace cards{
    public class Deck{
        List<Card> kards = new List<Card>();
        public string[] values;
        public string[] suites;
        public Deck(string[] vals, string[] _suites){
            values= vals;
            suites = _suites;
            kards = populate();    
        }
        public List<Card> populate(){
            List<Card> kards1 = new List<Card>();
            for(int i = 0; i<13; i++){
                for(int g = 0; g<4; g++){
                    //Console.WriteLine(values[i]+suites[g]);
                    int tempval = i+1;
                    if(values[i]=="Jack"||values[i]=="Queen"||values[i]=="King"){
                        tempval = 10;
                    }
                    Card temp = new Card(values[i] +" "+ suites[g], tempval);
                    kards1.Add(temp);
                }
            }
            return kards1;
        }
        public Card deal(){
            Card newKard = new Card(kards[0].valueandsuit, kards[0].val);
            kards.RemoveAt(0);

            return newKard;
        }
        public void reset(){
            kards = populate();
        }
        public void shuffle() {
            int n = kards.Count;
            Random rnd = new Random();
            while (n > 1) {
                int k = (rnd.Next(0, n) % n);
                n--;
                Card value = kards[k];
                kards[k] = kards[n];
                kards[n] = value;
            }
        }
    }
}