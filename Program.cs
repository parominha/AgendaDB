using Agenda_Lib.DAO.CEP;
using System;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            ViaCEP oViaCEP = new ViaCEP();
            DadosCEP oDadosCEP = new DadosCEP();
            oViaCEP = oDadosCEP.Pesquisar_CEP("06142050");
        }
    }
}
