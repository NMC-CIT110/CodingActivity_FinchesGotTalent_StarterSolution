using FinchAPI;
using System;

namespace CodingActivity_FinchesGotTalent_StarterSolution
{
    class Program
    {
        /// <summary>
        /// Finches Got Talent Application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // **************************************************
            //
            // Title: Finches Got Talent
            // Description: (add your description)
            // Application Type: Console
            // Author: (add your name)
            // Dated Created: (current date)
            // Last Modified:
            //
            // **************************************************

            //
            // create (instantiate) a new finch object
            //
            Finch myFinch;
            myFinch = new Finch();

            //
            // connect to the finch robot using the finch connect method
            //
            myFinch.connect();

            //
            // begin application code here
            //


            //
            // end application code here
            //

            //
            // disconnect from the finch robot using the finch disconnect method
            //
            myFinch.disConnect();
        }
    }
}
