using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace propriedades_metodos_e_construtores.models
{
    public class Curso
    {
        public string? name { get; set; }
        public List<Pessoa> ?students { get; set; }

        public void addNewStudent(Pessoa pessoa)
        {
            students!.Add(pessoa);
        }

        public int studentsCounter()
        {
            return students!.Count();
        }

        public bool removeStudent(Pessoa pessoa)
        {
            return students!.Remove(pessoa);
        }

        public void listAllStudents()
        {
            foreach(Pessoa student in students)
            {
                Console.WriteLine(student.fullName);
            }
            
        }
    }

}