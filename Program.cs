void Insere(ref tp_no l, string n, string i, string w)
{
    tp_no no = new tp_no();
    no.nome = n;
    no.idade = i;
    no.whats = w;
    if (l != null)
        no.prox = l;
    l = no;
}

void Consulta(tp_no l, string np,ref tp_no ant, ref tp_no atu)
{
    ant = null;
    atu = l;
    while (atu != null && atu.nome != np)
    {
        ant = atu;
        atu = atu.prox;
    }
}

void Altera(tp_no l)
{
    tp_no ant = null, atu = null;
    string np;
    Console.WriteLine("Nome procurado");
    np = Console.ReadLine();
    Consulta(l,np,ref ant, ref atu);
    if(atu != null){
        Console.WriteLine("Dados atuais");
        Console.WriteLine("Nome" + atu.nome);
        Console.WriteLine("Idade" + atu.idade);
        Console.WriteLine("Whats" + atu.whats);
        Console.WriteLine("Digite os novos valores");
        Console.WriteLine("Nome"); atu.nome = Console.ReadLine();
        Console.WriteLine("Idade"); atu.idade = Console.ReadLine();
        Console.WriteLine("Whats"); atu.whats = Console.ReadLine();
    }
    else{
        Console.WriteLine("Não encontrado");
    }
}

void Excluir(ref tp_no l){
    tp_no ant = null, atu = null;
    string np;
    Console.WriteLine("Nome Procurado"); np = Console.ReadLine();

    Consulta (l, np, ref ant, ref atu);
    if (atu != null){
        if (ant == null){
            l = atu.prox;
            atu.prox = null;
        }
        else if(atu.prox == null){
            ant.prox = null;
        }
        else{
            ant.prox = atu.prox;
            atu.prox = null;
        }
    }
    else{
        Console.WriteLine("Não encontrado");
    }
}

void Exibir(tp_no l){
    Console.WriteLine("Relatório");
    tp_no aux = l;
    int i = 1;
    while(aux != null){
        Console.WriteLine("Registro" + i);
        Console.WriteLine("Nome" + aux.nome);
        Console.WriteLine("Registro" + aux.idade);
        Console.WriteLine("Registro" + aux.whats);

    }
}


// Principal (main)
tp_no lista = null;
tp_no elem;

    Console.WriteLine("MENU PRINCIPAL ");
    Console.WriteLine("1 - Inclui");
    Console.WriteLine("2 - Alterar pelo nome");
    Console.WriteLine("3 - Excluir pelo nome");
    Console.WriteLine("4 - Exibir todos os registros");
    Console.Write("Opção desejada: ");
    string op = Console.ReadLine();

    //opção 1
if (op == "1"){
    Console.WriteLine("Você escolheu Incluir");
    Console.WriteLine("Digite um nome para Incluir");
    string n = Console.ReadLine();
    Console.WriteLine("Digite um idade para Incluir");
    string i = Console.ReadLine();
    Console.WriteLine("Digite um whats para Incluir");
    string w = Console.ReadLine();
    Insere(ref lista, n, i , w)
}
if (op == "2"){
    Console.WriteLine("Você escolheu Alterar pelo nome");
    Console.WriteLine("Digite um nome para Alterar");
    string np = Console.ReadLine();
    Altera(lista);
}
if (op == "3"){
    Console.WriteLine("Você escolheu Excluir pelo nome");
    Console.WriteLine("Digite um nome para Excluir");
    string n = Console.ReadLine();
    Excluir(ref lista);
}
if (op == "4"){
    Console.WriteLine("Você escolheu Excluir pelo nome");
    Console.WriteLine("Digite um nome para Excluir");
    string n = Console.ReadLine();
    Excluir(ref lista);
}



class tp_no
{
    public string nome, idade, whats;
    public tp_no prox;

}
