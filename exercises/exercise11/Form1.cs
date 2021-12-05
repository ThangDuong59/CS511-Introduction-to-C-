using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void toolStripMenuItem_story01_Click(object sender, EventArgs e)
        {
            FormTA01 newForm = new FormTA01();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void toolStripMenuItem_story02_Click(object sender, EventArgs e)
        {
            FormTA02 newForm = new FormTA02();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void toolStripMenuItem_story03_Click(object sender, EventArgs e)
        {
            FormTA03 newForm = new FormTA03();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void toolStripMenuItem_story04_Click(object sender, EventArgs e)
        {
            FormTA04 newForm = new FormTA04();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void toolStripMenuItem_story05_Click(object sender, EventArgs e)
        {
            FormTA05 newForm = new FormTA05();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void toolStripMenuItem_story06_Click(object sender, EventArgs e)
        {
            FormTA06 newForm = new FormTA06();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void toolStripMenuItem_story07_Click(object sender, EventArgs e)
        {
            FormTA07 newForm = new FormTA07();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void toolStripMenuItem_story08_Click(object sender, EventArgs e)
        {
            FormTA08 newForm = new FormTA08();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void toolStripMenuItem_story09_Click(object sender, EventArgs e)
        {
            FormTA09 newForm = new FormTA09();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void toolStripMenuItem_story10_Click(object sender, EventArgs e)
        {
            FormTA10 newForm = new FormTA10();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void toolStripMenuItem_story11_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem_story12_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem_myStory_Click(object sender, EventArgs e)
        {

        }
    }
}
