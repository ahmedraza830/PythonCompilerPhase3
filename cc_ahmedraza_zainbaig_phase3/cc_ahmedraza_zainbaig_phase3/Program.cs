using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc_ahmedraza_zainbaig_phase3
{
    class Program
    {
        static void Main(string[] args)
        {
            RDP w = new RDP();
        }

        class RDP
        {

            public RDP()
            {
                syntax = @"if x <= 5$"; //only for if and while @"while x <= 5$"
                lookAhead = syntax[count];
                MYWHILE();
                if (lookAhead == '$')
                {
                    Console.WriteLine("Correct Syntax and is Parsed Successfully");
                }
                else
                {
                    Console.WriteLine("Unsuccesfull Parsed");
                }
            }
            //public void MYWHILE()
            //{
            //    if (lookAhead == 'w')
            //    {
            //        Match('w');
            //        Match('h');
            //        Match('i');
            //        Match('l');
            //        Match('e');
            //        CONDITION();
            //        Match(':');

            //    }
            //}

            public void MYWHILE()
            {
                if (lookAhead == 'i')
                {
                    Match('i');
                    Match('f');

                    CONDITION();
                    Match(':');

                }
                else
                {
                    Match('w');
                    Match('h');
                    Match('i');
                    Match('l');
                    Match('e');
                    CONDITION();
                    Match(':');
                }
            }

            public char lookAhead;
            public string syntax;
            public int count = 0;
            public bool check = true;
            public void CONDITION()
            {
                if (check == true)
                {


                    OPNBRACKET();
                    VARIABLE();
                    OPERATOR();
                    NUMBER();
                    CLOSEBRACKET();

                }
            }
            public void X()
            {

                for (int c = '('; c < '('; c++)
                {
                    if (lookAhead == c)
                    {
                        OPNBRACKET();
                        Y();
                    }
                }
                for (char c = 'a'; c <= 'z'; c++)
                {
                    if (lookAhead == c)
                    {
                        VARIABLE();
                        Y();
                    }
                }

                for (int c = '0'; c < '9'; c++)
                {
                    if (lookAhead == c)
                    {
                        NUMBER();
                        Y();
                    }
                }


                for (int c = ')'; c < ')'; c++)
                {
                    if (lookAhead == c)
                    {
                        CLOSEBRACKET();
                        Y();
                    }
                }
            }
            public void Y()
            {
                if (lookAhead == '|')
                {
                    Match('|');
                    Match('|');
                    CONDITION();
                }
                else if (lookAhead == '&')
                {
                    Match('&');
                    Match('&');
                    CONDITION();
                }
            }
            public void OPNBRACKET()
            {
                if (check == true)
                {
                    for (char c = '('; c <= '('; c++)
                    {


                        if (lookAhead == c)
                        {
                            Match(lookAhead);
                            OPNBRACKET();
                        }
                    }
                }
            }

            public void CLOSEBRACKET()
            {
                if (check == true)
                {
                    for (char c = ')'; c <= ')'; c++)
                    {


                        if (lookAhead == c)
                        {
                            Match(lookAhead);
                            OPNBRACKET();
                        }
                    }
                }
            }
            public void VARIABLE()
            {
                if (check == true)
                {
                    for (char c = 'a'; c <= 'z'; c++)
                    {


                        if (lookAhead == c)
                        {
                            Match(lookAhead);
                            VARIABLE();
                        }
                    }
                }
            }
            public void NUMBER()
            {
                if (check == true)
                {
                    for (int c = '0'; c < '9'; c++)
                    {
                        if (lookAhead == c)
                        {
                            Match(lookAhead);
                            NUMBER();
                        }
                    }
                }
            }
            public void OPERATOR()
            {
                if (check == true)
                {
                    if (lookAhead == '>')
                    {
                        Match('>');
                        //  Console.WriteLine("hehe");
                        Z();
                    }
                    else if (lookAhead == '<')
                    {
                        Match('<');
                        // Console.WriteLine("hehe");
                        Z();
                    }
                    else if (lookAhead == '=')
                    {
                        Match('=');
                        //  Console.WriteLine("hehe");
                        Match('=');
                    }
                    else if (lookAhead == '!')
                    {
                        Match('!');
                        // Console.WriteLine("hehe");
                        Match('=');
                    }
                    else
                    {
                        check = false;
                    }
                }
            }
            public void Z()
            {
                if (check == true)
                {
                    if (lookAhead == '=')
                    {
                        Match('=');
                    }
                }
            }
            public void Match(char ch)
            {
                if (check == true)
                {
                    if (lookAhead == ch)
                    {
                        count++;
                        lookAhead = syntax[count];
                    }
                    else
                    {
                        check = false;
                    }
                    if (lookAhead == ' ')
                    {
                        count++;
                        lookAhead = syntax[count];
                    }
                }

            }


        }
    }

}
