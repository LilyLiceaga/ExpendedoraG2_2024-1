using System;


namespace ExpendedoraG2_2024_1
{
    internal class Cafe1 : Expendedora;
    {
        public Cafe1()
        {
            Saludar();
            Saludar();
            LimpiarDisplay();
            Console.WriteLine("Marca: {0}", Marca);
            LimpiarDisplay();

            string codigo = MostrarProducto();
            LimpiarDisplay();
            MostrarPrecio(codigo);
        }
    }
}
