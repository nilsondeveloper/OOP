namespace NJ.OOP.ConsoleApplication.Encapsulamento
{
    public class Voo
    {
        #region Métodos 

        public void VoarAviao(Aviao aviao)
        {
            aviao.Ligar();
            aviao.Decolar();
            aviao.Pousar();
            aviao.Desligar();
        }

        #endregion

    }
}