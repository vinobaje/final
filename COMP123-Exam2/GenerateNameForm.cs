using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace COMP123_Exam2
{
    public partial class GenerateNameForm : Form
    {

        //PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++
        private List<string> _firstNames = new List<string>();
        private List<string> _lastNames = new List<string>();
        private Random _rnd = new Random();

       
        private Character _character = new Character();
        
            // CONSTRUCTOR +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public GenerateNameForm()
        {
            InitializeComponent();

            this._populateNamesList("firstNames.txt", this._firstNames);
            this._populateNamesList("lastNames.txt", this._lastNames);
        }

        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // This method reads the file and adds the names to each name list
        private void _populateNamesList(string FileName, List<string> nameList)
        {
            FileStream inFile = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            while (reader.ReadLine() != null)
            {
                string lineFromFile;
                lineFromFile= reader.ReadLine();
                nameList.Add(lineFromFile);
                
            }
            reader.Close();
            inFile.Close();
        }

        /* This event handler generates a random firstName and lastName,
         * displays the results to FirstNameTextBox.Text and LastNameTextBox.Text
         * and saves this information in the _character object
        */
        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
             
            
            string randomFirstName = this._firstNames[this._rnd.Next(this._firstNames.Count)];
            string randomLastName = this._lastNames[this._rnd.Next(this._lastNames.Count)];

            FirstNameTextBox.Text = randomFirstName;
            LastNameTextBox.Text = randomLastName;
            //seting the values to 
             _character.FirstName = FirstNameTextBox.Text;
             _character.LastName = LastNameTextBox.Text;

           
        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateNameButton_Click(sender, e);
        }
        // creating a new abilityForm object and passing the _character
        private void NextButton_Click(object sender, EventArgs e)
        {

            AbilityForm abilityForm = new AbilityForm(this._character);

            this.Hide();
            abilityForm.Owner = this;
            
            this.Hide();
            abilityForm.Show();
            
        }


    }
}
