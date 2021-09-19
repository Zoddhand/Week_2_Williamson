using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    // enable / disable functions within unity. 
    public bool task1 = false;
    public bool task2 = false;
    public bool task3 = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(task1)
            Task1();
        if (task2)
            Task2();
        if (task3)
            Task3();
    }

    /* Write a function that outputs all numbers from 0 to 1000 that have both a 3 and a 7 in them. */
    void Task1()
    {
        for (int i = 0; i <= 1000; i++) // loop 0 to 1000
        {
            if (i.ToString().Contains("7") || i.ToString().Contains("3")) // if int i contains a 7 or a 3
            {
                Debug.Log(i + ","); // Log
            }
        }
        task1 = false;
    }

    /* Write a function to determine the most common letter in a string.*/
    void Task2()
    {
        var freq = new Dictionary<char, int>(); // Create a dictionary to hold each letter and its frequency.

        string str = "This is my string"; // a string to test with
        foreach(char i in str) // loops through each character in string
        {
            if (freq.ContainsKey(i)) // if dictonary key contains the current char
            {
                freq[i]++; // increase its fequency 
            }
            else freq.Add(i, 1); // otherwise add that char
        }

        int maxFreq = 0; 
        foreach(int i in freq.Values) // loop through the values
        {
            if (i > maxFreq) 
                maxFreq = i;
        }

        string temp = " ";
        foreach(KeyValuePair<char,int> i in freq) // format
        {
            if(i.Value == maxFreq && i.Key != ' ') 
            {
                temp += i.Key + ",";
            }
        }
        string temp2 = temp.Trim(','); // remove the , off the end
        Debug.Log("The Letters with the highest frequency are:" + temp2); // Log
        task2 = false;
    }

    /* Write a function that returns a string containing 
     * all letters in a list of words passed into it. Each letter should appear only once. */
    public string input; // public string to be edited in unity
    void Task3()
    {
        string letters = ""; // string to hold our letters
        bool dupe; // flag for if the letter is already in letters string
        foreach(char i in input) // loop through input string.
        {
            dupe = false; // reset dupe flag
            foreach(char h in letters) // loop through letters string. 
            {
                if (i == h); // if the current input char is equal to the current letters char
                dupe = true; // then there is a duplicate
            }
            if (dupe == false) // if no duplicate is found
                letters += i; // add this letter to the letters string
            else Debug.Log("Character " + i + " already in string"); // Log
        }
        task3 = false;
    }
}
