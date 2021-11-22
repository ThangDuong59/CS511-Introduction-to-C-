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
    public partial class FormTA06 : Form
    {
        public FormTA06()
        {
            InitializeComponent();
        }

        SpeechSynthesizer speechSynthesizer;
        string story = "He and his brother slept in a bunk bed. He had the bottom bunk. His brother had the top bunk. The top bunk had a guard rail. The rail kept the sleeper safe. His brother didn't like the rail. He always left it down. One time his brother fell out of the top bunk. He hit the carpet and woke up. He said, \"Ouch!\" Then he climbed back into the top bunk. When he woke up the next day, his back was sore. Mom took him to see the doctor. The doctor examined him. The doctor said he was okay. He said to keep the guard rail up. His brother said he would do that. That night his brother climbed into the top bunk again. He left the guard rail down. He said the guard rail was like jail. He didn't want to feel like he was in jail. He fell asleep. Then he fell out of the top bunk again.";
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
