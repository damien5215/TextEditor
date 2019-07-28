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
        // TextBox1.Text = "INPUT TEXTBOX: TEXT EDITOR APP" + "\n" + "\n" + "Please write (or paste) a paragraph or a few lines of dialogue into the LEFT textbox or use one of the three example buttons to load the textbox. Then click on one of the functions.";
        TextBox2.Text = "OUTPUT TEXTBOX: GENERAL RULES FOR GOOD PROSE" + "\n" + "\n" + "The best selling literary author Martin Amis once described writing as a war-on-cliches" + "\n" + "\n" + "The literary agent Jonny Gellar (Curtis Brown) believes that varying the length of each sentence makes prose more engaging." + "\n" + "\n" + "Some readers like novels that use phonetic-spellings to model the way speech is spoken in different dialects (A Clockwork Orange, Trainspotting, etc).";
    }

    protected void Button1_Click(object sender, EventArgs e)                         // WORD COUNT
    {
        if (TextBox1.Text == "")                                                     // If input textBox is EMPTY     
        {
            TextBox1.Text = "Please type in some text.";                             // Prompt user
        }
        else                                                                         
        {      
            int totalWords = 0;
            string result = "";
            string splitOn = ".";
            string string1 = TextBox1.Text.Replace('?', '.').Replace('!', '.').Replace(". ", ".");

            String[] sentenceArray = string1.Split(splitOn.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            int[] wordArr = new int[(sentenceArray.Length)];

            for (int i = 0; i < sentenceArray.Length; i++)
            {
                wordArr[i] = sentenceArray[i].Split(' ').Length;           
                totalWords += wordArr[i];
                result += "Sentence " + (i + 1) + " contains " + wordArr[i] + " words." + "\n";
            }

            result += "\n" + "There are a total of " + totalWords + " words and there are a total of " + (sentenceArray.Length) + " sentences.";
            TextBox2.Text = result;            
        }
    }

    protected void Button2_Click(object sender, EventArgs e)                         // SLANG CONVERTER
    {
        if(TextBox1.Text == "")                                                      // If input textBox is EMPTY return message   
        {
            TextBox1.Text = "Please type in some text.";                             // Prompt user
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

    protected void Button3_Click(object sender, EventArgs e)                          // WORD FREQ TEST
    {

        if (TextBox1.Text == "")                                                      // If input-textbox is empty
        {
            TextBox1.Text = "Please type in some text.";                              // Prompt user
        }
        else
        {
            TextBox2.Text = "";                                                       // Clear output-textbox
            string test3 = TextBox1.Text;                                             // Data from input-text-box
            test3 = formatStringClass.formatString(test3);                            // Remove punctuation , . ! ? ( ) ' ;

            String[] wordArray = test3.Split(' ');                                    // Array of words from input-textbox                                                                                     
            int[] numberOfRepeats = new int[(wordArray.Length)];                      // Array of numbers which indicates how many 
                                                                                      // times each word appears in the text

            int counter = 0;                                                          // Counter for word-matches
            int highestNumber = 0;                                                    // Holds highest number
            int highestNumberIndex = 0;                                               // Holds index of highest number

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
                string test2 = TextBox1.Text;                                        // String for input-textbox
                test2 = formatStringClass.formatString(test2);                       // Remove punctuation , . ! ? ( ) ' ;

                String[] wordArrayD1 = test2.Split(' ');                             // Create array of words (no punctuation)
                String[] wordArrayD2 = TextBox1.Text.Split(' ');                     // Create array of words (normal text)                       

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

    protected void Button9_Click(object sender, EventArgs e)                             // ANALYSE-TEXT BUTTON
    {
        if (TextBox1.Text == "")                                                         // If input textBox is EMPTY     
        {
            TextBox1.Text = "Please type in some text.";                                 // Prompt user
        }
        else                                                                             
        {
            TextBox2.Text = "";                                                          // Clear the output textbox

            string test = TextBox1.Text;                                                 // String from input-textbox
            test = formatStringClass.formatString(test);                                 // Remove punctuation , . ! ? ( ) ' ;
            String[] wordArray = test.Split(' ');                                        // Create array of words

            bool containsRacism = false;                                                 // Flag for racist content 
            bool containsExpletive = false;                                              // Flag for expletive content

            string[] badWords1 = new string[2]  {"nigger", "niggers"};
            string[] badWords2 = new string[17] {"fuck", "fucks", "fucker", "fuckers", "fucking", "fucked",
                                             "shit", "shits", "shitty", "shiter", "shiting", "shitstorm",
                                             "piss", "pissing", "pissed", "cunt", "cunts"};

            foreach (string element1 in wordArray)                                       // Steps through each word from text box
            {
                foreach(string element2 in badWords1)                                    // Steps through racist word array
                {
                    if(element1 == element2)
                    {
                        containsRacism = true;                                           // Flag for racist content
                        break;                                                           // Move onto next foreach loop
                    }
                }

                foreach (string element3 in badWords2)                                   // Steps through expletive word array
                {
                    if (element1 == element3)
                    {
                        containsExpletive = true;                                        // Flag for expletive content
                        break;                                                           // Move onto next word from the text box
                    }
                }
            }                                                                            // End of nested Foreach loop
                                                                 
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
        }                                                                                 
    }                                                                                     // End of Analyse Text block
}                                                                                         // End of partial class _Default

public static class formatStringClass                                                     
{
    public static string formatString(string formatString)                                // Public method returns string
    {
        formatString = formatString.Replace(",", "").Replace(".", "").Replace("!", "").Replace("?", "").ToLower();
        formatString = formatString.Replace("'", "").Replace("(", "").Replace(")", "").Replace(";", "");
        return formatString;
    }                                                                                     // Remove punctuation , . ! ? ( ) ' ;
}