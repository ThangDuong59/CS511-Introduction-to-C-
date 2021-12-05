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
    public partial class FormTA09 : Form
    {
        public FormTA09()
        {
            InitializeComponent();
        }

        SpeechSynthesizer speechSynthesizer;
        string story = "Mama was in the garden. \"What are you doing?\" Johnny asked. She said she was planting roses. Roses are flowers. They are very pretty. They are usually red. Roses have thorns. His mama said, \"Thorns will stick you.Be careful around thorns.\" Johnny went to the front yard. His dog Rex was waiting for him. Johnny picked up a stick and threw it. Rex chased the stick. He brought the stick back. Johnny ran around the house. Rex chased him. Johnny ran through the garden. Rex ran through the garden. Mom yelled at Johnny and Rex. She told them to play somewhere else. She told them to stay out of the garden. Johnny apologized to his mom. He went to the garage and got his bike. He went for a bike ride. Rex ran next to the bike.";
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
