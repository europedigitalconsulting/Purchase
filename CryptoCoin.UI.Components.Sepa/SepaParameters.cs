using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoCoin.UI.Components.Sepa
{
   public class SepaParameters
    {
        public string referenceMandat { get; set; }
        public DebiteurParameters debiteur { get; set; }
        public CreancierParameters creancier { get; set; }
    }
}
