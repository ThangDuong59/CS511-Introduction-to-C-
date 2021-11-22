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
    public partial class FormTA10 : Form
    {
        public FormTA10()
        {
            InitializeComponent();
        }

        SpeechSynthesizer speechSynthesizer;
        string story = "The mailman put the mail in the mailbox. Dad went outside. He said hello to the mailman. The mailman said hello. Dad opened the mailbox and took out a magazine and two letters. One letter was from his sister. The other letter was from his brother. The magazine was for his wife. It was a garden magazine. His wife liked to work in the garden. She grew flowers and vegetables in the garden. Dad went back into the house. He opened both letters. His sister invited him to a birthday party. His brother invited him to a wedding. Dad enjoyed reading the letters. He enjoyed getting the invitations. He picked up the phone. He left a message for his sister. He would come to the birthday party. He also called his brother. He said he would come to the wedding.";
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
