using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();

        Alumno a1 = new Alumno(1, "Juan", 8.5);
        Alumno a2 = new Alumno(2, "Maria", 9.0);
        Alumno a3 = new Alumno(3, "Pedro", 7.2);
        casoList.AgregarAlumno(a1);
        casoList.AgregarAlumno(a2);
        casoList.AgregarAlumno(a3);

        //Listar alumnos
        Console.WriteLine("\nLista Original");
        foreach (var alumno in casoList.ObtenerLista())
            Console.WriteLine(alumno);

        //Buscar por nombre un alumno que exista
        Console.WriteLine("\nBuscando a Maria");
        var alumnoEncontrado = casoList.BuscarAlumno("Maria");
        Console.WriteLine(alumnoEncontrado != null ? alumnoEncontrado.ToString() : "No existe");

        //Buscar por nombre un alumno que no exista
        Console.WriteLine("\nBuscando a Carlos");
        var alumnoNoEncontrado = casoList.BuscarAlumno("Carlos");
        Console.WriteLine(alumnoNoEncontrado != null ? alumnoNoEncontrado.ToString() : "No existe");

        //Eliminar un alumno
        Console.WriteLine("\nEliminando a Juan");
        casoList.EliminarAlumno(a1);
        foreach (var alumno in casoList.ObtenerLista())
            Console.WriteLine(alumno);

        //Eliminar el primer elemento
        Console.WriteLine("\nEliminando el primer elemento");
        casoList.EliminarAlumnoPorPosicion(0);
        foreach (var alumno in casoList.ObtenerLista())
            Console.WriteLine(alumno);
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary casoDict = new CasoDictionary();

        Alumno a1 = new Alumno(10, "Ana", 8.0);
        Alumno a2 = new Alumno(20, "Luis", 6.5);
        Alumno a3 = new Alumno(30, "Sofia", 9.5);
        casoDict.AgregarAlumno(a1.Id, a1);
        casoDict.AgregarAlumno(a2.Id, a2);
        casoDict.AgregarAlumno(a3.Id, a3);

        //Listar alumnos
        Console.WriteLine("\nDiccionario Original");
        foreach (var kvp in casoDict.obtenerDiccionario())
        {
            Console.WriteLine($"Legajo: {kvp.Key} | Datos: {kvp.Value}");
        }

        //Buscar un alumno por clave
        Console.WriteLine("\nBuscando Legajo 20");
        var encontrado = casoDict.buscarAlumno(20);
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

        //Buscar un alumno por clave que no exista
        Console.WriteLine("\nBuscando Legajo 99");
        var noEncontrado = casoDict.buscarAlumno(99);
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");

        //Eliminar un alumno por clave
        Console.WriteLine("\nEliminando Legajo 10");
        casoDict.eliminarAlumno(10);
        foreach (var kvp in casoDict.obtenerDiccionario())
            Console.WriteLine($"Legajo: {kvp.Key} | Datos: {kvp.Value}");
    }


    

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        List<Libro> listaLibros = Libro.CrearLista();

        CasoLinq casoLinq = new CasoLinq(listaLibros);

        // Llamadas a cada método
        Console.WriteLine($"1. Primer libro: {casoLinq.GetPrimero()?.Titulo ?? "N/A"}");
        Console.WriteLine($"2. Último libro: {casoLinq.GetUltimo()?.Titulo ?? "N/A"}");
        Console.WriteLine($"3. Suma de precios: {casoLinq.GetTotalPrecios():C}");
        Console.WriteLine($"4. Promedio de precios: {casoLinq.GetPromedioPrecios():C}");

        Console.WriteLine("\nLibros con Id > 15:");
        foreach (var libro in casoLinq.GetListById())
            Console.WriteLine($"   - {libro.Titulo} (Id: {libro.Id})");

        Console.WriteLine("\nLibros formato moneda:");
        foreach (var texto in casoLinq.GetLibros())
            Console.WriteLine($"   - {texto}");

        Console.WriteLine($"\nLibro con mayor precio: {casoLinq.GetMayorPrecio()?.Titulo} ({casoLinq.GetMayorPrecio()?.Precio:C})");
        Console.WriteLine($"8. Libro con menor precio: {casoLinq.GetMenorPrecio()?.Titulo} ({casoLinq.GetMenorPrecio()?.Precio:C})");

        Console.WriteLine("\nLibros con precio > promedio:");
        foreach (var libro in casoLinq.GetMayorPromedio())
            Console.WriteLine($"   - {libro.Titulo}");

        Console.WriteLine("\nLibros ordenados descendente:");
        foreach (var libro in casoLinq.GetLibrosOrdenados())
            Console.WriteLine($"   - {libro.Titulo}");
    }

}
