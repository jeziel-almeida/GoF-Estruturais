namespace PadroesGofCSharp.Models;

public class CartaoCredito 
{
    private int numero;
    private string nome;
    private int validade;
    private int cvv;
    private decimal limite = 5000;

    public CartaoCredito(int numero, string nome, int validade, int cvv)
    {
        this.numero = numero;
        this.nome = nome;
        this.validade = validade;
        this.cvv = cvv;
    }

    public Boolean abaixarLimite(decimal valor)
    {
        if(valor < this.limite)
        {
            this.limite -= valor;
            return true;
        }
        return false;
    }

    public int getNumero() 
    {
        return this.numero;
    }
    public string getNome() 
    {
        return this.nome;
    }
    public int getValidade()
    {
        return this.validade;
    }
    public int getCvv()
    {
        return this.cvv;
    }
    public decimal getLimite()
    {
        return this.limite;
    }
}