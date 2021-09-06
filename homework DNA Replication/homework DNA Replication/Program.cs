using System;

namespace homework_DNA_Replication
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDNA = Console.ReadLine();
            bool IsvalidSeq = IsvalidSequence(inputDNA);

            if (IsvalidSeq == true)
            {
                Console.Write("Current half DNA sequence : ");
                Console.WriteLine(inputDNA);
                Console.Write("Do you want to replicate it ? (Y/N) : ");
                string confirmReplicate = Console.ReadLine();

                while(confirmReplicate!="Y"&&confirmReplicate!="N")
                {
                    confirmYorN(IsvalidSeq);
                }
                if (confirmReplicate == "Y")
                {
                    string ReplicatedhalfDNA = ReplicateSequence(inputDNA);
                    Console.Write("Replicated half DNA sequence: ");
                    Console.WriteLine(ReplicatedhalfDNA);

                    Console.Write("Do you want to process another sequence ? (Y/N) : ");
                    string confirmProcess = Console.ReadLine();
                    if (confirmProcess == "Y")
                    {
                        process();
                    }
                    else if (confirmProcess == "N")
                    {
                        IsvalidSeq = false;
                    }
                    else
                    {
                        confirmYorN(IsvalidSeq);
                        
                    }

                }
                else if(confirmReplicate == "N")
                {

                }
                
            }
            else if (IsvalidSeq == false)
            {
                if (!IsvalidSeq)
                {
                    Console.WriteLine("That half DNA sequence is invalid.");

                }
                Console.Write("Do you want to process another sequence ? (Y/N) : ");
                string confirmProcess = Console.ReadLine();
                if (confirmProcess == "Y")
                {
                    process();
                }
                else if (confirmProcess == "N")
                {
                    IsvalidSeq = false;
                }
                else
                {
                    confirmYorN(IsvalidSeq);
                }
            }
            Console.ReadLine();
        }
        static bool IsvalidSequence(string halfDNASequence)
        {
            foreach(char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }
        static string ReplicateSequence(string halfDNASequence)
        {
            string result = "";
            foreach(char nucleotide in halfDNASequence)
            {
                result += "TACG"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }
        static void process()
        {
            string inputDNA = Console.ReadLine();
            bool IsvalidSeq = IsvalidSequence(inputDNA);

            if (IsvalidSeq == true)
            {
                Console.Write("Current half DNA sequence : ");
                Console.WriteLine(inputDNA);
                Console.Write("Do you want to replicate it ? (Y/N) : ");
                string confirmReplicate = Console.ReadLine();
                confirmYorNRep(IsvalidSeq, inputDNA);
                while(confirmReplicate!="Y"&&confirmReplicate!="N")
                {
                    confirmYorN(IsvalidSeq);
                }

                if (confirmReplicate == "Y")
                {
                    string ReplicatedhalfDNA = ReplicateSequence(inputDNA);
                    Console.Write("Replicated half DNA sequence: ");
                    Console.WriteLine(ReplicatedhalfDNA);

                    Console.Write("Do you want to process another sequence ? (Y/N) : ");
                    string confirmProcess = Console.ReadLine();
                    if (confirmProcess == "Y")
                    {
                        process();
                    }
                    else if (confirmProcess == "N")
                    {
                        IsvalidSeq = false;
                    }
                    else
                    {
                        confirmYorNRep(IsvalidSeq, inputDNA);

                    }

                }
                else if (confirmReplicate == "N")
                {
                    IsvalidSeq = false;
                }
                else
                {

                }

            }
            else if (IsvalidSeq == false)
            {
                if (!IsvalidSeq)
                {
                    Console.WriteLine("That half DNA sequence is invalid.");

                }
                Console.Write("Do you want to process another sequence ? (Y/N) : ");
                string confirmProcess = Console.ReadLine();
                if (confirmProcess == "Y")
                {
                    process();
                }
                else if (confirmProcess == "N")
                {
                    IsvalidSeq = false;
                }
                else
                {
                    confirmYorN(IsvalidSeq);
                }
            }
        }
        
        static void confirmYorN(bool IsvalidSeq)
        {

            Console.WriteLine("Please input Y or N.");
            string input = Console.ReadLine();
            if (input == "Y")
            {
                process();
            }if (input == "N")
            {
                Console.Write("Do you want to process another sequence ? (Y/N) : ");
                string confirmProcess = Console.ReadLine();
                if (confirmProcess == "Y")
                {
                    process();
                }
                else if (confirmProcess == "N")
                {
                    IsvalidSeq = false;
                }
                else
                {
                    confirmYorN(IsvalidSeq);
                }
            }
        }
        static void confirmYorNRep(bool IsvalidSeq,string inputDNA)
        {
            Console.WriteLine("Please input Y or N.");
            Console.Write("Do you want to replicate it ? (Y/N) : ");
                string confirmReplicate = Console.ReadLine();

                
                if (confirmReplicate == "Y")
                {
                    string ReplicatedhalfDNA = ReplicateSequence(inputDNA);
                    Console.Write("Replicated half DNA sequence: ");
                    Console.WriteLine(ReplicatedhalfDNA);

                    Console.Write("Do you want to process another sequence ? (Y/N) : ");
                    string confirmProcess = Console.ReadLine();
                    if (confirmProcess == "Y")
                    {
                        process();
                    }
                    else if (confirmProcess == "N")
                    {
                        IsvalidSeq = false;

                    }
                    else
                    {
                        confirmYorNRep(IsvalidSeq, inputDNA);

                    }

                }
                else if (confirmReplicate == "N")
                {
                    IsvalidSeq = false;
                Console.Write("Do you want to process another sequence ? (Y/N) : ");
                string confirmProcess = Console.ReadLine();
                if (confirmProcess == "Y")
                {
                    process();
                }
                else if (confirmProcess == "N")
                {
                    IsvalidSeq = false;
                }
                else
                {
                    confirmYorN(IsvalidSeq);
                }

                }
                else
                {

                }
        }
    }   
         
}
