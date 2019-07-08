using System;
using System.Collections.Generic;
using System.Text;

namespace GalinasSideProject2._0.Classes
{
    public class Oracle
    {
        public List<Card> oracleHand = new List<Card>();
        public OraclesMotivator internalMotivator = new OraclesMotivator();

        //The worst possible case is a hand with no land, and this method checks for that case.

        //These methods check to make sure an opening hand has at least one land, and at least one desireable card to play.
        public bool DetectTurnOneAetherVial(List<Card> playerHand)
        {
            bool handHasLand = false;
            bool handHasAetherVial = false;
            this.oracleHand = playerHand;
            
            foreach(Card card in playerHand)
            {
                if(card.IsLand == true)
                {
                    handHasLand = true;
                }
            }
            foreach (Card card in playerHand)
            {
                if (card.Name == "Aether Vial")
                {
                    handHasAetherVial = true;
                }
            }
            if(handHasAetherVial == true && handHasLand == true)
            {
                return true;
            }
            return false;
        }
        public bool DetectTurnOneChampion(List<Card> playerHand)
        {
            bool handHasLand = false;
            bool handHasChampion = false;
            this.oracleHand = playerHand;

            foreach (Card card in playerHand)
            {
                if (card.IsLand == true)
                {
                    handHasLand = true;
                }
            }
            foreach (Card card in playerHand)
            {
                if (card.Name == "Champion of the Parish")
                {
                    handHasChampion = true;
                }
            }
            if (handHasChampion == true && handHasLand == true)
            {
                return true;
            }
            return false;

        }
        public bool DetectTurnOneInspector(List<Card> playerHand)
        {
            bool handHasLand = false;
            bool handHasInspector = false;
            this.oracleHand = playerHand;

            foreach (Card card in playerHand)
            {
                if (card.IsLand == true)
                {
                    handHasLand = true;
                }
            }
            foreach (Card card in playerHand)
            {
                if (card.Name == "Thraben Inspector")
                {
                    handHasInspector = true;
                }
            }
            if (handHasInspector == true && handHasLand == true)
            {
                return true;
            }
            return false;
        }
        public bool DetectTurnOneNobleHierarch(List<Card> playerHand)
        {
            bool handHasLand = false;
            bool handHasHierarch = false;
            this.oracleHand = playerHand;

            foreach (Card card in playerHand)
            {
                if (card.IsLand == true)
                {
                    handHasLand = true;
                }
            }
            foreach (Card card in playerHand)
            {
                if (card.Name == "Noble Hierarch")
                {
                    handHasHierarch = true;
                }
            }
            if (handHasHierarch == true && handHasLand == true)
            {
                return true;
            }
            return false;
        }



        public bool DetectTurnOnePlay(List<Card> playerHand, List<Card> battlefield)
        {
            bool recommendTurnOneVial = false;
            bool recommendTurnOneChampion = false;
            bool recommendTurnOneHierarch = false;
            bool recommendTurnOneInspector = false;
            recommendTurnOneVial = DetectTurnOneAetherVial(playerHand);
            if (recommendTurnOneVial == true)
            {
                internalMotivator.PlayAnAetherVialTurnOne(playerHand, battlefield);
            }
            if (recommendTurnOneVial == false)
            {
                recommendTurnOneChampion = DetectTurnOneChampion(playerHand);
                if (recommendTurnOneChampion == true)
                {

                    
                    internalMotivator.PlayAChampionTurnOne(playerHand, battlefield);
                }

            }
            if (recommendTurnOneChampion == false && recommendTurnOneVial == false)
            {
                recommendTurnOneHierarch = DetectTurnOneNobleHierarch(playerHand);
                if (recommendTurnOneHierarch == true)
                {
                    internalMotivator.PlayANobleHierarchTurnOne(playerHand, battlefield);
                }
            }
            if (recommendTurnOneChampion == false && recommendTurnOneVial == false && recommendTurnOneHierarch == false)
            {
                recommendTurnOneInspector = DetectTurnOneInspector(playerHand);
                if (recommendTurnOneInspector == true)
                {
                    internalMotivator.PlayAnInspectorTurnOne(playerHand, battlefield);
                }
            }
            if(recommendTurnOneVial == true || recommendTurnOneChampion == true || recommendTurnOneHierarch == true ||
                recommendTurnOneInspector == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
