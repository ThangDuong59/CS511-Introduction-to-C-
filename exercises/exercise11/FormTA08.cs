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
    public partial class FormTA08 : Form
    {
        public FormTA08()
        {
            InitializeComponent();
        }

        SpeechSynthesizer speechSynthesizer;
        string story = "January 7 is Benny's birthday. He will be eight years old. He is in the third grade. He goes to Park Elementary School. An elementary school is for kids. It is only one mile away. He walks to school. It only takes 20 minutes. When it rains, he wears a raincoat. He used to take an umbrella. But he lost the umbrella. His mother gave him another umbrella. He broke that one. His mom said, \"You and umbrellas don't get along.\" For his eighth birthday, Benny wants a bicycle. He can ride the bike to school. After school he can ride with his friends. He can ride the bike to the swimming pool. He can ride the bike to the library. His mom and dad took him to the bike store. They asked him to look at the bikes. He looked at all the bikes. He chose a red bike. He showed his parents. Dad said it cost too much. He told Benny to choose another bike. Benny chose a blue bike. Dad said the blue bike was the right price.";
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
