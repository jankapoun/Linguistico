using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;


namespace Linguistico.NET_Mobile
{
    
    class DataContainer
    {
        
        public String[] wordPairs; //english/czech word pairs
        public String rawData; //raw data from a file
        private ListBox ListOfVocab = new ListBox();

        /**
         * Constructor
         */ 
        public DataContainer(String fileName, ListBox lBox) 
        {
            this.ListOfVocab = lBox;
            DataLoad(fileName);
            CreateWordPairs();
            ListOfVocab.Items.Clear();
            FillListBox();
            ListOfVocab.SelectedIndex = 0;
            
        }

        /**
         * Creates word pairs
         */ 
        public void CreateWordPairs()
        {
            char[] delimiter = { '\n' };
            wordPairs =  (String[]) rawData.Split(delimiter);
        }
        
        /**
         * Fills a listBox with dictionary entries
         */ 
        public void FillListBox()
        {
            IEnumerator i = wordPairs.GetEnumerator();
            FillListBox(i);
        }

        public void FillListBox(IEnumerator i)
        {
            String string1;
            String string2;
            
            for (int l = 0; l < 20; l++) 
            {
                string2 = "";
                if (!i.MoveNext()) { return; }

                string1 = (String)i.Current;
                foreach (char c in string1)
                {
                    if (c == 9)
                    {
                        for (int k = string2.Length; k < 14; k++)
                        { string2 += " "; }
                    }
                    else
                    if (c != 0 && c != 13 ) { string2 += c; }
                }
                ListOfVocab.Items.Add(string2);
            }
        }

        /**
         * Looks up a given word and fills the listBox accordingly
         */ 
        public void LookUp(String lookup, ListBox lBox)
        {
            int index = LookUp(lookup);
            lBox.Items.Clear();
            if (index == -1) { lBox.Items.Add("No entry found..."); return; }
            IEnumerator i = wordPairs.GetEnumerator();
            
            for (int k = 0; k < index; k++){i.MoveNext();}
            FillListBox(i);
            ListOfVocab.SelectedIndex = 0;

        }

        /**
         * Looks up a given word in the raw data string.
         */ 
        public int LookUp(String lookup)
        {
            IEnumerator i = wordPairs.GetEnumerator();
            String found;
            int count = 0;
            while (i.MoveNext())
            {
                found = (String)i.Current;
                if (found.StartsWith(lookup)){return count;}
                count++;
                
            } 
            return -1;
        }

       /**
        * Loads data from the disk
        */ 
        public void DataLoad(String s) //nahraje surova data do pameti
        {
            rawData = s;
            //FileInfo fi = new FileInfo(s);
            //try
            //{
            //    rawData = (String)fi.OpenText().ReadToEnd();
            //}
            //catch (Exception e)
            //{
            //    ListOfVocab.Items.Add(e.Message);
            //}
            
        }
    }

}
