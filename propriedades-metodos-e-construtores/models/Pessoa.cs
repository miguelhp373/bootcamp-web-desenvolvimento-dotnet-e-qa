using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace propriedades_metodos_e_construtores.models
{
    public class Pessoa
    {
        private string? _name;
        private int _age { get; set; }       


        public string? name 
        { 
            get => _name!.ToUpper();

            set 
            { 
                if(value == "")
                {
                    throw new ArgumentException("Name cannot be empty!");
                }
                _name = value;
            } 
        }

        public string? lastName { get; set; }

        public string? fullName => $"{name} {lastName}".ToUpper();
         
        public int age 
        { 
            get => _age; 
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Age cannot be less than 0!");
                }
                _age = value;
            } 
        }

        

        public void showPerson()
        {
            Console.WriteLine($"Name: {fullName} Age {age}");
        }

    }
}