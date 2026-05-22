using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private List<Alumno> _listaAlumnos = new List<Alumno>();

    //agregar alumno
    public void AgregarAlumno(Alumno alumno)
    {
        _listaAlumnos.Add(alumno);
    }

    //retornar lista 
    public List<Alumno> ObtenerLista()
    {
        return _listaAlumnos;
    }
    //buscar alumno por nombre

    public Alumno? BuscarAlumno(string nombre)
    {
        return _listaAlumnos.FirstOrDefault(alumno => alumno.Nombre == nombre);
    }

    //eliminar alumno
    public void EliminarAlumno(Alumno alumno)
    {
        _listaAlumnos.Remove(alumno);
    }

    //eliminar alumno por posicion
    public void EliminarAlumnoPorPosicion(int posicion)
    {
        if (posicion >= 0 && posicion < _listaAlumnos.Count)
        {
            _listaAlumnos.RemoveAt(posicion);
        }
    }





}
