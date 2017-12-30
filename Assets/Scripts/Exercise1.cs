using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region Start
public class Exercise1 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

        //Problem E0
        /* Write a function that takes in two integers and returns it's sum
        * */
        //P E0
        int x = 4;
        int y = 7;


        Debug.Log("Problem E0: The sum of the number " + x + " and " + y + " is " + Sum(x, y));

        //Problem E1
        /* Write a function that takes in two integers and returns the larger of the two
         */

        Debug.Log("Problem E1: The larger of the two numbers " + x + " and " + y + " is " + Largest(x, y));

        //Problem E3
        /*
         * Write a function that takes in an integer and returns the string "odd" if the num is odd and "even" if the number is even
         * */

        Debug.Log("Problem E3: The number " + x + " is " + OddOrEven(x));

        /*Problem E5
         * Write a function that displays the numbers 1 to 1000 using a for loop. Hint: Concatinate a temporary string."
         */

        Debug.Log("Problem E5: Here are the numbers 1 to 1000: ");

        DisplayOneToOneThousand();

        /*Problem E6
     * Write a function that takes in an int and finds the sum of  the numbers from 1 to that int using a for loop."
     */

        Debug.Log("Problem E6: Here's the sum of the numbers 1- " + x + " :" + SumOfOneToNum(x));


        /* Problem E7
         * Write a function that takes in an int, and displays all numbers from 0 to that num, using a while loop
         * */

        Debug.Log("Problem E7: Here's the sum of all numbers between 0 and " + x + ".");

        ZeroToNum(x);

        /* Problem E8
    * Write a function that takes in an int,  and finds the sum of  the numbers from 1 to that int, using a while loop
    * */

        Debug.Log("Problem E8: Here's the sum of the numbers 1- " + x + " :" + SumOfOneToNumE8(x));


        /* Problem E9
    * Write a function that takes in an int,  and finds the AVERAGE of  the numbers from 1 to that int, using a FOR loop
    * */

        Debug.Log(" Here is the average of 1 to " + x + ": " + FindAverage(x));

        /* Problem E10
    * Write a function that takes in an int,  and finds the AVERAGE of  the numbers from 1 to that int, using a WHILE loop
    * */

        Debug.Log("Here is the average of 1 to " + x + ": " + FindAverageE10(x));

        //Problem 

        Debug.Log("Here is the sum of the numbers between " + x + "and " + y + ": " + FindSumOfAllNumbersInBetween(x, y));

        insertNumToQuinList(QuinsList);

        
    }
    #endregion

    #region Problems


    List<int> QuinsList = new List<int>();

    void insertNumToQuinList2(List<int> QuinsList)
    {
        /* Write a function that inserts the numbers 
         * 10,15,19,25,32,65 in that order into the list Quin's List
         * */

        //List<int> TempList = new List<int>();

        QuinsList.Insert(0, 10);
        QuinsList.Insert(1, 15);
        QuinsList.Insert(2, 19);
        QuinsList.Insert(3, 25);
        QuinsList.Insert(4, 32);
        QuinsList.Insert(5, 65);

        return;
    }
    /*Problem 2
     * write a function that takes two integers as its parameters
     * The first parameter is the starting number, the end paramater will be the last number
     * This function calculates the summation of every number from the start to end number*/

    //* List<int> givenList = new List<int>();

    /* int Summation(startNum, endNum)
     {
     int Sum=0;
         for (int i = startNum; i < endNum; i++)
         {

         Sum=Sum+ QuinsList.[i];

         }

     }

     /*Problem 3a
          * Write a function to print out all the elements of QuinList, in this example
          * use the function to print out each value of givenList
          */
