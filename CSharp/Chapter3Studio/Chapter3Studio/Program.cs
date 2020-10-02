using System;
using System.Collections.Generic;
using System.IO;

namespace Chapter3Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            //String myString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            //Console.WriteLine("Enter a String: ");
            //String myString = Console.ReadLine();

            string myString = File.ReadAllText(@"..//..//..//Input.txt");
            Console.WriteLine(myString);

            Dictionary<char, int> myDictionary = new Dictionary<char, int>();
            char[] charactersInString = myString.ToLower().ToCharArray(); //toLower() -- Bonus mission #2

            foreach(char x in charactersInString)
            {
                //Bonus mission #3
                if(x == ' '  || x==',' || x == '.' || Char.IsDigit(x))
                {
                    continue;
                }

                if (myDictionary.ContainsKey(x))
                {
                    int count = myDictionary.GetValueOrDefault(x);
                    myDictionary[x] = count+1;
                }
                else
                {
                    myDictionary[x] = 1;
                }
            }
            foreach(KeyValuePair<char, int> eachChar in myDictionary) {
               Console.WriteLine(eachChar.Key + ": " + eachChar.Value );
            }
           
        }
    }
}
