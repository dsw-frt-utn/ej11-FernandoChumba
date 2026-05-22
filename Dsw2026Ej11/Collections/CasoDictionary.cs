using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave


public class CasoDictionary
{
    //clave
    private Dictionary<int, Alumno> _diccionarioAlumnos = new Dictionary<int, Alumno>();

    //agregar alumno
    public void AgregarAlumno(int legajo , Alumno alumno)
    {
        _diccionarioAlumnos[legajo] = alumno;
    }

    //buscar alumno
    public Alumno buscarAlumno(int leggajo)
    {
        if (_diccionarioAlumnos.ContainsKey(leggajo))
        {
            return _diccionarioAlumnos[leggajo];

        }
        return null;

    }

    //obtener diccionario
    public Dictionary<int, Alumno> obtenerDiccionario()
    {
        return _diccionarioAlumnos;
    }

    //eliminar alumno
    public void eliminarAlumno(int legajo)
    {
        if (_diccionarioAlumnos.ContainsKey(legajo))
        {
            _diccionarioAlumnos.Remove(legajo);
        }
    }

}
