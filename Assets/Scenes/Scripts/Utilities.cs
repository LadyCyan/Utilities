using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class Utilities
{
    /*private int NumberWords(string str)
    {
      

    private void calculateButton_Click(object sender, EventArgs e)
    {
        string allWords = inputBox.Text;
        if (NumberWords(allWords) > 1)
        {
            MessageBox.Show("Words counted.");

        }
        else
        {
            MessageBox.Show("Please input more than one word.");
        }
    }*/
    public static string ProcessText(string input)
        {
            int words = 1;
            int letters = 0;
            double average;

            foreach (char word in input)
            {
                if (char.IsSeparator(word))
                {
                    words++;

                }
                //return words.ToString();
            }
            foreach (char letter in input)
            {
                if (char.IsLetter(letter) && !char.IsSeparator(letter))
                {
                    letters++;
                }
            }
            average = letters / words;
        return average.ToString();
        }
        /*double num;
        if (double.TryParse(input, out num))
        {
            return "Number";
        }
        else
        {
            return "String";
        }*/
        //your code goes here:
        //determine whether user has input a word or a number.
        //return the string word if user enters a word (ab.23cd)
        //return a string 'number' if user enters a number (includes decimal)


    }