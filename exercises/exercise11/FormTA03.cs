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
    public partial class FormTA03 : Form
    {
        public FormTA03()
        {
            InitializeComponent();
        }

        SpeechSynthesizer speechSynthesizer;
        string story = "The black cat jumped up onto the chair. It looked down at the white dog. The dog was chewing on a bone. The cat jumped onto the dog. The dog kept chewing the bone. The cat played with the dog's tail. The dog kept chewing the bone. The cat jumped back onto the chair. It started licking its paws. The dog stood up. It looked at the cat. It licked the cat's fur. The cat licked the dog's nose. The dog went back to its bone. A boy ran through the room. He was wearing a yellow shirt. He almost ran into the chair. The cat jumped off the chair. The cat jumped onto the sofa. The chair fell onto the floor next to the dog. The dog stopped chewing the bone. The dog chased the boy. The boy ran out to the street. He threw a stick. The dog chased the stick. The dog lay down. It chewed on the stick.";
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
