using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        private void CustomizeDesign()
        {
            MediaPanel.Visible = false;
            PlayListPanel.Visible = false;
            ToolsPanel.Visible = false;
        }
        private void hidemenus()
        {
            if (MediaPanel.Visible = true)
            { MediaPanel.Visible = false; }
            if (PlayListPanel.Visible = true)
            { PlayListPanel.Visible = false; }
            if (ToolsPanel.Visible = true)
            { ToolsPanel.Visible = false; }
        }

        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidemenus();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        private Form activeform = null;
        private void openchildform(Form childform)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            Childpanel.Controls.Add(childform);
            Childpanel.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //mediaBtn
            showsubmenu(MediaPanel);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void PlayListBtn_Click(object sender, EventArgs e)
        {
            showsubmenu(PlayListPanel);
        }

        private void ToolsBtn_Click(object sender, EventArgs e)
        {
            showsubmenu(ToolsPanel);
        }

        private void PlayListBtn1_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hidemenus();
        }

        private void MediaBtn1_Click(object sender, EventArgs e)
        {
            openchildform(new Form2());
            //..
            //Your Code
            //..
            hidemenus();
        }

        private void MediaBtn2_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hidemenus();
        }

        private void Mediabtn3_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hidemenus();
        }

        private void MediaBtn4_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hidemenus();
        }

        private void PlayListBtn2_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hidemenus();
        }

        private void PlayListBtn3_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hidemenus();
        }

        private void PlayListBtn4_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hidemenus();
        }

        private void EquilizerBtn_Click(object sender, EventArgs e)
        {
            openchildform(new Form3());
            //..
            //Your Code
            //..
            hidemenus();
        }

        private void ToolsBtn2_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hidemenus();
        }

        private void button3Tools_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hidemenus();
        }

        private void ToolsBtn1_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hidemenus();
        }

        private void button4Tools_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hidemenus();
        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hidemenus();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlayerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
