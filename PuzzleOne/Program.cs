using PinNotify;
using System;
using System.Text;

namespace PuzzleOne
{
    class Program
    {
        /*****************************************
         * Welcome to Engineering Lesson 1!
         * 
         * By now, you're trying to find out why your phone won't work.  That's easy - I've changed the PIN number :)
         * Now, it's time for you to learn how to solve a problem that you have to do some reverse engineering on...
         * 
         * You need to solve the issues using code in the function below to uncover your new PIN.
         * First, you need to analyze the problem (other than your phone not working).  Next, you will need to successfully 
         * use the supplied file, read the data FROM the file, and get your new PIN.  Copying the string from the file will not work - you have to process the file. 
         * 
         * The file is located on C:\Users\Public\Keyfile.txt.  Don't delete it, or you'll NEVER be able to unlock your phone.
         * 
         * Starter Hint - The string has been encrypted using Base64 logic.  To decrypt it, I suggest using Google to look for your answers.
         * 
         * Here's a few helpful tutorials:
         *  Convert Method:  https://docs.microsoft.com/en-us/dotnet/api/system.convert?view=netframework-4.8
         *  Streamreader: https://docs.microsoft.com/en-us/dotnet/standard/io/how-to-read-text-from-a-file
         *  
         * And some basics as well about the C# language:
         * TutorialsPoint: https://www.tutorialspoint.com/csharp/
         * 
         * Use ALL of your resources.  ALL of your resources (another hint...)
         * 
         * Good Hunting!
         ***************************************/


        static void Main(string[] args)
        {
            //TODO - SOLUTION GOES BELOW HERE
            string AlexisPw = "";
            string AlexisPwUnencrypted = "";


            //TODO - solution goes below
            Console.WriteLine(String.Format("The Encrypted string is {0} ", AlexisPw));
            Console.WriteLine(String.Format("The Decrypted string is {0} ", AlexisPwUnencrypted));

        }
    }
}
