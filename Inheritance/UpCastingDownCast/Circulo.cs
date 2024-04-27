using System;

namespace UpCastingDownCast
{
    public class Circulo : Forma
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhar Circulo");
        }

        public void PintarCirculo()
        {
            Console.WriteLine("Pintando Circulo");
        }
    }
}
