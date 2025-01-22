using System;
using System.IO;
using System.Windows.Forms;

namespace DnD_Character_Creation
{
    public partial class MainForm : Form
    {
        private Character currentCharacter;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxRace = new System.Windows.Forms.ComboBox();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.numericUpDownStrength = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDexterity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownConstitution = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIntelligence = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWisdom = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCharisma = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDexterity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConstitution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntelligence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWisdom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharisma)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(20, 20);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 20);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.Text = "Enter character name";
            // 
            // comboBoxRace
            // 
            this.comboBoxRace.Items.AddRange(new object[] {
            "Human",
            "Elf",
            "Dwarf",
            "Halfling",
            "Orc"});
            this.comboBoxRace.Location = new System.Drawing.Point(20, 60);
            this.comboBoxRace.Name = "comboBoxRace";
            this.comboBoxRace.Size = new System.Drawing.Size(200, 21);
            this.comboBoxRace.TabIndex = 1;
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.Items.AddRange(new object[] {
            "Fighter",
            "Wizard",
            "Rogue",
            "Cleric",
            "Ranger"});
            this.comboBoxClass.Location = new System.Drawing.Point(20, 100);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(200, 21);
            this.comboBoxClass.TabIndex = 2;
            // 
            // numericUpDownStrength
            // 
            this.numericUpDownStrength.Location = new System.Drawing.Point(20, 140);
            this.numericUpDownStrength.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownStrength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStrength.Name = "numericUpDownStrength";
            this.numericUpDownStrength.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownStrength.TabIndex = 3;
            this.numericUpDownStrength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownDexterity
            // 
            this.numericUpDownDexterity.Location = new System.Drawing.Point(20, 180);
            this.numericUpDownDexterity.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownDexterity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDexterity.Name = "numericUpDownDexterity";
            this.numericUpDownDexterity.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDexterity.TabIndex = 4;
            this.numericUpDownDexterity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownConstitution
            // 
            this.numericUpDownConstitution.Location = new System.Drawing.Point(20, 220);
            this.numericUpDownConstitution.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownConstitution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownConstitution.Name = "numericUpDownConstitution";
            this.numericUpDownConstitution.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownConstitution.TabIndex = 5;
            this.numericUpDownConstitution.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownIntelligence
            // 
            this.numericUpDownIntelligence.Location = new System.Drawing.Point(20, 260);
            this.numericUpDownIntelligence.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownIntelligence.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIntelligence.Name = "numericUpDownIntelligence";
            this.numericUpDownIntelligence.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownIntelligence.TabIndex = 6;
            this.numericUpDownIntelligence.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownWisdom
            // 
            this.numericUpDownWisdom.Location = new System.Drawing.Point(20, 300);
            this.numericUpDownWisdom.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownWisdom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWisdom.Name = "numericUpDownWisdom";
            this.numericUpDownWisdom.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownWisdom.TabIndex = 7;
            this.numericUpDownWisdom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownCharisma
            // 
            this.numericUpDownCharisma.Location = new System.Drawing.Point(20, 340);
            this.numericUpDownCharisma.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownCharisma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCharisma.Name = "numericUpDownCharisma";
            this.numericUpDownCharisma.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCharisma.TabIndex = 8;
            this.numericUpDownCharisma.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(20, 380);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(120, 380);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 10;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 448);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.comboBoxRace);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.numericUpDownStrength);
            this.Controls.Add(this.numericUpDownDexterity);
            this.Controls.Add(this.numericUpDownConstitution);
            this.Controls.Add(this.numericUpDownIntelligence);
            this.Controls.Add(this.numericUpDownWisdom);
            this.Controls.Add(this.numericUpDownCharisma);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Name = "MainForm";
            this.Text = "DnD Character Sheet";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDexterity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConstitution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntelligence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWisdom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharisma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox textBoxName;
        private ComboBox comboBoxRace;
        private ComboBox comboBoxClass;
        private NumericUpDown numericUpDownStrength;
        private NumericUpDown numericUpDownDexterity;
        private NumericUpDown numericUpDownConstitution;
        private NumericUpDown numericUpDownIntelligence;
        private NumericUpDown numericUpDownWisdom;
        private NumericUpDown numericUpDownCharisma;
        private Button buttonSave;
        private Button buttonLoad;

        private void buttonSave_Click(object sender, EventArgs e)
        {
            currentCharacter = new Character
            {
                Name = textBoxName.Text,
                Race = comboBoxRace.SelectedItem?.ToString(),
                Class = comboBoxClass.SelectedItem?.ToString(),
                Strength = (int)numericUpDownStrength.Value,
                Dexterity = (int)numericUpDownDexterity.Value,
                Constitution = (int)numericUpDownConstitution.Value,
                Intelligence = (int)numericUpDownIntelligence.Value,
                Wisdom = (int)numericUpDownWisdom.Value,
                Charisma = (int)numericUpDownCharisma.Value
            };

            string characterData = currentCharacter.ToString();
            File.WriteAllText("character.txt", characterData);
            MessageBox.Show("Character saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (File.Exists("character.txt"))
            {
                string[] lines = File.ReadAllLines("character.txt");
                currentCharacter = Character.FromString(lines);

                textBoxName.Text = currentCharacter.Name;
                comboBoxRace.SelectedItem = currentCharacter.Race;
                comboBoxClass.SelectedItem = currentCharacter.Class;
                numericUpDownStrength.Value = currentCharacter.Strength;
                numericUpDownDexterity.Value = currentCharacter.Dexterity;
                numericUpDownConstitution.Value = currentCharacter.Constitution;
                numericUpDownIntelligence.Value = currentCharacter.Intelligence;
                numericUpDownWisdom.Value = currentCharacter.Wisdom;
                numericUpDownCharisma.Value = currentCharacter.Charisma;

                MessageBox.Show("Character loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No saved character data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }

    public class Character
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Class { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nRace: {Race}\nClass: {Class}\n" +
                   $"Strength: {Strength}\nDexterity: {Dexterity}\nConstitution: {Constitution}\n" +
                   $"Intelligence: {Intelligence}\nWisdom: {Wisdom}\nCharisma: {Charisma}";
        }

        public static Character FromString(string[] lines)
        {
            return new Character
            {
                Name = lines[0].Split(':')[1].Trim(),
                Race = lines[1].Split(':')[1].Trim(),
                Class = lines[2].Split(':')[1].Trim(),
                Strength = int.Parse(lines[3].Split(':')[1].Trim()),
                Dexterity = int.Parse(lines[4].Split(':')[1].Trim()),
                Constitution = int.Parse(lines[5].Split(':')[1].Trim()),
                Intelligence = int.Parse(lines[6].Split(':')[1].Trim()),
                Wisdom = int.Parse(lines[7].Split(':')[1].Trim()),
                Charisma = int.Parse(lines[8].Split(':')[1].Trim())
            };
        }
    }
}
