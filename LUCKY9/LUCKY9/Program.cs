using System;
using System.Collections;
using System.ComponentModel;

public class LUCKY9
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        string user;
        int player_c1, player_c2, comp_c1, comp_c2, player_score, comp_score, player_sum, comp_sum; 
        double cash_in, cash_total, bet, win, lose;
        bool program_run, playing;
        program_run = true;
        playing = true;
        while (program_run)
        {
            Console.WriteLine("============\n" +
                              "LUCKY 9 GAME|\n" +
                              "============");
            try
            {
                Console.WriteLine("Enter amount to cash in!");
                cash_in = Convert.ToDouble(Console.ReadLine());
                cash_total = 0 + cash_in;
                Console.WriteLine("You deposited: " + cash_in + " Total of: " + cash_total);
                while (playing)
                {
                    try
                    {
                        Console.WriteLine("Enter the amount you want to bet");
                        bet = Convert.ToDouble(Console.ReadLine());
                        player_c1 = rand.Next(1, 10);
                        player_c2 = rand.Next(1, 10);
                        comp_c1 = rand.Next(1, 10);
                        comp_c2 = rand.Next(1, 10);
                        player_sum = player_c1 + player_c2;
                        comp_sum = comp_c1 + comp_c2;
                        player_score = player_sum % 10;
                        comp_score = comp_sum % 10;
                        lose = cash_total - bet;
                        win = cash_total + bet;
                        if (bet > cash_total)
                        {
                            Console.WriteLine("Invalid amount\n" + "Do you wanna try again? if yes, type yes, if no, press any key");
                        }
                        else if (bet <= cash_total)
                        {
                            if (player_score < comp_score)
                            {
                                Console.WriteLine("Player you got: " + player_c1 + " and " + player_c2 + "\n" +
                                                  "Computer you got: " + comp_c1 + " and " + comp_c2 + "\n" +
                                                  "Player: " + player_score + " Computer: " + comp_score + "\n" +
                                                  "Computer won!" + "\n" +
                                                  "Cash left: " + lose + "\n" +
                                                  "Rematch? Y|N");
                                cash_total -= bet;
                                user = Console.ReadLine();
                                user = user.ToUpper();
     
                                if (user == "Y")
                                {
                                    playing = true;
                                }
                                else if (user == "N")
                                {
                                    Console.WriteLine("Thank you for playing!\n" +
                                                      "Cash out: " + cash_total);
                                    playing = false;
                                }
                                else
                                {
                                    Console.WriteLine("Thank you for playing!\n" +
                                                      "Cash out: " + cash_total);
                                    playing = false;
                                }
                            }
                            else if (player_score > comp_score)
                            {
                                Console.WriteLine("Player you got: " + player_c1 + " and " + player_c2 + "\n" +
                                                  "Computer you got: " + comp_c1 + " and " + comp_c2 + "\n" +
                                                  "Player: " + player_score + " Computer: " + comp_score + "\n" +
                                                  "Player won!" + "\n" +
                                                  "Cash left: " + win + "\n" +
                                                  "Rematch? Y|N");
                                cash_total += bet;
                                user = Console.ReadLine();
                                user = user.ToUpper();

                                if (user == "Y")
                                {
                                    playing = true;
                                }
                                else if (user == "N")
                                {
                                    Console.WriteLine("Thank you for playing!\n" +
                                                      "Cash out: " + cash_total);
                                    playing = false;
                                }
                                else
                                {
                                    playing = false;
                                }
                            }
                            else if (player_score == comp_score)
                            {
                                Console.WriteLine("Player you got: " + player_c1 + " and " + player_c2 + "\n" +
                                                  "Computer you got: " + comp_c1 + " and " + comp_c2 + "\n" +
                                                  "Player: " + player_score + " Computer: " + comp_score + "\n" +
                                                  "IT'S A DRAW!! WHAT ARE THE ODDS?" + "\n" +
                                                  "Cash left: " + cash_total + "\n" +
                                                  "Rematch? Y|N");
                                user = Console.ReadLine();
                                user = user.ToUpper();
                                if (user == "Y")
                                {
                                    playing = true;
                                }
                                else if (user == "N")
                                {
                                    Console.WriteLine("Thank you for playing!\n" +
                                                      "Cash out: " + cash_total);
                                    playing = false;
                                }
                                else
                                {
                                    playing = false;
                                }
                            }
                        }
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Invalid input! Type yes to try again, press any key to cash out!");
                    }
                } 
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Invalid input!");
            }
            Console.WriteLine("Do you wanna restart the program? Y/N");
            user = Console.ReadLine();
            user = user.ToUpper();
            if (user == "Y")
            {
                program_run = true;
                playing = true;
            }
            else if (user == "N")
            {
                Console.WriteLine("Thank you!");
                program_run = false;
            }
            else
            {
                Console.WriteLine("Thank you!");
                program_run = false;
            }
        }
    }
}