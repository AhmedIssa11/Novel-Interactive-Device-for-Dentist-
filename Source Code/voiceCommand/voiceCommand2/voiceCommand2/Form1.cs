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

namespace voiceCommand2
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        public Form1()
        {
            InitializeComponent();

    }

        private void Form1_Load(object sender, EventArgs e)
        {
            Choices commands = new Choices();
            commands.Add(new string[] { "say hello", "print my name" ,
                                        "shape" , "shape right", "shape left", "shape up", "shape down",
                                        "bending", "bending right", "bending left", "bending up", "bending down",
                                        "ruler", "ruler right","ruler left", "ruler up", "ruler down",
                                        "stop" });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammer = new Grammar(gBuilder);

            recEngine.LoadGrammarAsync(grammer);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += RecEngine_SpeechRecognized;

        }

        private void RecEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            
            switch (e.Result.Text)
            {
                case "say hello":
                    MessageBox.Show("Hello Sir. How Are You");
                    break;

                // one
                case "shape":
                    picturedent1.Visible = true;
                    break;
                case "shape right":          
                    picturedent1.Show();
                    timer1.Start();
                    break;
                case "shape left":
                    picturedent1.Show();
                    timer2.Start();
                    break;
                case "shape up":
                    picturedent1.Show();
                    timer3.Start();
                    break;
                case "shape down":
                    picturedent1.Show();
                    timer4.Start();
                    break;
                case "stop":
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Stop();
                    timer4.Stop();
                    dent2_down.Stop();
                    dent2_left.Stop();
                    dent2_right.Stop();
                    dent2_up.Stop();
                    dent3_down.Stop();
                    dent3_left.Stop();
                    dent3_right.Stop();
                    dent3_up.Stop();
                    break;

                // two
                case "bending":
                    picturedent2.Visible = true;
                    break;
                case "bending right":
                    picturedent2.Show();
                    dent2_right.Start();
                    break;
                case "bending left":
                    picturedent2.Show();
                    dent2_left.Start();
                    break;
                case "bending up":
                    picturedent2.Show();
                    dent2_up.Start();
                    break;
                case "bending down":
                    picturedent2.Show();
                    dent2_down.Start();
                    break;

                // three 
                case "ruler":
                    picturedent3.Visible = true;
                    break;
                case "ruler right":
                    picturedent3.Show();
                    dent3_right.Start();
                    break;
                case "ruler left":
                    picturedent3.Show();
                    dent3_left.Start();
                    break;
                case "ruler up":
                    picturedent3.Show();
                    dent3_up.Start();
                    break;
                case "ruler down":
                    picturedent3.Show();
                    dent3_down.Start();
                    break;
            }
            label2.Text = e.Result.Text.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = picturedent1.Location.X;
            int y = picturedent1.Location.Y;

            picturedent1.Location = new Point(x + 15, y);

            if (x > this.Width)
                timer1.Stop();
        }


        private void left_Tick(object sender, EventArgs e)
        {
            int x = picturedent1.Location.X;
            int y = picturedent1.Location.Y;

            picturedent1.Location = new Point(x - 15, y);

            if (x > this.Width)
                timer2.Stop();
        }

        private void up_Tick(object sender, EventArgs e)
        {
            int x = picturedent1.Location.X;
            int y = picturedent1.Location.Y;

            picturedent1.Location = new Point(x , y - 15);

            if (y > this.Height)
                timer3.Stop();
        }

        private void down_Tick(object sender, EventArgs e)
        {
            int x = picturedent1.Location.X;
            int y = picturedent1.Location.Y;

            picturedent1.Location = new Point(x , y + 15);

            if (y > this.Height)
                timer1.Stop();
        }

        private void dent2_right_Tick(object sender, EventArgs e)
        {
            int x = picturedent2.Location.X;
            int y = picturedent2.Location.Y;

            picturedent2.Location = new Point(x + 15, y);

            if (x > this.Width)
                dent2_right.Stop();
        }

        private void dent2_left_Tick(object sender, EventArgs e)
        {
            int x = picturedent2.Location.X;
            int y = picturedent2.Location.Y;

            picturedent2.Location = new Point(x - 15, y);

            if (x > this.Width)
                dent2_left.Stop();
        }

        private void dent2_up_Tick(object sender, EventArgs e)
        {
            int x = picturedent2.Location.X;
            int y = picturedent2.Location.Y;

            picturedent2.Location = new Point(x, y - 15);

            if (y > this.Height)
                dent2_up.Stop();
        }

        private void dent2_down_Tick(object sender, EventArgs e)
        {
            int x = picturedent2.Location.X;
            int y = picturedent2.Location.Y;

            picturedent2.Location = new Point(x, y + 15);

            if (y > this.Height)
                dent2_down.Stop();
        }

        private void dent3_right_Tick(object sender, EventArgs e)
        {
            int x = picturedent3.Location.X;
            int y = picturedent3.Location.Y;

            picturedent3.Location = new Point(x + 15, y);

            if (x > this.Width)
                dent3_right.Stop();
        }

        private void dent3_left_Tick(object sender, EventArgs e)
        {
            int x = picturedent3.Location.X;
            int y = picturedent3.Location.Y;

            picturedent3.Location = new Point(x - 15, y);

            if (x > this.Width)
                dent3_left.Stop();
        }

        private void dent3_up_Tick(object sender, EventArgs e)
        {
            int x = picturedent3.Location.X;
            int y = picturedent3.Location.Y;

            picturedent3.Location = new Point(x, y - 15);

            if (y > this.Height)
                dent3_up.Stop();
        }

        private void dent3_down_Tick(object sender, EventArgs e)
        {
            int x = picturedent3.Location.X;
            int y = picturedent3.Location.Y;

            picturedent3.Location = new Point(x, y + 15);

            if (y > this.Height)
                dent3_down.Stop();
        }
    }
}
