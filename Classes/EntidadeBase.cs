namespace APP_de_cadastro_de_series
{
    public abstract class EntidadeBase // classe abstrata pode implementar ou não um método, sendo obrigatória a existência de pelo menos um método abstrato, sem corpo.
    {
        public int Id {get; protected set;}
    }
}