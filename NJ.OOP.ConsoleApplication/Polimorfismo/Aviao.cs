namespace NJ.OOP.ConsoleApplication.Polimorfismo
{
    public class Aviao : Veiculo
    {
        #region Propriedades

        public int HorasDeVoo { get; set; }

        #endregion

        #region Construtor

        public Aviao(int horasDeVoo, string modelo, string fabricante, string cor, int anoFabricacao) 
            : base(modelo, fabricante, cor, anoFabricacao)
        {
            HorasDeVoo = horasDeVoo;
        }

        #endregion

        #region Métodos

        public override void Ligar()
        {
            // Procedimento para ligar o avião
        }

        public override void Desligar()
        {
            // Procedimento para desligar o avião
        }

        public void Decolar()
        {
            // Procedimento para decolar o avião
        }

        public void Pousar()
        {
            // Procedimento para pousar o avião
        }

        #endregion
    }
}