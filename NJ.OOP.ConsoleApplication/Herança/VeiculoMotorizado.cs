using System;

namespace NJ.OOP.ConsoleApplication.Herança
{
    public class VeiculoMotorizado
    {
        #region Propriedades

        public String Modelo { get; set; }
        public String Fabricante { get; set; }
        public String Cor { get; set; }
        public int AnoFabricacao { get; set; }

        #endregion

        #region Construtor

        public VeiculoMotorizado(string cor, int anoFabricacao, string modelo, string fabricante)
        {
            Cor = cor;
            AnoFabricacao = anoFabricacao;
            Modelo = modelo;
            Fabricante = fabricante;
        }

        #endregion

        #region Métodos

        public int IdadeVeiculoMotorizado()
        {
            return DateTime.Now.Year - AnoFabricacao;
        }

        #endregion
    }
}
