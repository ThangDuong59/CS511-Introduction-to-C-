using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace exercise11
{
    public partial class FormTA04 : Form
    {
        public FormTA04()
        {
            InitializeComponent();
        }

        SpeechSynthesizer speechSynthesizer;
        string story = "The baby bear followed his mama. Mama bear walked through the woods. She was looking for berries to eat. She found some black berries. She started eating them. The baby started eating them, too. They ate all the berries. Baby bear was full. Mama bear was still hungry. She started walking again. She wanted to find more berries to eat. Baby bear lay down. He was full. He wanted to take a nap. But mama bear came back. She growled at baby bear. He understood mama's growl. When mama growled, he obeyed. He got up and followed his mama. Someday he would take a nap after a meal. A squirrel ran up a tree with a nut. It dropped the nut and ran back down to the ground. It picked up the nut and looked at baby bear. Then it ran back up the tree. Baby bear did not like nuts. They were too hard to open.";
        private void pictureBox_speak_Click(object sender, EventArgs e)
        {
            speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Volume = 100;
            speechSynthesizer.Rate = 0;
            speechSynthesizer.SpeakAsync(story);
        }

        private void pictureBox_mute_Click(object sender, EventArgs e)
        {
            speechSynthesizer.Pause();
        }
    }
}
