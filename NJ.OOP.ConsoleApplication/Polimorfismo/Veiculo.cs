using System;

namespace NJ.OOP.ConsoleApplication.Polimorfismo
{
    public abstract class Veiculo
    {
        #region Propriedades 

        private readonly string _modelo;
        private readonly string _fabricante;
        private readonly string _cor;
        private readonly int _anoFabricacao;

        #endregion

        #region Construtor

        protected Veiculo(string modelo, string fabricante, string cor, int anoFabricacao)
        {
            _modelo = modelo;
            _fabricante = fabricante;
            _cor = cor;
            _anoFabricacao = anoFabricacao;
        }
        #endregion

        #region Métodos

        public abstract void Ligar();

        public abstract void Desligar();

        public int IdadeVeiculo()
        {
            return DateTime.Now.Year - _anoFabricacao;
        }

        #endregion
    }
}