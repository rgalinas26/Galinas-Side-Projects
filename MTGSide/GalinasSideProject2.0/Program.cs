using GalinasSideProject2._0.Classes;
using System;
using System.Collections.Generic;

namespace GalinasSideProject2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck humansDeck = new Deck();
            Oracle oracle = new Oracle();
            OraclesMotivator oraclesMotivator = new OraclesMotivator();
            
            List<string> deckToDisplay = new List<string>();
            List<Card> playerOneHand = new List<Card>();
            List<Card> battlefield = new List<Card>();
            humansDeck.Build();
            humansDeck.Shuffle(); 
            for(int i = 1; i < 8; i++)
            {
                playerOneHand.Add(humansDeck.Deal());
            }

            Console.WriteLine("Your opening hand is: ");
            Console.WriteLine("\t");
            foreach (Card card in playerOneHand)
            {
                
                Console.WriteLine(card.Name);
            }

            
            for(bool firstTurnPlay = false; firstTurnPlay == false;)
            {
                firstTurnPlay = oracle.DetectTurnOnePlay(playerOneHand, battlefield);
                if(firstTurnPlay == false)
                {
                    Console.WriteLine("\t");
                    Console.WriteLine("Well, you've drawn a hand that isn't recommended to keep as a beginner. If you take a look," +
                    " the hand has no lands in it or it has no cards to play on turn one. " +
                    "There are cases in which an advanced player would keep such a hand, but for now let's shuffle your card back" +
                    "into the deck and get you a new hand.");
                    playerOneHand.Clear();
                    humansDeck.Clear();
                    humansDeck.Build();
                    humansDeck.Shuffle();
                    for (int i = 1; i < 8; i++)
                    {
                        playerOneHand.Add(humansDeck.Deal());
                    }
                    Console.WriteLine("\t");
                    Console.WriteLine("Your new hand is: ");
                    foreach (Card card in playerOneHand)
                    {

                        Console.WriteLine(card.Name);
                    }
                }
            }
            #region Old turn One recommendations now commented out. These existed prior to the problem of a looping amount of bad hands
            //bool recommendTurnOneVial = false;
            //bool recommendTurnOneChampion = false;
            //bool recommendTurnOneHierarch = false;
            //bool recommendTurnOneInspector = false;
            //recommendTurnOneVial = oracle.DetectTurnOneAetherVial(playerOneHand);
            //if (recommendTurnOneVial == true)
            //{
            //    Console.WriteLine("\t");
            //    Console.WriteLine("The Oracle recommends that you play a land and an Aether Vial on turn one. " +
            //        "The Oracle indicates that you have at least one land in hand, so you can produce enough mana to cast an Aether Vial. " +
            //        "Aether Vial gains a counter for each turn it is on the battlefield, but only when it is on the battlefield. The counters " +
            //        "on Aether Vial represent a number, and if that number matches the converted mana cost of a creature card in your hand, you " +
            //        "may tap Aether Vial and play that card for free. This is a powerful ability, but because of the speed of the format that this " +
            //        "deck exists in playing Aether Vial on later turns is typically too slow to be a winning play.");
            //    oraclesMotivator.PlayAnAetherVialTurnOne(playerOneHand, battlefield);

            //}
            //if (recommendTurnOneVial == false)
            //{
            //    recommendTurnOneChampion = oracle.DetectTurnOneChampion(playerOneHand);
            //    if(recommendTurnOneChampion == true)
            //    {
            //        Console.WriteLine("\t");
            //        Console.WriteLine("The Oracle recommends that you play Champion of the Parish on turn one. Champion of the Parish is a" +
            //            "cheap spell to play and has a high up-side. Champion of the Parish will grow stronger the more humans you play, " +
            //            "and since this deck's creatures are all humans, the Champion will grow large.");
            //        oraclesMotivator.PlayAChampionTurnOne(playerOneHand, battlefield);
            //    }

            //}
            //if (recommendTurnOneChampion == false && recommendTurnOneVial == false)
            //{
            //    recommendTurnOneHierarch = oracle.DetectTurnOneNobleHierarch(playerOneHand);
            //    if(recommendTurnOneHierarch == true)
            //    {
            //        Console.WriteLine("The oracle recommends that you play Noble Hierarch on turn one. Noble Hierarch is a medium-power" +
            //            "turn one play. The card has an ability called \"Exalted\" which gives any creature that attacks alone" +
            //            "one extra power. That means that you can chip in a bit more damage against your opponent. In a fast format" +
            //            "such as modern, this can often times be the differenc between a win and a loss.");
            //        oraclesMotivator.PlayANobleHierarchTurnOne(playerOneHand, battlefield);
            //    }
            //}
            //if (recommendTurnOneChampion == false && recommendTurnOneVial == false && recommendTurnOneHierarch == false)
            //{
            //    recommendTurnOneInspector = oracle.DetectTurnOneInspector(playerOneHand);
            //    if(recommendTurnOneInspector == true)
            //    {
            //        Console.WriteLine("The Oracle recommends that you play Thraben Inspector on turn one. Thraben is the weakest possibly" +
            //            "turn one play aside from playing nothing, but it still has value. Thraben Insepctor creates a clue token when it" +
            //            "enters the battlefield, which would allow you to draw another card (if that feature was implemented)");
            //        oraclesMotivator.PlayAnInspectorTurnOne(playerOneHand, battlefield);
            //    }
            //}

            ////What about a case where the person gets a bad hand over and over?
            //if (recommendTurnOneChampion == false && recommendTurnOneVial == false && recommendTurnOneHierarch == false
            //    && recommendTurnOneInspector == false)
            //{
            //    Console.WriteLine("Well, you've drawn a hand that isn't recommended to keep as a beginner. If you take a look," +
            //        " the hand has no lands in it or it has no cards to play on turn one. " +
            //        "There are cases in which an advanced player would keep such a hand, but for now let's shuffle your card back" +
            //        "into the deck and get you a new hand.");
            //    playerOneHand.Clear();
            //    humansDeck.Clear();
            //    humansDeck.Build();
            //    humansDeck.Shuffle();
            //    for (int i = 1; i < 8; i++)
            //    {
            //        playerOneHand.Add(humansDeck.Deal());
            //    }

            //    Console.WriteLine("Your new hand is: ");
            //    foreach (Card card in playerOneHand)
            //    {

            //        Console.WriteLine(card.Name);
            //    }
            //     recommendTurnOneVial = false;
            //     recommendTurnOneChampion = false;
            //     recommendTurnOneHierarch = false;
            //     recommendTurnOneInspector = false;
            //    //Need to implement cases of Noble Hierarch and No Turn one play and No land
            //    recommendTurnOneVial = oracle.DetectTurnOneAetherVial(playerOneHand);
            //    if (recommendTurnOneVial == true)
            //    {
            //        Console.WriteLine("\t");
            //        Console.WriteLine("The Oracle recommends that you play a land and an Aether Vial on turn one. " +
            //            "The Oracle indicates that you have at least one land in hand, so you can produce enough mana to cast an Aether Vial. " +
            //            "Aether Vial gains a counter for each turn it is on the battlefield, but only when it is on the battlefield. The counters " +
            //            "on Aether Vial represent a number, and if that number matches the converted mana cost of a creature card in your hand, you " +
            //            "may tap Aether Vial and play that card for free. This is a powerful ability, but because of the speed of the format that this " +
            //            "deck exists in playing Aether Vial on later turns is typically too slow to be a winning play.");
            //        oraclesMotivator.PlayAnAetherVialTurnOne(playerOneHand, battlefield);

            //    }
            //    if (recommendTurnOneVial == false)
            //    {
            //        recommendTurnOneChampion = oracle.DetectTurnOneChampion(playerOneHand);
            //        if (recommendTurnOneChampion == true)
            //        {
            //            Console.WriteLine("\t");
            //            Console.WriteLine("The Oracle recommends that you play Champion of the Parish on turn one. Champion of the Parish is a" +
            //                "cheap spell to play and has a high up-side. Champion of the Parish will grow stronger the more humans you play, " +
            //                "and since this deck's creatures are all humans, the Champion will grow large.");
            //            oraclesMotivator.PlayAChampionTurnOne(playerOneHand, battlefield);
            //        }

            //    }
            //    if (recommendTurnOneChampion == false && recommendTurnOneVial == false)
            //    {
            //        recommendTurnOneHierarch = oracle.DetectTurnOneNobleHierarch(playerOneHand);
            //        if (recommendTurnOneHierarch == true)
            //        {
            //            Console.WriteLine("The oracle recommends that you play Noble Hierarch on turn one. Noble Hierarch is a medium-power" +
            //                "turn one play. The card has an ability called \"Exalted\" which gives any creature that attacks alone" +
            //                "one extra power. That means that you can chip in a bit more damage against your opponent. In a fast format" +
            //                "such as modern, this can often times be the differenc between a win and a loss.");
            //            oraclesMotivator.PlayANobleHierarchTurnOne(playerOneHand, battlefield);
            //        }
            //    }
            //    if (recommendTurnOneChampion == false && recommendTurnOneVial == false && recommendTurnOneHierarch == false)
            //    {
            //        recommendTurnOneInspector = oracle.DetectTurnOneInspector(playerOneHand);
            //        if (recommendTurnOneInspector == true)
            //        {
            //            Console.WriteLine("The Oracle recommends that you play Thraben Inspector on turn one. Thraben is the weakest possibly" +
            //                "turn one play aside from playing nothing, but it still has value. Thraben Insepctor creates a clue token when it" +
            //                "enters the battlefield, which would allow you to draw another card (if that feature was implemented)");
            //            oraclesMotivator.PlayAnInspectorTurnOne(playerOneHand, battlefield);
            //        }



            //    }

            //}

            #endregion
            Console.WriteLine("\t");
            Console.WriteLine("The cards currently on the battlefield are: ");
            Console.WriteLine("\t");
            //For testing purposes, writes the names of the cards on the battlefield. Currently should only display the Oracle's turn one hand.
            foreach(Card card in battlefield)
            {
                Console.WriteLine(card.Name);               
            }
            Console.WriteLine("\t");
            foreach(Card card in battlefield)
            {
                if (card.Name == "Aether Vial")
                {
                    Console.WriteLine("\t");
                    Console.WriteLine("The Oracle decided to play a turn one Aether Vial. An Aether Vial is best played on turn one " +
                        "or soon after. The card gains counters each turn, and will allow you to play a a creature for free that " +
                        "has the same converted mana cost as the number of counters on Aether Vial. Aether Vial's value diminishes " +
                        "the long the game goes on. This is because the modern format is very fast. You may also have noticed that " +
                        "the oracle played a land. Logic for specific lands is not currently implemented, but know that each land " +
                        "in the deck will allow you to play cards on turn one. For now, just get used to what the cards themselves do.");
                }
                if (card.Name == "Champion of the Parish")
                {
                    Console.WriteLine("The Oracle decided to play a turn one Champion of the Parish (nicknamed Parish Champ)." +
                        " Parish Champ is a creature card that starts with one power, but it gains one power and toughness for " +
                        "each human that enters the battlefield after it. Parish Champ is the true hero of the deck, and often does a " +
                        "vast amount of damage to opponents if it is not removed. Parish Champ is best played on turn one or soon after, " +
                        "but it does not lose the same amount of value that Aether Vial does if Aether Vial is not played early. " +
                        "You may also have noticed that the oracle played a land. Logic for specific lands is not currently implemented, " +
                        "but know that each land in the deck will allow you to play cards on turn one. " +
                        "For now, just get used to what the cards themselves do.");
                }
                if (card.Name == "Noble Hierarch")
                {
                    Console.WriteLine("The Oracle decided that a Noble Hierarch should be played on turn one. Noble Hierarch is " +
                        "unassuming on its face, but it packs serious power. Noble Hierarch can be used to add one mana to your mana " +
                        "pool, and that mana can be used to play additional creatues. Noble Hierarch also has the ability " +
                        " \"Exalted\". The Exalted ability gives any creature that attacks alone one extra power. In fast format" +
                        " like modern each point of damage matters, and Hierarch helps to chip in extra damage. You may have noticed " +
                        "that the Oracle also played a land card. Logic for playing specific land is not currently implemented " +
                        "as every land in the deck will allow you to play cards, and specific land play is an advanced topic.");
                }
                if (card.Name == "Thraben Inspector")
                {
                    Console.WriteLine("The Oracle has decided to play a Thraben Inspector on turn one. Thraben is your weakest turn one " +
                        "play, but it helps to practice sub-optimal lines. Thraben is a relatively weak creature, but it is a creature, so " +
                        "it will interact with our other human creatures well, and it creates a \"Clue\" token. The Clue token can " +
                        "be sacrificed to draw a card. You may have noticed that the Oracle also played a land on turn one. Logic " +
                        "for playing specific lands has not been implemented at this time, but suffice it to say that each land can play " +
                        "any card in the deck, and you should always play a land if you can except in advanced cases. Since this is a basic" +
                        " learning tool, focus on learning how the cards in the deck interact.");
                }
            }
            


            Console.ReadKey();
          
        }
    }
}
