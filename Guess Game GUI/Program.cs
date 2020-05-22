using System;
using System.Linq;

namespace Exercise1402
{
    class Guess
    {
        private string answer;
        private int acount, bcount;

        public string Answer
        {
            get { return answer; }
            set { answer = value; }
        } 

        public int ACount
        {
            get { return acount; }
            set { acount = value; }
        }

        public int BCount
        {
            get { return bcount; }
            set { bcount = value; }
        }

        public Guess(int digit = 4)
        {
            string number = "1234567890";
            bool invaildNumber = true;

            while (invaildNumber)
            {
                Answer = this.Shuffle(number).Substring(0, digit);
                if (Answer[0] == 48)
                    invaildNumber = true;
                else
                    invaildNumber = false;
            }
            acount = 0;
            bcount = 0;
        }

        public void ABCounter(string guess)
        {
            foreach(char c in guess)
            {
                if (Answer.Contains(c))
                {
                    if (guess.IndexOf(c) == Answer.IndexOf(c))
                        acount++;
                    else
                        bcount++;
                }
            }
        }

        public bool FindNumber(string number)
        {
            bool vaildInput = true;
            int iterator = 0;

            if (number.Length != Answer.Length)
            {
                vaildInput = false;
                Console.WriteLine("Please enter a vaild number.");
            }

            foreach (char c in number)
            {
                foreach (char i in number)
                {
                    if (c == i)
                        iterator++;
                }

                if (iterator > 1)
                {
                    vaildInput = false;
                    Console.WriteLine("You enter a number with repeat charater.");
                }
                iterator = 0;
            }
            return vaildInput;
        }

        public string Shuffle(string s)
        {
            int n = s.Length;
            Random r = new Random();
            char[] ca = s.ToCharArray();
            
            while (n > 1)
            {
                n--;
                int k = r.Next(n + 1);
                var v = ca[k];
                ca[k] = ca[n];
                ca[n] = v;
            }
            return new string(ca);
        }
    }
}
