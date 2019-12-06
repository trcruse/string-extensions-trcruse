﻿using System;
using System.Collections.Generic;
using System.Linq;
using ExtensionMethods;

namespace StringExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> writings = new List<string>()
            {
                "foo",
                "bar",
                "A River Runs through It",
                "The Five-Year Itch",
                "The Bridges of Madison County",
                "a quick brown fox jumps over the lazy dog",
                "Four score and seven years ago our fathers brought forth on this continent, a new nation, conceived in Liberty, and dedicated to the proposition that all men are created equal.\n\nNow we are engaged in a great civil war, testing whether that nation, or any nation so conceived and so dedicated, can long endure. We are met on a great battle-field of that war. We have come to dedicate a portion of that field, as a final resting place for those who here gave their lives that that nation might live.It is altogether fitting and proper that we should do this.\n\nBut, in a larger sense, we can not dedicate—we can not consecrate—we can not hallow—this ground.The brave men, living and dead, who struggled here, have consecrated it, far above our poor power to add or detract.The world will little note, nor long remember what we say here, but it can never forget what they did here. It is for us the living, rather, to be dedicated here to the unfinished work which they who fought here have thus far so nobly advanced.It is rather for us to be here dedicated to the great task remaining before us—that from these honored dead we take increased devotion to that cause for which they gave the last full measure of devotion—that we here highly resolve that these dead shall not have died in vain—that this nation, under God, shall have a new birth of freedom—and that government of the people, by the people, for the people, shall not perish from the earth.",
                "Fox\nSocks\nBox\nKnox\n\nKnox in box.\nFox in socks.\n\nKnox on fox in socks in box.\n\nSocks on Knox and Knox in box.\n\nFox in socks on box on Knox."
            };

            Console.WriteLine("Fun with string extensions!");
            Console.WriteLine("---------------------------");


            foreach(string s in writings)
            {
                Console.WriteLine(s);
                Console.WriteLine($"Words: {s.WordCount()}");
                Console.WriteLine("---------------------------");
            }

            Console.WriteLine(writings[0].Capitalize());
            Console.WriteLine(writings[2].Capitalize());
            Console.WriteLine(writings[3].Capitalize());

            Console.WriteLine(writings[5].ToCamelCase());

            Console.WriteLine(writings[6].Smurf("our"));
        }
    }
}
