tp_no Remove(ref tp_no l)
{
    tp_no no = null;
    if (l != null)
    {
        no = l;
        l = l.prox;
        no.prox = null;
    }
    return no;
}
void Insere(ref tp_no l, int v)
{
    tp_no no = new tp_no();
    no.valor = v;
    if (l != null)
        no.prox = l;
    l = no;
}

tp_no lista = null;
tp_no elem;

class tp_no
{
    public string nome, idade, whats;
    public tp_no prox;

}
void Consulta(tp_no l, string np,ref tp_no ant, ref tp_no atu){
    ant = null;
    atu = l;
    while (atu!=null && atu.nome !np){
        ant = atu;
        atu = atu.prox;
    }
}

    Console.WriteLine("MENU PRINCIPAL ");
    Console.WriteLine("1 - Inclui");
    Console.WriteLine("2 - Alterar pelo nome");
    Console.WriteLine("3 - Excluir pelo nome");
    Console.WriteLine("4 - Exibir todos os registros");
    Console.Write("Opção desejada: ");
    string op = Console.ReadLine();

    //opção 1
if (op == "1" ){
    Console.WriteLine("Você escolheu Incluir");
    Console.WriteLine("Digite um número para Incluir");
    int n = int.Parse(Console.ReadLine());
    Insere(,n);
}
if (op == "2" ){
    Console.WriteLine("Você escolheu Alterar pelo nome");
    Console.WriteLine("Digite um número para Alterar");
    int n = int.Parse(Console.ReadLine());
    Insere(,n);
}

