/*
Ejercicio 1. Java HashMaps.
Crea una clase colegio que almacene la nacionalidad de los alumnos de un colegio. La clase tendrá los siguientes métodos.

addAlumno(String nacionalidad)
añade la nacionalidad de un nuevo alumno

showAll()
Muestra las distintas nacionalidades y el número de alumnos que existen por nacionalidad.

pista:
for(String key: nacionalidades.keySet())
System.out.println(key + » – » + nacionalidades.get(key));

showNacionalidad(String nacionalidad)
Muestra la nacionalidad y el número de alumnos de esa nacionalidad

cuantos()
Muestra cuántas nacionalidades diferentes existen en el colegio.

borra()
Elimina los datos insertados.

Crea también una clase para testear la clase anterior.
Crea también una clase exceptionVacio del tipo Exception que será lanzada en el caso que se llame al método addAlumno(String nacionalidad) con un parámetro nacionalidad vacío.
Nota: Las nacionalidades se almacenan en mayúsculas.
*/
using System;
using System.Collections.Generic;

namespace ejercicio_3
{
    class Program
    {
        public class colegio {
    
    Map alumno = new HashMap();
    
    public void addAlumno(String nac) {
        if (this.alumno.containsKey(nac)) {
            int i = this.alumno.get(nac);
            this.alumno.remove(nac);
            this.alumno.put(nac, i++);
        }
        else {
            this.alumno.put(nac, 1);
        }
        
    }
    
    public void showAll() {
        Iterator it = this.alumno.keySet().iterator();
        while (it.hasNext()) {
            int key = ((int)(it.next()));
            Console.WriteLine("  Numero, de, {0}, :, {1},",this.alumno,showNacionalidad);
        }
        
    }
    
    public void showNacionalidad() {
        foreach (String k in this.alumno.keySet()) {
            Console.WriteLine(k, this.alumno.get(k));
        }
        
    }
    
    public int cuantos() {
        return this.alumno.size();
    }
    
    public void borrar(String nac) {
        this.alumno.remove(nac);
    }
}
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
