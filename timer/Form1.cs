using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class Form1 : Form
    {
        public int iseconds;
        public int iminutes;
        public int ihours;
        public int totalSeconds;
        public Form1()
        {
            
            InitializeComponent();

        }
        
        private void refreshS()
        {
            if (iseconds < 10)
            {
                seconds.Text = "0" + iseconds.ToString();
                return;
            }
            seconds.Text = iseconds.ToString();
        }

        private void refreshM()
        {
            if (iminutes < 10)
            {
                minutes.Text = "0" + iminutes.ToString();
                return;
            }
            minutes.Text = iminutes.ToString();
        }

        private void refreshH()
        {
            if (ihours < 10)
            {
                hours.Text = "0" + ihours.ToString();
                return;
            }
            hours.Text = ihours.ToString();
        }
        private void increaseSeconds_Click(object sender, EventArgs e)
        {
            if (iseconds == 59)
            {
                iseconds = 0;
                refreshS();
                increaseMinutes_Click(sender, e);
            }
            iseconds++;
            refreshS();
        }
        
        private void increaseMinutes_Click(object sender, EventArgs e)
        {
            if (iminutes == 59)
            {
                iminutes = 0;
                refreshM();
                increaseHours_Click(sender, e);
            }
            iminutes++;
            refreshM();
        }

        private void increaseHours_Click(object sender, EventArgs e)
        {
            ihours++;
            refreshH();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
            ToolTip tt = new ToolTip();
            tt.AutoPopDelay = 2000;
            tt.InitialDelay = 300;
            tt.ReshowDelay = 500;
            tt.ShowAlways = false;
            tt.SetToolTip(dark, "Dark Mode");
            tt.SetToolTip(light, "Light Mode");
            iseconds = 0;
            iminutes = 0;
            ihours = 0;
            seconds.Text = iseconds.ToString();
            minutes.Text = iminutes.ToString();
            hours.Text = ihours.ToString();
            refreshS();
            refreshM();
            refreshH();
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\timer"))
            {
                using (StreamReader f = new StreamReader(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "timer")))
                {
                    String r = f.ReadLine();
                    if (r == "dark")
                    {
                        f.Close();
                        setDark();
                    }
                    else
                    {
                        f.Close();
                        setLight();
                    }
                    
                }
            }
            else
            {
                using (StreamWriter f = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "timer")))
                {
                    f.WriteLine("dark");
                    f.Close();
                    setDark();
                }
            }
        }

        private void decreaseSeconds_Click(object sender, EventArgs e)
        {
            if (!(iseconds == 0))
            {
                iseconds--;
                refreshS();
            }
        }
        private void setDark()
        {
            this.BackColor = Color.FromArgb(255, 31, 31, 31);
            this.ForeColor = Color.White;
            increaseHours.ForeColor = Color.Gray;
            increaseMinutes.ForeColor = Color.Gray;
            increaseSeconds.ForeColor = Color.Gray;
            decraseHours.ForeColor = Color.Gray;
            decreaseMinutes.ForeColor = Color.Gray;
            decreaseSeconds.ForeColor = Color.Gray;
            dark.ForeColor = Color.Gray;
            light.ForeColor = Color.White;
            using (StreamWriter f = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "timer")))
                f.WriteLine("dark");
        }

        private void setLight()
        {
            this.BackColor = Color.FromName("Control");
            this.ForeColor = Color.Black;
            increaseHours.ForeColor = Color.Black;
            increaseMinutes.ForeColor = Color.Black;
            increaseSeconds.ForeColor = Color.Black;
            decraseHours.ForeColor = Color.Black;
            decreaseMinutes.ForeColor = Color.Black;
            decreaseSeconds.ForeColor = Color.Black;
            light.ForeColor = Color.Gray;
            dark.ForeColor = Color.Black;
            using (StreamWriter f = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "timer")))
                f.WriteLine("light");
        }
        private void decreaseMinutes_Click(object sender, EventArgs e)
        {
            if (!(iminutes == 0))
            {
                iminutes--;
                refreshM();
            }
        }

        private void decraseHours_Click(object sender, EventArgs e)
        {
            if (!(ihours == 0))
            {
                ihours--;
                refreshH();
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            this.Text = hours.Text + ":" + minutes.Text + ":" + seconds.Text;
            start.Enabled = false;
            stop.Enabled = true;
            timer.Enabled = true;
            increaseHours.Hide();
            increaseMinutes.Hide();
            increaseSeconds.Hide();
            decraseHours.Hide();
            decreaseSeconds.Hide();
            decreaseMinutes.Hide();
            decreaseMinutes.Hide();
            totalSeconds = iseconds + (iminutes * 60) + (ihours * 3600);
}

        private void stop_Click(object sender, EventArgs e)
        {
            this.Text = "Timer";
            start.Enabled = true;
            stop.Enabled = false;
            timer.Enabled = false;
            increaseHours.Show();
            increaseMinutes.Show();
            increaseSeconds.Show();
            decraseHours.Show();
            decreaseSeconds.Show();
            decreaseMinutes.Show();
            decreaseMinutes.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            
            if (totalSeconds == 0)
            {
                timer.Stop();
                stop_Click(sender, e);
                if (playsound.Checked == true)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resource1.alarm);
                    player.Play();
                }
                return;
            }
            else if (iseconds > 0)
            {
                totalSeconds--;
                iseconds -= 1;
                //seconds.Text = iseconds.ToString();
                refreshS();
            }
            else if (iminutes > 0)
            {
                iminutes -= 1;
                iseconds = 59;
                //minutes.Text = iminutes.ToString();
                refreshS();
                refreshM();
            }
            else if (ihours > 0)
            {
                ihours -= 1;
                iminutes = 59;
                iseconds = 59;
                //hours.Text = ihours.ToString();
                refreshS();
                refreshM();
                refreshH();
            }
            this.Text = hours.Text + ":" + minutes.Text + ":" + seconds.Text;
        }

        private void dark_Click(object sender, EventArgs e)
        {
            if (dark.ForeColor == Color.Gray)
                return;
            setDark();
        }

        private void light_Click(object sender, EventArgs e)
        {
            if (light.ForeColor == Color.Gray)
                return;
            setLight();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.Opacity = ((double)trackBar1.Value / 100.0);

        }

        private void ontop_CheckedChanged(object sender, EventArgs e)
        {
            if (ontop.Checked == true)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }
    }
}
