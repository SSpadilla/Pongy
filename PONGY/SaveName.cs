using Npgsql;
using System;
using System.Windows.Forms;

namespace PONGY
{
    public partial class SaveName : Form
    {

        // -------------------------------Variables----------------------------

        PONGY.Start.Players actualPlayer = new Start.Players();
        public bool close = false;

        // -------------------------------Métodos----------------------------
        public void InsertScoresDatabase() //Ingresa los datos en la database
        {
            Start.Psql.ConnectDatabase();
            NpgsqlCommand[] insertcommand = new NpgsqlCommand[5];//almacena comandos
            string table = !Start.Difficulty.DifficultyBool ? "easyscores" : "hardscores";
            string delete = "Delete from " + table;

            for (int i =0; i<insertcommand.Length; i++)
            {
                insertcommand[i] = new NpgsqlCommand("Insert into " + table + " values  ('" + (i + 1).ToString() +"','" + Start.player[i].name + "'," + Start.player[i].score + ")", Start.Psql.database);
            }
            
            NpgsqlCommand deleteCommand = new NpgsqlCommand(delete, Start.Psql.database);

            try {deleteCommand.ExecuteNonQuery();
                for(int j =0; j < insertcommand.Length; j++){insertcommand[j].ExecuteNonQuery();}}
            catch (Exception e) { MessageBox.Show(e.Message); }

            Start.Psql.DisconectDatabase();

        }
        public void OrderScores(Start.Players player)//ordena los punteos grandes
        {
            Start.player.Add(player);
            Start.Players auxiliar;
            for (int i = 0; i < Start.player.Count; i++)
            {
                for (int j = 0; j < Start.player.Count; j++)
                {
                    if (Start.player[i].score >= Start.player[j].score)
                    {
                        auxiliar = Start.player[i];
                        Start.player[i] = Start.player[j];
                        Start.player[j] = auxiliar;
                    }
                }
            }
            Start.player.Remove(Start.player[5]);
            InsertScoresDatabase();
        }
        
        private void DoneButton_Click(object sender, EventArgs e)//cuando se ingresa la informacion
        {
            actualPlayer.name = IngresedName.Text;
            //OrderScores(actualPlayer);
            if (!close) { this.Close(); } else { Application.Exit(); }   
        }

        public void Loader(char winner, int score, bool close)//informacion necesaria para guarda la infor
        {
            switch (winner)
            {
                case 'K':
                    WinnerImg.Image = PONGY.Properties.Resources.KeyboarHighScore;
                    break;
                case 'M':
                    WinnerImg.Image = PONGY.Properties.Resources.MouseHighScore;
                    close = true;
                    break;
            }
            this.close = close;
            actualPlayer.score = score;
        }
        public SaveName(){InitializeComponent();}//constructor
    }
}
