using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoKenPo
{
    internal class Game
    {
        public Image ImgPC { get; private set; }
        public Image ImgPlayer { get; private set; }

        public enum Resultado
        {
            Ganhar, Perder, Empatar
        }

        public static Image[] images =
        {
            Image.FromFile("imagens/Pedra.png"),
            Image.FromFile("imagens/Papel.png"),
            Image.FromFile("imagens/Tesoura.png")
        };

        public Resultado Jogar (int escolhaPlayer)
        {
            Random random = new Random();
            int escolhaPC = random.Next(0, 3);
            ImgPC = images[escolhaPC];
            ImgPlayer = images[escolhaPlayer];
            if (escolhaPlayer == escolhaPC)
                return Resultado.Empatar;
            else if ((escolhaPlayer == 0 && escolhaPC == 2) ||
                     (escolhaPlayer == 1 && escolhaPC == 0) ||
                     (escolhaPlayer == 2 && escolhaPC == 1))
                return Resultado.Ganhar;
            else
                return Resultado.Perder;
        }

    }
}
