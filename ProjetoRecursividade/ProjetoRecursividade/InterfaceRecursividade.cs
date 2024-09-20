namespace ProjetoRecursividade{
    public interface IfcRecursividade
    {
        // Retorna o fatorial de n (versão recursiva)
        long getFatorial(long n);

        // Retorna o fatorial de n (versão iterativa)
        long getFatorial(long n, bool flag);

        // Retorna o Fibonacci de n (versão recursiva)
        long getFibonacci(long n);

        // Retorna o Fibonacci de n (versão iterativa)
        long getFibonacci(long n, bool flag);
    }
}
