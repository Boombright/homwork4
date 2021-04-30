using System;

namespace Homework4
{
    class Program
    {
        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    Console.WriteLine("That half DNA sequence is invalid.");
                    Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
                    string choice = Console.ReadLine();
                    return false;
                }
            }
            return true;
        }
        static string ReplicateSeqeunce(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            Console.Write("Replicated half DNA sequence : ");
            Console.WriteLine(result);
            return result;
        }
        static void Main(string[] args)
        {
            string nucleotide;
            string replucate_choice;
            nucleotide = Console.ReadLine();
            IsValidSequence(nucleotide);
            Console.Write("Do you want to replicate it ? (Y/N) : ");
            replucate_choice = Console.ReadLine();
            if(replucate_choice == "Y")
            {
                ReplicateSeqeunce(nucleotide);
                Console.Write("Do you want to process another sequence ? (Y/N) : ");
                string choice = Console.ReadLine();
                if (choice == "Y")
                {
                    nucleotide = Console.ReadLine();
                    IsValidSequence(nucleotide);
                }
                else if (choice == "N")
                {
                    Console.ReadLine();
                }
            }
            else if (replucate_choice == "N")
            {
                Console.ReadLine();
            }
            else
                Console.WriteLine("Please input Y or N.");


        }
    }
}
/*if (!"ATCG".Contains(nucleotide))
{
Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
                string choice = Console.ReadLine();
                Console.WriteLine("Please type again to confirm.");
                while (choice == Console.ReadLine())
                {
                    if(choice == "Y")
                    {

                    }
                    else if (choice == "N")
                    {
                        Console.ReadLine();
                    }
                    else
                    Console.Write("Please input Y or N.");
                    choice = Console.ReadLine();
                }*/