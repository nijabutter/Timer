namespace timer
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
            this.components = new System.ComponentModel.Container();
            this.hours = new System.Windows.Forms.Label();
            this.minutes = new System.Windows.Forms.Label();
            this.seconds = new System.Windows.Forms.Label();
            this.colon1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.increaseSeconds = new System.Windows.Forms.Button();
            this.decreaseSeconds = new System.Windows.Forms.Button();
            this.decreaseMinutes = new System.Windows.Forms.Button();
            this.increaseMinutes = new System.Windows.Forms.Button();
            this.decraseHours = new System.Windows.Forms.Button();
            this.increaseHours = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.stop = new System.Windows.Forms.Button();
            this.dark = new System.Windows.Forms.Label();
            this.light = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.ontop = new System.Windows.Forms.CheckBox();
            this.playsound = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // hours
            // 
            this.hours.AutoSize = true;
            this.hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours.Location = new System.Drawing.Point(-4, 93);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(104, 73);
            this.hours.TabIndex = 0;
            this.hours.Text = "00";
            // 
            // minutes
            // 
            this.minutes.AutoSize = true;
            this.minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes.Location = new System.Drawing.Point(143, 93);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(104, 73);
            this.minutes.TabIndex = 1;
            this.minutes.Text = "00";
            // 
            // seconds
            // 
            this.seconds.AutoSize = true;
            this.seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seconds.Location = new System.Drawing.Point(290, 93);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(104, 73);
            this.seconds.TabIndex = 2;
            this.seconds.Text = "00";
            // 
            // colon1
            // 
            this.colon1.AutoSize = true;
            this.colon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colon1.Location = new System.Drawing.Point(97, 93);
            this.colon1.Name = "colon1";
            this.colon1.Size = new System.Drawing.Size(50, 73);
            this.colon1.TabIndex = 3;
            this.colon1.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = ":";
            // 
            // increaseSeconds
            // 
            this.increaseSeconds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.increaseSeconds.Location = new System.Drawing.Point(303, 67);
            this.increaseSeconds.Name = "increaseSeconds";
            this.increaseSeconds.Size = new System.Drawing.Size(75, 22);
            this.increaseSeconds.TabIndex = 5;
            this.increaseSeconds.Text = "↑";
            this.increaseSeconds.UseVisualStyleBackColor = true;
            this.increaseSeconds.Click += new System.EventHandler(this.increaseSeconds_Click);
            // 
            // decreaseSeconds
            // 
            this.decreaseSeconds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decreaseSeconds.Location = new System.Drawing.Point(292, 180);
            this.decreaseSeconds.Name = "decreaseSeconds";
            this.decreaseSeconds.Size = new System.Drawing.Size(75, 23);
            this.decreaseSeconds.TabIndex = 6;
            this.decreaseSeconds.Text = "↓";
            this.decreaseSeconds.UseVisualStyleBackColor = true;
            this.decreaseSeconds.Click += new System.EventHandler(this.decreaseSeconds_Click);
            // 
            // decreaseMinutes
            // 
            this.decreaseMinutes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decreaseMinutes.Location = new System.Drawing.Point(156, 180);
            this.decreaseMinutes.Name = "decreaseMinutes";
            this.decreaseMinutes.Size = new System.Drawing.Size(75, 23);
            this.decreaseMinutes.TabIndex = 8;
            this.decreaseMinutes.Text = "↓";
            this.decreaseMinutes.UseVisualStyleBackColor = true;
            this.decreaseMinutes.Click += new System.EventHandler(this.decreaseMinutes_Click);
            // 
            // increaseMinutes
            // 
            this.increaseMinutes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.increaseMinutes.Location = new System.Drawing.Point(156, 67);
            this.increaseMinutes.Name = "increaseMinutes";
            this.increaseMinutes.Size = new System.Drawing.Size(75, 23);
            this.increaseMinutes.TabIndex = 7;
            this.increaseMinutes.Text = "↑";
            this.increaseMinutes.UseVisualStyleBackColor = true;
            this.increaseMinutes.Click += new System.EventHandler(this.increaseMinutes_Click);
            // 
            // decraseHours
            // 
            this.decraseHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decraseHours.Location = new System.Drawing.Point(7, 180);
            this.decraseHours.Name = "decraseHours";
            this.decraseHours.Size = new System.Drawing.Size(75, 23);
            this.decraseHours.TabIndex = 10;
            this.decraseHours.Text = "↓";
            this.decraseHours.UseVisualStyleBackColor = true;
            this.decraseHours.Click += new System.EventHandler(this.decraseHours_Click);
            // 
            // increaseHours
            // 
            this.increaseHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.increaseHours.Location = new System.Drawing.Point(7, 67);
            this.increaseHours.Name = "increaseHours";
            this.increaseHours.Size = new System.Drawing.Size(75, 23);
            this.increaseHours.TabIndex = 9;
            this.increaseHours.Text = "↑";
            this.increaseHours.UseVisualStyleBackColor = true;
            this.increaseHours.Click += new System.EventHandler(this.increaseHours_Click);
            // 
            // start
            // 
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(292, 230);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(78, 51);
            this.start.TabIndex = 11;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // stop
            // 
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.Location = new System.Drawing.Point(9, 230);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(78, 51);
            this.stop.TabIndex = 12;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // dark
            // 
            this.dark.AutoSize = true;
            this.dark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dark.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dark.Location = new System.Drawing.Point(2, 3);
            this.dark.Name = "dark";
            this.dark.Size = new System.Drawing.Size(39, 29);
            this.dark.TabIndex = 14;
            this.dark.Text = "🌙";
            this.dark.Click += new System.EventHandler(this.dark_Click);
            // 
            // light
            // 
            this.light.AutoSize = true;
            this.light.Cursor = System.Windows.Forms.Cursors.Hand;
            this.light.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.light.Location = new System.Drawing.Point(47, 3);
            this.light.Name = "light";
            this.light.Size = new System.Drawing.Size(39, 29);
            this.light.TabIndex = 15;
            this.light.Text = "☀";
            this.light.Click += new System.EventHandler(this.light_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(256, 12);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(122, 45);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // ontop
            // 
            this.ontop.AutoSize = true;
            this.ontop.Location = new System.Drawing.Point(151, 230);
            this.ontop.Name = "ontop";
            this.ontop.Size = new System.Drawing.Size(92, 17);
            this.ontop.TabIndex = 16;
            this.ontop.Text = "Always on top";
            this.ontop.UseVisualStyleBackColor = true;
            this.ontop.CheckedChanged += new System.EventHandler(this.ontop_CheckedChanged);
            // 
            // playsound
            // 
            this.playsound.AutoSize = true;
            this.playsound.Location = new System.Drawing.Point(151, 252);
            this.playsound.Name = "playsound";
            this.playsound.Size = new System.Drawing.Size(80, 17);
            this.playsound.TabIndex = 17;
            this.playsound.Text = "Play Sound";
            this.playsound.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 295);
            this.Controls.Add(this.playsound);
            this.Controls.Add(this.ontop);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.light);
            this.Controls.Add(this.dark);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.decraseHours);
            this.Controls.Add(this.increaseHours);
            this.Controls.Add(this.decreaseMinutes);
            this.Controls.Add(this.increaseMinutes);
            this.Controls.Add(this.decreaseSeconds);
            this.Controls.Add(this.increaseSeconds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colon1);
            this.Controls.Add(this.seconds);
            this.Controls.Add(this.minutes);
            this.Controls.Add(this.hours);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(405, 334);
            this.MinimumSize = new System.Drawing.Size(405, 334);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Timer";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hours;
        private System.Windows.Forms.Label minutes;
        private System.Windows.Forms.Label seconds;
        private System.Windows.Forms.Label colon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button increaseSeconds;
        private System.Windows.Forms.Button decreaseSeconds;
        private System.Windows.Forms.Button decreaseMinutes;
        private System.Windows.Forms.Button increaseMinutes;
        private System.Windows.Forms.Button decraseHours;
        private System.Windows.Forms.Button increaseHours;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label dark;
        private System.Windows.Forms.Label light;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox ontop;
        private System.Windows.Forms.CheckBox playsound;
    }
}

