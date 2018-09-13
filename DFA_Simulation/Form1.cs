using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DFA_Simulation
{
    public partial class Form1 : Form
    {
        string[] test, dfaLanguage;
        string initialState, currentState, finalState;
        List<string> finalStates = new List<string>();
        DataTable name;
        bool invalidInput = false, initialStateSelectedOnce = false, finalStateSelectedOnce = false;
        public Form1()
        {
            InitializeComponent();
            name = new DataTable("name");
            name.Columns.Add(" ");

            dataGridView1.DataSource = name;
            dataGridView1.Columns[" "].ReadOnly = true;
            dataGridView1.Columns[" "].Frozen = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxStates.Text.Trim() != String.Empty && textBoxDfaLanguage.Text.Trim() != String.Empty)
            {
                char[] separatorChars = { ' ', ',', '.' };
                
                dfaLanguage = textBoxDfaLanguage.Text.Split(separatorChars, StringSplitOptions.RemoveEmptyEntries);
                test = textBoxStates.Text.Split(separatorChars, StringSplitOptions.RemoveEmptyEntries);

                if (dfaLanguage.Length != dfaLanguage.Distinct().Count())
                {
                    MessageBox.Show("The DFA Language contains same repeated symbol for differnt characters in the"
                        + " language. \n\nMake sure that every character possesses its own unique symbol", "Repeated "
                        + "Symbol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (test.Length != test.Distinct().Count())
                {
                    MessageBox.Show("Same name has been used for multiple states."
                        + " language. \n\nMake sure that every state possesses its own unique name", "Repeated "
                        + "Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (string character in dfaLanguage)
                {
                    name.Columns.Add(character);
                }

                foreach (var word in test)
                {
                    name.Rows.Add(word);
                }

                buttonGenerateTable.Enabled = false;
                textBoxDfaLanguage.ReadOnly = true;
                textBoxStates.ReadOnly = true;
                buttonClearTable.Enabled = true;
                buttonSetInitialState.Enabled = true;
                buttonSetFinalState.Enabled = true;
                checkBoxMultiFinal.Enabled = true;
            }

            //Make all the columns in the Data Grid View unsortable
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!buttonGenerateTable.Enabled)
            {
                name.Columns.Clear();
                name.Rows.Clear();

                name.Columns.Add(" ");
                dataGridView1.Columns[" "].ReadOnly = true;
                dataGridView1.Columns[" "].Frozen = true;
                buttonGenerateTable.Enabled = true;
                buttonClearTable.Enabled = false;
                buttonSetInitialState.Enabled = false;
                buttonSetFinalState.Enabled = false;
                checkBoxMultiFinal.Enabled = false;
            }

            initialStateSelectedOnce = false;
            finalStateSelectedOnce = false;

            labelInitialState.Text = "Initial State: ";
            labelFinalState.Text = "Final State: ";
            labelFinalStates.Text = "";

            checkBoxMultiFinal.Checked = false;
            checkBoxMultiFinal.Enabled = true;

            textBoxDfaLanguage.ReadOnly = false;
            textBoxStates.ReadOnly = false;
            buttonTestString.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            initialState = dataGridView1.SelectedCells[0].OwningRow.Cells[" "].Value.ToString();
            MessageBox.Show("     Initial State set to: " + initialState, "Initial State Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            labelInitialState.Text = "Initial State: " + initialState;
            initialStateSelectedOnce = true;

            if (initialStateSelectedOnce && finalStateSelectedOnce && !buttonTestString.Enabled)
            {
                buttonTestString.Enabled = true;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            finalStateSelectedOnce = true;

            if (!buttonClearFinalStates.Visible)
            {
                finalState = dataGridView1.SelectedCells[0].OwningRow.Cells[" "].Value.ToString();
                MessageBox.Show("     Final State set to: " + finalState, "Final State Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelFinalState.Text = "Final State: " + finalState;
            }

            else
            {
                checkBoxMultiFinal.Enabled = false;
                finalState = dataGridView1.SelectedCells[0].OwningRow.Cells[" "].Value.ToString();
                if (!finalStates.Contains(finalState))
                {
                    finalStates.Add(finalState);
                    labelFinalStates.Text += finalState + "\n";
                }

                else
                {
                    MessageBox.Show("     State \"" + finalState + "\" has already been selected as a final state.", "State Already Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (finalStateSelectedOnce && initialStateSelectedOnce && !buttonTestString.Enabled) buttonTestString.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            labelFinalStates.Text = "";
            finalStates.Clear();
            checkBoxMultiFinal.Enabled = true;
            finalStateSelectedOnce = false;
            buttonTestString.Enabled = false;
        }



        private void checkBoxMultiFinal_CheckedChanged(object sender, EventArgs e)
        {
            if (!buttonClearFinalStates.Visible)
            {
                buttonClearFinalStates.Enabled = true;
                buttonClearFinalStates.Visible = true;
                labelFinalState.Text = "Final States: ";
               
            }

            else
            {
                buttonClearFinalStates.Visible = false;
                buttonClearFinalStates.Enabled = false;
                labelFinalState.Text = "Final State: ";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //This ensures that there are neither accidental nor deliberate whitespaces in the input string
            textBoxTestString.Text = textBoxTestString.Text.Replace(" ", "");

            #region Validating Input String

            //This loop compares every individual character of input string to the characters entered in dfaLanguage.
            int j;
            for (j = 0; j < textBoxTestString.Text.Length; j++)
            {
                 if (!dfaLanguage.Contains(textBoxTestString.Text[j].ToString()))
                {
                    invalidInput = true;    //A single invalid character is enough to invalidate entire input string
                }
            }
            #endregion

            //Reset the currentState back to initialState before traversing Transition Table again
            //This is to ensure that the DFA works correct if user decides to check input string again.
            currentState = initialState;

            //Only proceed if input string is valid
            if (!invalidInput)
            {
                //Separating the input string's characters into a char array
                char[] inputString = textBoxTestString.Text.ToCharArray();

                //To ensure that stack doesn't change the order of input string's characters, 
                //and transition table is traversed correctly. The following reverses the order of the input string's 
                //characters. Thus, when stack is popped, characters come out in their original order.
                Array.Reverse(inputString);
                Stack<char> stack = new Stack<char>();
                foreach (char letter in inputString)
                {
                    stack.Push(letter);
                }

                char poppedCharacter;    //poppedCharacter will store the stack's popped character

                
                

                int i;
                int rowIndex = -1;
                bool innerloopBroken = false;
                for (i = 0; i < inputString.Length; i++)
                {
                    #region Validiting State Names in Transition Table

                    //This traverses through all the rows in the Transition Table.
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        //If a particular row's states' column contains the state which is equal to the currentState
                        if (row.Cells[" "].Value.ToString().Equals(currentState))
                        {
                            rowIndex = row.Index;   //Then fetch that particular row's index.
                            break;
                        }
                        else
                        {
                            rowIndex = -1;         //If currentState doesn't contain valid state name, set index to -1
                        }
                    }

                    #endregion
                    
                    //Since the currentState didn't contain a valid state name
                    if (rowIndex == -1)
                    {
                        //Throw error message
                        MessageBox.Show("One or more states entered in the Transition Table do not match the names of "
                        + "any of the states entered. \n\nCorrect the Transition Table, and try again.",
                                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //And break out of the loop
                        innerloopBroken = true;
                        break;
                    }
                    else
                    {
                        //This stores the previous state, in case the user wishes to see step by step traversal
                        string previousState = currentState;
                        
                        //Save popped character in poppedCharacter
                        poppedCharacter = stack.Pop();

                        //rowIndex indicates the index of the row of the current state, poppedCharacter is the character
                        //encountered in the input string. Both poppedCharacter and rowIndex give the exact location
                        //of the cell to store its value as the next current state
                        currentState = dataGridView1.Rows[rowIndex].Cells[poppedCharacter.ToString()].Value.ToString();
                                             
                        
                        if (checkBoxShowTraverse.Checked)
                        {
                            MessageBox.Show("Current State" + "\t" + "->" + "\t" + "Transition \t" + "->" + "\t" + 
                                            "Next State\n" + previousState + "\t \t  " + "\t" + poppedCharacter + 
                                            "\t \t  " + "\t" + currentState, "Step-by-step State Transition",
                                            MessageBoxButtons.OK);
                        }
                    }
                }

                if (!innerloopBroken)
                {
                    if (!checkBoxMultiFinal.Checked)
                    {
                        if (currentState != finalState) MessageBox.Show("     Input String Rejected!", "Invalid String", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else MessageBox.Show("     Input String Accepted", "Valid String", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        if (!finalStates.Contains(currentState)) MessageBox.Show("     Input String Rejected!", "Invalid String", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else MessageBox.Show("     Input String Accepted", "Valid String", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            else
            {
                MessageBox.Show("Illegal character(s) encountered.\n\n"
                                 + "Make sure that the entered input string only contains the characters "
                                 + "as defined in the language.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                invalidInput = false;
            }
        
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitDialogResult = MessageBox.Show("Are you sure you want to exit the application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (exitDialogResult == DialogResult.Yes) Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "This program simulates Deterministic Finite Automata (DFA) Machine.\n\n"                   +
                "It takes language characters, states, and transition table as input, and tests a\n"        +
                "string to check whether it will be accepted or rejected by the given DFA.\n\n"              +

                "Developed by:\n\n"                                                                         +
                "Adeel Ahmed S/O Sohail Ahmed\n"                                                            +
                "Class Roll # 07\n"                                                                         +
                "Theory of Automata\n"                                                                      +
                "BSCS 5, Section A (Evening)\n"                                                             +
                "FUUAST, Gulshan-e-Iqbal, Karachi", 
                            
                "Project by Adeel Ahmed");
        }

        private void tutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Showing tutorial directly via MessageBox produces inconsistent formatting across different machines
            //MessageBox.Show(
            //"   This program simulates Deterministic Finite Automata (DFA) Machine.\n\n"                        +
            //"   It takes language characters, states, and transition table as input, and tests a\n"             +
            //"   string to check whether it will be accepted or rejected by the given DFA.\n\n"                  +
            //"   To use this program, follow these steps:\n\n"                                                   +
            //"   1.  Enter a unique symbol for every character in the DFA language\n"                            +
            //"        (separate each character by either comma, dot, or space)\n\n"                              +
            //"   2.  Enter a unique name for every state in the DFA\n"                                           +
            //"        (each state separated by either comma, dot, or space)\n\n"                                 + 
            //"   3.  Click on \"Generate Transition Table\" button.\n\n"                                         + 
            //"   4.  Enter the corresponding states for their respective transitions\n"                          +
            //"        for every state\n\n"                                                                       +
            //"   5.  To set initial state: first click on any one of the states to select it,\n"                 +
            //"        then click on \"Set Initial State\" button to set that state as initial state\n\n"         +
            //"   6.  Similarly, to set final state: first click on any one of states to select it,\n"            +
            //"        then click on \"Set Final State\" button to set that state as final state\n\n"             +   
            //"   7.  To set multiple final states, check \"Multiple Final States\", and then repeat\n"           +
            //"         Step 6 for every state needed to be set as final state.\n\n"                              +
            //"   8.  To test the DFA, enter test string in text box, then click \"Test String\" button.\n\n"     +
            //"   9.  You can see step-by-step traversion by checking the appropriate checkbox.\n\n"              +
            //"   Tip:\n"                                                                                         +
            //"          You can click on \"?\" button (next to close button) in the program, \n"                 +
            //"          and then click on any element to learn more about that particular element\n"             +
            //"          and its purpose in the program."

            //, "How to use this program --- A Step by Step Guide");
            #endregion
                   
            //Instead, create a form which contains the above text in a label, and call it whenever tutorial is clicked
            new FormTutorial().ShowDialog();
        }
   
    }
}
