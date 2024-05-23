using propriedades_metodos_e_construtores.models;

Pessoa pessoa = new Pessoa();

pessoa.name = "Miguel";
pessoa.lastName = "Pereira";
pessoa.age = 10;

//pessoa.showPerson();

Curso curso = new Curso();

curso.addNewStudent(pessoa);

pessoa.name = "Jubileu";
pessoa.lastName = "James";
pessoa.age = 20;

curso.addNewStudent(pessoa);

curso.studentsCounter();