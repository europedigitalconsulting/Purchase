using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoCoin.UI.Components.Sepa
{
     public partial class SepaComponent : ComponentBase
    {
       

        static CreancierParameters crea = new CreancierParameters()
        {
            creancierID = "FR21542125852",
            creancierName = "France Digital Consulting",
            creancierAdresse = "3 RUE MRX DORMOY 91480 Quincy Sous senart",
            creancierPays = "France"
        };
        SepaParameters sepa = new SepaParameters()
        {
            creancier = crea,
            debiteur = new DebiteurParameters(),
            referenceMandat = "XXXXXXXXXXXX001"
        };

        public void OnSubmitSepa()
        {


        }

    }
}
