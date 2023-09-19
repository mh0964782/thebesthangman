using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace TheBestHangman
{
    public partial class Form2 : Form
    {
        public Form2(string name, string filePath, string fileName, int curScore)
        {
            // On each instance of a game, set properties of the player's name, the filepath for the words,
            // The filename for the words, the current score (kept over multiple games when played again), and guesses left.
            // Run functions to get a new word, display it, display guesses left and the current score, and the player's name in the header.
            InitializeComponent();
            Name = name;
            FilePath = filePath;
            FileName = fileName;
            CurScore = curScore;
            Word = GetWord();
            DisplayWord();
            GuessesLeft = 6;
            lbl_guesses.Text += GuessesLeft.ToString();
            lbl_score.Text += CurScore.ToString();
            this.Text = $"Current Game - {Name}";
        }

        // All properties needed to be scoped to the current diffculty/game instance.
        public string Name { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public int CurScore { get; set; }
        public int GuessesLeft { get; set; }
        public string Word { get; set; }

        private string GetWord()
        {
            // create a list to hold the words
            List<string> wordList = new List<string>();
            // declare a variable to hold the new word
            string newWord;

            try
            {
                // open the file at the specified file path
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    string line;
                    // read each line in the file and add it to the list of words
                    while ((line = sr.ReadLine()) != null)
                    {
                        wordList.Add(line);
                    }
                }
            }
            catch (IOException e)
            {
                // if there's an error reading the file, write an error message to the console
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            // choose a random number between 0 and the number of words in the list
            Random rnd = new Random();
            int rndNum = rnd.Next(0, wordList.Count);
            // set the new word to be the word at the randomly chosen index
            newWord = wordList[rndNum];
            // return the new word
            return newWord;
        }


        private void disableKeyboard()
        {
            // disable all of the letter buttons
            qButton.Enabled = false;
            wButton.Enabled = false;
            eButton.Enabled = false;
            rButton.Enabled = false;
            tButton.Enabled = false;
            yButton.Enabled = false;
            uButton.Enabled = false;
            iButton.Enabled = false;
            oButton.Enabled = false;
            pButton.Enabled = false;
            aButton.Enabled = false;
            sButton.Enabled = false;
            dButton.Enabled = false;
            fButton.Enabled = false;
            gButton.Enabled = false;
            hButton.Enabled = false;
            jButton.Enabled = false;
            kButton.Enabled = false;
            lButton.Enabled = false;
            zButton.Enabled = false;
            xButton.Enabled = false;
            cButton.Enabled = false;
            vButton.Enabled = false;
            bButton.Enabled = false;
            nButton.Enabled = false;
            mButton.Enabled = false;
        }


        private void DisplayWord()
        {
            // create an empty string to hold the displayed word
            string displayStr = "";
            // for each letter in the chosen word, add an underscore and a space to the displayed word
            for (int i = 0; i < Word.Length; i++)
            {
                displayStr += "_ ";
            }
            // set the text of the label to the displayed word
            lbl_displayStr.Text = displayStr;
        }

        // declare a variable to hold the current picture index
        int currentPictureIndex = 0;

        private void UpdateDisplay(char letter, Button btn)
        {
            // set a flag to false indicating that the guessed letter is not in the word
            bool letterInWord = false;

            // check each letter in the word to see if it matches the guessed letter
            for (int i = 0; i < Word.Length; i++)
            {
                if (Word[i] == letter)
                {
                    // if the guessed letter is in the word, change the color of the button to light green
                    btn.BackColor = Color.LightGreen;
                    // set the flag to true indicating that the guessed letter is in the word
                    letterInWord = true;
                    // exit the loop
                    break;
                }
            }

            // if the guessed letter is in the word
            if (letterInWord)
            {
                // create a char array from the displayed word
                char[] slicedDisplay = lbl_displayStr.Text.ToCharArray();

                for (int i = 0; i < Word.Length; i++)
                {
                    // if the guessed letter matches the letter at position i
                    if (Word[i] == letter)
                    {
                        // update the slicedDisplay string at the appropriate index
                        slicedDisplay[((i * 2))] = letter;
                    }
                }

                // convert the slicedDisplay character array into a string
                string newDisplay = "";
                for (int i = 0; i < slicedDisplay.Length; i++)
                {
                    newDisplay += Convert.ToString(slicedDisplay[i]);
                }

                // update the displayed string with the newDisplay string
                lbl_displayStr.Text = newDisplay;

                // check if the word has been fully guessed
                bool finishedWord = true;
                foreach (char character in lbl_displayStr.Text)
                {
                    // if there is still a blank space in the displayed string
                    if (character == '_')
                    {
                        finishedWord = false;
                        break;
                    }
                }

                // if the word has been fully guessed
                if (finishedWord)
                {
                    // update the score and game status
                    if (currentPictureIndex == 0)
                    {
                        // The player guessed perfectly.
                        CurScore += 2;
                    }
                    else
                    {
                        // The player guessed the word with at least one wrong guess.
                        CurScore += 1;
                    }
                    lbl_score.Text = "Current Score: " + CurScore.ToString();
                    lbl_gameStatus.Text = "You solved the word!";

                    // enable the play again and quit buttons, and disable the keyboard
                    btn_playAgain.Enabled = true;
                    btn_playAgain.Visible = true;
                    btn_quit.Enabled = true;
                    btn_quit.Visible = true;
                    disableKeyboard();
                }
            }
            else
            {
                btn.BackColor = Color.IndianRed;
                // Simulate a negative value received through the bad button press
                int badButtonPressValue = -1;

                // Check if the bad button press value is negative
                if (badButtonPressValue < 0)
                {
                    // Update the counter to the next picture in the sequence
                    currentPictureIndex = (currentPictureIndex + 1) % iml_hanging.Images.Count;

                    // Display the new picture
                    ptb_hanging.Image = iml_hanging.Images[currentPictureIndex];
                }

                // The guess was wrong, so guesses left decreases.
                GuessesLeft--;
                lbl_guesses.Text = "Guesses Left: " + GuessesLeft.ToString();

                if (GuessesLeft <= 0)
                {
                    // If the player ran out of the 6 guesses, the status is updated, the quit button is displayed, and the keyboard is disabled.
                    lbl_gameStatus.Text = $"You lost the game!\nThe word was: {Word}";
                    btn_quit.Enabled = true;
                    btn_quit.Visible = true;
                    disableKeyboard();
                }
            }
        }

        private void setScore()
        {
            // substring the filpath to tell which file it is
            if (FileName == "EasyWords.txt")
            {
                //init list
                List<string> fileLines = new List<string>();
                //filepath to score
                string scoreFilePath = Path.Combine(FilePath.Substring(0, FilePath.Length - FileName.Length), "EasyHighscore.txt");
                //Initialize reader object and read in first line of file
                StreamReader reader = new StreamReader(scoreFilePath);

                //init temp var
                string temp;
                //loop while temp isnt null
                do
                {
                    //set temp to the file current line
                    temp = reader.ReadLine();
                    //if temp is null stop loop
                    if (temp == null)
                    {
                        break;
                    }
                    //add the line to the list
                    fileLines.Add(temp);
                } while (temp != null);
                reader.Close();


                //Initialize the streamWriter
                StreamWriter writer = new StreamWriter(scoreFilePath);
                //write old data
                for (int i = 0; i < fileLines.Count; i++)
                {
                    writer.WriteLine(fileLines[i]);
                }
                //write new name and score
                writer.WriteLine(Name + "," + CurScore);
                writer.Close();
            }
            else if (FileName == "MedWords.txt")
            {
                //init list
                List<string> fileLines = new List<string>();
                //filepath to score
                string scoreFilePath = Path.Combine(FilePath.Substring(0, FilePath.Length - FileName.Length), "MidHighscore.txt");
                //Initialize reader object and read in first line of file
                StreamReader reader = new StreamReader(scoreFilePath);

                //init temp var
                string temp;
                //loop while temp isnt null
                do
                {
                    //set temp to the file current line
                    temp = reader.ReadLine();
                    //if temp is null stop loop
                    if (temp == null)
                    {
                        break;
                    }
                    //add the line to the list
                    fileLines.Add(temp);
                } while (temp != null);
                reader.Close();


                //Initialize the streamWriter
                StreamWriter writer = new StreamWriter(scoreFilePath);
                //write old data
                for (int i = 0; i < fileLines.Count; i++)
                {
                    writer.WriteLine(fileLines[i]);
                }
                //write new name and score
                writer.WriteLine(Name + "," + CurScore);
                writer.Close();
            }
            else if (FileName == "HardWords.txt")
            {
                //init list
                List<string> fileLines = new List<string>();
                //filepath to score
                string scoreFilePath = Path.Combine(FilePath.Substring(0, FilePath.Length - FileName.Length), "HardHighscore.txt");
                //Initialize reader object and read in first line of file
                StreamReader reader = new StreamReader(scoreFilePath);

                //init temp var
                string temp;
                //loop while temp isnt null
                do
                {
                    //set temp to the file current line
                    temp = reader.ReadLine();
                    //if temp is null stop loop
                    if (temp == null)
                    {
                        break;
                    }
                    //add the line to the list
                    fileLines.Add(temp);
                } while (temp != null);
                reader.Close();


                //Initialize the streamWriter
                StreamWriter writer = new StreamWriter(scoreFilePath);
                //write old data
                for (int i = 0; i < fileLines.Count; i++)
                {
                    writer.WriteLine(fileLines[i]);
                }
                //write new name and score
                writer.WriteLine(Name + "," + CurScore);
                writer.Close();
            }

        }

        private void ptb_hanging_Click(object sender, EventArgs e)
        { }

        private void lbl_score_Click(object sender, EventArgs e)
        {

        }

        // 26 Functions to update the display and disable the button when clicked for a choice.
        private void qButton_Click_1(object sender, EventArgs e)
        {
            qButton.Enabled = false;
            UpdateDisplay('q', qButton);
        }

        private void wButton_Click_1(object sender, EventArgs e)
        {
            wButton.Enabled = false;
            UpdateDisplay('w', wButton);
        }

        private void eButton_Click_1(object sender, EventArgs e)
        {
            eButton.Enabled = false;
            UpdateDisplay('e', eButton);
        }

        private void rButton_Click_1(object sender, EventArgs e)
        {
            rButton.Enabled = false;
            UpdateDisplay('r', rButton);
        }

        private void tButton_Click_1(object sender, EventArgs e)
        {
            tButton.Enabled = false;
            UpdateDisplay('t', tButton);
        }

        private void yButton_Click_1(object sender, EventArgs e)
        {
            yButton.Enabled = false;
            UpdateDisplay('y', yButton);
        }

        private void uButton_Click_1(object sender, EventArgs e)
        {
            uButton.Enabled = false;
            UpdateDisplay('u', uButton);
        }

        private void iButton_Click_1(object sender, EventArgs e)
        {
            iButton.Enabled = false;
            UpdateDisplay('i', iButton);
        }

        private void oButton_Click_1(object sender, EventArgs e)
        {
            oButton.Enabled = false;
            UpdateDisplay('o', oButton);
        }

        private void pButton_Click_1(object sender, EventArgs e)
        {
            pButton.Enabled = false;
            UpdateDisplay('p', pButton);
        }

        private void aButton_Click_1(object sender, EventArgs e)
        {
            aButton.Enabled = false;
            UpdateDisplay('a', aButton);
        }

        private void sButton_Click_1(object sender, EventArgs e)
        {
            sButton.Enabled = false;
            UpdateDisplay('s', sButton);
        }

        private void dButton_Click_1(object sender, EventArgs e)
        {
            dButton.Enabled = false;
            UpdateDisplay('d', dButton);
        }

        private void fButton_Click_1(object sender, EventArgs e)
        {
            fButton.Enabled = false;
            UpdateDisplay('f', fButton);
        }

        private void gButton_Click_1(object sender, EventArgs e)
        {
            gButton.Enabled = false;
            UpdateDisplay('g', gButton);
        }

        private void hButton_Click_1(object sender, EventArgs e)
        {
            hButton.Enabled = false;
            UpdateDisplay('h', hButton);
        }

        private void jButton_Click_1(object sender, EventArgs e)
        {
            jButton.Enabled = false;
            UpdateDisplay('j', jButton);
        }

        private void kButton_Click_1(object sender, EventArgs e)
        {
            kButton.Enabled = false;
            UpdateDisplay('k', kButton);
        }

        private void lButton_Click_1(object sender, EventArgs e)
        {
            lButton.Enabled = false;
            UpdateDisplay('l', lButton);
        }

        private void zButton_Click_1(object sender, EventArgs e)
        {
            zButton.Enabled = false;
            UpdateDisplay('z', zButton);
        }

        private void xButton_Click_1(object sender, EventArgs e)
        {
            xButton.Enabled = false;
            UpdateDisplay('x', xButton);
        }

        private void cButton_Click_1(object sender, EventArgs e)
        {
            cButton.Enabled = false;
            UpdateDisplay('c', cButton);
        }

        private void vButton_Click_1(object sender, EventArgs e)
        {
            vButton.Enabled = false;
            UpdateDisplay('v', vButton);
        }

        private void bButton_Click_1(object sender, EventArgs e)
        {
            bButton.Enabled = false;
            UpdateDisplay('b', bButton);
        }

        private void nButton_Click_1(object sender, EventArgs e)
        {
            nButton.Enabled = false;
            UpdateDisplay('n', nButton);
        }

        private void mButton_Click_1(object sender, EventArgs e)
        {
            mButton.Enabled = false;
            UpdateDisplay('m', mButton);
        }



        private void btn_quit_Click_1(object sender, EventArgs e)
        {
            // The score is saved with setScore() when the user quits, and they are put back in the main menu to start again.
            setScore();
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void btn_playAgain_Click_1(object sender, EventArgs e)
        {
            // The user choose to play again, so a new Form2 instance is created that carries over the score, difficulty, and player name.
            Form2 currentGame = new Form2(Name, FilePath, FileName, CurScore);
            this.Hide();
            currentGame.ShowDialog();
            this.Close();
        }
    }
}
