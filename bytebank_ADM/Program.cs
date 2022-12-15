using bytebank_ADM.Funcionarios;

Funcionario Renan =new Funcionario();
Renan.Nome = "Renan Cunha";
Renan.Cpf = "123456789";
Renan.Salario = 2000;

Console.WriteLine(Renan.Nome+"\n"+Renan.Cpf+"\n"+Renan.Salario+"\n" );
Console.WriteLine(Renan.GetBonificacao);
