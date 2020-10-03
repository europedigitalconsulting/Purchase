using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoCoin.UI.Components.Sepa
{
    public class DebiteurParameters
    {
        public string debiteurName { get; set; }
        public string debiteurAdresse { get; set; }
        public string debiteurCp { get; set; }
        public string debiteurVille { get; set; }
        public string debiteurPays { get; set; }
        public string debiteurIBAN { get; set; }
        public string debiteurBIC { get; set; }
        public string debiteurAdresseSignature { get; set; }
    }
}
