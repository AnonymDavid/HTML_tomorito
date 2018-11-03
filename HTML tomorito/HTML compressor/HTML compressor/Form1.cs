using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HTML_compressor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string source;
        private string destination;
        private List<string[]> compressData;

        private void Form1_Load(object sender, EventArgs e)
        {
            compressData = new List<string[]>();

            // adding the keys (kulcsok hozzáadása)
            #region tagek
            addCompressText("<A", @"\0");
            addCompressText("<B", @"\1");
            addCompressText("<I", @"\2");
            addCompressText("<P", @"\3");
            addCompressText("<S", @"\4");
            addCompressText("<U", @"\5");
            addCompressText("ID", @"\6");
            addCompressText("<BR", @"\7");
            addCompressText("<DD", @"\8");
            addCompressText("<DL", @"\9");
            addCompressText("<DT", @"\10");
            addCompressText("<EM", @"\11");
            addCompressText("<H1", @"\12");
            addCompressText("<H2", @"\13");
            addCompressText("<H3", @"\14");
            addCompressText("<H4", @"\15");
            addCompressText("<H5", @"\16");
            addCompressText("<H6", @"\17");
            addCompressText("<HR", @"\18");
            addCompressText("<LI", @"\19");
            addCompressText("<OL", @"\20");
            addCompressText("<TD", @"\21");
            addCompressText("<TH", @"\22");
            addCompressText("<TR", @"\23");
            addCompressText("<TT", @"\24");
            addCompressText("<UL", @"\25");
            addCompressText("</A", @"\26");
            addCompressText("</B", @"\27");
            addCompressText("</I", @"\28");
            addCompressText("</P", @"\29");
            addCompressText("</S", @"\30");
            addCompressText("</U", @"\31");
            addCompressText("ALT", @"\32");
            addCompressText("DIR", @"\33");
            addCompressText("FOR", @"\34");
            addCompressText("LOW", @"\35");
            addCompressText("MAX", @"\36");
            addCompressText("MIN", @"\37");
            addCompressText("REL", @"\38");
            addCompressText("SRC", @"\39");
            addCompressText("<APP", @"\40");
            addCompressText("<BIG", @"\41");
            addCompressText("<COL", @"\42");
            addCompressText("<DEL", @"\43");
            addCompressText("<DFN", @"\44");
            addCompressText("<DIR", @"\45");
            addCompressText("<DIV", @"\46");
            addCompressText("<IMG", @"\47");
            addCompressText("<INS", @"\48");
            addCompressText("<KBD", @"\49");
            addCompressText("<MAP", @"\50");
            addCompressText("<PRE", @"\51");
            addCompressText("<SUB", @"\52");
            addCompressText("<SUP", @"\53");
            addCompressText("<VAR", @"\54");
            addCompressText("<WBR", @"\55");
            addCompressText("<XMP", @"\56");
            addCompressText("</BR", @"\57");
            addCompressText("</DD", @"\58");
            addCompressText("</DL", @"\59");
            addCompressText("</DT", @"\60");
            addCompressText("</EM", @"\61");
            addCompressText("</H1", @"\62");
            addCompressText("</H2", @"\63");
            addCompressText("</H3", @"\64");
            addCompressText("</H4", @"\65");
            addCompressText("</H5", @"\66");
            addCompressText("</H6", @"\67");
            addCompressText("</HR", @"\68");
            addCompressText("</LI", @"\69");
            addCompressText("</OL", @"\70");
            addCompressText("</TD", @"\71");
            addCompressText("</TH", @"\72");
            addCompressText("</TR", @"\73");
            addCompressText("</TT", @"\74");
            addCompressText("</UL", @"\75");
            addCompressText("CITE", @"\76");
            addCompressText("COLS", @"\77");
            addCompressText("DATA", @"\78");
            addCompressText("FORM", @"\79");
            addCompressText("HIGH", @"\80");
            addCompressText("HREF", @"\81");
            addCompressText("KIND", @"\82");
            addCompressText("LANG", @"\83");
            addCompressText("LIST", @"\84");
            addCompressText("LOOP", @"\85");
            addCompressText("NAME", @"\86");
            addCompressText("OPEN", @"\87");
            addCompressText("ROWS", @"\88");
            addCompressText("SIZE", @"\89");
            addCompressText("SPAN", @"\90");
            addCompressText("STEP", @"\91");
            addCompressText("TYPE", @"\92");
            addCompressText("<AREA", @"\93");
            addCompressText("<BASE", @"\94");
            addCompressText("<BODY", @"\95");
            addCompressText("<CITE", @"\96");
            addCompressText("<CODE", @"\97");
            addCompressText("<FONT", @"\98");
            addCompressText("<FORM", @"\99");
            addCompressText("<HEAD", @"&0");
            addCompressText("<HTML", @"&1");
            addCompressText("<HYPE", @"&2");
            addCompressText("<LINK", @"&3");
            addCompressText("<MENU", @"&4");
            addCompressText("<META", @"&5");
            addCompressText("<NOBR", @"&6");
            addCompressText("<SAMP", @"&7");
            addCompressText("<SPAN", @"&8");
            addCompressText("</APP", @"&9");
            addCompressText("</BIG", @"&10");
            addCompressText("</COL", @"&11");
            addCompressText("</DEL", @"&12");
            addCompressText("</DFN", @"&13");
            addCompressText("</DIR", @"&14");
            addCompressText("</DIV", @"&15");
            addCompressText("</IMG", @"&16");
            addCompressText("</INS", @"&17");
            addCompressText("</KBD", @"&18");
            addCompressText("</MAP", @"&19");
            addCompressText("</PRE", @"&20");
            addCompressText("</SUB", @"&21");
            addCompressText("</SUP", @"&22");
            addCompressText("</VAR", @"&23");
            addCompressText("</WBR", @"&24");
            addCompressText("</XMP", @"&25");
            addCompressText("ALIGN", @"&26");
            addCompressText("ASYNC", @"&27");
            addCompressText("CLASS", @"&28");
            addCompressText("COLOR", @"&29");
            addCompressText("DEFER", @"&30");
            addCompressText("ISMAP", @"&31");
            addCompressText("LABEL", @"&32");
            addCompressText("MEDIA", @"&33");
            addCompressText("MUTED", @"&34");
            addCompressText("ONCUT", @"&35");
            addCompressText("SCOPE", @"&36");
            addCompressText("SHAPE", @"&37");
            addCompressText("SIZES", @"&38");
            addCompressText("START", @"&39");
            addCompressText("STYLE", @"&40");
            addCompressText("TITLE", @"&41");
            addCompressText("VALUE", @"&42");
            addCompressText("WIDTH", @"&43");
            addCompressText("<BLINK", @"&44");
            addCompressText("<EMBED", @"&45");
            addCompressText("<FRAME", @"&46");
            addCompressText("<INPUT", @"&47");
            addCompressText("<LABEL", @"&48");
            addCompressText("<PARAM", @"&49");
            addCompressText("<SMALL", @"&50");
            addCompressText("<SOUND", @"&51");
            addCompressText("<STYLE", @"&52");
            addCompressText("<TABLE", @"&53");
            addCompressText("<TBODY", @"&54");
            addCompressText("<TFOOT", @"&55");
            addCompressText("<THEAD", @"&56");
            addCompressText("<TBODY", @"&57");
            addCompressText("<TFOOT", @"&58");
            addCompressText("<TITLE", @"&59");
            addCompressText("</AREA", @"&60");
            addCompressText("</BASE", @"&61");
            addCompressText("</BODY", @"&62");
            addCompressText("</CITE", @"&63");
            addCompressText("</CODE", @"&64");
            addCompressText("</FONT", @"&65");
            addCompressText("</FORM", @"&66");
            addCompressText("</HEAD", @"&67");
            addCompressText("</HTML", @"&68");
            addCompressText("</HYPE", @"&69");
            addCompressText("</LINK", @"&70");
            addCompressText("</MENU", @"&71");
            addCompressText("</META", @"&72");
            addCompressText("</NOBR", @"&73");
            addCompressText("</SAMP", @"&74");
            addCompressText("</SPAN", @"&75");
            addCompressText("ACCEPT", @"&76");
            addCompressText("ACTION", @"&77");
            addCompressText("BORDER", @"&78");
            addCompressText("COORDS", @"&79");
            addCompressText("DATA-*", @"&80");
            addCompressText("HEIGHT", @"&81");
            addCompressText("HIDDEN", @"&82");
            addCompressText("METHOD", @"&83");
            addCompressText("ONBLUR", @"&84");
            addCompressText("ONCOPY", @"&85");
            addCompressText("ONDRAG", @"&86");
            addCompressText("ONDROP", @"&87");
            addCompressText("ONLOAD", @"&88");
            addCompressText("ONPLAY", @"&89");
            addCompressText("POSTER", @"&90");
            addCompressText("SRCDOC", @"&91");
            addCompressText("SRCSET", @"&92");
            addCompressText("TARGET", @"&93");
            addCompressText("USEMAP", @"&94");
            addCompressText("<APPLET", @"&95");
            addCompressText("<BUTTON", @"&96");
            addCompressText("<CENTER", @"&97");
            addCompressText("<IFRAME", @"&98");
            addCompressText("<LEGEND", @"&99");
            addCompressText("<OPTION", @"$0");
            addCompressText("<SCRIPT", @"$1");
            addCompressText("<SELECT", @"$2");
            addCompressText("<SPACER", @"$3");
            addCompressText("<STRIKE", @"$4");
            addCompressText("<STRONG", @"$5");
            addCompressText("</BLINK", @"$6");
            addCompressText("</EMBED", @"$7");
            addCompressText("</FRAME", @"$8");
            addCompressText("</INPUT", @"$9");
            addCompressText("</LABEL", @"$10");
            addCompressText("</PARAM", @"$11");
            addCompressText("</SMALL", @"$12");
            addCompressText("</SOUND", @"$13");
            addCompressText("</STYLE", @"$14");
            addCompressText("</TABLE", @"$15");
            addCompressText("</TBODY", @"$16");
            addCompressText("</TFOOT", @"$17");
            addCompressText("</THEAD", @"$18");
            addCompressText("</TBODY", @"$19");
            addCompressText("</TFOOT", @"$20");
            addCompressText("</TITLE", @"$21");
            addCompressText("BGCOLOR", @"$22");
            addCompressText("CHARSET", @"$23");
            addCompressText("CHECKED", @"$24");
            addCompressText("COLSPAN", @"$25");
            addCompressText("CONTENT", @"$26");
            addCompressText("DEFAULT", @"$27");
            addCompressText("DIRNAME", @"$28");
            addCompressText("ENCTYPE", @"$29");
            addCompressText("HEADERS", @"$30");
            addCompressText("ONABORT", @"$31");
            addCompressText("ONCLICK", @"$32");
            addCompressText("ONENDED", @"$33");
            addCompressText("ONERROR", @"$34");
            addCompressText("ONFOCUS", @"$35");
            addCompressText("ONINPUT", @"$36");
            addCompressText("ONKEYUP", @"$37");
            addCompressText("ONPASTE", @"$38");
            addCompressText("ONPAUSE", @"$39");
            addCompressText("ONRESET", @"$40");
            addCompressText("ONWHEEL", @"$41");
            addCompressText("OPTIMUM", @"$42");
            addCompressText("PATTERN", @"$43");
            addCompressText("PRELOAD", @"$44");
            addCompressText("ROWSPAN", @"$45");
            addCompressText("SANDBOX", @"$46");
            addCompressText("SRCLANG", @"$47");
            addCompressText("<ADDRESS", @"$48");
            addCompressText("<BGSOUND", @"$49");
            addCompressText("<CAPTION", @"$50");
            addCompressText("<COMMENT", @"$51");
            addCompressText("<ISINDEX", @"$52");
            addCompressText("<LISTING", @"$53");
            addCompressText("<MARQUEE", @"$54");
            addCompressText("<NOEMBED", @"$55");
            addCompressText("</APPLET", @"$56");
            addCompressText("</BUTTON", @"$57");
            addCompressText("</CENTER", @"$58");
            addCompressText("</IFRAME", @"$59");
            addCompressText("</LEGEND", @"$60");
            addCompressText("</OPTION", @"$61");
            addCompressText("</SCRIPT", @"$62");
            addCompressText("</SELECT", @"$63");
            addCompressText("</SPACER", @"$64");
            addCompressText("</STRIKE", @"$65");
            addCompressText("</STRONG", @"$66");
            addCompressText("AUTOPLAY", @"$67");
            addCompressText("CONTROLS", @"$68");
            addCompressText("DATETIME", @"$69");
            addCompressText("DISABLED", @"$70");
            addCompressText("DOWNLOAD", @"$71");
            addCompressText("DROPZONE", @"$72");
            addCompressText("HREFLANG", @"$73");
            addCompressText("MULTIPLE", @"$74");
            addCompressText("ONCHANGE", @"$75");
            addCompressText("ONONLINE", @"$76");
            addCompressText("ONRESIZE", @"$77");
            addCompressText("ONSCROLL", @"$78");
            addCompressText("ONSEARCH", @"$79");
            addCompressText("ONSEEKED", @"$80");
            addCompressText("ONSELECT", @"$81");
            addCompressText("ONSUBMIT", @"$82");
            addCompressText("ONTOGGLE", @"$83");
            addCompressText("ONUNLOAD", @"$84");
            addCompressText("READONLY", @"$85");
            addCompressText("REQUIRED", @"$86");
            addCompressText("REVERSED", @"$87");
            addCompressText("SELECTED", @"$88");
            addCompressText("TABINDEX", @"$89");
            addCompressText("<!DOCTYPE", @"$90");
            addCompressText("<BASEFONT", @"$91");
            addCompressText("<COLGROUP", @"$92");
            addCompressText("<FIELDSET", @"$93");
            addCompressText("<FRAMESET", @"$94");
            addCompressText("<HTMLPLUS", @"$95");
            addCompressText("<MULTICOL", @"$96");
            addCompressText("<NOFRAMES", @"$97");
            addCompressText("<NOSCRIPT", @"$98");
            addCompressText("<TEXTAREA", @"$99");
            addCompressText("</ADDRESS", @"%0");
            addCompressText("</BGSOUND", @"%1");
            addCompressText("</CAPTION", @"%2");
            addCompressText("</COMMENT", @"%3");
            addCompressText("</ISINDEX", @"%4");
            addCompressText("</LISTING", @"%5");
            addCompressText("</MARQUEE", @"%6");
            addCompressText("</NOEMBED", @"%7");
            addCompressText("ACCESSKEY", @"%8");
            addCompressText("AUTOFOCUS", @"%9");
            addCompressText("DRAGGABLE", @"%10");
            addCompressText("MAXLENGTH", @"%11");
            addCompressText("ONCANPLAY", @"%12");
            addCompressText("ONDRAGEND", @"%13");
            addCompressText("ONEMPTIED", @"%14");
            addCompressText("ONINVALID", @"%15");
            addCompressText("ONKEYDOWN", @"%16");
            addCompressText("ONMOUSEUP", @"%17");
            addCompressText("ONOFFLINE", @"%18");
            addCompressText("ONPLAYING", @"%19");
            addCompressText("ONSEEKING", @"%20");
            addCompressText("ONSTALLED", @"%21");
            addCompressText("ONSTORAGE", @"%22");
            addCompressText("ONSUSPEND", @"%23");
            addCompressText("ONWAITING", @"%24");
            addCompressText("TRANSLATE", @"%25");
            addCompressText("<PLAINTEXT", @"%26");
            addCompressText("</!DOCTYPE", @"%27");
            addCompressText("</BASEFONT", @"%28");
            addCompressText("</COLGROUP", @"%29");
            addCompressText("</FIELDSET", @"%30");
            addCompressText("</FRAMESET", @"%31");
            addCompressText("</HTMLPLUS", @"%32");
            addCompressText("</MULTICOL", @"%33");
            addCompressText("</NOFRAMES", @"%34");
            addCompressText("</NOSCRIPT", @"%35");
            addCompressText("</TEXTAREA", @"%36");
            addCompressText("FORMACTION", @"%37");
            addCompressText("HTTP-EQUIV", @"%38");
            addCompressText("NOVALIDATE", @"%39");
            addCompressText("ONDBLCLICK", @"%40");
            addCompressText("ONDRAGOVER", @"%41");
            addCompressText("ONKEYPRESS", @"%42");
            addCompressText("ONMOUSEOUT", @"%43");
            addCompressText("ONPAGEHIDE", @"%44");
            addCompressText("ONPAGESHOW", @"%45");
            addCompressText("ONPOPSTATE", @"%46");
            addCompressText("ONPROGRESS", @"%47");
            addCompressText("SPELLCHECK", @"%48");
            addCompressText("<BLOCKQUOTE", @"%49");
            addCompressText("</PLAINTEXT", @"%50");
            addCompressText("ONCUECHANGE", @"%51");
            addCompressText("ONDRAGENTER", @"%52");
            addCompressText("ONDRAGLEAVE", @"%53");
            addCompressText("ONDRAGSTART", @"%54");
            addCompressText("ONLOADSTART", @"%55");
            addCompressText("ONMOUSEDOWN", @"%56");
            addCompressText("ONMOUSEMOVE", @"%57");
            addCompressText("ONMOUSEOVER", @"%58");
            addCompressText("PLACEHOLDER", @"%59");
            addCompressText("</BLOCKQUOTE", @"%60");
            addCompressText("AUTOCOMPLETE", @"%61");
            addCompressText("ONAFTERPRINT", @"%62");
            addCompressText("ONHASHCHANGE", @"%63");
            addCompressText("ONLOADEDDATA", @"%64");
            addCompressText("ONMOUSEWHEEL", @"%65");
            addCompressText("ONRATECHANGE", @"%66");
            addCompressText("ONTIMEUPDATE", @"%67");
            addCompressText("ONBEFOREPRINT", @"%68");
            addCompressText("ONCONTEXTMENU", @"%69");
            addCompressText("ACCEPT-CHARSET", @"%70");
            addCompressText("ONBEFOREUNLOAD", @"%71");
            addCompressText("ONVOLUMECHANGE", @"%72");
            addCompressText("CONTENTEDITABLE", @"%73");
            addCompressText("ONCANPLAYTHROUGH", @"%74");
            addCompressText("ONDURATIONCHANGE", @"%75");
            addCompressText("ONLOADEDMETADATA", @"%76");
            addCompressText("WRAP", @"%77");

            #endregion
        }

        private void btnForras_Click(object sender, EventArgs e)
        {
            // original file browsing (eredeti file kiválasztása)

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "HTML|*.html";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtForras.Text = ofd.FileName;
            }
        }

        private void btnCel_Click(object sender, EventArgs e)
        {
            // place selection for the compressed file (helyválasztás a tömörített filenak)

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "HTML|*.html";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                txtCel.Text = sfd.FileName;
            }
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            // compressing (tömörítés)
            compress();
        }

        private void btnDeCompress_Click(object sender, EventArgs e)
        {
            // decompressing (visszafejtés)
            deCompress();
        }

        private void addCompressText(string _base, string _compressed)
        {
            // method for uploading the array (metódus a tömb feltöltéséhez)

            string[] temp = new string[2];
            temp[0] = _base;
            temp[1] = _compressed;
            compressData.Add(temp);
        }

        private void compress()
        {
            // compressing method (tömörítő metódus)
            try
            {
                // set source and destination (forrás és cél beolvasása)
                source = txtForras.Text;
                destination = txtCel.Text;

                // check source and destination (forrás és cél ellenőrzése)
                if (source != null && destination != null && File.Exists(source))
                {
                    // create destination folder if it doesn't exists (cél mappa létrehozása, ha nem létezik)
                    int l = 0;
                    while (l < destination.Length && destination.IndexOf("\\", l) >= 0)
                        l = destination.IndexOf("\\", l) + 1;
                    if (!Directory.Exists(destination.Substring(0, destination.Length - destination.Substring(l - 1).Length)))
                        Directory.CreateDirectory(destination.Substring(0, destination.Length - destination.Substring(l - 1).Length));

                    // creating reader and writer object (olvasó és író objektum létrehozása)
                    StreamReader sr = new StreamReader(source, Encoding.GetEncoding("ISO-8859-2"));
                    StreamWriter sw = new StreamWriter(new FileStream(destination, FileMode.OpenOrCreate, FileAccess.ReadWrite), Encoding.UTF8);

                    // iterating trough source file (végigiterálás a forrásfile-on)
                    while (!sr.EndOfStream)
                    {
                        // current variable stores the current line in the source file (current változó tárolja a jelenlegi sort a forrásfile-ban)
                        string current = sr.ReadLine();

                        // removing comments (kommentek eltávolítása)
                        while (current.Contains("<!--"))
                        {
                            if (current.Contains("-->"))
                            {
                                // removing single-line comments (1 soros commentek eltávolítása)
                                current = current.Remove(current.IndexOf("<!--"), (current.IndexOf("-->") + 3) - current.IndexOf("<!--"));
                            }
                            else
                            {
                                // removing multiple-line comments (többsoros kommentek eltávolítása)
                                while (!current.Contains("-->") && !sr.EndOfStream)
                                {
                                    current = sr.ReadLine();
                                }
                                current = current.Remove(0, current.IndexOf("-->") + 3);
                            }
                        }
                        // removing whitespaces and tabulators (üres helyek és tabulátorok eltávolítása)
                        current = current.TrimStart(' ');
                        current = current.TrimStart('\t');

                        // only write the line if it isn't empty after removing comments and whitespaces (csak akkor íródik ki a sor, ha nem üres az üres helyek, és kommentek eltávolítása után)
                        if (current != "")
                        {
                            // differentiate the 4 special character used in the keys (a kulcsokban használt 4 speciális karakter megkülönböztetése)
                            current = current.Replace(@"\", @"\\");
                            current = current.Replace(@"&", @"&&");
                            current = current.Replace(@"$", @"$$");
                            current = current.Replace(@"%", @"%%");

                            // compress tags and properties (tagek és tulajdonságok tömörítése)
                            string upperCurrent = current.ToUpper();
                            for (int i = compressData.Count - 1; i >= 0; i--)
                            {
                                while (upperCurrent.Contains(compressData[i][0]))
                                {
                                    // finding the current tag/property in the uppercased current line (a jelenlegi tag/tulajdonság megkeresése a nagybetűsített sorban)
                                    // because the tags and properties are saved in uppercase characters. (mert a tagek és tulajdonságok nagybetűsen vannak elmentve)
                                    // Than change the tag/property in the original curret line (utána az eredeti sorban a tag/tulajdonság megváltoztatása)
                                    // at the same position as in the uppercased line (ugyanabban a pozícióban mint a nagybetűsben)
                                    current = current.Replace(current.Substring(upperCurrent.IndexOf(compressData[i][0]), compressData[i][0].Length), compressData[i][1]);

                                    // syncing the uppercased line variable with the changed line (a nagybetűs sor változó szinkronizálása a megváltozott eredeti sorral)
                                    upperCurrent = current.ToUpper();
                                }
                            }
                            // writing the compressed line to the file (tömörített sor fileba írása)
                            sw.WriteLine(current);
                        }
                    }
                    // closing the reader and writer objects (olvasó és író objektum lezárása)
                    sw.Close();
                    sr.Close();

                    // information gathering about file sizes (információgyűjtés a file-méretekről)
                    FileInfo fileBefore = new FileInfo(source);
                    FileInfo fileAfter = new FileInfo(destination);

                    // succesful compressing -> write out the filesizes (sikeres tömörítés -> fileméretek kiírása)
                    MessageBox.Show(string.Format("Kész!\n\nEredeti méret: {0} B\nTömörített méret: {1} B", fileBefore.Length, fileAfter.Length));
                }
                else
                {
                    // error if the source file doesn't exists (hiba, ha a forrás file nem létezik)
                    MessageBox.Show("A megadott file nem létezik: " + source, "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // general error catching, preventing the program to stop (általános hiba elkapás, a program leállásának elkerülése érdekében)
                MessageBox.Show("Hiba: " + ex.Message, "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deCompress()
        {
            try
            {
                // set source and destination (forrás és cél beolvasása)
                source = txtForras.Text;
                destination = txtCel.Text;

                if (source != null && destination != null && File.Exists(source))
                {
                    // create destination folder if it doesn't exists (cél mappa létrehozása, ha nem létezik)
                    int l = 0;
                    while (l < destination.Length && destination.IndexOf("\\", l) >= 0)
                        l = destination.IndexOf("\\", l) + 1;
                    if (!Directory.Exists(destination.Substring(0, destination.Length - destination.Substring(l - 1).Length)))
                        Directory.CreateDirectory(destination.Substring(0, destination.Length - destination.Substring(l - 1).Length));

                    // creating reader and writer object (olvasó és író objektum létrehozása)
                    StreamReader sr = new StreamReader(source, Encoding.GetEncoding("ISO-8859-2"));
                    StreamWriter sw = new StreamWriter(new FileStream(destination, FileMode.OpenOrCreate, FileAccess.ReadWrite), Encoding.UTF8);

                    // iterating trough source file (végigiterálás a forrásfile-on)
                    while (!sr.EndOfStream)
                    {
                        // current variable stores the current line in the source file (current változó tárolja a jelenlegi sort a forrásfile-ban)
                        string current = sr.ReadLine();

                        // differentiate the 4 special character used in the keys (a kulcsokban használt 4 speciális karakter megkülönböztetése)
                        current = current.Replace(@"\\", @"\");
                        current = current.Replace(@"&&", @"&");
                        current = current.Replace(@"$$", @"$");
                        current = current.Replace(@"%%", @"%");

                        // decompress tags and properties (tagek és tulajdonságok visszafejtése)
                        for (int i = compressData.Count - 1; i >= 0; i--)
                        {
                            // simply change the keys to the original tag/property (egyszerűen a kulcsok kicserélése a tagre/tulajdonságra)
                            current = current.Replace(compressData[i][1], compressData[i][0]);
                        }
                        // writing out the decompressed line to the file (visszafejtett sor kiírása fileba)
                        sw.WriteLine(current);
                    }
                    // closing the reader and writer objects (olvasó és író objektum lezárása)
                    sw.Close();
                    sr.Close();

                    // succesful decompressing (sikeres visszafejtés)
                    MessageBox.Show("Kész!");
                }
                else
                {
                    // error if the source file doesn't exists (hiba, ha a forrás file nem létezik)
                    MessageBox.Show("A megadott file nem létezik: " + source, "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // general error catching, preventing the program to stop (általános hiba elkapás, a program leállásának elkerülése érdekében)
                MessageBox.Show("Hiba: " + ex.Message, "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
