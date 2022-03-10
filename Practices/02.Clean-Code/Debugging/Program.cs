using System;
using System.Diagnostics;



namespace Debugging
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            string sProdName = "Widget";
            int iUnitQty = 100;
            double dUnitCost = 1.03;

                Debug.Indent();
                Debug.WriteLine("Debug: Iniciando depuracion de producto");

                Debug.WriteLine("El Nombre del producto es: " + sProdName);
                Debug.WriteLine("El numero de unidades es: " + iUnitQty.ToString());
                Debug.WriteLine("El valor por unidad es: " + dUnitCost.ToString());

                System.Xml.XmlDocument oxml = new System.Xml.XmlDocument();
                Debug.WriteLine(oxml);
        }
    }

}