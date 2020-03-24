using GameTop.Interface;

namespace GameTop
{
    public class JogoFoda
    {
        private readonly iJogador jogadorA;
        private readonly iJogador jogadorB;

        public JogoFoda(iJogador jogadorA, iJogador jogadorB)
        {
            this.jogadorA = jogadorA;
            this.jogadorB = jogadorB;
        }
        public void iniciarJogo()
        {
            System.Console.Write(jogadorA.corre());
            System.Console.Write(jogadorA.chuta());
            System.Console.Write(jogadorA.passe());

            System.Console.Write("\nPróximo Jogador\n");

            System.Console.Write(jogadorB.corre());
            System.Console.Write(jogadorB.chuta());
            System.Console.Write(jogadorB.passe());
            //System.Console.Write("");
        }
    }
}