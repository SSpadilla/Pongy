using Npgsql;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PONGY
{
    public partial class Start : Form
    {
        //------------------------Clases y Lists---------------------
        
        //Clases estaticas
        public static class Psql //para usar database en todo el proyeto y sus métodos
        {
            public static NpgsqlConnection database; 

            public static void ConnectDatabase()
            {
                database = new NpgsqlConnection("Server=127.0.0.1; Port=5432; User Id=postgres; Password=(Me100to9zito); Database=Pongy");

                try {database.Open();}
                catch (Exception e) { MessageBox.Show(e.Message); }
            }//incluye string de conexión

            public static void DisconectDatabase()
            {
                try{if (database.State == System.Data.ConnectionState.Open){database.Close();}}
                catch (Exception e) { MessageBox.Show(e.Message); }
            }
        }
        public static class Difficulty //tipo de dificultad se use en todo el proyecto
        {
            public static bool DifficultyBool = false;
            public static int Velocity = 5;

        }

        //Clases no estaticas
        public class Players //datos de los mejores jugadores
        {
            public  string name = null;
            public  int score = 0;
        }
        
        //Listas
        public static List<Players> player = new List<Players>();//guarda los mejores jugadores segun la dificultad

        //-----------------------------Métodos------------------------
        
        //Métodos void
        public void PaintPayers()//Muestra los mejores jugadores
        {
            Name1.Text = player[0].name; Score1.Text = player[0].score.ToString();
            Name2.Text = player[1].name; Score2.Text = player[1].score.ToString();
            Name3.Text = player[2].name; Score3.Text = player[2].score.ToString();
            Name4.Text = player[3].name; Score4.Text = player[3].score.ToString();
            Name5.Text = player[4].name; Score5.Text = player[4].score.ToString();
        }
        public void LoadData()//carga los datos desde la database
        {
            player.Clear();
            string fact = !Difficulty.DifficultyBool ? "SELECT * FROM easyscores" : "SELECT * FROM hardscores";

            Psql.ConnectDatabase();
            NpgsqlCommand command = new NpgsqlCommand(fact, Psql.database);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Players _player = new Players
                {
                    name = reader.GetValue(1).ToString(),
                    score = int.Parse(reader.GetValue(2).ToString())
                };
                player.Add(_player);
 
            }
            Psql.DisconectDatabase();
            PaintPayers();
        }

        //Métodos Con objetos    
        private void StartButton_Click(object sender, EventArgs e)//inicia el match
        {      
            Match match = new Match();
            match.Show();
        }   
        private void Dificulty_Click(object sender, EventArgs e)//cambia los valores segun las dificultades
        {
            if (!Difficulty.DifficultyBool)
            {
                Dificulty.Image = PONGY.Properties.Resources.HardButton;
                Difficulty.DifficultyBool = true;
                Difficulty.Velocity = 30;
            }
            else
            {
                Dificulty.Image = PONGY.Properties.Resources.EasyButton;
                Difficulty.DifficultyBool = false;
                Difficulty.Velocity = 6;
            }
            //LoadData();

        } 
        public Start()//Constructor
        {
            InitializeComponent();
            //LoadData();
        }
    }
}