namespace NJ.OOP.ConsoleApplication.Encapsulamento
{
    public class Aviao : VeiculoMotorizado
    {
        #region Construtor

        public Aviao(string modelo, string fabricante, string cor, int anoFabricacao) 
            : base(modelo, fabricante, cor, anoFabricacao)
        {
    
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