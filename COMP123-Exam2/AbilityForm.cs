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
    public partial class AbilityForm : Form
    {
        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private Random _rnd = new Random();
        private Character _character;
        

        // CONSTRUCTOR ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        /* MODIFY CODE HERE ----
                               |
                               |
                               V
         * Modify the AbilityForm default constructor to receive a local character variable of type Character (1 Mark: Functionality)
         */
        public AbilityForm(Character character)
        {
            InitializeComponent();
            this._character = character;
            
        }

        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private int _roll4d6()
        {
            List<int> dice = new List<int>();

            int sum = 0;

            for (int die = 0; die < 4; die++)
            {
                dice.Add(_rnd.Next(6) + 1);
            }
            dice.Sort();

            sum = dice[1] + dice[2] + dice[3];
            

            return sum;
        }

        
        private void GenerateAbilityButton_Click(object sender, EventArgs e)
        {

            
            this._character.Strength = this._roll4d6();
            StrengthTextBox.Text = this._character.Strength.ToString();
            this._character.Dexterity = this._roll4d6();
            DexterityTextBox.Text = this._character.Dexterity.ToString();
            this._character.Constitution = this._roll4d6();
            ConstitutionTextBox.Text = this._character.Constitution.ToString();
            this._character.intelligence = this._roll4d6();
            IntelligenceTextBox.Text = this._character.intelligence.ToString();
            this._character.Wisdom = this._roll4d6();
            WisdomTextBox.Text = this._character.Wisdom.ToString();
            this._character.Charisma = this._roll4d6();
            CharismaTextBox.Text = this._character.Charisma.ToString();
             
            
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            FinalForm finalForm = new FinalForm(this._character);

            this.Hide();
            finalForm.Owner = this;
            this.Hide();
            finalForm.Show();


        }

        private void AbilityForm_Load(object sender, EventArgs e)
        {
            this.GenerateAbilityButton_Click(sender, e);
        }
    }
}