/*
for (int i  = 0; i < givenList.count; i++)
{
   Debug.LoggivenList[i]);
}
*/


    /*Problem 3b
     * Use the same function to print out all the elements of any list, in this example
     * use the function to print out each value of givenList
     */
     /*
        for (int i=0; i<givenList.count; i++)
        {

        }

        */

    /* Problem 4
     * Find Max
     * Given a list of elements, iterate through the list and find the largest integer value
     * */

    /* Problem 5
     * Find the second largest element in the list
     */

    /* Problem 6
     * Find the sum of all elements in the list
     */

    /* Problem 8
     * Find the average of all elements in the list
     */

    /* Problem 9
     * Function will take in a parameter called "int amountToAdd" and a list to be manipulated
     * The function will add "amountToAdd" to each element in the List
     */


    /* Problem 10 
     * Write a function to reverse the elements of the list
     * that is a list 1,2,3,4,5,7,9 will become 9,7,5,4,3,2,1
    */

    /* Problem 11
     * Write a function that takes in two lists and merges them into one list
     * /
     * for example, given two lists 
     * 1,3,5,7,9
     * 2,4,6,8,10
     * The resulting output will be :
     * 1,2,3,4,5,6,7,8,9,10
     */


    #endregion

    #region E problems

    int Sum(int x, int y)
    {
        int sum = 0;
        sum = x + y;
        return sum;
        // Debug.Log("");
    }

    int Largest (int x, int y)
    {
        if (x > y)
            return x;
        else
            return y;
    }

    string OddOrEven(int num)
    {
        if (num % 2 == 0)
            return "even";
        else return "odd";
    }

    void insertNumToQuinList(List<int> QuinsList)
    {
        //Write your implementation to insert those numbers into that list..
        // Hint..use the List.Add() function
        QuinsList.Add(10);
    }
    void DisplayOneToOneThousand()
    {
        string temp = "";
        for (int i = 1; i <= 1000; i++)
        {
            temp += i.ToString() + ","; //for now, just know that you can stringCat this way 
        }
        Debug.Log(temp); 
    }

    //This function takes in an int and finds the sum of the numbers from 1 to that int using a for loop

    int SumOfOneToNum(int x)
    {
        int sum = 0;
        for (int i = 1; i <= x; i++)
        {
            sum = sum + i;
        }


        return sum;
    }

    //This function takes in an int num, and displays all numbers from 0 to that num, using a while loop
      
    string ZeroToNum (int num)
    {
        int i = 0;
        string temp = "";
        while (i<num)
        {
            temp += i.ToString() + ",";
            i++;
        }

        Debug.Log(temp);
        return temp; 
    }





    /* Problem E8
* Write a function that takes in an int,  and finds the sum of  the numbers from 1 to that int, using a while loop
* */

    int SumOfOneToNumE8(int x)
    {
        int i = 1;
        int theSum =0;
        while (i<=x)
        {
            theSum = theSum + i;
            i++;
        }
        return theSum;
    }


    /* Problem E9
* Write a function that takes in an int,  and finds the AVERAGE of  the numbers from 1 to that int, using a FOR loop
* */

    float FindAverage (int num)
    {
        float avg = 0;
        int sum = 0;
  
        for (int i=0; i<=num; i++)
        {
            sum = sum + i;


        }
        avg = ((float) sum /num);
        return avg;

    }

    /* Problem E10
* Write a function that takes in an int,  and finds the AVERAGE of  the numbers from 1 to that int, using a WHILE loop
* */

    float  FindAverageE10 (int x)
    {
        float avg = 0;
        int sum = 0;
        int i = 1;

        while (i<=x)
        {
            sum = sum + i;

            i++;
        }
        avg = ((float)sum / x);
        return avg;
    }
    
    //Problem E11

    int FindSumOfAllNumbersInBetween(int startNumber, int endNumber)
    {

        int start = 28;
        int end = 45;
        int i;
        int sum = 0;

        for (i=start; i<end; i++)
        {
            sum+=i;
        }
        
        
      
        return sum; 
    }


    //Problem E12; I will need this one checked because I am not sure how to test it.

    int FindMax(List<int> listOfNumbers)
    {
        //the List<int> is very similar to vector<int> in c++... Figure out how to use this, using the internet to help you.

        if (listOfNumbers.Count == 0)
            {
                Debug.Log ("Empty list");
            }
            int maxValue = listOfNumbers[0];

        for (int i=1; i<listOfNumbers.Count; i++)
            {
                if (listOfNumbers[i]> maxValue)
                {
                    maxValue = listOfNumbers[i];
                }
            }
            return maxValue;
    }
}
#endregion
