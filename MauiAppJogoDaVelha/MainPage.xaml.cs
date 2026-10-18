namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.IsEnabled = false;

            if (vez == "X")
            {
                btn.Text = "X";
                vez = "O";
            }
            else
            {
                btn.Text = "O";
                vez = "X";
            }

            // ==========================================
            // VERIFICAÇÕES DE VITÓRIA PARA O "X"
            // ==========================================

            // Linhas
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X") { DeclararVencedor("X"); return; }
            if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X") { DeclararVencedor("X"); return; }
            if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X") { DeclararVencedor("X"); return; }

            // Colunas
            if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X") { DeclararVencedor("X"); return; }
            if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X") { DeclararVencedor("X"); return; }
            if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X") { DeclararVencedor("X"); return; }

            // Diagonais
            if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X") { DeclararVencedor("X"); return; }
            if (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X") { DeclararVencedor("X"); return; }


            // ==========================================
            // VERIFICAÇÕES DE VITÓRIA PARA O "O"
            // ==========================================

            // Linhas
            if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O") { DeclararVencedor("O"); return; }
            if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O") { DeclararVencedor("O"); return; }
            if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O") { DeclararVencedor("O"); return; }

            // Colunas
            if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O") { DeclararVencedor("O"); return; }
            if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O") { DeclararVencedor("O"); return; }
            if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O") { DeclararVencedor("O"); return; }

            // Diagonais
            if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O") { DeclararVencedor("O"); return; }
            if (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O") { DeclararVencedor("O"); return; }


            // ==========================================
            // VERIFICAÇÃO DE EMPATE (DEU VELHA)
            // ==========================================
            if (!btn10.IsEnabled && !btn11.IsEnabled && !btn12.IsEnabled &&
                !btn20.IsEnabled && !btn21.IsEnabled && !btn22.IsEnabled &&
                !btn30.IsEnabled && !btn31.IsEnabled && !btn32.IsEnabled)
            {
                DisplayAlert("Deu Velha!", "O jogo terminou empatado!", "OK");
                Zerar();
            }
        }

        private void DeclararVencedor(string vencedor)
        {
            DisplayAlert("Parabéns!", $"O {vencedor} ganhou!", "OK");
            Zerar();
        }

        void Zerar()
        {
            // Limpa o texto dos botões
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";

            // Reabilita os botões para um novo jogo
            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;
            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;

            // Reinicia a vez para o "X" começar jogando
            vez = "X";
        }
    }
}