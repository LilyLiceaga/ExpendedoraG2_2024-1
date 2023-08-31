using System;


namespace ExpendedoraG2_2024_1
{
    internal class Cafe1 : Expendedora
    {
        #region Propiedades
        public override byte Temperatura
        {
            get => base.Temperatura;
            set
            {
                if (50 < value && value < 70)
                {
                    temperatura = value;
                }
                else
                {
                    temperatura = 60;
                }

            }
        }

        #endregion

        public Cafe1()
        {
            Saludar();
            Temperatura = 60; 
            Console.WriteLine("Temperatura: {0} [°C]", Temperatura);
            LimpiarDisplay();

            string codigo = MostrarProducto();
            LimpiarDisplay();
            Precio = 10;
            MostrarPrecio(codigo);
        }
        public Cafe1(bool Mantenimiento)
        {
            if (Mantenimiento)
                Console.WriteLine("Entrando a modo mantenimiento");
            else
                Saludar();
        }
        public Cafe1(int CantidadProductos)
        {

            Console.WriteLine("La expendedora contiene {0}", CantidadProductos);
        }

        #region Métodos
        public override string MostrarProducto()
        {
            Console.WriteLine("4C: Americano \n4D: Expresso");
            string codigo = Console.ReadLine();

            return codigo;
        }
        public override void MostrarPrecio(string codigo)
        {
            switch (codigo)
            {
                case "4C":
                    Console.WriteLine("Precio ${0}", Precio + 3);
                    break;
                case "4D":
                    Console.WriteLine("Precio ${0}", Precio + 6);
                    break;
                default:
                    Console.WriteLine("Elige un producto válido");
                    break;
            }

        }

        #endregion

    }

}
