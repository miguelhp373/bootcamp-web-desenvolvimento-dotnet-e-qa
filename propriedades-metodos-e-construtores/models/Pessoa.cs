using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace propriedades_metodos_e_construtores.models
{
    public class Pessoa
    {
        public Pessoa(){}

        public Pessoa(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        private string? _name;
        private int _age { get; set; }       


        public string? Name 
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

        public string? LastName { get; set; }

        public string? FullName => $"{Name} {LastName}".ToUpper();
         
        public int Age 
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

        

        public void ShowPerson()
        {
            Console.WriteLine($"Name: {FullName} Age {Age}");
        }

    }
}