using System;
using System.Drawing;
using System.IO;

namespace MissionPlanner
{
    partial class MainV2
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
            Console.WriteLine("mainv2_Dispose");
            if (PluginThreadrunner != null)
                PluginThreadrunner.Dispose();
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainV2));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.CTX_mainmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.autoHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readonlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new MissionPlanner.Controls.MyButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new MyPanel();
            this.myPanel1 = new MyPanel();
            this.myPanel2 = new MyPanel();
            this.cmb_Connection = new System.Windows.Forms.ComboBox();
            this.pictureBoxConnect = new System.Windows.Forms.PictureBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelStar = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelDian = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.status1 = new MissionPlanner.Controls.Status();
            this.imageRenderer1 = new BrightIdeasSoftware.ImageRenderer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CTX_mainmenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.myPanel1.SuspendLayout();
            this.myPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            resources.ApplyResources(this.MainMenu, "MainMenu");
            this.MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(214)))), ((int)(((byte)(234)))));
            this.MainMenu.ContextMenuStrip = this.CTX_mainmenu;
            this.MainMenu.GripMargin = new System.Windows.Forms.Padding(0);
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(45, 39);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.ShowItemToolTips = true;
            this.MainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MainMenu_ItemClicked);
            this.MainMenu.MouseLeave += new System.EventHandler(this.MainMenu_MouseLeave);
            // 
            // CTX_mainmenu
            // 
            this.CTX_mainmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoHideToolStripMenuItem,
            this.fullScreenToolStripMenuItem,
            this.readonlyToolStripMenuItem,
            this.connectionOptionsToolStripMenuItem,
            this.connectionListToolStripMenuItem});
            this.CTX_mainmenu.Name = "CTX_mainmenu";
            resources.ApplyResources(this.CTX_mainmenu, "CTX_mainmenu");
            // 
            // autoHideToolStripMenuItem
            // 
            this.autoHideToolStripMenuItem.CheckOnClick = true;
            this.autoHideToolStripMenuItem.Name = "autoHideToolStripMenuItem";
            resources.ApplyResources(this.autoHideToolStripMenuItem, "autoHideToolStripMenuItem");
            this.autoHideToolStripMenuItem.Click += new System.EventHandler(this.autoHideToolStripMenuItem_Click);
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.CheckOnClick = true;
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            resources.ApplyResources(this.fullScreenToolStripMenuItem, "fullScreenToolStripMenuItem");
            this.fullScreenToolStripMenuItem.Click += new System.EventHandler(this.fullScreenToolStripMenuItem_Click);
            // 
            // readonlyToolStripMenuItem
            // 
            this.readonlyToolStripMenuItem.CheckOnClick = true;
            this.readonlyToolStripMenuItem.Name = "readonlyToolStripMenuItem";
            resources.ApplyResources(this.readonlyToolStripMenuItem, "readonlyToolStripMenuItem");
            this.readonlyToolStripMenuItem.Click += new System.EventHandler(this.readonlyToolStripMenuItem_Click);
            // 
            // connectionOptionsToolStripMenuItem
            // 
            this.connectionOptionsToolStripMenuItem.Name = "connectionOptionsToolStripMenuItem";
            resources.ApplyResources(this.connectionOptionsToolStripMenuItem, "connectionOptionsToolStripMenuItem");
            this.connectionOptionsToolStripMenuItem.Click += new System.EventHandler(this.connectionOptionsToolStripMenuItem_Click);
            // 
            // connectionListToolStripMenuItem
            // 
            this.connectionListToolStripMenuItem.Name = "connectionListToolStripMenuItem";
            resources.ApplyResources(this.connectionListToolStripMenuItem, "connectionListToolStripMenuItem");
            this.connectionListToolStripMenuItem.Click += new System.EventHandler(this.connectionListToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.menu, "menu");
            this.menu.Name = "menu";
            this.menu.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.menu.UseVisualStyleBackColor = false;
            this.menu.MouseEnter += new System.EventHandler(this.menu_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(214)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.status1);
            this.panel1.Controls.Add(this.MainMenu);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Tag = "custom";
            this.panel1.MouseLeave += new System.EventHandler(this.MainMenu_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.myPanel1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.Tag = "custom";
            // 
            // myPanel1
            // 
            this.myPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.myPanel1.Controls.Add(this.myPanel2);
            this.myPanel1.Controls.Add(this.pictureBoxConnect);
            this.myPanel1.Controls.Add(this.labelLocation);
            this.myPanel1.Controls.Add(this.pictureBox3);
            this.myPanel1.Controls.Add(this.labelStar);
            this.myPanel1.Controls.Add(this.pictureBox2);
            this.myPanel1.Controls.Add(this.labelDian);
            this.myPanel1.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.myPanel1, "myPanel1");
            this.myPanel1.Name = "myPanel1";
            this.myPanel1.Opacity = 0;
            this.myPanel1.Tag = "custom";
            // 
            // myPanel2
            // 
            this.myPanel2.Controls.Add(this.cmb_Connection);
            resources.ApplyResources(this.myPanel2, "myPanel2");
            this.myPanel2.Name = "myPanel2";
            this.myPanel2.Opacity = 0;
            // 
            // cmb_Connection
            // 
            this.cmb_Connection.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_Connection, "cmb_Connection");
            this.cmb_Connection.Name = "cmb_Connection";
            this.cmb_Connection.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmb_Connection_DrawItem);
            this.cmb_Connection.Click += new System.EventHandler(this.cmb_Connection_Click);
            // 
            // pictureBoxConnect
            // 
            resources.ApplyResources(this.pictureBoxConnect, "pictureBoxConnect");
            this.pictureBoxConnect.Image = global::MissionPlanner.Properties.Resources.connect;
            this.pictureBoxConnect.Name = "pictureBoxConnect";
            this.pictureBoxConnect.TabStop = false;
            this.pictureBoxConnect.Click += new System.EventHandler(this.MenuConnect_Click);
            // 
            // labelLocation
            // 
            resources.ApplyResources(this.labelLocation, "labelLocation");
            this.labelLocation.ForeColor = System.Drawing.Color.White;
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Tag = "custom";
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // labelStar
            // 
            resources.ApplyResources(this.labelStar, "labelStar");
            this.labelStar.ForeColor = System.Drawing.Color.White;
            this.labelStar.Name = "labelStar";
            this.labelStar.Tag = "custom";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // labelDian
            // 
            resources.ApplyResources(this.labelDian, "labelDian");
            this.labelDian.ForeColor = System.Drawing.Color.White;
            this.labelDian.Name = "labelDian";
            this.labelDian.Tag = "custom";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // status1
            // 
            resources.ApplyResources(this.status1, "status1");
            this.status1.Name = "status1";
            this.status1.Percent = 0D;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainV2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.KeyPreview = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainV2";
            this.Load += new System.EventHandler(this.MainV2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainV2_KeyDown);
            this.Resize += new System.EventHandler(this.MainV2_Resize);
            this.CTX_mainmenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.myPanel1.ResumeLayout(false);
            this.myPanel1.PerformLayout();
            this.myPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.MyButton menu;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip CTX_mainmenu;
        private System.Windows.Forms.ToolStripMenuItem autoHideToolStripMenuItem;
        public System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readonlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionListToolStripMenuItem;
        public Controls.Status status1;
        private MyPanel myPanel1;
        private BrightIdeasSoftware.ImageRenderer imageRenderer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDian;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelStar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private MyPanel panel2;
        private System.Windows.Forms.PictureBox pictureBoxConnect;
        private System.Windows.Forms.ComboBox cmb_Connection;
        private MyPanel myPanel2;
    }
}