using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 1;
            int v = 0;

            string p1 = "1";
            string p2 = "2";
            string p3 = "3";
            string p4 = "4";
            string p5 = "5";
            string p6 = "6";
            string p7 = "7";
            string p8 = "8";
            string p9 = "9";
            string J1 = " ";
            string J2 = " ";
            string Turn = " ";
            string Win = " ";
            string tied = " ";

           
            Console.WriteLine("[1] para Portugues || [2] for English || [3] para Español");
            int select = int.Parse(Console.ReadLine());

            switch (select)
            {
                case 1:  J1 = "Jogador 1, escreva o seu nome: ";
                         J2 = "Jogador 2, escreva o seu nome: ";
                         Turn = "Sua vez";
                         Win = "você venceu!!";
                         tied = "Deu velha!!";
                    break;

                case 2:
                        J1 = "Player 1, type your name: ";
                        J2 = "Player 2, type your name: ";
                        Turn = "Your turn";
                        Win = "you are the champion!!";
                        tied = "Tied!!";
                    break;

                case 3:
                    J1 = "Jugador 1, escribe tu nombre: ";
                    J2 = "Jugador 2, escribe tu nombre: ";
                    Turn = "Tu turno";
                    Win = "Tú eres el campeón!!";
                    tied = "juego empatado!!";
                    break;
            }       

            Console.Clear();
          
            Console.WriteLine(J1 + " :");
            string player1 = Console.ReadLine();
            player1 = player1.ToUpper(); //turn the name to uppercase
            Console.WriteLine("");

            Console.Clear();

            Console.WriteLine(J2 + " :");
            string player2 = Console.ReadLine();
            player2 = player2.ToUpper(); //turn the name to uppercase
            Console.WriteLine("");

            Console.Clear();                

            while ((Tester(p1, p2, p3, p4, p5, p6, p7, p8, p9) == 0) && (i <= 4)) 
            {
                i = i+1;

                //  Player 1
                if (Tester(p1, p2, p3, p4, p5, p6, p7, p8, p9) == 0)
                {
                    while (v != 1)
                    {
                        Display(p1, p2, p3, p4, p5, p6, p7, p8, p9);
                        Console.WriteLine(Turn+ ", " + player1 + ": ");
                        string valor = Console.ReadLine();

                        if ((valor == "1") && (p1 != "O" && (p1 != "X")))
                        {
                            p1 = "X";
                            v = 1;
                        }
                        if ((valor == "2") && (p2 != "O" && (p2 != "X")))
                        {
                            p2 = "X";
                            v = 1;
                        }
                        if ((valor == "3") && (p3 != "O" && (p3 != "X")))
                        {
                            p3 = "X";
                            v = 1;
                        }
                        if ((valor == "4") && (p4 != "O" && (p4 != "X")))
                        {
                            p4 = "X";
                            v = 1;
                        }
                        if ((valor == "5") && (p5 != "O" && (p5 != "X")))
                        {
                            p5 = "X";
                            v = 1;
                        }
                        if ((valor == "6") && (p6 != "O" && (p6 != "X")))
                        {
                            p6 = "X";
                            v = 1;
                        }
                        if ((valor == "7") && (p7 != "O" && (p7 != "X")))
                        {
                            p7 = "X";
                            v = 1;
                        }
                        if ((valor == "8") && (p8 != "O" && (p8 != "X")))
                        {
                            p8 = "X";
                            v = 1;
                        }
                        if ((valor == "9") && (p9 != "O" && (p9 != "X")))
                        {
                            p9 = "X";
                            v = 1;
                        }
                        Console.Clear();
                    }                   
                }// player 1
                                              
                v = 0;
              
                // Player 2
                if (Tester(p1, p2, p3, p4, p5, p6, p7, p8, p9) == 0)
                {

                    while (v != 1)
                    {
                        Display(p1, p2, p3, p4, p5, p6, p7, p8, p9);
                        Console.WriteLine(Turn + ", " + player2 + ": ");
                        string valor2 = Console.ReadLine();

                        if ((valor2 == "1") && (p1 != "O" && (p1 != "X")))
                        {
                            p1 = "O";
                            v = 1;
                        }
                        if ((valor2 == "2") && (p2 != "O" && (p2 != "X")))
                        {
                            p2 = "O";
                            v = 1;
                        }
                        if ((valor2 == "3") && (p3 != "O" && (p3 != "X")))
                        {
                            p3 = "O";
                            v = 1;
                        }
                        if ((valor2 == "4") && (p4 != "O" && (p4 != "X")))
                        {
                            p4 = "O";
                            v = 1;
                        }
                        if ((valor2 == "5") && (p5 != "O" && (p5 != "X")))
                            {
                            p5 = "O";
                            v = 1;
                        }

                        if ((valor2 == "6") && (p6 != "O" && (p6 != "X")))
                        {
                            p6 = "O";
                            v = 1;
                        }
                        if ((valor2 == "7") && (p7 != "O" && (p7 != "X")))
                        {
                            p7 = "O";
                            v = 1;
                        }
                        if ((valor2 == "8") && (p8 != "O" && (p8 != "X")))
                        {
                            p8 = "O";
                            v = 1;
                        }
                        if ((valor2 == "9") && (p9 != "O" && (p9 != "X")))
                        {
                            p9 = "O";
                            v = 1;
                        }
                        Console.Clear();
                    }// player 2
                }   
                                                           
                v = 0;
            }


            if (Tester(p1, p2, p3, p4, p5, p6, p7, p8, p9) == 0)
            {
                Console.WriteLine(tied);
            }

            if (Tester(p1, p2, p3, p4, p5, p6, p7, p8, p9) == 1)
            {
                Console.WriteLine(player1 + " " + Win);
            }

            if (Tester(p1, p2, p3, p4, p5, p6, p7, p8, p9) == 2)
            {
                Console.WriteLine(player2 + " " + Win);
            }

            Console.ReadKey();
        }

        static void Display(string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9)
        {

            Console.WriteLine("       |      |        ");
            Console.WriteLine("    " + p1 + "  |  " + p2 + "   |  " + p3 + "");
            Console.WriteLine("_______|______|_______");
            Console.WriteLine("       |      |       ");
            Console.WriteLine("    " + p4 + "  |  " + p5 + "   |  " + p6 + "");
            Console.WriteLine("_______|______|_______");
            Console.WriteLine("       |      |       ");
            Console.WriteLine("    " + p7 + "  |  " + p8 + "   |  " + p9 + "");
            Console.WriteLine("       |      |       ");

            Console.ReadKey();
        }

        static int Tester(string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9)
        {
            int tester = 0;

            if (((p1 == "X") && (p2 == "X") && (p3 == "X")) || (p4 == "X") && (p5 == "X") && (p6 == "X") || (p7 == "X") && (p8 == "X") && (p9 == "X") || (p1 == "X") && (p4 == "X") && (p7 == "X") || (p2 == "X") && (p5 == "X") && (p8 == "X") || (p3 == "X") && (p6 == "X") && (p9 == "X") || (p1 == "X") && (p5 == "X") && (p9 == "X") || (p3 == "X") && (p5 == "X") && (p7 == "X")) {

                tester = 1;
            }

            if (((p1 == "O") && (p2 == "O") && (p3 == "O")) || (p4 == "O") && (p5 == "O") && (p6 == "O") || (p7 == "O") && (p8 == "O") && (p9 == "O") || (p1 == "O") && (p4 == "O") && (p7 == "O") || (p2 == "O") && (p5 == "O") && (p8 == "O") || (p3 == "O") && (p6 == "O") && (p9 == "O") || (p1 == "O") && (p5 == "O") && (p9 == "O") || (p3 == "O") && (p5 == "O") && (p7 == "O")) {

                tester = 2;           
            }




            return tester;

        }
    }
}
