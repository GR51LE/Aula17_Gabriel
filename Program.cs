// See https://aka.ms/new-console-template for more information

// Pessoa p = new Pessoa();

// p.Nome = "Gabriel";
// p.Sobrenome = "Reale";
// p.CPF = 40028922;
// Console.WriteLine($"Olá {p.Nome} {p.Sobrenome} seu CPF é {p.CPF}");


Console.WriteLine("Digite seu nome: ");
string? nome = Console.ReadLine();

Console.WriteLine("Digite seu sobrenome: ");
string? sobrenome = Console.ReadLine();

Console.WriteLine("Digite a sua data de nascimento no formato dd/mm/yy");
DateTime.TryParse(Console.ReadLine(), out DateTime dataNascimento);

Console.WriteLine("Digite seu CPF sem ponto ou caracter: ");
int.TryParse(Console.ReadLine(), out int cpf);

Console.WriteLine("Digite seu peso: ");
decimal.TryParse(Console.ReadLine(), out decimal peso) ;

Console.WriteLine("Digite sua altura: ");
decimal.TryParse(Console.ReadLine(), out decimal altura);

Pessoa p = new Pessoa(nome, sobrenome, dataNascimento, cpf, peso, altura);

int idade = p.CalcularIdade();

decimal imc = Math.Round (p.CalcularIMC(), 2);

bool sair = false;

while(!sair)
{
    Console.WriteLine("Escolha umas das opcões abaixo!");
    Console.WriteLine("0 - Informações do usuário");
    Console.WriteLine("1 - Calcular IMC");
    Console.WriteLine("2 - Verifica a maioridade do usuário");
    Console.WriteLine("3 - Sair");
    string? opcao = Console.ReadLine();

    switch(opcao)
    {
        case "0":
        Console.WriteLine($"Nome Completo: {nome} {sobrenome}");
        Console.WriteLine($"DataNascimento: {dataNascimento}");
        Console.WriteLine($"CPF: {cpf}");
        Console.WriteLine($"Peso: {peso}");
        Console.WriteLine($"Altura: {altura}");
        Console.WriteLine($"Idade: {idade}");
        break;
        
        case "1":
        Console.WriteLine($"Seu IMC é: {imc}");
          if(imc < 17)
        {
            Console.WriteLine($"Olá {nome}, você foi classificado como Muito Abaixo do Peso, por ter {imc} de IMC!");
        }else if(imc >= 17 && imc < 19)
        {
            Console.WriteLine($"Olá {nome}, você foi classificado como Abaixo do Peso, por ter {imc} de IMC! ");
        }else if(imc >=19 && imc < 25)
        {
            Console.WriteLine($"Olá {nome}, você foi classificado como Peso Normal, por ter {imc} de IMC!");
        }else if(imc >= 25 && imc < 30){
            Console.WriteLine($"Olá {nome}, você foi classificado como Acima do Peso, por ter {imc} de IMC!");
        }else if(imc >= 30 && imc < 35)
        {
            Console.WriteLine($"Olá {nome}, você foi classificado como Obesidade grau I, por ter {imc} de IMC!");
        }else if(imc >=35 && imc <=40)
        {
            Console.WriteLine($"Olá {nome}, você foi classificado como Obesidade grau II, por ter {imc} de IMC!");
        }else if(imc > 40)
        {
            Console.WriteLine($"Olá {nome}, você foi classificado como Obesidade grau III, por ter {imc} de IMC!");
        }
        break;

        case "2":
        if(idade >= 18)
        {
           Console.WriteLine($"Olá {nome}, parabéns você já é Maior de idade por ter {idade} anos de idade");
        }else
        Console.WriteLine($"Olá {nome}, você é Menor de idade por ter apenas {idade} anos de idade");
        break;

        case "3":
        sair = true;
        break;
    }
}