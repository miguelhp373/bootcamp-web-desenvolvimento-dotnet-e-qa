using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace propriedades_metodos_e_construtores.models
{
    public class Pessoa
    {
        private string? _name;
        public string? name 
        { 
            get
            {
                return _name!.ToUpper();
            }

            set 
            { 
                if(value == "")
                {
                    throw new ArgumentException("The Name don't can empty!");
                }
                _name = value;
            } 
        }
                
        public int age { get; set; }

        public void showPerson()
        {
            Console.WriteLine($"Name: {name}, Age {age}");
        }

    }
}