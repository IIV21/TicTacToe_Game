using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TicTacToe_Game
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int[,] gameBoard = new int[3, 3];
        int counter = 0;

        private async void B00_Clicked(object sender, EventArgs e)
        {
            if(gameBoard[0,0] == 0) /* VERIFICAM CA BUTONUL NU E APASAT*/
            {
                counter++;

                if (counter % 2 == 0)   /* counter == 1 pt x si 2 pt 0*/
                {
                    gameBoard[0, 0] = 2;
                    l00.FontFamily = "FAR";
                    l00.Text = "\uf111";
                    await l00.FadeTo(1, 250);
                }
                else
                {
                    gameBoard[0, 0] = 1;
                    l00.FontFamily = "FAS";
                    l00.Text = "\uf057";
                    await l00.FadeTo(1, 250);
                }

                /*SERIILE DE VERIFICARI PT CASTIGATOR*/
                if(gameBoard[0, 0] == 1 && gameBoard[0, 1] == 1 && gameBoard[0, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 1] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 1] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 2] == 1 && gameBoard[1, 2] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[1, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[1, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[2, 0] == 1 && gameBoard[2, 1] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 1 && gameBoard[1, 0] == 1 && gameBoard[2, 0] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (gameBoard[0, 0] == 2 && gameBoard[0, 1] == 2 && gameBoard[0, 2] == 2)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (gameBoard[0, 2] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 0] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (gameBoard[0, 0] == 2 && gameBoard[1, 0] == 2 && gameBoard[2, 0] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                    if (gameBoard[0, 0] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 1] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 1] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 2] == 2 && gameBoard[1, 2] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[1, 0] == 2 && gameBoard[1, 1] == 2 && gameBoard[1, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[2, 0] == 2 && gameBoard[2, 1] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 2] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 0] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (counter == 9)
                {
                    finalLabel.Text = "DRAW";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
            }
        }

        private async void B01_Clicked(object sender, EventArgs e)
        {
            if (gameBoard[0, 1] == 0) /* VERIFICAM CA BUTONUL NU E APASAT*/
            {
                counter++;

                if (counter % 2 == 0)   /* counter == 1 pt x si 2 pt 0*/
                {
                    gameBoard[0, 1] = 2;
                    l01.FontFamily = "FAR";
                    l01.Text = "\uf111";
                    await l01.FadeTo(1, 250);
                }
                else
                {
                    gameBoard[0, 1] = 1;
                    l01.FontFamily = "FAS";
                    l01.Text = "\uf057";
                    await l01.FadeTo(1, 250);
                }

                /*SERIILE DE VERIFICARI PT CASTIGATOR*/
                if (gameBoard[0, 0] == 1 && gameBoard[0, 1] == 1 && gameBoard[0, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 1] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 1] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 2] == 1 && gameBoard[1, 2] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[1, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[1, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[2, 0] == 1 && gameBoard[2, 1] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 1 && gameBoard[1, 0] == 1 && gameBoard[2, 0] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (gameBoard[0, 2] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 0] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (gameBoard[0, 0] == 2 && gameBoard[0, 1] == 2 && gameBoard[0, 2] == 2)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 2 && gameBoard[1, 0] == 2 && gameBoard[2, 0] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 1] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 1] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 2] == 2 && gameBoard[1, 2] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[1, 0] == 2 && gameBoard[1, 1] == 2 && gameBoard[1, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[2, 0] == 2 && gameBoard[2, 1] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (gameBoard[0, 2] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 0] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (counter == 9)
                {
                    finalLabel.Text = "DRAW";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
            }
        }

        private async void B02_Clicked(object sender, EventArgs e)
        {
            if (gameBoard[0, 2] == 0) /* VERIFICAM CA BUTONUL NU E APASAT*/
            {
                counter++;

                if (counter % 2 == 0)   /* counter == 1 pt x si 2 pt 0*/
                {
                    gameBoard[0, 2] = 2;
                    l02.FontFamily = "FAR";
                    l02.Text = "\uf111";
                    await l02.FadeTo(1, 250);
                }
                else
                {
                    gameBoard[0, 2] = 1;
                    l02.FontFamily = "FAS";
                    l02.Text = "\uf057";
                    await l02.FadeTo(1, 250);
                }

                /*SERIILE DE VERIFICARI PT CASTIGATOR*/
                if (gameBoard[0, 0] == 1 && gameBoard[0, 1] == 1 && gameBoard[0, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 1] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 1] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 2] == 1 && gameBoard[1, 2] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[1, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[1, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[2, 0] == 1 && gameBoard[2, 1] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 1 && gameBoard[1, 0] == 1 && gameBoard[2, 0] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (gameBoard[0, 2] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 0] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (gameBoard[0, 0] == 2 && gameBoard[0, 1] == 2 && gameBoard[0, 2] == 2)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 2 && gameBoard[1, 0] == 2 && gameBoard[2, 0] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 1] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 1] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 2] == 2 && gameBoard[1, 2] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[1, 0] == 2 && gameBoard[1, 1] == 2 && gameBoard[1, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[2, 0] == 2 && gameBoard[2, 1] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (gameBoard[0, 2] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 0] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (counter == 9)
                {
                    finalLabel.Text = "DRAW";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
            }
        }

        private async void B10_Clicked(object sender, EventArgs e)
        {
            if (gameBoard[1, 0] == 0) /* VERIFICAM CA BUTONUL NU E APASAT*/
            {
                counter++;

                if (counter % 2 == 0)   /* counter == 1 pt x si 2 pt 0*/
                {
                    gameBoard[1, 0] = 2;
                    l10.FontFamily = "FAR";
                    l10.Text = "\uf111";
                    await l10.FadeTo(1, 250);
                }
                else
                {
                    gameBoard[1, 0] = 1;
                    l10.FontFamily = "FAS";
                    l10.Text = "\uf057";
                    await l10.FadeTo(1, 250);
                }

                /*SERIILE DE VERIFICARI PT CASTIGATOR*/
                if (gameBoard[0, 0] == 1 && gameBoard[0, 1] == 1 && gameBoard[0, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 1] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 1] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 2] == 1 && gameBoard[1, 2] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[1, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[1, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[2, 0] == 1 && gameBoard[2, 1] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 1 && gameBoard[1, 0] == 1 && gameBoard[2, 0] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 2] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 0] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (gameBoard[0, 0] == 2 && gameBoard[0, 1] == 2 && gameBoard[0, 2] == 2)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 2 && gameBoard[1, 0] == 2 && gameBoard[2, 0] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 1] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 1] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 2] == 2 && gameBoard[1, 2] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[1, 0] == 2 && gameBoard[1, 1] == 2 && gameBoard[1, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (gameBoard[0, 2] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 0] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (gameBoard[2, 0] == 2 && gameBoard[2, 1] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (counter == 9)
                {
                    finalLabel.Text = "DRAW";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
            }
        }

        private async void B11_Clicked(object sender, EventArgs e)
        {
            if (gameBoard[1, 1] == 0) /* VERIFICAM CA BUTONUL NU E APASAT*/
            {
                counter++;

                if (counter % 2 == 0)   /* counter == 1 pt x si 2 pt 0*/
                {
                    gameBoard[1, 1] = 2;
                    l11.FontFamily = "FAR";
                    l11.Text = "\uf111";
                    await l11.FadeTo(1, 250);
                }
                else
                {
                    gameBoard[1, 1] = 1;
                    l11.FontFamily = "FAS";
                    l11.Text = "\uf057";
                    await l11.FadeTo(1, 250);
                }

                /*SERIILE DE VERIFICARI PT CASTIGATOR*/
                if (gameBoard[0, 0] == 1 && gameBoard[0, 1] == 1 && gameBoard[0, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 1] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 1] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 2] == 1 && gameBoard[1, 2] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[1, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[1, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[2, 0] == 1 && gameBoard[2, 1] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 1 && gameBoard[1, 0] == 1 && gameBoard[2, 0] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 2] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 0] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (gameBoard[0, 0] == 2 && gameBoard[0, 1] == 2 && gameBoard[0, 2] == 2)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 2 && gameBoard[1, 0] == 2 && gameBoard[2, 0] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 1] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 1] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 2] == 2 && gameBoard[1, 2] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[1, 0] == 2 && gameBoard[1, 1] == 2 && gameBoard[1, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (gameBoard[0, 2] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 0] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (gameBoard[2, 0] == 2 && gameBoard[2, 1] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (counter == 9)
                {
                    finalLabel.Text = "DRAW";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
            }
        }

        private async void B12_Clicked(object sender, EventArgs e)
        {
            if (gameBoard[1, 2] == 0) /* VERIFICAM CA BUTONUL NU E APASAT*/
            {
                counter++;

                if (counter % 2 == 0)   /* counter == 1 pt x si 2 pt 0*/
                {
                    gameBoard[1, 2] = 2;
                    l12.FontFamily = "FAR";
                    l12.Text = "\uf111";
                    await l12.FadeTo(1, 250);
                }
                else
                {
                    gameBoard[1, 2] = 1;
                    l12.FontFamily = "FAS";
                    l12.Text = "\uf057";
                    await l12.FadeTo(1, 250);
                }

                /*SERIILE DE VERIFICARI PT CASTIGATOR*/
                if (gameBoard[0, 0] == 1 && gameBoard[0, 1] == 1 && gameBoard[0, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 1] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 1] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 2] == 1 && gameBoard[1, 2] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[1, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[1, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[2, 0] == 1 && gameBoard[2, 1] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 1 && gameBoard[1, 0] == 1 && gameBoard[2, 0] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (gameBoard[0, 0] == 2 && gameBoard[0, 1] == 2 && gameBoard[0, 2] == 2)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (gameBoard[0, 2] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 0] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (gameBoard[0, 0] == 2 && gameBoard[1, 0] == 2 && gameBoard[2, 0] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 1] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 1] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 2] == 2 && gameBoard[1, 2] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[1, 0] == 2 && gameBoard[1, 1] == 2 && gameBoard[1, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[2, 0] == 2 && gameBoard[2, 1] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (gameBoard[0, 2] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 0] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (counter == 9)
                {
                    finalLabel.Text = "DRAW";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
            }
        }

        private async void B20_Clicked(object sender, EventArgs e)
        {
            if (gameBoard[2, 0] == 0) /* VERIFICAM CA BUTONUL NU E APASAT*/
            {
                counter++;

                if (counter % 2 == 0)   /* counter == 1 pt x si 2 pt 0*/
                {
                    gameBoard[2, 0] = 2;
                    l20.FontFamily = "FAR";
                    l20.Text = "\uf111";
                    await l20.FadeTo(1, 250);
                }
                else
                {
                    gameBoard[2, 0] = 1;
                    l20.FontFamily = "FAS";
                    l20.Text = "\uf057";
                    await l20.FadeTo(1, 250);
                }

                /*SERIILE DE VERIFICARI PT CASTIGATOR*/
                if (gameBoard[0, 0] == 1 && gameBoard[0, 1] == 1 && gameBoard[0, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 1] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 1] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 2] == 1 && gameBoard[1, 2] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[1, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[1, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[2, 0] == 1 && gameBoard[2, 1] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 1 && gameBoard[1, 0] == 1 && gameBoard[2, 0] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (gameBoard[0, 0] == 2 && gameBoard[0, 1] == 2 && gameBoard[0, 2] == 2)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (gameBoard[0, 2] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 0] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (gameBoard[0, 0] == 2 && gameBoard[1, 0] == 2 && gameBoard[2, 0] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 1] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 1] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 2] == 2 && gameBoard[1, 2] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[1, 0] == 2 && gameBoard[1, 1] == 2 && gameBoard[1, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[2, 0] == 2 && gameBoard[2, 1] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (gameBoard[0, 2] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 0] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (counter == 9)
                {
                    finalLabel.Text = "DRAW";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
            }
        }

        private async void B21_Clicked(object sender, EventArgs e)
        {
            if (gameBoard[2, 1] == 0) /* VERIFICAM CA BUTONUL NU E APASAT*/
            {
                counter++;

                if (counter % 2 == 0)   /* counter == 1 pt x si 2 pt 0*/
                {
                    gameBoard[2, 1] = 2;
                    l21.FontFamily = "FAR";
                    l21.Text = "\uf111";
                    await l21.FadeTo(1, 250);
                }
                else
                {
                    gameBoard[2, 1] = 1;
                    l21.FontFamily = "FAS";
                    l21.Text = "\uf057";
                    await l21.FadeTo(1, 250);
                }

                /*SERIILE DE VERIFICARI PT CASTIGATOR*/
                if (gameBoard[0, 0] == 1 && gameBoard[0, 1] == 1 && gameBoard[0, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 1] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 1] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 2] == 1 && gameBoard[1, 2] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[1, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[1, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[2, 0] == 1 && gameBoard[2, 1] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 1 && gameBoard[1, 0] == 1 && gameBoard[2, 0] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 2] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 0] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (gameBoard[0, 0] == 2 && gameBoard[0, 1] == 2 && gameBoard[0, 2] == 2)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 2 && gameBoard[1, 0] == 2 && gameBoard[2, 0] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 1] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 1] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 2] == 2 && gameBoard[1, 2] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[1, 0] == 2 && gameBoard[1, 1] == 2 && gameBoard[1, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[2, 0] == 2 && gameBoard[2, 1] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (gameBoard[0, 2] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 0] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (counter == 9)
                {
                    finalLabel.Text = "DRAW";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
            }
        }

        private async void B22_Clicked(object sender, EventArgs e)
        {
            if (gameBoard[2, 2] == 0) /* VERIFICAM CA BUTONUL NU E APASAT*/
            {
                counter++;

                if (counter % 2 == 0)   /* counter == 1 pt x si 2 pt 0*/
                {
                    gameBoard[2, 2] = 2;
                    l22.FontFamily = "FAR";
                    l22.Text = "\uf111";
                    await l22.FadeTo(1, 250);
                }
                else
                {
                    gameBoard[2, 2] = 1;
                    l22.FontFamily = "FAS";
                    l22.Text = "\uf057";
                    await l22.FadeTo(1, 250);
                }

                /*SERIILE DE VERIFICARI PT CASTIGATOR*/
                if (gameBoard[0, 0] == 1 && gameBoard[0, 1] == 1 && gameBoard[0, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 1] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 1] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 2] == 1 && gameBoard[1, 2] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[1, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[1, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[2, 0] == 1 && gameBoard[2, 1] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 1 && gameBoard[1, 0] == 1 && gameBoard[2, 0] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 2] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 0] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }


                if (gameBoard[0, 0] == 2 && gameBoard[0, 1] == 2 && gameBoard[0, 2] == 2)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 2 && gameBoard[1, 0] == 2 && gameBoard[2, 0] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 0] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 1] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 1] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[0, 2] == 2 && gameBoard[1, 2] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[1, 0] == 2 && gameBoard[1, 1] == 2 && gameBoard[1, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
                if (gameBoard[2, 0] == 2 && gameBoard[2, 1] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (gameBoard[0, 2] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 0] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }

                if (counter == 9)
                {
                    finalLabel.Text = "DRAW";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
            }
        }

        private void playAgainButton_Clicked(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    gameBoard[i, j] = 0;
            l00.Opacity = 0;
            l01.Opacity = 0;
            l02.Opacity = 0;
            l10.Opacity = 0;
            l11.Opacity = 0;
            l12.Opacity = 0;
            l20.Opacity = 0;
            l21.Opacity = 0;
            l22.Opacity = 0;
            finalLabel.Text = "";
            counter = 0;
        }
    }
}
