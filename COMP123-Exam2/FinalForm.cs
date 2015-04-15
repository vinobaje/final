using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Exam2
{
    public partial class FinalForm : Form
    {
        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++
        private Character _character;
  
        // CONSTRUCTOR ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

       
        public FinalForm(Character character)
        {
            InitializeComponent();
            this._character = character;

            this._populateForm();
        }

        // PRIVATE METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void _populateForm()
        {


            FirstNameTextBox.Text = this._character.FirstName;
            LastNameTextBox.Text = this._character.LastName;
            StrengthTextBox.Text = this._character.Strength.ToString();
            DexterityTextBox.Text = this._character.Dexterity.ToString();
            ConstitutionTextBox.Text = this._character.Constitution.ToString();
            IntelligenceTextBox.Text = this._character.intelligence.ToString();
            WisdomTextBox.Text = this._character.Wisdom.ToString();
            CharismaTextBox.Text = this._character.Charisma.ToString();
             
           
        }
        //exting the application
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //print preview of a screenshot
        private void PrintButton_Click(object sender, EventArgs e)
        {
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }
        //show the About box dialog
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();

            aboutBox.ShowDialog();
        }
        //print preview of a screenshot
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }
    }
}
