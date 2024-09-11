// See https://aka.ms/new-console-template for more information
using ripassoinizioanno;
CAtrazione attrazione1 = new CAtrazione("Russian Roller Coaster", "Montagna Russa", new DateTime(2007, 3, 26), new int[] { 12,140,45});
CAtrazione attrazione2= new CAtrazione("water slide", "scivolo d'acqua", new DateTime(2007, 2, 26), new int[] { 12, 140, 45 });
CAtrazione attrazione3= new CAtrazione("oblivion", "Montagna Russa", new DateTime(2007, 3, 26), new int[] { 12, 140, 45 });
CArea area1 = new CArea(new List<CAtrazione> { attrazione1 }, 500, new DateTime(2007, 1, 1), new DateTime(2024, 1, 1));
CArea area2 = new CArea(new List<CAtrazione> { attrazione2 }, 1060, new DateTime(2007, 1, 1), new DateTime(2024, 1, 1));
CArea area3 = new CArea(new List<CAtrazione> { attrazione3 }, 900, new DateTime(2007, 1, 1), new DateTime(2024, 1, 1));
CParcoDivertimenti parcoDivertimenti1 = new CParcoDivertimenti("gardaland","verona");
parcoDivertimenti1.aree.Add(area1);
parcoDivertimenti1.aree.Add(area2);
parcoDivertimenti1.aree.Add(area3);

Console.WriteLine(parcoDivertimenti1.scrivi());

Console.WriteLine(parcoDivertimenti1.ElencoAttrazioni("marzo", "Montagna Russa"));

Console.WriteLine(area1.scrivi());
Console.WriteLine(attrazione1.scrivi());