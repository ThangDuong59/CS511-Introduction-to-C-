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
    public partial class FormTA01 : Form
    {
        public FormTA01()
        {
            InitializeComponent();
        }

        SpeechSynthesizer speechSynthesizer;
        string story = "The mother gave her baby a red apple. The baby tried to eat the apple. His mouth was too small. And he didn't have any teeth. His brother took the apple. His brother ate the apple. The baby cried. His brother gave the baby a blue ball to play with. The baby smiled. His brother took the ball from the baby. He rolled the ball on the floor. The brown and white dog picked up the ball. The dog chewed on the ball. The baby cried again. His brother picked up the cat. He put the cat on the bed with the baby. The baby pulled the cat's tail. The cat jumped off the bed. The dog chased the cat. The baby cried again. His brother let the baby hold a sock. The baby played with the sock. The baby was happy.";
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
