namespace ucanTop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int yerX = 15, yerY = 15, can = 3;

        private void CarpmaOlayi()
        {
            //label3 carpma
            if(ball.Top <= label3.Bottom)
            {
                yerY = yerY * -1;
            }

            //Kontrole carpma
            if(ball.Bottom >= kontrol.Top && ball.Left >= kontrol.Left && ball.Right <= kontrol.Right)
            {
                yerY = -yerY;
            }

            //sað kenara çarpma olayý
            else if(ball.Right >= label2.Left)
            {
                yerX = -yerX;
            }
            //sol kenara çarpma
            else if(ball.Left <= label1.Right)
            {
                yerX = -yerX;
            }
          
        }
        private void yanmaOlayi(object sender, EventArgs e)
        {
            if(ball.Top >= label2.Bottom)
            {
                if(can > 0)
                {
                    timer1.Stop();
                    can--;
                    MessageBox.Show("Yandýnýz. kalan can: " + can.ToString());
                    Form1_Load(sender, e);

                }
                if(can == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Oyun bitti.", "" , MessageBoxButtons.OK);
                }
            }
            label4.Text = can.ToString();
        }

        private void topBasa()
        {
            ball.Location = new Point(246, 114);
        }


        private void kontrol_MouseMove(object sender, MouseEventArgs e)
        {
             kontrol.Left += e.X;
             

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CarpmaOlayi();
            yanmaOlayi(sender, e);
            ball.Location = new Point(ball.Location.X + yerX, ball.Location.Y + yerY);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            topBasa();
            timer1.Enabled = true;
        }
    }
}
