namespace trilha_dotnet_desafiofinal;

public class Calculadora
{
    private List<string> listaHistorico;
    private string data;

    public Calculadora(string data)
    {
        listaHistorico = new List<string>();
        this.data = data;
    }

    public int teste(int val1, int val2)
    {
        int res = 0; 
        listaHistorico.Insert(0, "Valor: " + res );
        return res;
    }
    
    public int sum(int val1, int val2)
    {
        int res = val1 + val2; 
        listaHistorico.Insert(0, "Valor: " + res );
        return res;
    }

    public  int sub(int val1, int val2)
    {
        int res = val1 - val2;
        listaHistorico.Insert(0, "Valor: " + res );
        return res;
    }
    
    public int div(int val1, int val2)
    {
        int res = val1 / val2; 
        listaHistorico.Insert(0, "Valor: " + res );
        return res;
    }
    
    public int mult(int val1, int val2)
    {
        int res = val1 * val2; 
        listaHistorico.Insert(0, "Valor: " + res );
        return res;
    }

    public List<string> historico(string data)
    {
        listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
        return listaHistorico;
    }

}