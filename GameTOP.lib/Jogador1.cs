using GameTOP.Interface;

namespace GameTOP.lib
{
        public class Jogador1 : iJogador
    {
        public readonly string _Nome;

        public Jogador1(string nome = "Ronaldo")
        {
            _Nome = nome;
        }
         
        //Chute
        public string Chuta()
        {
            return $"{_Nome} está Chutando \n";
        }
        //Corre
        public string Corre()
        {
            return $"{_Nome} está correndo \n";
        }
        //Passe
        public string Passe()
        {
            return $"{_Nome} está passando \n";
        }
    }

}