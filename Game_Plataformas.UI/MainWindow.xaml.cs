using Game_Plataformas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Game_Plataformas.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        enum Acao { left, right, up, down };
        DispatcherTimer gameTimer;
        Canvas canvas;
        List<Plataforma> plataformas;
        Bloco bloco;
        Acao acaoAtual;
        PanoDeFundo panoDeFundo;


        public MainWindow()
        {
            InitializeComponent();
            canvas = new Canvas();
            canvas.Height = this.Height;
            canvas.Width = this.Width;
            canvas.Background = Brushes.White;
            this.AddChild(canvas);
            panoDeFundo = new PanoDeFundo(canvas);
            plataformas = new List<Plataforma>();
            LinhaHorizontais();
            LinhasVerticais();

            bloco = new Bloco(canvas, plataformas);
            bloco.Draw();

            acaoAtual = Acao.down;
            panoDeFundo.Draw();
            plataformas.ForEach(p => p.Draw());

            gameTimer = new DispatcherTimer(DispatcherPriority.Render);
            gameTimer.Interval = TimeSpan.FromMilliseconds(30);
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
        }

        private void LinhasVerticais()
        {
            //Coluna 1
            plataformas.Add(new Plataforma(canvas, 8, 4, 7, 665));
            //Coluna 2
            plataformas.Add(new Plataforma(canvas, 60, 57, 7, 80));
            plataformas.Add(new Plataforma(canvas, 60, 278, 7, 132));
            plataformas.Add(new Plataforma(canvas, 60, 496, 7, 128));
            //Coluna 3
            plataformas.Add(new Plataforma(canvas, 112, 93, 7, 176));
            plataformas.Add(new Plataforma(canvas, 112, 359, 7, 86));
            plataformas.Add(new Plataforma(canvas, 112, 582, 7, 86));
            //Coluna 4

            plataformas.Add(new Plataforma(canvas, 164, 279, 7, 35));
            plataformas.Add(new Plataforma(canvas, 164, 367, 7, 78));
            plataformas.Add(new Plataforma(canvas, 164, 582, 7, 51));
            //Coluna 5
            plataformas.Add(new Plataforma(canvas, 216, 102, 7, 212));
            plataformas.Add(new Plataforma(canvas, 216, 499, 7, 41));
            plataformas.Add(new Plataforma(canvas, 216, 625, 7, 44));
            //Coluna 6
            plataformas.Add(new Plataforma(canvas, 267, 102, 7, 123));
            plataformas.Add(new Plataforma(canvas, 267, 270, 7, 88));
            plataformas.Add(new Plataforma(canvas, 267, 412, 7, 34));
            plataformas.Add(new Plataforma(canvas, 267, 590, 7, 34));
            //Coluna 7
            plataformas.Add(new Plataforma(canvas, 319, 58, 7, 85));
            plataformas.Add(new Plataforma(canvas, 319, 318, 7, 45));
            plataformas.Add(new Plataforma(canvas, 319, 411, 7, 43));
            plataformas.Add(new Plataforma(canvas, 319, 544, 7, 43));
            //Coluna 8
            plataformas.Add(new Plataforma(canvas, 371, 4, 7, 51));
            plataformas.Add(new Plataforma(canvas, 371, 96, 7, 41));
            plataformas.Add(new Plataforma(canvas, 371, 407, 7, 41));
            plataformas.Add(new Plataforma(canvas, 371, 497, 7, 41));
            plataformas.Add(new Plataforma(canvas, 371, 625, 7, 44));
            //Coluna 9
            plataformas.Add(new Plataforma(canvas, 422, 4, 7, 51));
            plataformas.Add(new Plataforma(canvas, 422, 146, 7, 78));
            plataformas.Add(new Plataforma(canvas, 422, 279, 7, 78));
            plataformas.Add(new Plataforma(canvas, 422, 625, 7, 51));
            //Coluna 10
            plataformas.Add(new Plataforma(canvas, 474, 50, 7, 51));
            plataformas.Add(new Plataforma(canvas, 474, 234, 7, 40));
            plataformas.Add(new Plataforma(canvas, 474, 367, 7, 40));
            plataformas.Add(new Plataforma(canvas, 474, 497, 7, 40));
            plataformas.Add(new Plataforma(canvas, 474, 588, 7, 43));
            //Coluna 11
            plataformas.Add(new Plataforma(canvas, 526, 6, 7, 50));
            plataformas.Add(new Plataforma(canvas, 526, 146, 7, 34));
            plataformas.Add(new Plataforma(canvas, 526, 276, 7, 90));
            plataformas.Add(new Plataforma(canvas, 526, 451, 7, 40));
            plataformas.Add(new Plataforma(canvas, 526, 625, 7, 43));
            //Coluna 12
            plataformas.Add(new Plataforma(canvas, 578, 56, 7, 40));
            plataformas.Add(new Plataforma(canvas, 578, 278, 7, 123));
            plataformas.Add(new Plataforma(canvas, 578, 584, 7, 40));
            //Coluna 13
            plataformas.Add(new Plataforma(canvas, 629, 6, 7, 41));
            plataformas.Add(new Plataforma(canvas, 629, 190, 7, 78));
            plataformas.Add(new Plataforma(canvas, 629, 323, 7, 123));
            plataformas.Add(new Plataforma(canvas, 629, 536, 7, 50));
            //Coluna 14
            plataformas.Add(new Plataforma(canvas, 681, 50, 7, 42));
            plataformas.Add(new Plataforma(canvas, 681, 138, 7, 42));
            plataformas.Add(new Plataforma(canvas, 681, 360, 7, 42));
            plataformas.Add(new Plataforma(canvas, 681, 581, 7, 42));
            //Coluna 15
            plataformas.Add(new Plataforma(canvas, 733, 13, 7, 43));
            plataformas.Add(new Plataforma(canvas, 733, 102, 7, 43));
            plataformas.Add(new Plataforma(canvas, 733, 190, 7, 123));
            plataformas.Add(new Plataforma(canvas, 733, 404, 7, 95));
            plataformas.Add(new Plataforma(canvas, 733, 544, 7, 80));
            //Coluna 16
            plataformas.Add(new Plataforma(canvas, 785, 4, 7, 665));
        }

        private void LinhaHorizontais()
        {
            //Linha 1
            plataformas.Add(new Plataforma(canvas, 8, 4, 360, 7));
            plataformas.Add(new Plataforma(canvas, 426, 4, 360, 7));
            //Linha 2
            plataformas.Add(new Plataforma(canvas, 58, 49, 63, 7));
            plataformas.Add(new Plataforma(canvas, 163, 49, 164, 7));
            plataformas.Add(new Plataforma(canvas, 577, 49, 60, 7));

            //Linha 3
            plataformas.Add(new Plataforma(canvas, 370, 94, 267, 7));
            plataformas.Add(new Plataforma(canvas, 163, 94, 112, 7));
            plataformas.Add(new Plataforma(canvas, 679, 94, 104, 7));
            //Linha 4
            plataformas.Add(new Plataforma(canvas, 16, 138, 53, 7));
            plataformas.Add(new Plataforma(canvas, 120, 138, 53, 7));
            plataformas.Add(new Plataforma(canvas, 317, 138, 63, 7));
            plataformas.Add(new Plataforma(canvas, 421, 138, 216, 7));
            //Linha 5
            plataformas.Add(new Plataforma(canvas, 16, 182, 93, 7));
            plataformas.Add(new Plataforma(canvas, 161, 182, 53, 7));
            plataformas.Add(new Plataforma(canvas, 318, 182, 102, 7));
            plataformas.Add(new Plataforma(canvas, 473, 182, 62, 7));
            plataformas.Add(new Plataforma(canvas, 577, 182, 62, 7));
            plataformas.Add(new Plataforma(canvas, 679, 182, 61, 7));
            //Linha 6
            plataformas.Add(new Plataforma(canvas, 59, 226, 114, 7));
            plataformas.Add(new Plataforma(canvas, 265, 226, 165, 7));
            plataformas.Add(new Plataforma(canvas, 473, 226, 113, 7));
            plataformas.Add(new Plataforma(canvas, 637, 226, 54, 7));
            //Linha 7
            plataformas.Add(new Plataforma(canvas, 16, 270, 53, 7));
            plataformas.Add(new Plataforma(canvas, 110, 270, 62, 7));
            plataformas.Add(new Plataforma(canvas, 317, 270, 217, 7));
            plataformas.Add(new Plataforma(canvas, 575, 270, 208, 7));
            //Linha 8
            plataformas.Add(new Plataforma(canvas, 68, 315, 53, 7));
            plataformas.Add(new Plataforma(canvas, 162, 315, 62, 7));
            plataformas.Add(new Plataforma(canvas, 276, 315, 104, 7));
            plataformas.Add(new Plataforma(canvas, 430, 315, 53, 7));
            plataformas.Add(new Plataforma(canvas, 627, 315, 114, 7));
            //Linha 9
            plataformas.Add(new Plataforma(canvas, 163, 359, 112, 7));
            plataformas.Add(new Plataforma(canvas, 318, 359, 112, 7));
            plataformas.Add(new Plataforma(canvas, 473, 359, 62, 7));
            plataformas.Add(new Plataforma(canvas, 679, 359, 104, 7));
            //Linha 10
            plataformas.Add(new Plataforma(canvas, 213, 403, 62, 7));
            plataformas.Add(new Plataforma(canvas, 317, 403, 62, 7));
            plataformas.Add(new Plataforma(canvas, 422, 403, 164, 7));
            plataformas.Add(new Plataforma(canvas, 680, 403, 62, 7));
            //Linha 11
            plataformas.Add(new Plataforma(canvas, 16, 447, 104, 7));
            plataformas.Add(new Plataforma(canvas, 162, 447, 113, 7));
            plataformas.Add(new Plataforma(canvas, 370, 447, 164, 7));
            plataformas.Add(new Plataforma(canvas, 577, 447, 112, 7));
            //Linha 12
            plataformas.Add(new Plataforma(canvas, 60, 492, 60, 7));
            plataformas.Add(new Plataforma(canvas, 163, 492, 267, 7));
            plataformas.Add(new Plataforma(canvas, 472, 492, 217, 7));
            //Linha 13
            plataformas.Add(new Plataforma(canvas, 68, 536, 260, 7));
            plataformas.Add(new Plataforma(canvas, 368, 536, 115, 7));
            plataformas.Add(new Plataforma(canvas, 525, 536, 215, 7));
            //Linha 14
            plataformas.Add(new Plataforma(canvas, 110, 580, 166, 7));
            plataformas.Add(new Plataforma(canvas, 369, 580, 217, 7));
            plataformas.Add(new Plataforma(canvas, 741, 580, 42, 7));
            //Linha 15
            plataformas.Add(new Plataforma(canvas, 16, 625, 53, 7));
            plataformas.Add(new Plataforma(canvas, 266, 625, 60, 7));
            plataformas.Add(new Plataforma(canvas, 576, 625, 165, 7));
            //Linha 16
            plataformas.Add(new Plataforma(canvas, 8, 669, 370, 7));
            plataformas.Add(new Plataforma(canvas, 423, 669, 370, 7));
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                switch (acaoAtual)
                {
                    case Acao.left:
                        bloco.MoveLeft();
                        break;
                    case Acao.right:
                        bloco.MoveRight();
                        break;
                    case Acao.up:
                        bloco.MoveUp();
                        break;
                    case Acao.down:
                        bloco.MoveDown();
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                gameTimer.Stop();
                MessageBox.Show("Game Over!");
            }

        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
                acaoAtual = Acao.left;
            if (e.Key == Key.Right)
                acaoAtual = Acao.right;
            if (e.Key == Key.Space)
                bloco.Jump();
            if (e.Key == Key.Up)
                acaoAtual = Acao.up;
            if (e.Key == Key.Down)
                acaoAtual = Acao.down;
            if (e.Key == Key.Escape)
                this.Close();

        }
    }
}
