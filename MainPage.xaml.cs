namespace tic_tac_toe_MAUI
{
    public partial class MainPage : ContentPage
    {
        string Turn = "X"

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;

            if(Turn == "X")
            {
                btn.Text = "X";
                Turn = "O";
            }
            else
            {
                btn.Text = "O";
                Turn = "X";
            }
            //x ganhou primeira linha horizontal
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                Zerar();
            }
            //O ganhou primeira linha horizontal
            else if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                Zerar();
            }
            //X ganhou a segunda linha horizontal
            else if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                Zerar();
            }
            //O ganhou segunda linha horizontal
            else if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
            {
                DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                Zerar();
            }
            //x ganhou a terceira linha horizontal
            else if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                Zerar();
            }
            //O ganhou terceira linha horizontal
            else if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                Zerar();
            }
            // X ganhou primeira linha vertical
            else if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                Zerar();
            }
            // O ganhou primeira linha vertical
            else if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
            {
                DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                Zerar();
            }
            // X ganhou segunda linha vertical
            else if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                Zerar();
            }
            // O ganhou segunda linha vertical
            else if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
            {
                DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                Zerar();
            }
            // X ganhou terceira linha vertical
            else if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                Zerar();
            }
            // O ganhou terceira linha vertical
            else if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                Zerar();
            }
            //X ganhou na diagonal descendente
            else if(btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                Zerar();
            }
            // O ganhou na diagonal descendente
            else if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                Zerar();
            }
            //X ganhou na diagonal ascendente
            else if (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                Zerar();
            }
            // O ganhou na diagonal ascendente
            else if (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O")
            {
                DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                Zerar();
            }
            //Empate
            else if (!btn10.Text = "" && !btn11.Text == "" && !btn12.Text = "" && !btn20.Text == "" && !btn21.Text = "" && !btn22.Text == "" && !btn30.Text == "" && !btn31.Text = "" && !btn32.Text == "")
            {
                DisplayAlert("Empate!", " Não houve vencedores", "OK");
                Zerar();
            }




        }

        void Zerar()
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";

            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";

            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";

            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;

            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;

            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;
        }
    }

}
