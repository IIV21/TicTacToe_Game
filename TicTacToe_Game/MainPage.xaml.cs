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
        async void checkWinner(int l, int c, Label label)
        {
            if (gameBoard[l, c] == 0) /* VERIFICAM CA BUTONUL NU E APASAT*/
            {
                counter++;
                int ok = 0;

                if (counter % 2 == 0)   /* counter == 1 pt x si 2 pt 0*/
                {
                    gameBoard[l, c] = 2;
                    label.FontFamily = "FAR";
                    label.Text = "\uf111";
                    await label.FadeTo(1, 250);
                }
                else
                {
                    gameBoard[l, c] = 1;
                    label.FontFamily = "FAS";
                    label.Text = "\uf057";
                    await label.FadeTo(1, 250);
                }

                /*SERIILE DE VERIFICARI PT CASTIGATOR*/
                if (gameBoard[0, 0] == 1 && gameBoard[0, 1] == 1 && gameBoard[0, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                    ok = 1;
                }
                if (gameBoard[0, 1] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 1] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                    ok = 1;
                }
                if (gameBoard[0, 2] == 1 && gameBoard[1, 2] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                    ok = 1;
                }
                if (gameBoard[1, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[1, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                    ok = 1;
                }
                if (gameBoard[2, 0] == 1 && gameBoard[2, 1] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                    ok = 1;
                }
                if (gameBoard[0, 0] == 1 && gameBoard[1, 0] == 1 && gameBoard[2, 0] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                    ok = 1;
                }
                if (gameBoard[0, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 2] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                    ok = 1;
                }

                if (gameBoard[0, 0] == 2 && gameBoard[0, 1] == 2 && gameBoard[0, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                    ok = 1;
                }

                if (gameBoard[0, 2] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 0] == 1)
                {
                    finalLabel.Text = "X MARKS THE SPOT";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                    ok = 1;
                }

                if (gameBoard[0, 0] == 2 && gameBoard[1, 0] == 2 && gameBoard[2, 0] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                    ok = 1;
                }
                if (gameBoard[0, 0] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                    ok = 1;
                }
                if (gameBoard[0, 1] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 1] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                    ok = 1;
                }
                if (gameBoard[0, 2] == 2 && gameBoard[1, 2] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                    ok = 1;
                }
                if (gameBoard[1, 0] == 2 && gameBoard[1, 1] == 2 && gameBoard[1, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                    ok = 1;
                }
                if (gameBoard[2, 0] == 2 && gameBoard[2, 1] == 2 && gameBoard[2, 2] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                    ok = 1;
                }
                if (gameBoard[0, 2] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 0] == 2)
                {
                    finalLabel.Text = "O, THE WINNER THRIVES";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                    ok = 1;
                }

                if (counter == 9 && ok ==0)
                {
                    finalLabel.Text = "DRAW";
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            gameBoard[i, j] = 3;
                }
            }
        }
    

        private void B00_Clicked(object sender, EventArgs e)
        {
            checkWinner(0, 0, l00);
        }

        private void B01_Clicked(object sender, EventArgs e)
        {
            checkWinner(0,1,l01);
        }

        private void B02_Clicked(object sender, EventArgs e)
        {
            checkWinner(0, 2, l02);
        }

        private void B10_Clicked(object sender, EventArgs e)
        {
            checkWinner(1, 0, l10);
        }

        private void B11_Clicked(object sender, EventArgs e)
        {
            checkWinner(1, 1, l11);
        }

        private void B12_Clicked(object sender, EventArgs e)
        {
            checkWinner(1, 2, l12);
        }

        private void B20_Clicked(object sender, EventArgs e)
        {
            checkWinner(2, 0, l20);
        }

        private void B21_Clicked(object sender, EventArgs e)
        {
            checkWinner(2, 1, l21);
        }

        private void B22_Clicked(object sender, EventArgs e)
        {
            checkWinner(2, 2, l22);
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

