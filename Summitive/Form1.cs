using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summitive
{
    
    public partial class Form1 : Form
    {
        public static int timer =0;
        public static Image heroimage; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {          

            StartScreen cs = new StartScreen();
            this.Controls.Add(cs);
        }
    }
}
