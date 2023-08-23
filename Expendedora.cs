using System;
using System.Collections.Specialized;
using System.Threading;


namespace ExpendedoraG2_2024_1
{
    internal class Expendedora
    {
        #region Atributos
        private string marca;
        private ushort cantidadProductos;
        private float precio;
        #endregion

        #region Metodos
        private void Saludar()
        {
            Console.WriteLine("Bienvenido, Elige un producto");
        }
        private void LimpiarDisplay()
        {
            Thread.Sleep(2000); //milisegundos
            Console.Clear();
        }
        public string MostrarProducto()
        {
            Console.WriteLine(" 3A: Doritos \n 3B: Churrumais ");
            Console.WriteLine("Ingresa el código del producto");
            string codigo = Console.ReadLine(); //VARIABLE LOCAL, no tiene valor por default. Siempre se debe inicializar.

            return codigo;
        }
        public void MostrarPrecio(string codigo)
        {
            switch (codigo)
            {
                case "3A":
                    Console.WriteLine("Precio: ${0}", precio);
                    break;
                case "3B":
                    Console.WriteLine("Precio: ${0}", precio-6);
                    break;
                default:
                    Console.WriteLine("No ingresaste producto válido");
                    break;
            }
        }

        #endregion
        
        #region Constructor
        public Expendedora()
        {
            marca = "AMS";
            precio = 18;
            Saludar();
            LimpiarDisplay();
            Console.WriteLine("Marca: {0}", marca);
            LimpiarDisplay();

            string codigo = MostrarProducto();
            LimpiarDisplay();
            MostrarPrecio(codigo);
        }

        public Expendedora(bool Mantenimiento)
        {
            if(Mantenimiento == true)
                Console.WriteLine("Entrando en modo manenimiento... ");
        }

        #endregion

    }
}
