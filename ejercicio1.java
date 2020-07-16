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

package Ejercicio1;
import java.util.*;
public class colegio {
    Map alumno = new HashMap();

    public void addAlumno(String nac){
        if (alumno.containsKey(nac)){
            Integer i = alumno.get(nac);
            alumno.remove(nac);
            alumno.put(nac, i++);
        }else{
            alumno.put(nac,1);
        }
    }

    public void showAll(){
        Iterator it = alumno.keySet().iterator();
        while (it.hasNext()){
            Integer key = (Integer) it.next();
            System.out.println(«Numero de alumno: «+key+» Nacionalidad alumno: «+alumno.get(key));
        }
    }

    public void showNacionalidad(){
        for (String k :alumno.keySet()){
            System.out.println(k+»->»+alumno.get(k));
        }
    }

    public int cuantos(){
        return alumno.size();
    }

    public void borrar(String nac){
        alumno.remove(nac);
    }
}