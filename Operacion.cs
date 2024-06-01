using EspacioTipoOperacion;
namespace espacioOperacion
{
    public class Operacion{
        private double resultadoAnterior;
        private double nuevoValor;
        private TipoOperacion operacion;

        public double ResultadoAnterior { get => resultadoAnterior; set => resultadoAnterior = value; }
        public double NuevoValor { get => nuevoValor; set => nuevoValor = value; }
    }
}