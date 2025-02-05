using System.Diagnostics;
using CardLib;

Deck myDeck = new Deck();
myDeck.Shuffle();
Card[] myHand = new Card[5];


DrawFiveCards(myDeck);


 void DrawFiveCards(Deck deck)
 {

    for (int i = 0; i < 5; i++)
    {
        Card myCard = deck.GetCard(i);
        myHand[i] = myCard;
        Console.WriteLine(myHand[i]);
    }
}

