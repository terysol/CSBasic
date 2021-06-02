using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            // this.Text = "핀과 제이크 버전 옥토캣 짜잔";
            Button button = new Button();
            button.Text = "버튼";
            button.Location = new Point(13, 13 + 23 + 23);
            button.Width = 100;
            Controls.Add(button);

            Button button2 = new Button();
            button2.Text = "버튼1";
            button2.Location = new Point(13, 13 + 23 + 23);
            button2.Width = 150;
            Controls.Add(button2);

            Button buttonTemp;
            for(int i = 0; i < 5; i++)
            {
                buttonTemp = new Button();
                buttonTemp.Text = "버튼" + i;
                buttonTemp.Location = new Point(13, 13+23 + 23 + 20 * i);
                buttonTemp.Width = 100 + i * 20;
                Controls.Add(buttonTemp);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value < 20)
                trackBar1.Value = 20;
            
            this.Opacity = trackBar1.Value / 100.0;
        }
    }
}
