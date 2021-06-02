using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Windows.Forms;
using System.Runtime;
using System.Threading;
using System.Resources;
using Microsoft.WindowsCE.Forms;

namespace Linguistico.NET_Mobile
{

    public partial class MainWnd : Form
    {
        private DataContainer DataDct; //holds the actual data
        private InputPanel inputPanel; //keyboard input panel (smart pc)
        
        //handles resources
        private ResourceManager rm = new ResourceManager("Linguistico.NET_Mobile.dict_resources",
                System.Reflection.Assembly.GetExecutingAssembly());
            
        //Initialization
        public MainWnd(bool b)
        {
            InitializeComponent();

            if (b)
            { InitInputPanel(); }
            
            ChangingDctInfo();
            ColorBtns(germanBtn);
            DataDct = new DataContainer(rm.GetString("english_german"), ListOfVocab);

        }
        
        //shows input panel
        public void InitInputPanel()
        { 
            inputPanel = new InputPanel();
            inputPanel.Enabled = true;
        }

        /**
         * Button - Looks up an entry
         */
        private void Find_Click(object sender, EventArgs e)
        {
            DataDct.LookUp(FindTextBox.Text, ListOfVocab);
        }

        /**
         * Button - switches to Czech language
         */
        private void CzechBtn_Click(object sender, EventArgs e)
        {
            ChangingDctInfo();
            ColorBtns(czechBtn);
            DataDct = new DataContainer(rm.GetString("english_czech"), ListOfVocab);
            DataDct.LookUp(FindTextBox.Text, ListOfVocab);
        }

        /**
         * Button - switches to French language
         */
        private void FrenchBtn_Click(object sender, EventArgs e)
        {
            ChangingDctInfo();
            ColorBtns(frenchBtn);
            DataDct = new DataContainer(rm.GetString("english_french"), ListOfVocab);
            DataDct.LookUp(FindTextBox.Text, ListOfVocab);

        }

        /**
         * Button - switches to Spanish language
         */
        private void SpanishBtn_Click(object sender, EventArgs e)
        {
            ChangingDctInfo();
            ColorBtns(spanishBtn);
            DataDct = new DataContainer(rm.GetString("english_spanish"), ListOfVocab);
            DataDct.LookUp(FindTextBox.Text, ListOfVocab);

        }


        /**
         * Button - switches to German language
         */
        private void GermanBtn_Click(object sender, EventArgs e)
        {
            ChangingDctInfo();
            ColorBtns(germanBtn);
            DataDct = new DataContainer(rm.GetString("english_german"), ListOfVocab);
            DataDct.LookUp(FindTextBox.Text, ListOfVocab);
        }


        private void FindTextBoxFocus(object sender, EventArgs e)
        {
            FindTextBox.SelectAll();
        }

        /**
         * If Enter pressed, look up a word.
         */
        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                DataDct.LookUp(FindTextBox.Text, ListOfVocab);
                FindTextBox.SelectAll();
            }

        }

        /**
         * Show the current entry in the textBox.
         */
        private void updateTextBox(object sender, EventArgs e)
        {
            showEntryBox.Text = (String)ListOfVocab.SelectedItem;
        }

        private void ColorBtns(Button b)
        {
            czechBtn.BackColor = Color.DodgerBlue;
            spanishBtn.BackColor = Color.DodgerBlue;
            frenchBtn.BackColor = Color.DodgerBlue;
            germanBtn.BackColor = Color.DodgerBlue;
            b.BackColor = Color.Lime;
            b.Refresh();


        }

        private void ChangingDctInfo()
        {
            showEntryBox.Text = "Changing dictionary...";
            showEntryBox.SelectAll();
        }

        private void FindTextBox_GotFocus(object sender, EventArgs e)
        {
            showEntryBox.SelectAll();
        }


    }
}