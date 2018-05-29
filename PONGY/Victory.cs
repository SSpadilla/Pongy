using System;
using System.Windows.Forms;

namespace PONGY
{
    public partial class Victory : Form
    {
        //---------------------------Variables------------------------

        public int mouseBest, keyboardBest; private Timer timer;

        //---------------------------Métodos------------------------

        public bool IsHighScore(int score, char player)//si el punteo entra en el top
        {
            int auxiliar = player == 'K' ? mouseBest : keyboardBest;
            if (score > PONGY.Start.player[4].score && score > auxiliar) { return true; }
            return false;
        }

        public void Winner(int keyboardBest, int mouseBest,  char side )//muestra quien gano y guarda punteos altos
        {
            switch (side)
            {
                case 'L':
                    VictoryName.Image = PONGY.Properties.Resources.KeyboardVictory;
                    break;
                case 'R':
                    VictoryName.Image = PONGY.Properties.Resources.MouseVictory;
                    break;
            }
            this.mouseBest = mouseBest;
            this.keyboardBest = keyboardBest;
        }

        //información necesaria para el guardado
        public void loadData(ref int keyboardGoal, ref int mouseGoal, ref bool goalScored, ref Timer timer, ref PictureBox picture)
        {
            keyboardGoal = 0;mouseGoal = 0;goalScored = false;picture.Top = 258;picture.Left = 461;this.timer = timer;
        }

        private void ExitButton_Click(object sender, EventArgs e)//Acciones al cerrar
        {
            // instancia las clases de guardado si hay un punteo alto
            /*
            SaveName save = new SaveName();
            if (IsHighScore(keyboardBest,'K'))
            {
                save.Loader('K', keyboardBest, !IsHighScore(mouseBest,'M'));
                save.Show();
            }
            if(IsHighScore(mouseBest,'M'))
            {
                SaveName save1 = new SaveName();
                save1.Loader('M', mouseBest, true);
                save1.Show();
                save.BringToFront();
            }
            if(!IsHighScore(keyboardBest,'K') && !IsHighScore(mouseBest,'M')){Application.Exit();}*/
            Application.Exit(); //delete if is connected whit database

        }

        private void ContinueButton_Click(object sender, EventArgs e){this.Close();timer.Start();}//sigue con el juego
   
        public Victory(){InitializeComponent();} //constructor
    }
}
