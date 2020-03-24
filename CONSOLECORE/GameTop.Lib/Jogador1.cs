using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador1 : iJogador
    {
        public readonly string nome;

        public Jogador1(string nome)
        {
            this.nome = nome;
        }

        public string chuta()
        {
            return $"{nome} está chutando\n";
        }

        public string corre()
        {
            return $"{nome} está correndo\n";
        }

        public string passe()
        {
            return $"{nome} está passando\n";
        }
    }
}