# 🎮 Jogo da Velha em .NET MAUI

Aplicativo mobile de **Jogo da Velha** desenvolvido para a disciplina do curso técnico em Desenvolvimento de Sistemas da **Etec**. O projeto utiliza **C#** e **XAML** com a plataforma **.NET MAUI**, trazendo uma interface moderna com suporte a dimensionamento nativo para telas mobile.

---

## 📸 Demonstração da Aplicação

![Demo do Jogo da Velha](./Screenshots/Demo%20Jogo%20da%20Velha.png)

---

## 🚀 Funcionalidades

- **Alternância de Turnos**: Controle automático da vez dos jogadores (`X` e `O`).
- **Validação Completa de Vitórias**:
  - 3 Linhas (Horizontais)
  - 3 Colunas (Verticais)
  - 2 Diagonais
- **Detecção de Empate (Deu Velha)**: Identifica quando todas as jogadas foram efetuadas sem um vencedor.
- **Reinício Automático**: Método para zerar o tabuleiro e redefinir o jogador inicial após o encerramento da partida.
- **Layout Personalizado**: Design estilizado em formato de game mobile com palette de cores no estilo *Dark Mode*.

---

## 🛠️ Tecnologias Utilizadas

- **.NET MAUI** (Multi-platform App UI)
- **C#** (Lógica de jogo e eventos)
- **XAML** (Interface gráfica e estilos)
- **Visual Studio** (IDE de desenvolvimento)

---

## 📁 Estrutura do Código

- `MainPage.xaml`: Define os estilos visuais, grade (Grid 3x3), botões e o layout geral.
- `MainPage.xaml.cs`: Contém os manipuladores de evento de clique, alternância de jogadas, validações de vitória/empate e rotina de limpeza do tabuleiro.
- `App.xaml.cs`: Configuração das dimensões nativas da janela para simular a proporção de um smartphone no Windows Machine.

---

## 📄 Licença

Este projeto é um trabalho acadêmico desenvolvido exclusivamente para fins de estudo no curso técnico da Etec.