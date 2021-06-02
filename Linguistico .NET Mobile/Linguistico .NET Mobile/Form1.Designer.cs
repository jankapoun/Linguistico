namespace Linguistico.NET_Mobile
{
    partial class MainWnd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWnd));
            this.germanBtn = new System.Windows.Forms.Button();
            this.spanishBtn = new System.Windows.Forms.Button();
            this.ListOfVocab = new System.Windows.Forms.ListBox();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.showEntryBox = new System.Windows.Forms.TextBox();
            this.frenchBtn = new System.Windows.Forms.Button();
            this.czechBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // germanBtn
            // 
            this.germanBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.germanBtn.Location = new System.Drawing.Point(3, 270);
            this.germanBtn.Name = "germanBtn";
            this.germanBtn.Size = new System.Drawing.Size(32, 21);
            this.germanBtn.TabIndex = 1;
            this.germanBtn.Text = "Ger";
            this.germanBtn.Click += new System.EventHandler(this.GermanBtn_Click);
            // 
            // spanishBtn
            // 
            this.spanishBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.spanishBtn.Location = new System.Drawing.Point(38, 270);
            this.spanishBtn.Name = "spanishBtn";
            this.spanishBtn.Size = new System.Drawing.Size(32, 21);
            this.spanishBtn.TabIndex = 2;
            this.spanishBtn.Text = "Esp";
            this.spanishBtn.Click += new System.EventHandler(this.SpanishBtn_Click);
            // 
            // ListOfVocab
            // 
            this.ListOfVocab.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ListOfVocab.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold);
            this.ListOfVocab.Location = new System.Drawing.Point(0, -2);
            this.ListOfVocab.Name = "ListOfVocab";
            this.ListOfVocab.Size = new System.Drawing.Size(240, 170);
            this.ListOfVocab.TabIndex = 5;
            this.ListOfVocab.SelectedIndexChanged += new System.EventHandler(this.updateTextBox);
            this.ListOfVocab.GotFocus += new System.EventHandler(this.FindTextBox_GotFocus);
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(144, 270);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(57, 21);
            this.FindTextBox.TabIndex = 6;
            this.FindTextBox.GotFocus += new System.EventHandler(this.FindTextBox_GotFocus);
            this.FindTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // showEntryBox
            // 
            this.showEntryBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.showEntryBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.showEntryBox.Location = new System.Drawing.Point(0, 167);
            this.showEntryBox.Multiline = true;
            this.showEntryBox.Name = "showEntryBox";
            this.showEntryBox.ReadOnly = true;
            this.showEntryBox.Size = new System.Drawing.Size(240, 21);
            this.showEntryBox.TabIndex = 8;
            this.showEntryBox.Text = "textBox1";
            // 
            // frenchBtn
            // 
            this.frenchBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.frenchBtn.Location = new System.Drawing.Point(73, 270);
            this.frenchBtn.Name = "frenchBtn";
            this.frenchBtn.Size = new System.Drawing.Size(32, 21);
            this.frenchBtn.TabIndex = 10;
            this.frenchBtn.Text = "Fr";
            this.frenchBtn.Click += new System.EventHandler(this.FrenchBtn_Click);
            // 
            // czechBtn
            // 
            this.czechBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.czechBtn.Location = new System.Drawing.Point(108, 270);
            this.czechBtn.Name = "czechBtn";
            this.czechBtn.Size = new System.Drawing.Size(32, 21);
            this.czechBtn.TabIndex = 11;
            this.czechBtn.Text = "Cz";
            this.czechBtn.Click += new System.EventHandler(this.CzechBtn_Click);
            // 
            // MainWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.czechBtn);
            this.Controls.Add(this.frenchBtn);
            this.Controls.Add(this.showEntryBox);
            this.Controls.Add(this.FindTextBox);
            this.Controls.Add(this.ListOfVocab);
            this.Controls.Add(this.spanishBtn);
            this.Controls.Add(this.germanBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWnd";
            this.Text = "Linguistico .NET Mobile";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button germanBtn;
        private System.Windows.Forms.Button spanishBtn;
        private System.Windows.Forms.ListBox ListOfVocab;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.TextBox showEntryBox;
        private System.Windows.Forms.Button frenchBtn;
        private System.Windows.Forms.Button czechBtn;
        
    }
}

