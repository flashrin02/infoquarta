using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcodivertimentiform
{
    internal class CArea
    {
        public List<CAtrazione> attrazioni { get; set; }
        public int vish { get; set; }
        public DateTime apertura { get; set; }
        public DateTime chiusura { get; set; }

        public CArea()
        {
            this.attrazioni = new List<CAtrazione>();
            this.vish = 0;
            this.apertura = default;
            this.chiusura = default;
        }
        public CArea(List<CAtrazione> attrazioni, int vish, DateTime apertura, DateTime chiusura)
        {
            this.attrazioni = attrazioni;
            this.vish = vish;
            this.apertura = apertura;
            this.chiusura = chiusura;
        }

        public string scrivi()
        {
            int attrazioniconv = attrazioni.Count;

            string vishconv = vish.ToString();
            string dataaconv = apertura.ToString();
            string datacconv = chiusura.ToString();
            string desc = $"descrizione area:\n numero attrazioni:{attrazioniconv}\n numero visitatori all'ora:" +
                          $"{vishconv}\n data di apertura:{dataaconv}\n data di chiusura:{dataaconv}";
            return desc;
        }
    }
}

