using System;
using System.Collections.Specialized;
using System.Threading;


namespace ExpendedoraG2_2024_1
{
    internal abstract class Expendedora
    {
        #region Atributos
        private string marca;
        private ushort cantidadProductos;
        internal byte temperatura; //internal ?
        private float precio;
        #endregion

        #region Property

        public virtual byte Temperatura 
        { 
            get => temperatura; 
            set
            {
                if (0 < value && value < 25)
                    temperatura = value;
                else
                    temperatura = 20;
            }
        }

        public string Marca { get => marca; set => marca = value; }
        public float Precio
        {
            get => precio;
            set
            {
                if (value < 0 )
                {
                    precio = 10;
                }
                else
                {
                    precio = value;
                }
            }
        }
        #endregion

        #region Metodos
        public void Saludar()
        {
            Console.WriteLine("Bienvenido, Elige un producto");
        }
        public void LimpiarDisplay()
        {
            Thread.Sleep(2000); //milisegundos
            Console.Clear();
        }
        public virtual string MostrarProducto() //virtual?
        {
            string codigo = "";
            Console.WriteLine(" 3A: Doritos \n 3B: Churrumais ");
            Console.WriteLine("Ingresa el código del producto");
            codigo = Console.ReadLine(); //VARIABLE LOCAL, no tiene valor por default. Siempre se debe inicializar.

            return codigo;
        }
        public virtual void MostrarPrecio(string codigo)
        {
            switch (codigo)
            {
                case "3A":
                    Console.WriteLine("Precio: ${0}", Precio);
                    break;
                case "3B":
                    Console.WriteLine("Precio: ${0}", Precio-6);
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
            Marca = "AMS";
            Precio = 18;
            Saludar();
            LimpiarDisplay();

        }

        public Expendedora(bool Mantenimiento)
        {
            Temperatura = 20;
            if(Mantenimiento == true)
                Console.WriteLine("Entrando en modo manenimiento... ");
            Console.WriteLine("Cambiando temperatura");
            LimpiarDisplay();
            for (int i = 0; i < 20; i++)
            {
                Temperatura++;
            }
            Console.WriteLine("Mostrando Temperatura: " + Temperatura + " [°C]");
        }

        #endregion

    }
} 
