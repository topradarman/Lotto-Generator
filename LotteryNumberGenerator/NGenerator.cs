using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryNumberGenerator
{
    class NGenerator
    {
        
        


        //============ new

        //============ new


        private const int MAX_NUMBER = MAX_PB_NUMBER+1;       //private const int MAX_NUMBER = 46;
        private const int MIN_NUMBER = 1;        //private const int MIN_NUMBER = 1;
        private const int MAX_PB_NUMBER = 45;    //private const int MAX_PB_NUMBER = 45;     
        private Random numGen1 = new Random();
        private Random numGen2 = new Random();

        

        //Generate and return a number between max and min numbers.
        public int generateNum1()
        {
            int number = numGen1.Next(MIN_NUMBER, MAX_NUMBER);     //int number = numGen1.Next(MIN_NUMBER, MAX_NUMBER);
            return number;
        }



        //Generate and return PowerBall Number.
        public int generatePBNum1()
        {
            int number = numGen1.Next(MIN_NUMBER, MAX_PB_NUMBER);
            return number;
        }

    }
}
