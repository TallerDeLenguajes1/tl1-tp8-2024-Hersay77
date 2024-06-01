namespace EspacioCalculadora
{

    public class MiCalculadora
    {
        private double dato = 0;

        public double Resultado{
            get => dato;
        }

        public void Sumar(double x){
            dato+=x;
        }
        public void Restar(double x){
            dato-=x;
        }
        public void Multiplicar(double x){
            dato*=x;
        }
        public void Dividir(double x){
            if (x != 0)
            {
                dato/=x;
            }
        }
        public void Limpiar(){
            dato = 0;
        }
    }
}