using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ripassoinizioanno
{
    internal class CParcoDivertimenti
    {

            public List<CArea> aree { get; set; }
            public string nome { get; set; }
            public string localita { get; set; }

            public CParcoDivertimenti(string nome, string localita)
            {
                aree = new List<CArea>();
                this.nome = nome;
                this.localita = localita;
            }

            public string scrivi()
            {
                string stringa = $"Nome parco: {nome}\nLocalità: {localita}\nAree:\n";
                int i = 0;
            {

            }
                foreach (var area in aree)
                {
                    i++;
                    stringa += $"area {i}\n";

                    foreach (var attrazione in area.attrazioni)
                    {
                        stringa += $"  - {attrazione.nome}\n";
                    }

                }
                return stringa;
            }

            public string ElencoAttrazioni(string mese, string tipo)
            {
                string string2 = "Ecco le attrazioni che soddisfano i requisiti:\n";
                foreach (var area in aree)
                {
                    foreach (var attrazione in area.attrazioni)
                    {
                        bool meseMatch = false;

                        switch (mese.ToLower())
                        {
                            case "gennaio":
                                meseMatch = attrazione.datainaugurazione.Month == 1;
                                break;
                            case "febbraio":
                                meseMatch = attrazione.datainaugurazione.Month == 2;
                                break;
                            case "marzo":
                                meseMatch = attrazione.datainaugurazione.Month == 3;
                                break;
                            case "aprile":
                                meseMatch = attrazione.datainaugurazione.Month == 4;
                                break;
                            case "maggio":
                                meseMatch = attrazione.datainaugurazione.Month == 5;
                                break;
                            case "giugno":
                                meseMatch = attrazione.datainaugurazione.Month == 6;
                                break;
                            case "luglio":
                                meseMatch = attrazione.datainaugurazione.Month == 7;
                                break;
                            case "agosto":
                                meseMatch = attrazione.datainaugurazione.Month == 8;
                                break;
                            case "settembre":
                                meseMatch = attrazione.datainaugurazione.Month == 9;
                                break;
                            case "ottobre":
                                meseMatch = attrazione.datainaugurazione.Month == 10;
                                break;
                            case "novembre":
                                meseMatch = attrazione.datainaugurazione.Month == 11;
                                break;
                            case "dicembre":
                                meseMatch = attrazione.datainaugurazione.Month == 12;
                                break;
                            default:
                                meseMatch = false;
                                break;
                        }

                        if (meseMatch && attrazione.tipo.ToLower() == tipo.ToLower())
                        {
                            string2 += $"- {attrazione.nome} ({attrazione.tipo})\n";
                        }
                    }
                }

                return string2;
            }
        }
    }

