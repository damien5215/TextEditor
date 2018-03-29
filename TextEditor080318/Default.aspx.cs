// Damien Bactawar, 29/03/18, Text Editor Code for www.damienasp.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Cliches to put in "smart as a fox", "at the end of the day", "let's face it", "to be honest", "agree to disagree"
        // TextBox1.Text = "INPUT TEXTBOX: TEXT EDITOR APP" + "\n" + "\n" + "Please write (or paste) a paragraph or a few lines of dialogue into the LEFT textbox or use one of the three example buttons to load the textbox. Then click on one of the functions.";
        TextBox2.Text = "OUTPUT TEXTBOX: GENERAL RULES FOR GOOD PROSE" + "\n" + "\n" + "The best selling literary author Martin Amis once described writing as a war-on-cliches" + "\n" + "\n" + "The literary agent Jonny Gellar (Curtis Brown) believes that varying the length of each sentence makes prose more engaging." + "\n" + "\n" + "Some readers like novels that use phonetic-spellings to model the way speech is spoken in different dialects (A Clockwork Orange, Trainspotting, etc).";
    }

    protected void Button1_Click(object sender, EventArgs e)                         // WORD COUNT
    {
        if (TextBox1.Text == "")                                                     // If input textBox is EMPTY return message     
        {
            TextBox1.Text = "Please type in some text.";
        }
        else                                                                         // Convert ?/! to . and create array of sentences
        {
            String[] sentenceArray = TextBox1.Text.Replace('?','.').Replace('!', '.').Split('.');

            int[] wordArray2 = new int[(sentenceArray.Length)];                      // Number of sentences determines size of wordArray
            int totalWords = 0;                                                      // Variable for total number of words
            int i;                                                                   // Local variable for for-loops 

            for (i = 1; i <= (sentenceArray.Length - 1); i++)
            {
                wordArray2[0] = sentenceArray[0].Split(' ').Length;                  // Number of words, in each sentence, put into a 
                wordArray2[i] = sentenceArray[i].Split(' ').Length - 1;              // number of int-arrays (sentence3 = 4 words)
            }

            for (i = 0; i <= (wordArray2.Length - 2); i++)                           // -2 because last value of array is empty
            {
                totalWords += wordArray2[i];                                         // Calculates total number of words
            }

            TextBox2.Text = "PARAGRAPH: There are a total of " + totalWords + " words and there are a total of " + (sentenceArray.Length - 1) + " sentences." + Environment.NewLine + Environment.NewLine;

            for (i = 0; i <= (wordArray2.Length - 2); i++)                           // -2 because last value of array is empty
            {
                TextBox2.Text += "Sentence " + (i + 1) + " contains " + wordArray2[i] + " words." + "\n";
            }
        }
    }

    protected void Button2_Click(object sender, EventArgs e)                         // SLANG CONVERTER
    {
        if(TextBox1.Text == "")
        {
            TextBox1.Text = "Please type in some text.";
        }
        else
        {
            string slangString2 = TextBox1.Text.Replace("ing", "in").Replace("was", "woz").Replace("into", "inta");
            slangString2 = slangString2.Replace("with", "wiv").Replace("what", "wot").Replace("think", "fink");
            slangString2 = slangString2.Replace("got to", "gotta").Replace("er ", "a ").Replace("thank", "fank");
            slangString2 = slangString2.Replace("What", "Wot").Replace("Thank", "Fank");

            TextBox2.Text = slangString2;                                            // Prints converted text
        }
    }

    protected void Button3_Click(object sender, EventArgs e)                              // WORD FREQ TEST
    {
        string text1 = TextBox1.Text.Replace(",", "").Replace(".", "").Replace("!", "").Replace("?", "").ToLower();
        text1 = text1.Replace("(", "").Replace(")", "").Replace("'", "").Replace(";", "");

        if (TextBox1.Text == "")                                                          // If input-textbox is empty
        {
            TextBox1.Text = "Please type in some text.";                                  // Prompt user
        }
        else
        {
            TextBox2.Text = "";                                                           // Clear output-textbox

            String[] wordArray = text1.Split(' ');                                        // Array of words from input-textbox
                                                                                          // Punctuation removed , . ! ? ( ) ' ;
                int[] numberOfRepeats = new int[(wordArray.Length)];                      // Array of numbers which indicates how many 
                                                                                          // times each word appears in the text

                int counter = 0;                                                          // Counter for word-matches
                int highestNumber = 0;                                                    // Holds highest number
                int highestNumberIndex = 0;                                               // Holds index of highest number (q5)

                for (int q = 0; q <= (wordArray.Length - 1); q++)                         // Nested for-loop compares list to itself
                {
                    for (int q2 = 0; q2 <= (wordArray.Length - 1); q2++)
                    {
                        if ((wordArray[q2] == wordArray[q]) && (q2 != q))                 // If words match and array-index is not equal
                        {                                                                 
                            counter++;                                                    // Increment word-match-counter 
                        }
                    }
                    numberOfRepeats[q] = counter;                                         // After looping through for one word, store its
                    counter = 0;                                                          // frequency and reset word-match-counter
                }

                for (int q = 0; q <= (wordArray.Length - 1); q++)                         // Determines the highest word-frequency
                {
                    if (numberOfRepeats[q] > highestNumber)                               // If word-freq number is bigger
                    {
                        highestNumber = numberOfRepeats[q];                               // Load highestNumber variable
                        highestNumberIndex = q;                                           // Store the index
                    }
                    TextBox2.Text = "The word " + "\"" + wordArray[highestNumberIndex] + "\"" + " is the most frequently occuring word and it appears " + (highestNumber + 1) + " times.";
                }
            }
    }

    protected void Button6_Click(object sender, EventArgs e)                                   // Example 3 Button      
    {
        TextBox1.Text = "Who was with you and what were you thinking?";
        TextBox2.Text = "";
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        TextBox2.Text = "OUTPUT TEXTBOX: GENERAL RULES FOR GOOD PROSE" + "\n" + "\n" + "The best selling literary author Martin Amis once described writing as a war-on-cliches" + "\n" + "\n" + "The literary agent Jonny Gellar (Curtis Brown) believes that varying the length of each sentence makes prose more engaging." + "\n" + "\n" + "Some readers like novels that use phonetic-spellings to model the way speech is spoken in different dialects (A Clockwork Orange, Trainspotting, etc).";
        TextBox1.Text = "";
        TextBox3.Text = "";
    }

    protected void Button5_Click(object sender, EventArgs e)                                    // Example 2 Button
    {
        TextBox1.Text = "Freedom is what you do with what's been done to you.";
        TextBox2.Text = "";
    }

    protected void Button4_Click(object sender, EventArgs e)                                    // Example 1 Button
    {
        TextBox1.Text = "The cat sat on the mat. The cat felt thirsty. The cat shrieked. The owner brought the cat some milk. The end.";
        TextBox2.Text = "";
    }

    protected void Button7_Click1(object sender, EventArgs e)                       // SEARCH BUTTON
    {
        int searchRepeats = 0;                                                      // Number of times search-word appears in text
        string searchWord = TextBox3.Text.ToLower();                                // Take string from SEARCH box and lower the case

        if ((TextBox1.Text == ""))                                                  // If input TextBox is empty
        {
            TextBox1.Text = "Please type in some text.";                            // Prompt user
            TextBox2.Text = "";                                                     // Clear output textbox
        }
        else
        {
            if (TextBox3.Text == "")                                                 // If searchbox is empty
            {
                TextBox3.Text = "Please type in a word.";                            // Prompt user
                TextBox2.Text = "";                                                  // Clear output textbox
            }
            else
            {
                TextBox2.Text = "";                                                  // Clear the output textbox

                string TBoxString = TextBox1.Text.Replace('.',' ').Replace(',', ' ').Replace('"', ' ').ToLower();     // Remove '.' ',' '"'
                TBoxString = TBoxString.Replace('!', ' ').Replace('(', ' ').Replace(')', ' ').Replace('?', ' ');      // Remove '!' '(' ')' '?'

                String[] wordArrayD1 = TBoxString.Split(' ');                        // Create array of words (no punctuation)
                String[] wordArrayD2 = TextBox1.Text.Split(' ');                     // Create array of words (normal text)

                wordArrayD1 = wordArrayD1.Where(w => w != wordArrayD1[wordArrayD1.Length-1]).ToArray();             
                // Removes last element in no-punctuation array so that the 2 arrays are the same length
                // Caused by the Replace('.',' ') + Split('.',' '), it creates an extra element which is blank                        

                for (int b9 = 0; b9 <= (wordArrayD1.Length - 1); b9++)               // Loop through each word (no punctuation) 
                {
                    if (wordArrayD1[b9] == searchWord)                               // If searched word is present
                    {
                        wordArrayD2[b9] = wordArrayD2[b9].ToUpper();                 // Highlight text by CAPITALISATION
                        searchRepeats++;                                             // Count occurrences of SEARCH-word
                    }

                    TextBox2.Text += wordArrayD2[b9] + " ";                          // Reconstruct and display paragraph with
                }                                                                    // highlighted word (CAPITALISED)

                TextBox2.Text += "\n" + "\n" + "The word \"" + searchWord + "\" appears " + searchRepeats + " times in the text.";
            }     
        }
    }

    protected void Button9_Click(object sender, EventArgs e)                          // ANALYSE-TEXT BUTTON
    {

        TextBox2.Text = "";                                                           // Clear the output textbox
        string textboxToString5 = TextBox1.Text.ToLower();                            // Textbox to string and lower the case
        textboxToString5.Replace(",", "").Replace(".", "").Replace("'", "");          // Remove punctuation (, . ')
        String[] wordArray = textboxToString5.Split(' ');                             // Create array of words

        bool containsRacism = false;                                                  // Flag for racist content 
        bool containsExpletive = false;                                               // Flag for expletive content

        string[] badWords1 = new string[2]  {"nigger", "niggers"};
        string[] badWords2 = new string[17] {"fuck", "fucks", "fucker", "fuckers", "fucking", "fucked",
                                             "shit", "shits", "shitty", "shiter", "shiting", "shitstorm",
                                             "piss", "pissing", "pissed", "cunt", "cunts"};

        foreach (string element1 in wordArray)                                        // Steps through each word from text box
        {
            foreach(string element2 in badWords1)                                     // Steps through racist word array
            {
                if(element1 == element2)
                {
                    containsRacism = true;                                            // Flag for racist content
                    break;                                                            // Move onto next foreach loop
                }
            }

            foreach (string element3 in badWords2)                                    // Steps through expletive word array
            {
                if (element1 == element3)
                {
                    containsExpletive = true;                                         // Flag for expletive content
                    break;                                                            // Move onto next word from the text box
                }
            }
        }                                                                             // End of nested Foreach loop
                                                                 
        if ((containsRacism == true) && (containsExpletive == true))            
        {
            TextBox2.Text = "The user has entered content which contains 'EXPLETIVES' and contains language which is 'RACIST'";
        }

        else if ((containsExpletive == true))                                   
        {
            TextBox2.Text = "The user has entered content which contains 'EXPLETIVES'";
        }

        else if (containsRacism == true)                                        
        {
            TextBox2.Text = "The user has entered content which contains language that is 'RACIST'";
        }

        else                                                       
        {
            TextBox2.Text = "No offensive words.";
        }
    }                                                                                 // End of Analyse Text block
}                                                                                     // End of Code