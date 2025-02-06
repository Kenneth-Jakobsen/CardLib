using System.Diagnostics;
using CardLib;

Deck myDeck = new Deck();
myDeck.Shuffle();
Card[] hand = new Card[5];


DrawFiveCards(myDeck);
Flush(hand);


 void DrawFiveCards(Deck deck)
 {

    for (int i = 0; i < 5; i++)
    {
        Card myCard = deck.GetCard(i);
        hand[i] = myCard;
        Console.WriteLine(hand[i]);
    }
}

 void Flush(Card[] myhand)
 {
     if(myhand.Any(elem => elem.suit != myhand[0].suit))
     {
         Console.WriteLine("No flush");
     }
     else
     {
         Console.WriteLine("Flush");
     }
 }