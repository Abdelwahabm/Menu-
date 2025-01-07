namespace menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char Selector = '\0';
            List<int> MyList = new List<int>();
            int Small = 0, Large = 0, Find = 0, Add = 0, Flag = 0, Temp = 0 , RemovedNum = 0  ;
            double Sum = 0;
            do
            {

                Console.WriteLine("-------Menu------\n"); 
                Console.WriteLine("----------------------------------------------------");

                Console.WriteLine("P - Print numbers ");
                Console.WriteLine("I - Print the list in reverse order ");
                Console.WriteLine("A - Add a number "); // Duplicate numbers are handled
                Console.WriteLine("T - Display the total sum of all numbers ");
                Console.WriteLine("M - Display mean of the numbers ");
                Console.WriteLine("S - Display the smallest number ");
                Console.WriteLine("L - Display the largest number ");
                Console.WriteLine("X - Display the largest and the smallest numbers ");
                Console.WriteLine("F - Search for number ");
                Console.WriteLine("C - Clear the list ");
                Console.WriteLine("O - Order The list from smallest to largest ");
                Console.WriteLine("D - Display the list size");
                Console.WriteLine("R - Remove number ");
                Console.WriteLine("Q - Quit ");
                
                Console.WriteLine("----------------------------------------------------\n");

                Console.Write("Enter your choice: ");
                Selector = Convert.ToChar(Console.ReadLine());
                
                Console.WriteLine("\n");

                Selector = char.ToUpper(Selector);

                switch (Selector)
                {
                    case 'P':
                        {
                            if (MyList.Count > 0)
                            {
                                Console.Write("[");
                                for (int i = 0; i<MyList.Count; i++ )
                                {
                                    Console.Write($" {MyList[i]}");
                                }
                                Console.Write(" ]\n");
                            }
                            else
                            {
                                Console.WriteLine("[] - The List is Empty") ;
                            }

                        }
                        break;

                    case 'I':
                        {
                            if(MyList.Count > 0)
                            {
                                Console.Write("[");
                                for (int i = MyList.Count-1 ; i >= 0 ; i--)
                                {
                                    Console.Write($" {MyList[i]}");
                                }
                                Console.Write(" ]\n");
                            }
                            else
                            {
                                Console.WriteLine("[] - The List is Empty");
                            }
                        }
                        break;

                    case 'A':
                        {
                            Console.Write("Enter The number you want to add: ");
                            Add=(Convert.ToInt32( Console.ReadLine() ));
                            Flag = 0;
                            for (int i = 0;i < MyList.Count ;i++ )
                            {
                                if (Add == MyList[i])
                                {
                                    Flag = 1;
                                    Console.WriteLine($"Sorry can't add {Add}, because it is a duplicate number");
                                    break;
                                }
                            }
                            if(Flag==0)
                            {
                                MyList.Add(Add);
                                Console.WriteLine($"{MyList[(MyList.Count - 1)]} added ");
                            }
                            
                        }
                        break;

                    case 'T':
                        {
                            if ( MyList.Count > 0 )
                            {
                                //Console.WriteLine($"Total sum is {MyList.Sum()}");
                                for (int i = 0; i < MyList.Count; i++ )
                                {
                                    Sum += MyList[i];
                                }
                                Console.WriteLine($"Total sum is {Sum}");
                                Sum = 0;
                            }
                            else
                            {
                                Console.WriteLine("List is empty ,try again later ");
                            }
                        }
                        break;

                    case 'M':
                        {
                            if (MyList.Count > 0)
                            {
                                //Console.WriteLine($"The mean of the elements in the list: {MyList.Sum()/MyList.Count}");
                                for (int i = 0; i < MyList.Count; i++)
                                {
                                    Sum += MyList[i];
                                }
                                Console.WriteLine($"The mean of the elements in the list: {(Sum / MyList.Count):F2}");
                                Sum=0;
                            }
                            else
                            {
                                Console.WriteLine("Unable to calculate the mean - no data");
                            }
                        }
                        break;
                    case 'S':
                        {
                            if (MyList.Count > 0 )
                            {
                                Small = MyList[0];
                                for (int i = 1 ; i < MyList.Count ; i++ )
                                {                                 
                                        if (Small > MyList[i])
                                        {
                                            Small = MyList[i];
                                        }
                                    
                                }
                                Console.WriteLine($"The smallest number: {Small}");
                                Small = MyList[0];
                            }
                            else
                            {
                                Console.WriteLine("Unable to determine the smallest element - List is Empty");
                            }

                        }
                        break;

                    case 'L':
                        {
                            if (MyList.Count > 0)
                            {
                                Large = MyList[0];
                                for (int i = 1 ; i < MyList.Count ; i++)
                                {
                                    if (Large < MyList[i])
                                    {
                                        Large = MyList[i];
                                    }

                                }
                                Console.WriteLine($"The largest number: {Large}");
                                Large = MyList[0] ;
                            }
                            else
                            {
                                Console.WriteLine("Unable to determine the Largest element - List is Empty");
                            }

                        }
                        break;

                    case 'X':
                        {
                            if (MyList.Count > 0)
                            {
                                Small = MyList[0];
                                for (int i = 1; i < MyList.Count; i++)
                                {
                                    if (Small > MyList[i])
                                    {
                                        Small = MyList[i];
                                    }

                                }

                                Large = MyList[0];
                                for (int i = 1; i < MyList.Count; i++)
                                {
                                    if (Large < MyList[i])
                                    {
                                        Large = MyList[i];
                                    }
                                    
                                }

                                Console.WriteLine($"The Largest number is {Large} & The smallest number is {Small}");
                                Small = MyList[0] ;
                                Large = MyList[0] ;
                            }
                            else
                            {
                                Console.WriteLine("Sorry can't display the numbers - List is Empty");
                            }
                        }
                        break;

                    case 'F':
                        {
                            if (MyList.Count > 0)
                            { 
                                Console.Write("Enter Number you want to find: ");
                                Find=Convert.ToInt32( Console.ReadLine() );
                            
                                for (int i = 0;i < MyList.Count ;i++)
                                {
                                    if (Find == MyList[i])
                                    {
                                        Console.WriteLine($"{Find} is found at index {i}");
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Unable to search for number - List is Empty");
                            }
                        }
                        break;

                    case 'C':
                        {
                            if (MyList.Count > 0)
                            {
                                MyList.Clear();
                                Console.WriteLine("List is cleared successfully, List is now empty");
                            }
                            else
                            {
                                Console.WriteLine("List is already Empty");
                            }
                        }
                        break;

                    case 'O':
                        {
                            if (MyList.Count > 0)
                            {
                                for (int i = 0; i < MyList.Count ; i++)
                                {
                                    for (int j = 0; j < MyList.Count - i - 1; j++)
                                    {
                                        if (MyList[j] > MyList[j + 1])
                                        {
                                            Temp = MyList[j + 1];
                                            MyList[j + 1] = MyList[j];
                                            MyList[j] = Temp;
                                        }
                                    }

                                }
                                Temp = 0;
                                Console.WriteLine("List is ordered successfully");

                            }
                            else
                            {
                                Console.WriteLine("List is empty can't order it ");
                            }
                        }                       
                        break;

                    case 'D':
                        {
                            if (MyList.Count > 0)
                            {
                                Console.WriteLine($"The Size of the list is {MyList.Count} ");
                            }
                            else
                            {
                                Console.WriteLine("List is Empty Size is 0 ");
                            }
                        }    
                        break;

                    case 'R':
                        {
                            if (MyList.Count > 0)
                            {
                                Console.WriteLine("Enter number you want to remove");
                                RemovedNum = Convert.ToInt32( Console.ReadLine() );
                                
                                if (MyList.Remove(RemovedNum))
                                {
                                    Console.WriteLine($"{RemovedNum} is removed from the list");
                                }
                                else
                                {
                                    Console.WriteLine($"{RemovedNum} is not found in the list ,Please try again");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Sorry can't remove - List is empty");
                            }
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Unknown Selection, Please try again ");
                        }
                        break;
                           
                }
                Console.WriteLine("\n");
            } while (Selector != 'Q' && Selector != 'q');

            Console.WriteLine("Thank you , GoodBye");

        }
    }
}
