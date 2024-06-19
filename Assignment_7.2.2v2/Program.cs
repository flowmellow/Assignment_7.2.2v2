using System.Security.Cryptography.X509Certificates;

namespace Assignment_7._2._2v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "hello";
            string text2 = "avacado";
            string text3 = "intelligent";

            SwapVowels swapVowels = new SwapVowels();

            string output = swapVowels.Swap(text3);

            Console.WriteLine(output);
        }

        static bool IsVowel(char c) // set up method to check for vowel in while loop. Helps reduce retyping long condition.
        {
            return (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                 c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U');

        }
        public class SwapVowels
        {
            public string Swap(string text)
            {               
             
                int i = 0; // set up i to act as left pointer
                int j = text.Length - 1; //set up j to act as right pointer
                char[] newString = text.ToCharArray(); // converted string argument to char[] array for ease of evaluation in the while loop condition

                while (i < j) // condition is set because as long as ther are characters remaining i will be less than j
                {
                    if (!IsVowel(newString[i])) // passes char array indexed value to IsVowel method. If it is a vowel the index will remain 0.
                                                // if it is not a vowel the condition is true and the if statement will be entered to increment i.
                    {
                        i++;
                        continue;
                    }

                    if (!IsVowel(newString[j]))// passes char array indexed value to IsVowel method. If it is a vowel the index will remain 0.
                                               // if it is not a vowel the condition is true and the if statement will be entered to increment j.
                    {
                        j--;
                        continue;
                    }

                    char temp = newString[i]; //if there was a vowel in i then it is assigned to a temp location
                    newString[i] = newString[j]; // a vowel from the rear of the array in the j position is then assigned the i position
                    newString[j] = temp;// places stored i value into j position

                    i++; //this icrements from the last i position. either from vowel replaced or through the last iteration of i
                    j--; //this decrements from the last j position. either from vowel replaced or through the last iteration of j
                }

                string output = String.Join("", newString);
                return output;

               
            }
                


            

        }
    }
}
