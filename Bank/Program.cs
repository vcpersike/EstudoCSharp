

using Bank;

internal class Programa
{
    private static void Main(string[] args)
    {
        ContaCorrente contaDoVictor = new ContaCorrente();
        contaDoVictor.titular = "Victor";
        contaDoVictor.numero_agencia = 15;
        contaDoVictor.conta = "1010-x";
        contaDoVictor.saldo = 100000;
    }
}