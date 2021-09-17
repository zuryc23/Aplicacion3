using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aplicacion3
{
    class Program
    {
        static void Main(string[] args)
        {
            char op='s';
            string archivo ="";
            int OP;
            string nombre;

            while(op=='s')
            {
                Console.WriteLine("n.1 Crear un archivo\n.2 Escribir archivo\n.3 Ver archivo\n.4 Borrar contacto\n.5 Salir");
                OP=int.Parse(Console.ReadLine());
               Console.Clear();

                if (OP==1)
                {
                    StreamWriter ar;
                    Console.WriteLine("Nombre a poner: ");
                    archivo=Console.ReadLine();
                    ar=File.CreateText(archivo+".txt");
                    nombre=archivo;
                    ar.Close();
                }

                if(OP==2)
                {
                    EscribirArchivo(archivo);
                }

                if(OP==3)
                {
                    MostrarContenido(archivo);
                }

                if(OP==4)
                {
                    Borrarcontacto(archivo);
                }

                Console.ReadKey();

                if(OP==5)
                {
                    Console.WriteLine("Salir");
                }

                Console.Clear();
                Console.WriteLine("¿Desea continuar? ['s/n']");
                op=char.Parse(Console.ReadLine());
            }
        }

        static void EscribirArchivo(string nombre)
        {
            StreamWriter ar;
            string agenda;
            Console.WriteLine("Ingrese nombre: ");
            agenda=Console.ReadLine()+"*";
            Console.WriteLine("Ingrese Apellido: ");
            agenda=agenda+Console.ReadLine()+"*";

            Console.WriteLine("Telefono: ");
            agenda=agenda+Console.ReadLine()+"*";
            Console.WriteLine("Direccion: ");
            agenda=agenda+Console.ReadLine()+"*";

            ar=File.AppendText(nombre);
            ar.WriteLine(agenda);
            agenda="";
            Console.WriteLine("Contacto a buscar: ");
            string busqueda=Console.ReadLine();
            ar.Close();

            StreamReader l;
            l=File.OpenText(nombre);

            string linea;
            linea=l.ReadLine();

            while(linea!=null)
            {
                string[] vec = linea.Split('/');

                if(vec[0]== busqueda)
                {
                    Console.Write("Contacto encontrado: "+ vec[0]+""+ vec[1]+""+ vec[2]+"*"+ vec[3]);
                }

                linea=l.ReadLine();

            }

            l.Close();
        }

        static void MostrarArchivo(string ruta)
        {
            StreamReader ar;
            ar=File.OpenText(ruta);
            Console.WriteLine(ar.ReadToEnd());
            ar.Close();
        }

        static void BorrarContacto(string nombre)
        {
            StreamWriter are;
            string agenda="";
            string temp="app3.txt";

            string borrar 
            Console.WriteLine("Contacto a borrar: ");
            borrar=Console.ReadLine();

            StreamReader l;
            l=File.OpenText(nombre);
            string linea;
            linea=Console.ReadLine();

            StreamReader tar;
            tar=File.CreateText(app3);

            while(linea!=null)
            {
                string[] vec = linea.Split('/');

                if (vec[0]!=borrar)
                {
                    Console.WriteLine("Contactos que no se eliminaron: "+vec[0]+""+vec[1]+""+vec[2]+"*"+vec[3]);
                    tar.ReadLine(linea);
                }
                tar.Close();
                l.Close();
                StreamReader an;
                an=File.OpenText(app3);
                StreamWriter art;
                art=File.CreateText(nombre);
                string k=an.ReadToEnd();
                art.WriteLine(k);
                an.Close();
                art.Close();
            }
        }

    }
}
