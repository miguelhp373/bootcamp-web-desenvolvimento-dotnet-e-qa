using propriedades_metodos_e_construtores.models;

Pessoa pessoa1 = new Pessoa(name: "Miguel", lastName: "Henrique");
Pessoa pessoa2 = new Pessoa(name : "James", lastName: "Gordon");

Curso ingles = new Curso();

ingles.Name = "English";
ingles.Students = new List<Pessoa>();

ingles.AddNewStudent(pessoa1);
ingles.AddNewStudent(pessoa2);

ingles.ListAllStudents();