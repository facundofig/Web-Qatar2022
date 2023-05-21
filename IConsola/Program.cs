using System;
using Dominio;

namespace IConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Sistema sist = Sistema.Instancia;
                int opc = -1;
                while (opc != 0)
                {
                    try
                    {
                        Console.WriteLine("############### QATAR 2022 ###############");
                        Console.WriteLine("");
                        Console.WriteLine("1- Alta de periodista");
                        Console.WriteLine("2- Establecer valor de referencia para categoría financiera");
                        Console.WriteLine("3- Listar partidos de un jugador");
                        Console.WriteLine("4- Listar jugadores expulsados");
                        Console.WriteLine("5- Partido con mas goles de una selección");
                        Console.WriteLine("6- Listar jugadores con al menos 1 gol en un partido");
                        Console.WriteLine("0- Salir");
                        opc = int.Parse(Console.ReadLine());

                        switch (opc)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Ingrese el nombre:");
                                string nombre = Console.ReadLine().ToLower();
                                Console.WriteLine("Ingrese el apellido:");
                                string apellido = Console.ReadLine().ToLower();
                                Console.WriteLine("Ingrese el email:");
                                string email = Console.ReadLine().ToLower();
                                Console.WriteLine("Ingrese la contraseña:");
                                string pass = Console.ReadLine().ToLower();
                                sist.AltaPeriodista(new Periodista(nombre, apellido, email, pass));
                                Console.WriteLine("Periodista ingresado con éxito!");
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Ingrese el monto de referencia:");
                                double monto = double.Parse(Console.ReadLine());
                                sist.CambiarMontoCategoria(monto);
                                Console.WriteLine("Monto establecido con éxito!");
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("Ingrese el id del jugador:");
                                int id = int.Parse(Console.ReadLine());
                                foreach (Partido p in sist.PartidosDeUnJugador(id))
                                {
                                    Console.WriteLine($"{p.FechaHora} - {p.Seleccion1.Pais.Nombre} vs {p.Seleccion2.Pais.Nombre} - {p.GetIncidencias().Count} incidencias");
                                }
                                
                                
                                Console.WriteLine("");
                                break;
                            case 4:
                                Console.Clear();                              
                                Console.WriteLine("Jugadores expulsados");
                                Console.WriteLine("");

                                foreach (Jugador j in sist.JugadoresExpulsados())
                                {
                                    Console.WriteLine($"{j.NombreCompleto}");
                                }
                                break;
                            case 5:
                                Console.Clear();
                                Console.WriteLine("Ingrese el nombre de la selección:");
                                string nombreSeleccion = Console.ReadLine().ToLower();

                                foreach (Partido p in sist.PartidoMasGolesDeUnaSeleccion(nombreSeleccion))
                                {
                                    Console.WriteLine($"{p.Seleccion1.Pais.Nombre} vs {p.Seleccion2.Pais.Nombre} - {p.FechaHora} - {p.ResultadoFinal}");
                                }
                                
                                Console.WriteLine("");
                                break;
                            case 6:
                                Console.Clear();
                                Console.WriteLine("Ingrese el id del partido");
                                int id_partido = int.Parse(Console.ReadLine());

                                foreach (Jugador j in sist.JugadoresConAlMenosUnGol(id_partido))
                                {
                                    Console.WriteLine($"{j.NombreCompleto} - {j.ValorMercado} - {j.CategoriaFinanciera()}");
                                }

                                Console.WriteLine("");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadKey();
        }
    }
}
