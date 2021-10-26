using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly iJogador _JogadorA;
        private readonly iJogador _JogadorB;
        public JogoFODA(iJogador Jogador1, iJogador Jogador2)
        {
            _JogadorA = Jogador1;
            _JogadorB = Jogador2;
        }
        public void IniciadorJOGO()
        {
            System.Console.Write(_JogadorA.Corre());
            System.Console.Write(_JogadorA.Chuta());
            System.Console.Write(_JogadorA.Passe());

            System.Console.Write("\n PROXIMO JOGADOR \n");
        
            System.Console.Write(_JogadorB.Corre());
            System.Console.Write(_JogadorB.Chuta());
            System.Console.Write(_JogadorB.Passe());
        
        }
    }
}