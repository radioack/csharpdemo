using System;
using System.Collections.Generic;
using System.Linq;

namespace csharpDemo
{
    class Program
    {
        static IEnumerable<string> Suits()
        {
            yield return "clubs";
            yield return "diamonds";
            yield return "hearts";
            yield return "spades";
        }

        static IEnumerable<string> Ranks()
        {
            yield return "two";
            yield return "three";
            yield return "four";
            yield return "five";
            yield return "six";
            yield return "seven";
            yield return "eight";
            yield return "nine";
            yield return "ten";
            yield return "jack";
            yield return "queen";
            yield return "king";
            yield return "ace";
        }
        static void Main(string[] args)
        {
            var startingDeck = Suits().SelectMany(suit => Ranks().Select(rank => new { Suit = suit, Rank = rank }));

            foreach (var card in startingDeck)
            {
                Console.WriteLine(card);
            }

            // var takenCards = startingDeck.Take(10);
            // foreach (var card in takenCards)
            // {
            //     Console.WriteLine(card);
            // }

            // var skippedCards = startingDeck.Skip(5);
            // foreach (var card in skippedCards)
            // {
            //     Console.WriteLine(card);
            // }

            // var chaining = startingDeck.Skip(5).Take(3);
            // foreach (var card in chaining)
            // {
            //     Console.WriteLine(card);
            // }

            // var findSpecificNumberCards = startingDeck.Where(card => card.Rank == "three" || card.Rank == "four");
            // foreach (var card in findSpecificNumberCards)
            // {
            //     Console.WriteLine(card);
            // }

            // var selectCard = from card in startingDeck where (card.Suit == "clubs") select card;
            // foreach (var card in selectCard)
            // {
            //     Console.WriteLine(card);
            // }
        }
    }
}
