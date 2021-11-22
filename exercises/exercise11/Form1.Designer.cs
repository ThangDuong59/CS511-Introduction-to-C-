namespace exercise11
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myStoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.birdsAndABabyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCatAndADogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theBabyBearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anApplePieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theTopBunkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.askSantaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBirthdayBikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inTheGardenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todaysMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boysWillBeBoysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aGoodMealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storyToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.storyToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.tileVerticalToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myStoryToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // myStoryToolStripMenuItem
            // 
            this.myStoryToolStripMenuItem.Name = "myStoryToolStripMenuItem";
            this.myStoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.myStoryToolStripMenuItem.Text = "My Story";
            this.myStoryToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_myStory_Click);
            // 
            // storyToolStripMenuItem
            // 
            this.storyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.birdsAndABabyToolStripMenuItem,
            this.aCatAndADogToolStripMenuItem,
            this.theBabyBearToolStripMenuItem,
            this.anApplePieToolStripMenuItem,
            this.theTopBunkToolStripMenuItem,
            this.askSantaToolStripMenuItem,
            this.aBirthdayBikeToolStripMenuItem,
            this.inTheGardenToolStripMenuItem,
            this.todaysMailToolStripMenuItem,
            this.boysWillBeBoysToolStripMenuItem,
            this.aGoodMealToolStripMenuItem});
            this.storyToolStripMenuItem.Name = "storyToolStripMenuItem";
            this.storyToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.storyToolStripMenuItem.Text = "Story";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItem2.Text = "01. A Baby and a Sock";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem_story01_Click);
            // 
            // birdsAndABabyToolStripMenuItem
            // 
            this.birdsAndABabyToolStripMenuItem.Name = "birdsAndABabyToolStripMenuItem";
            this.birdsAndABabyToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.birdsAndABabyToolStripMenuItem.Text = "02. Birds and a Baby";
            this.birdsAndABabyToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_story02_Click);
            // 
            // aCatAndADogToolStripMenuItem
            // 
            this.aCatAndADogToolStripMenuItem.Name = "aCatAndADogToolStripMenuItem";
            this.aCatAndADogToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.aCatAndADogToolStripMenuItem.Text = "03. A Cat and a Dog";
            this.aCatAndADogToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_story03_Click);
            // 
            // theBabyBearToolStripMenuItem
            // 
            this.theBabyBearToolStripMenuItem.Name = "theBabyBearToolStripMenuItem";
            this.theBabyBearToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.theBabyBearToolStripMenuItem.Text = "04. The Baby Bear";
            this.theBabyBearToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_story04_Click);
            // 
            // anApplePieToolStripMenuItem
            // 
            this.anApplePieToolStripMenuItem.Name = "anApplePieToolStripMenuItem";
            this.anApplePieToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.anApplePieToolStripMenuItem.Text = "05. An Apple Pie";
            this.anApplePieToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_story05_Click);
            // 
            // theTopBunkToolStripMenuItem
            // 
            this.theTopBunkToolStripMenuItem.Name = "theTopBunkToolStripMenuItem";
            this.theTopBunkToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.theTopBunkToolStripMenuItem.Text = "06. The Top Bunk";
            this.theTopBunkToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_story06_Click);
            // 
            // askSantaToolStripMenuItem
            // 
            this.askSantaToolStripMenuItem.Name = "askSantaToolStripMenuItem";
            this.askSantaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.askSantaToolStripMenuItem.Text = "07. Ask Santa";
            this.askSantaToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_story07_Click);
            // 
            // aBirthdayBikeToolStripMenuItem
            // 
            this.aBirthdayBikeToolStripMenuItem.Name = "aBirthdayBikeToolStripMenuItem";
            this.aBirthdayBikeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.aBirthdayBikeToolStripMenuItem.Text = "08. A Birthday Bike";
            this.aBirthdayBikeToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_story08_Click);
            // 
            // inTheGardenToolStripMenuItem
            // 
            this.inTheGardenToolStripMenuItem.Name = "inTheGardenToolStripMenuItem";
            this.inTheGardenToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.inTheGardenToolStripMenuItem.Text = "09. In the Garden";
            this.inTheGardenToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_story09_Click);
            // 
            // todaysMailToolStripMenuItem
            // 
            this.todaysMailToolStripMenuItem.Name = "todaysMailToolStripMenuItem";
            this.todaysMailToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.todaysMailToolStripMenuItem.Text = "10. Today\'s Mail";
            this.todaysMailToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_story10_Click);
            // 
            // boysWillBeBoysToolStripMenuItem
            // 
            this.boysWillBeBoysToolStripMenuItem.Name = "boysWillBeBoysToolStripMenuItem";
            this.boysWillBeBoysToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.boysWillBeBoysToolStripMenuItem.Text = "11. Boys Will Be Boys";
            this.boysWillBeBoysToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_story11_Click);
            // 
            // aGoodMealToolStripMenuItem
            // 
            this.aGoodMealToolStripMenuItem.Name = "aGoodMealToolStripMenuItem";
            this.aGoodMealToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.aGoodMealToolStripMenuItem.Text = "12. A Good Meal";
            this.aGoodMealToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_story12_Click);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tileHorizontalToolStripMenuItem.Text = "TileHorizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.tileHorizontalToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tileVerticalToolStripMenuItem.Text = "TileVertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "BabyStory";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myStoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birdsAndABabyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCatAndADogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theBabyBearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anApplePieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theTopBunkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem askSantaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBirthdayBikeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inTheGardenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todaysMailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boysWillBeBoysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aGoodMealToolStripMenuItem;
    }
}

