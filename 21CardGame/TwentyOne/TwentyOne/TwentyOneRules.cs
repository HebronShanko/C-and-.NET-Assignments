﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneRules
    {
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Two]=2,
            [Face.Three]=3,
            [Face.Four]=4,
            [Face.Five]=5,
            [Face.Six]=6,
            [Face.Seven]=7,
            [Face.Eight]=8,
            [Face.Nine]=9,
            [Face.Ten]=10,
            [Face.Jack]=10,
            [Face.Queen]=10,
            [Face.King]=10,
            [Face.Ace]=1
        };

        public static int[] GetAllPossibleHandValue(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace);
            int[] result = new int[aceCount + 1];
            int value = Hand.Sum(x => _cardValues[x.Face]);
            result[0] = value;
            if (result.Length == 1) return result;

            for (int i = 1; i < result.Length; i++)
            {
                value += value + (i * 10);
                result[i] = value;
            }
            return result;

        }

        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValue(Hand);
            int value = possibleValues.Max();
            if (value == 21) return true;
            else return false;
        }

        public static bool isBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValue(Hand).Min();
            if (value > 21) return true;
            else return false;
        }

        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValue = GetAllPossibleHandValue(Hand);
            foreach (int value in possibleHandValue)
            {
                if (value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool? compareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValue(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValue(DealerHand);

            int playerScore = playerResults.Where(x => x < 22).Max();
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;

        }
    }
}
