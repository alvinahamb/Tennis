using System;
//using System.Collections.Generic;
//using System.Security.AccessControl;
//using System.Windows.Forms;
//using Microsoft.Win32.SafeHandles;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace Tennis
{
    public partial class Form1 : Form
    {
        int directionLB1 = 1;
        int directionLB2 = 1;
        int directionRB1 = -1;
        int directionRB2 = 1;
        int directionP1 = 0;
        int directionP2 = 0;
        int vitessePlayer = 3;
        int vitesseBall = 4;
        int x = 370;
        int y = 184;
        int dirBallX = 1;
        int dirBallY = 1;
        int[] ballStart = { 1, -1 };
        Random rand1 = new Random();
        int dir = 0;
        int score1 = 0;
        int score2 = 0;
        String heure= DateTime.Now.ToString("HH:mm:ss");
        DateTime specificTime;
        string connexion = "User Id=kasaina;Password=alvinah;Data Source=localhost:1521/DBCOURS.UNEPH.HT";
        //manche de jeu 
        //façon de sauvegarde de score

        public Form1()
        {
            InitializeComponent();
            //debut aleatoire 
            specificTime = DateTime.Parse("15:30:00");
            dir = rand1.Next(2);
            dirBallX = ballStart[dir];
            dir = rand1.Next(2);
            dirBallY = ballStart[dir];
        }

        private void GameTimer(object sender, EventArgs e)
        {
            heure = DateTime.Now.ToString("HH:mm:ss");
            Console.WriteLine("ok");
            //heure = specificTime.ToString("HH:mm:ss");
            //specificTime = specificTime.AddMilliseconds(30);
            //mouvement ball
            BallMouvement();
            //player 
            PlayerMouvement();
            //ballPointDirection pour point 
            ballPointDirection(leftBall1, ref directionLB1, 3);
            ballPointDirection(leftBall2, ref directionLB2, 8);
            ballPointDirection(rightBall1, ref directionRB1, 3);
            ballPointDirection(rightBall2, ref directionRB2, 8);
            //score
            Collision();
            if (score1>2 || score2>2)
            {
                timer.Stop();
            } 
            panel2.Invalidate();
        }
        private void BallMouvement()
        {
            if (y <= 0 || y + GameBall.Height >= panel1.Height)
            {
                dirBallY = -dirBallY;
            }
            if (x <= 0 || x + GameBall.Height >= panel1.Width)
            {
                dirBallX = -dirBallX;
            }
            if (player1.Bounds.IntersectsWith(GameBall.Bounds) || player2.Bounds.IntersectsWith(GameBall.Bounds))
            {
                dirBallX = -dirBallX;
            }

            x += vitesseBall * dirBallX;
            y += vitesseBall * dirBallY;
            GameBall.Location = new Point(x, y);
        }
        
        private void PlayerMouvement()
        {
            //player1
            //Up
            if (directionP1 < 0 && player1.Top >= 0)
            {
                player1.Top -= vitessePlayer;
            }
            //Down 
            if (directionP1 > 0 && player1.Top + player1.Height <= panel1.Height)
            {
                player1.Top += vitessePlayer;
            }
            //player2
            //Up
            if (directionP2 < 0 && player2.Top >= 0)
            {
                player2.Top -= vitessePlayer;
            }
            //Down 
            if (directionP2 > 0 && player2.Top + player2.Height <= panel1.Height)
            {
                player2.Top += vitessePlayer;
            }
        }
        private void ballPointDirection(PictureBox ball, ref int direction, int vitesse)
        {
            ball.Top += vitesse * direction;
            if (ball.Top + ball.Height >= panel1.Height)
            {
                direction = -1;
            }
            else if (ball.Top <= 0)
            {
                direction = 1;
            }
        }

        private void ResetBall()
        {
            x = 370;
            y = 184;
            dirBallX = ballStart[rand1.Next(2)];
            dirBallY = ballStart[rand1.Next(2)];
        }

        private void Collision()
        {
            //Pas de point
            if (x <= 0 || x + GameBall.Width >= panel1.Width)
            {
                ResetBall();
            }
            //collision
            string sql = "";
            if (leftBall1.Bounds.IntersectsWith(GameBall.Bounds))
            {
                //Point genre gagné 1 ou 2 pts
                score2++;
                sql = "INSERT INTO Tennis_Score (ID, Score1, Score2, ScoreTime) VALUES (Tennis_ScoreSeq.NEXTVAL,0,"+score2+", TO_TIMESTAMP('"+heure+"', 'HH24:MI:SS'))";
                ResetBall();
            }
            if (leftBall2.Bounds.IntersectsWith(GameBall.Bounds))
            {
                //Point genre gagné 1 ou 2 pts
                score2 += 2;
                sql = "INSERT INTO Tennis_Score (ID, Score1, Score2, ScoreTime) VALUES (Tennis_ScoreSeq.NEXTVAL,0," + score2 + ", TO_TIMESTAMP('" + heure + "', 'HH24:MI:SS'))";
                ResetBall();
            }
            if (rightBall1.Bounds.IntersectsWith(GameBall.Bounds))
            {
                score1++;
                sql = "INSERT INTO Tennis_Score (ID, Score1, Score2, ScoreTime) VALUES (Tennis_ScoreSeq.NEXTVAL," + score1 + ",0, TO_TIMESTAMP('" + heure + "', 'HH24:MI:SS'))";
                ResetBall();
            }
            if (rightBall2.Bounds.IntersectsWith(GameBall.Bounds))
            {
                score1 += 2;
                sql = "INSERT INTO Tennis_Score (ID, Score1, Score2, ScoreTime) VALUES (Tennis_ScoreSeq.NEXTVAL," + score1 + ",0, TO_TIMESTAMP('" + heure + "', 'HH24:MI:SS'))";
                ResetBall();
                
            }
            //base 
            using (OracleConnection conn = new OracleConnection(connexion))
            {
                try
                {
                    // Ouvre la connexion
                    conn.Open();
                    Console.WriteLine("Connexion réussie!");

                    // Crée une commande
                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        // Exécute la commande
                        int rowsAffected = cmd.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} ligne(s) insérée(s).");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur: " + ex.Message);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 1);
            Font font = new Font("Arial", 10);
            g.DrawString(heure, font, Brushes.Black, new PointF(70, 5));
            g.DrawString(score1.ToString()+" : "+score2.ToString(), font, Brushes.Black, new PointF(90,30));
            pen.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 1);
            // Coordonées de la ligne
            Point start = new Point(panel1.Width/2, 0);
            Point end = new Point(panel1.Width / 2, panel1.Height); 
            g.DrawLine(pen, start, end);
            pen.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void KeyListener(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                directionP1 = -1;
            }
            if (e.KeyCode == Keys.Q)
            {
                directionP1 = 1;
            }
            if (e.KeyCode == Keys.Up)
            {
                directionP2 = -1;
            }
            if (e.KeyCode == Keys.Down)
            {
                directionP2 = 1;
            }
        }
    }
}

//CREATE TABLE Tennis_Score(
//    ID NUMBER PRIMARY KEY,
//    Player1 VARCHAR2(100) DEFAULT 'Player1', 
//    Player2 VARCHAR2(100) DEFAULT 'Player2', 
//    Score1 NUMBER,
//    Score2 NUMBER,
//    ScoreTime TIMESTAMP
//);

//CREATE SEQUENCE Tennis_ScoreSeq START WITH 1 INCREMENT BY 1; 

//INSERT INTO Tennis_Score (ID, Score1, Score2, ScoreTime) VALUES (Tennis_ScoreSeq.NEXTVAL,0,0, TO_TIMESTAMP('00:00:00', 'HH24:MI:SS'));


