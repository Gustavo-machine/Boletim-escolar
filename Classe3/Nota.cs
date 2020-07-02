

namespace Classe3
{
    class Nota
    {
        public string Nome;
        public double x, y, z;
        

        public double Media()
        {
             return x + y + z;
        }
        public bool Aprovado()
        {
            if(Media() >= 60.0)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
        public double Restante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - Media();
            }
        }
        
    }
}
