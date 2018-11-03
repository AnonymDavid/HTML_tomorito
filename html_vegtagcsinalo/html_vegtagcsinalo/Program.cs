using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace html_vegtagcsinalo
{
    class Program
    {
        static void Main(string[] args)
        {
            // html eleje tagek megszámolása
            int n = 0;
            StreamReader sr = new StreamReader("html_tag_eleje.txt");
            while (!sr.EndOfStream)
            {
                string sor;
                sor = sr.ReadLine();
                if (sor != "") n++;
            }
            sr.Close();

            // html eleje tagek beolvasása
            string[] etagek = new string[n];
            StreamReader sr1 = new StreamReader("html_tag_eleje.txt");
            int seged = 0;
            while (!sr1.EndOfStream)
            {
                string sor;
                sor = sr1.ReadLine();
                if (sor != "")
                {
                    etagek[seged] = sor;
                    seged++;
                }
            }
            sr.Close();

            // attribútumok megszámolása
            int m = 0;
            StreamReader sr2 = new StreamReader("allatr.txt");
            while (!sr2.EndOfStream)
            {
                string sor;
                sor = sr2.ReadLine();
                if (sor != "") m++;
            }
            sr2.Close();

            // attribútumok beolvasása
            string[] attr = new string[m];
            StreamReader sr3 = new StreamReader("allatr.txt");
            seged = 0;
            while (!sr3.EndOfStream)
            {
                string sor;
                sor = sr3.ReadLine();
                if (sor != "")
                {
                    attr[seged] = sor.ToUpper();
                    seged++;
                }
            }
            sr3.Close();

            seged = 0;

            // végtagek elkészítése
            string[] vtagek = new string[n];
            for (int i = 0; i < n; i++)
            {
                string vtag = "</" + etagek[i];
                vtag = vtag.Remove(2, 1);
                vtagek[i] = vtag;
            }

            //rendezések
            string cs;

            for (int i = etagek.Length -1; i > 1; i--)
            {
                for (int j = 0; j < etagek.Length - 2 ; j++)
                {
                    if (etagek[j].Length > etagek[j + 1].Length)
                    {
                        cs = etagek[j];
                        etagek[j] = etagek[j + 1];
                        etagek[j + 1] = cs;
                    }
                }
            }

            cs = "";

            for (int i = vtagek.Length - 1; i > 1; i--)
            {
                for (int j = 0; j < vtagek.Length - 2; j++)
                {
                    if(vtagek[j].Length > vtagek[j + 1].Length)
                    {
                        cs = vtagek[j];
                        vtagek[j] = vtagek[j + 1];
                        vtagek[j + 1] = cs;
                    }
                }
            }

            cs = "";

            for (int i = attr.Length - 1; i > 1; i--)
            {
                for (int j = 0; j < attr.Length - 2; j++)
                {
                    if (attr[j].Length > attr[j + 1].Length)
                    {
                        cs = attr[j];
                        attr[j] = attr[j + 1];
                        attr[j + 1] = cs;
                    }
                }
            }

            // html végtagek kiírása
            StreamWriter sw = new StreamWriter("html_tag_vege.txt");
            for (int i = 0; i < n; i++)
            {
                sw.WriteLine(vtagek[i]);
            }
            sw.Close();

            // összes alakítandó elem egy tömbbe eltárolása, extra szöveg hozzáadása, rendezése hossz szerint
            string apsz = (Convert.ToChar(34)).ToString();
            string[] ossz = new string[n * 2 + m];
            for (int i = 0; i < n; i++)
            {
                ossz[i] = "addCompressText(" + apsz + etagek[i] + apsz;
            }
            for (int i = 0; i < n; i++)
            {
                int bseged = n + i;
                ossz[bseged] = "addCompressText(" + apsz + vtagek[i] + apsz;
            }
            for (int i = 0; i < m; i++)
            {
                int bseged = n * 2 + i;
                ossz[bseged] = "addCompressText(" + apsz + attr[i] + apsz;
            }

            for (int i = ossz.Length - 1; i > 1; i--)
            {
                for (int j = 0; j < ossz.Length - 2; j++)
                {
                    if (ossz[j].Length > ossz[j + 1].Length)
                    {
                        cs = ossz[j];
                        ossz[j] = ossz[j + 1];
                        ossz[j + 1] = cs;
                    }
                }
            } 

            // lehetõség tömbök feltöltése
            int[] szamok = new int[100];
            for (int i = 0; i < 100; i++)
            {
                szamok[i] = i + 1;
            }
            string[] karakterek = { "\\", "&", "$", "%" };

            // kiírás
            int kseged = n * 2 + m;

            StreamWriter sw1 = new StreamWriter("mehetaprogiba.txt");
            for (int i = 0; i < 100; i++)
            {
                sw1.WriteLine(ossz[i] + ", @" + apsz + karakterek[0] + i + apsz + ");");
            }
            for (int i = 100; i < 200; i++)
            {
                sw1.WriteLine(ossz[i] + ", @" + apsz + karakterek[1] + (i - 100) + apsz + ");");
            }
            for (int i = 200; i < 300; i++)
            {
                sw1.WriteLine(ossz[i] + ", @" + apsz + karakterek[2] + (i - 200) + apsz + ");");
            }
            for (int i = 300; i < kseged; i++)
            {
                sw1.WriteLine(ossz[i] + ", @" + apsz + karakterek[3] + (i - 300) + apsz + ");");
            }
            sw1.Close();

            Console.WriteLine("Ready for program.");

            Console.ReadKey();
        }
    }
}
