using System;
using System.Windows.Forms;

namespace PONGY
{
   
    public partial class Match : Form
    {
        //-----------------------------------Variables---------------------------------

        public int velocity = PONGY.Start.Difficulty.Velocity;//velocidad de la bola deacuerdo a la dificultad
        public int dx, dy,i=0 ,j = 0;//marcan la dirección en los ejees
        public bool goalScored = false;//reinician el juego después de cada gol
        public int keyboardGoals = 0, keyboardBest = 0, mouseBest = 0, mouseGoals = 0;//llevan control de goles en los lados

        //-----------------------------------Métodos---------------------------------

        //Detectores de movimiento en mouse y teclado
        private void Match_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar== ' ')
            {
                if (timer1.Enabled){timer1.Enabled = false;}else{timer1.Enabled = true;}
            }

            if (LeftRacket.Top >15)
            {
                if ((char.ToUpper(e.KeyChar)).Equals('W')) { LeftRacket.Top -= 55; }
            }

            if (LeftRacket.Bottom <= 520) {
                if ((char.ToUpper(e.KeyChar)).Equals('S')) { LeftRacket.Top += 55; }
            } 
        
        }
        private void Match_MouseMove(object sender, MouseEventArgs e)
        {   
           if (e.Location.Y <= 8 || e.Location.Y >= 450){RightRacket.Top += 0;}
            else{RightRacket.Top = e.Y;}
        }
        
        private void Win(char side)//atributos y clases de victoria
        {
            Victory victory = new Victory();
            victory.Winner(keyboardBest, mouseBest, side);
            victory.loadData(ref keyboardGoals, ref mouseGoals, ref goalScored, ref timer1, ref Ball);
            victory.Show();
        }
        private void MarkerPaint()//dibuja los marcadores en cada gol
        {
            LeftMarker.Text = keyboardGoals.ToString();
            RightMarker.Text = mouseGoals.ToString();
            LeftAcMarker.Text = i.ToString();
            RightAcMarker.Text = j.ToString();
        }
        private void Best(ref int kb, ref int mb, ref int i, ref int j, ref int other)//guarda el mejor punteo de ambos lados
        {
            if (kb < i) { kb = i; }
            if (mb < j) { mb = j; }
            other = 0;
        }

        //Métodos de rebote y goles
        public void Goal(PictureBox element)
        {
           
            if (element.Location.X - element.Width >= this.ClientSize.Width )
            {
                goalScored = true;
                keyboardGoals++; i++;
                if (i >= 10) { LeftAcMarker.Left = 145; } else { LeftAcMarker.Left = 160; }
                Best(ref keyboardBest, ref mouseBest, ref i, ref j, ref j);
                MarkerPaint();
            }

            if (element.Location.X + element.Width <= 0)
            {
                goalScored = true;
                mouseGoals++; j++;
                Best(ref keyboardBest, ref mouseBest, ref i, ref j, ref i);
                if (mouseGoals >= 10) { RightAcMarker.Left = 770; } else { RightAcMarker.Left = 730; }
                MarkerPaint();
            }

            if (keyboardGoals == 15){timer1.Stop();Win('L'); }
            else if (mouseGoals == 15){timer1.Stop();Win('R');}

        }
        public void BounceOfWalls (PictureBox element, char location, ref int d)
        {
   
            switch (location)
            {
                case 'Y':
                    if (element.Location.Y >= this.ClientSize.Height - element.Height)
                    {
                        d = -velocity;
                    }

                    if (element.Location.Y <= 0)
                    {
                        d = velocity;
                    }
                    break;
                case 'X':
                    if (element.Location.X >= this.ClientSize.Width - element.Width)
                    {
                        d = velocity;
                    }

                    if (element.Location.X <= 0)
                    {
                        d = -velocity;
                    }
                    break;
            }
        }
        public void BounceOfRackets(PictureBox element, PictureBox racket, char side)
        {
            switch (side)
            {
                case 'L':
                    if ((element.Location.X <= racket.Location.X + racket.Width) && (element.Location.X >= racket.Location.X - (racket.Width )) && ((element.Location.Y + element.Height >= racket.Location.Y) && (element.Location.Y <= racket.Location.Y + racket.Height)))
                    {
                        dx = velocity;
                    }
                    break;
                case 'R':
                    if ((element.Location.X + element.Width > racket.Location.X) && (element.Location.X + element.Width <= racket.Location.X + racket.Width) && (element.Location.Y + element.Height >= racket.Location.Y) && (element.Location.Y <= racket.Location.Y + racket.Height))
                    {
                        dx = -velocity;
                    }
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)//Mueve la bola y analiza las posiciones
        {
            if (!goalScored)
            {
                Ball.Left += dx;
                Ball.Top += dy;
                BounceOfWalls(Ball,'Y', ref dy);
                BounceOfRackets(Ball, LeftRacket, 'L');
                BounceOfRackets(Ball, RightRacket, 'R');
                Goal(Ball);  
            }
            else
            {
                timer1.Stop();
                Ball.Top = 258;
                Ball.Left = 461;
                goalScored = false;
                timer1.Start();
            }
        }

        public Match() //Constructor
        {
            InitializeComponent();
            dx = velocity;
            dy = velocity;
        }
    }
}
