using propriedades_metodos_e_construtores.models;

Pessoa pessoa1 = new Pessoa();

pessoa1.name = "Miguel";
pessoa1.lastName = "Henrique";

Pessoa pessoa2 = new Pessoa();

pessoa2.name = "James";
pessoa2.lastName = "Gordon";


Curso ingles = new Curso();

ingles.name = "English";
ingles.students = new List<Pessoa>();

ingles.addNewStudent(pessoa1);
ingles.addNewStudent(pessoa2);

ingles.listAllStudents();