using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcodivertimentiform
{
    internal class CAtrazione
    {
        public string nome { get; set; }
        public string tipo { get; set; }
        public DateTime datainaugurazione { get; set; }
        public int[] restrizioni { get; set; }

        public CAtrazione()
        {
            this.nome = default;
            this.tipo = default;
            this.datainaugurazione = default;
            this.restrizioni = new int[3];
        }
        public CAtrazione(string nome, string tipo, DateTime datainaugurazione, int[] restrizioni)
        {
            this.nome = nome;
            this.tipo = tipo;
            this.datainaugurazione = datainaugurazione;
            this.restrizioni = restrizioni;
        }

        public string scrivi()
        {
            string dataiconv = datainaugurazione.ToString();

            string desc = $"descrizione attrazione {nome}:\n nome:{nome}\n tipo:{tipo}\n data inugurazione:" +
                        $"{dataiconv}\n restrizioni:\n età={restrizioni[0]}anni\n altezza={restrizioni[1]}m\n peso={restrizioni[2]}kg";

            return desc;
        }
    }
}
}
