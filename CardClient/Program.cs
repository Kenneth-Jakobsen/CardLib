using CardLib;


Deck myDeck = new Deck();
myDeck.Shuffle();

for (int i = 0; i < 52; i++)
{
    Card tempCard = myDeck.GetCard(i); 
    Console.WriteLine(tempCard);
}
