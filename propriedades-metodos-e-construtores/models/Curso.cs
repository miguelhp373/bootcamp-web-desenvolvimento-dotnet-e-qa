using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace propriedades_metodos_e_construtores.models
{
    public class Curso
    {
        public string? Name { get; set; }
        public List<Pessoa> ?Students { get; set; }

        public void AddNewStudent(Pessoa pessoa)
        {
            Students!.Add(pessoa);
        }

        public int StudentsCounter()
        {
            return Students!.Count();
        }

        public bool RemoveStudent(Pessoa pessoa)
        {
            return Students!.Remove(pessoa);
        }

        public void ListAllStudents()
        {
            foreach(Pessoa student in Students)
            {
                Console.WriteLine(student.FullName);
            }
            
        }
    }

}