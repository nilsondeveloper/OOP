namespace NJ.OOP.ConsoleApplication.Herança
{
    public class Aviao : VeiculoMotorizado
    {
        #region Propriedades

        public int HorasDeVoo { get; set; }

        #endregion

        #region Construtor

        public Aviao(int horasDeVoo, string cor, int anoFabricacao, string modelo, string fabricante)
            : base(cor, anoFabricacao, modelo, fabricante)
        {
            HorasDeVoo = horasDeVoo;
        }

        #endregion


        #region Métodos

        public void Decolar()
        {
            // Procedimento para decolar
            
        }

        public void Pousar()
        {
            // Procedimento para pousar
        }

        #endregion
    }
}
