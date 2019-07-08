using System;
using System.Collections.Generic;
using System.Text;

namespace GalinasSideProject2._0.Classes
{
    public class OraclesMotivator
    {
        #region This region contains the logic for turn one plays
        //Methods with "TurnOne" at the end of the method name play the recommended card and a land on turn one. 
        public void PlayAnAetherVialTurnOne(List<Card> playerHand ,List<Card> battleField)
        {
            /*The existence of both a land and an Aether Vial in the player's hand (playerHand) are confirmed by the Detect family of functions
             * in the class Oracle. When this function finds the index location of the Aether Vial in playerHand the value of foundVial is set to true,
             *  and the value of indexOfFirstAetherVial is set to the value of i. 
             *  
             * A second for loop finds the first Card object in playerHand with a property isLand that is true. If a true
             * isLand property is found, the value of foundLand is set to true, and the indexOfFirstLand variable is set to the value of i.
             * 
             * The function then removes the two Card objects from playerHand to simulate the player playing those cards. The two Card objects are then
             * added to the list battleField, which represents the playing field in a game of Magic. 
             */
             
            int indexOfFirstAetherVial = 0;
            int indexOfFirstLand = 0;
            bool foundVial = false;
            bool foundLand = false;
            
            for(int i = 0; foundVial != true || i < playerHand.Count; i++)
            {
                if(playerHand[i].Name == "Aether Vial")
                {
                    indexOfFirstAetherVial = i;
                    foundVial = true;
                }
            }
            battleField.Add(playerHand[indexOfFirstAetherVial]);
            playerHand.RemoveAt(indexOfFirstAetherVial);
            for (int i = 0; foundLand != true || i < playerHand.Count; i++)
            {
                if (playerHand[i].IsLand == true)
                {
                    indexOfFirstLand = i;
                    foundLand = true;
                }
            }
            battleField.Add(playerHand[indexOfFirstLand]);
            playerHand.RemoveAt(indexOfFirstLand);
        }
        public void PlayAChampionTurnOne(List<Card> playerHand, List<Card> battleField)
        {
            /*The existence of both a land and an Champion of the Parish in the player's hand (playerHand) are confirmed by the Detect family 
             * of functions in the class Oracle. When this function finds the index location of the Champion of the Parish in playerHand
            * the index location of the Champion in playerHand the value of foundVial is set to true, and the value of indexOfFirstAetherVial 
            * is set to the value of i. 
            *    
            * A second for loop finds the first Card object in playerHand with a property isLand that is true. If a true
            * isLand property is found, the value of foundLand is set to true, and the indexOfFirstLand variable is set to the value of i.
            * 
            * The function then removes the two Card objects from playerHand to simulate the player playing those cards. 
            * The two Card objects are then added to the list battleField, which represents the playing field in a game of Magic. 
            * 
            */
            int indexOfFirstChampion = 0;
            int indexOfFirstLand = 0;
            bool foundChampion = false;
            bool foundLand = false;

            for (int i = 0; foundChampion != true || i < playerHand.Count; i++)
            {
                if (playerHand[i].Name == "Champion of the Parish")
                {
                    indexOfFirstChampion = i;
                    foundChampion = true;
                }
            }
            battleField.Add(playerHand[indexOfFirstChampion]);
            playerHand.RemoveAt(indexOfFirstChampion);
            for (int i = 0; foundLand != true || i < playerHand.Count; i++)
            {
                if (playerHand[i].IsLand == true)
                {
                    indexOfFirstLand = i;
                    foundLand = true;
                }
            }
            battleField.Add(playerHand[indexOfFirstLand]);
            playerHand.RemoveAt(indexOfFirstLand);

        }
        public void PlayANobleHierarchTurnOne(List<Card> playerHand, List<Card> battleField)
        {
            int indexOfFirstNoble = 0;
            int indexOfFirstLand = 0;
            bool foundNoble = false;
            bool foundLand = false;

            for (int i = 0; foundNoble != true || i < playerHand.Count; i++)
            {
                if (playerHand[i].Name == "Noble Hierarch")
                {
                    indexOfFirstNoble = i;
                    foundNoble = true;
                }
            }
            battleField.Add(playerHand[indexOfFirstNoble]);
            playerHand.RemoveAt(indexOfFirstNoble);
            for (int i = 0; foundLand != true || i < playerHand.Count; i++)
            {
                if (playerHand[i].IsLand == true)
                {
                    indexOfFirstLand = i;
                    foundLand = true;
                }
            }
            battleField.Add(playerHand[indexOfFirstLand]);
            playerHand.RemoveAt(indexOfFirstLand);
        }
        public void PlayAnInspectorTurnOne(List<Card> playerHand, List<Card> battleField)
        {
            /*The existence of both a land and a Thraben Inspector in the player's hand (playerHand) are confirmed by the Detect family 
            * of functions in the class Oracle. When this function finds the index location of the Thraben Inspector in playerHand
           * the index location of the Inspector in playerHand the value of foundVial is set to true, and the value of indexOfFirstAetherVial 
           * is set to the value of i. 
           *    
           * A second for loop finds the first Card object in playerHand with a property isLand that is true. If a true
           * isLand property is found, the value of foundLand is set to true, and the indexOfFirstLand variable is set to the value of i.
           * 
           * The function then removes the two Card objects from playerHand to simulate the player playing those cards. 
           * The two Card objects are then added to the list battleField, which represents the playing field in a game of Magic. 
           * 
           */
            int indexOfFirstInspector = 0;
            int indexOfFirstLand = 0;
            bool foundInspector = false;
            bool foundLand = false;

            for (int i = 0; foundInspector != true || i < playerHand.Count; i++)
            {
                if (playerHand[i].Name == "Thraben Inspector")
                {
                    indexOfFirstInspector = i;
                    foundInspector = true;
                }
            }
            battleField.Add(playerHand[indexOfFirstInspector]);
            playerHand.RemoveAt(indexOfFirstInspector);
            for (int i = 0; foundLand != true || i < playerHand.Count; i++)
            {
                if (playerHand[i].IsLand == true)
                {
                    indexOfFirstLand = i;
                    foundLand = true;
                }
            }
            battleField.Add(playerHand[indexOfFirstLand]);
            playerHand.RemoveAt(indexOfFirstLand);

        }
        #endregion
    }
}
