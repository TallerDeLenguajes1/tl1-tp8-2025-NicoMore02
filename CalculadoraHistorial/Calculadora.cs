namespace EspacioCalculadora
{

    public class Calculadora
    {
        public enum TipoOperacion
        {
            Suma,
            Resta,
            Multiplicacion,
            Division,
            Limpiar
        }
        private double dato;
        private List<Operacion> historial = new List<Operacion>();

        public double Dato
        {
            get => dato;
        }
        public List<Operacion> Historial { get => historial; set => historial = value; }

        public void suma(double valor)
        {
            historial.Add(new Operacion(dato, valor, TipoOperacion.Suma));
            dato += valor;
        }

        public void resta(double valor)
        {
            historial.Add(new Operacion(dato, valor, TipoOperacion.Resta));
            dato -= valor;
        }

        public void multiplicacion(double valor)
        {
            historial.Add(new Operacion(dato, valor, TipoOperacion.Multiplicacion));
            dato *= valor;
        }

        public void division(double valor)
        {
            if (valor != 0)
            {
                historial.Add(new Operacion(dato, valor, TipoOperacion.Division));
                dato /= valor;
            }
            else
            {
                Console.WriteLine("No se puede dividir en 0");
            }
        }

        public void limpiar()
        {
            historial.Add(new Operacion(dato, 0, TipoOperacion.Limpiar));
            dato = 0;
        }
    }

    public class Operacion
    {
        private double resultadoAnterior;
        private double nuevoValor;
        private Calculadora.TipoOperacion operacion;
        public double Resultado { get; }
        public Double NuevoValor { get => nuevoValor; }
        public Double ResultadoAnterior { get => resultadoAnterior; }
        public Calculadora.TipoOperacion Ope { get => operacion; }

        public Operacion(double resultadoAnterior, double nuevoValor, Calculadora.TipoOperacion operacion)
        {
            this.resultadoAnterior = resultadoAnterior;
            this.nuevoValor = nuevoValor;
            this.operacion = operacion;

            switch (operacion)
            {
                case Calculadora.TipoOperacion.Suma:
                    Resultado = resultadoAnterior + nuevoValor;
                    break;
                case Calculadora.TipoOperacion.Resta:
                    Resultado = resultadoAnterior - nuevoValor;
                    break;
                case Calculadora.TipoOperacion.Multiplicacion:
                    Resultado = resultadoAnterior * nuevoValor;
                    break;
                case Calculadora.TipoOperacion.Division:
                    if (nuevoValor != 0)
                    {
                    Resultado = resultadoAnterior / nuevoValor;
                    }
                    break;
                case Calculadora.TipoOperacion.Limpiar:
                    Resultado = 0;
                    break;
            }
        }
    }
}
