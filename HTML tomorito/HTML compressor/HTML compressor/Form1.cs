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
            addCompressText("<A", @"\!");
            addCompressText("<B", @"\#");
            addCompressText("<I", @"\$");
            addCompressText("<P", @"\%");
            addCompressText("<S", @"\&");
            addCompressText("<U", @"\'");
            addCompressText("ID", @"\(");
            addCompressText("<BR", @"\)");
            addCompressText("<DD", @"\*");
            addCompressText("<DL", @"\+");
            addCompressText("<DT", @"\,");
            addCompressText("<EM", @"\-");
            addCompressText("<H1", @"\.");
            addCompressText("<H2", @"\/");
            addCompressText("<H3", @"\0");
            addCompressText("<H4", @"\1");
            addCompressText("<H5", @"\2");
            addCompressText("<H6", @"\3");
            addCompressText("<HR", @"\4");
            addCompressText("<LI", @"\5");
            addCompressText("<OL", @"\6");
            addCompressText("<TD", @"\7");
            addCompressText("<TH", @"\8");
            addCompressText("<TR", @"\9");
            addCompressText("<TT", @"\:");
            addCompressText("<UL", @"\;");
            addCompressText("</A", @"\<");
            addCompressText("</B", @"\=");
            addCompressText("</I", @"\>");
            addCompressText("</P", @"\?");
            addCompressText("</S", @"\@");
            addCompressText("</U", @"\[");
            addCompressText("ALT", @"\\");
            addCompressText("DIR", @"\]");
            addCompressText("FOR", @"\^");
            addCompressText("LOW", @"\_");
            addCompressText("MAX", @"\`");
            addCompressText("MIN", @"\{");
            addCompressText("REL", @"\|");
            addCompressText("SRC", @"\}");
            addCompressText("<APP", @"\~");
            addCompressText("<BIG", @"\#!");
            addCompressText("<COL", @"\##");
            addCompressText("<DEL", @"\#$");
            addCompressText("<DFN", @"\#%");
            addCompressText("<DIR", @"\#&");
            addCompressText("<DIV", @"\#'");
            addCompressText("<IMG", @"\#(");
            addCompressText("<INS", @"\#)");
            addCompressText("<KBD", @"\#*");
            addCompressText("<MAP", @"\#+");
            addCompressText("<PRE", @"\#,");
            addCompressText("<SUB", @"\#-");
            addCompressText("<SUP", @"\#.");
            addCompressText("<VAR", @"\#/");
            addCompressText("<WBR", @"\#0");
            addCompressText("<XMP", @"\#1");
            addCompressText("</BR", @"\#2");
            addCompressText("</DD", @"\#3");
            addCompressText("</DL", @"\#4");
            addCompressText("</DT", @"\#5");
            addCompressText("</EM", @"\#6");
            addCompressText("</H1", @"\#7");
            addCompressText("</H2", @"\#8");
            addCompressText("</H3", @"\#9");
            addCompressText("</H4", @"\#:");
            addCompressText("</H5", @"\#;");
            addCompressText("</H6", @"\#<");
            addCompressText("</HR", @"\#=");
            addCompressText("</LI", @"\#>");
            addCompressText("</OL", @"\#?");
            addCompressText("</TD", @"\#@");
            addCompressText("</TH", @"\#[");
            addCompressText("</TR", @"\#\");
            addCompressText("</TT", @"\#]");
            addCompressText("</UL", @"\#^");
            addCompressText("CITE", @"\#_");
            addCompressText("COLS", @"\#`");
            addCompressText("DATA", @"\#{");
            addCompressText("FORM", @"\#|");
            addCompressText("HIGH", @"\#}");
            addCompressText("HREF", @"\#~");
            addCompressText("KIND", @"\$!");
            addCompressText("LANG", @"\$#");
            addCompressText("LIST", @"\$$");
            addCompressText("LOOP", @"\$%");
            addCompressText("NAME", @"\$&");
            addCompressText("OPEN", @"\$'");
            addCompressText("ROWS", @"\$(");
            addCompressText("SIZE", @"\$)");
            addCompressText("SPAN", @"\$*");
            addCompressText("STEP", @"\$+");
            addCompressText("TYPE", @"\$,");
            addCompressText("<AREA", @"\$-");
            addCompressText("<BASE", @"\$.");
            addCompressText("<BODY", @"\$/");
            addCompressText("<CITE", @"\$0");
            addCompressText("<CODE", @"\$1");
            addCompressText("<FONT", @"\$2");
            addCompressText("<FORM", @"\$3");
            addCompressText("<HEAD", @"\$4");
            addCompressText("<HTML", @"\$5");
            addCompressText("<HYPE", @"\$6");
            addCompressText("<LINK", @"\$7");
            addCompressText("<MENU", @"\$8");
            addCompressText("<META", @"\$9");
            addCompressText("<NOBR", @"\$:");
            addCompressText("<SAMP", @"\$;");
            addCompressText("<SPAN", @"\$<");
            addCompressText("</APP", @"\$=");
            addCompressText("</BIG", @"\$>");
            addCompressText("</COL", @"\$?");
            addCompressText("</DEL", @"\$@");
            addCompressText("</DFN", @"\$[");
            addCompressText("</DIR", @"\$\");
            addCompressText("</DIV", @"\$]");
            addCompressText("</IMG", @"\$^");
            addCompressText("</INS", @"\$_");
            addCompressText("</KBD", @"\$`");
            addCompressText("</MAP", @"\${");
            addCompressText("</PRE", @"\$|");
            addCompressText("</SUB", @"\$}");
            addCompressText("</SUP", @"\$~");
            addCompressText("</VAR", @"\%!");
            addCompressText("</WBR", @"\%#");
            addCompressText("</XMP", @"\%$");
            addCompressText("ALIGN", @"\%%");
            addCompressText("ASYNC", @"\%&");
            addCompressText("CLASS", @"\%'");
            addCompressText("COLOR", @"\%(");
            addCompressText("DEFER", @"\%)");
            addCompressText("ISMAP", @"\%*");
            addCompressText("LABEL", @"\%+");
            addCompressText("MEDIA", @"\%,");
            addCompressText("MUTED", @"\%-");
            addCompressText("ONCUT", @"\%.");
            addCompressText("SCOPE", @"\%/");
            addCompressText("SHAPE", @"\%0");
            addCompressText("SIZES", @"\%1");
            addCompressText("START", @"\%2");
            addCompressText("STYLE", @"\%3");
            addCompressText("TITLE", @"\%4");
            addCompressText("VALUE", @"\%5");
            addCompressText("WIDTH", @"\%6");
            addCompressText("<BLINK", @"\%7");
            addCompressText("<EMBED", @"\%8");
            addCompressText("<FRAME", @"\%9");
            addCompressText("<INPUT", @"\%:");
            addCompressText("<LABEL", @"\%;");
            addCompressText("<PARAM", @"\%<");
            addCompressText("<SMALL", @"\%=");
            addCompressText("<SOUND", @"\%>");
            addCompressText("<STYLE", @"\%?");
            addCompressText("<TABLE", @"\%@");
            addCompressText("<TBODY", @"\%[");
            addCompressText("<TFOOT", @"\%\");
            addCompressText("<THEAD", @"\%]");
            addCompressText("<TBODY", @"\%^");
            addCompressText("<TFOOT", @"\%_");
            addCompressText("<TITLE", @"\%`");
            addCompressText("</AREA", @"\%{");
            addCompressText("</BASE", @"\%|");
            addCompressText("</BODY", @"\%}");
            addCompressText("</CITE", @"\%~");
            addCompressText("</CODE", @"\&!");
            addCompressText("</FONT", @"\&#");
            addCompressText("</FORM", @"\&$");
            addCompressText("</HEAD", @"\&%");
            addCompressText("</HTML", @"\&&");
            addCompressText("</HYPE", @"\&'");
            addCompressText("</LINK", @"\&(");
            addCompressText("</MENU", @"\&)");
            addCompressText("</META", @"\&*");
            addCompressText("</NOBR", @"\&+");
            addCompressText("</SAMP", @"\&,");
            addCompressText("</SPAN", @"\&-");
            addCompressText("ACCEPT", @"\&.");
            addCompressText("ACTION", @"\&/");
            addCompressText("BORDER", @"\&0");
            addCompressText("COORDS", @"\&1");
            addCompressText("DATA-*", @"\&2");
            addCompressText("HEIGHT", @"\&3");
            addCompressText("HIDDEN", @"\&4");
            addCompressText("METHOD", @"\&5");
            addCompressText("ONBLUR", @"\&6");
            addCompressText("ONCOPY", @"\&7");
            addCompressText("ONDRAG", @"\&8");
            addCompressText("ONDROP", @"\&9");
            addCompressText("ONLOAD", @"\&:");
            addCompressText("ONPLAY", @"\&;");
            addCompressText("POSTER", @"\&<");
            addCompressText("SRCDOC", @"\&=");
            addCompressText("SRCSET", @"\&>");
            addCompressText("TARGET", @"\&?");
            addCompressText("USEMAP", @"\&@");
            addCompressText("<APPLET", @"\&[");
            addCompressText("<BUTTON", @"\&\");
            addCompressText("<CENTER", @"\&]");
            addCompressText("<IFRAME", @"\&^");
            addCompressText("<LEGEND", @"\&_");
            addCompressText("<OPTION", @"\&`");
            addCompressText("<SCRIPT", @"\&{");
            addCompressText("<SELECT", @"\&|");
            addCompressText("<SPACER", @"\&}");
            addCompressText("<STRIKE", @"\&~");
            addCompressText("<STRONG", @"\'!");
            addCompressText("</BLINK", @"\'#");
            addCompressText("</EMBED", @"\'$");
            addCompressText("</FRAME", @"\'%");
            addCompressText("</INPUT", @"\'&");
            addCompressText("</LABEL", @"\''");
            addCompressText("</PARAM", @"\'(");
            addCompressText("</SMALL", @"\')");
            addCompressText("</SOUND", @"\'*");
            addCompressText("</STYLE", @"\'+");
            addCompressText("</TABLE", @"\',");
            addCompressText("</TBODY", @"\'-");
            addCompressText("</TFOOT", @"\'.");
            addCompressText("</THEAD", @"\'/");
            addCompressText("</TBODY", @"\'0");
            addCompressText("</TFOOT", @"\'1");
            addCompressText("</TITLE", @"\'2");
            addCompressText("BGCOLOR", @"\'3");
            addCompressText("CHARSET", @"\'4");
            addCompressText("CHECKED", @"\'5");
            addCompressText("COLSPAN", @"\'6");
            addCompressText("CONTENT", @"\'7");
            addCompressText("DEFAULT", @"\'8");
            addCompressText("DIRNAME", @"\'9");
            addCompressText("ENCTYPE", @"\':");
            addCompressText("HEADERS", @"\';");
            addCompressText("ONABORT", @"\'<");
            addCompressText("ONCLICK", @"\'=");
            addCompressText("ONENDED", @"\'>");
            addCompressText("ONERROR", @"\'?");
            addCompressText("ONFOCUS", @"\'@");
            addCompressText("ONINPUT", @"\'[");
            addCompressText("ONKEYUP", @"\'\");
            addCompressText("ONPASTE", @"\']");
            addCompressText("ONPAUSE", @"\'^");
            addCompressText("ONRESET", @"\'_");
            addCompressText("ONWHEEL", @"\'`");
            addCompressText("OPTIMUM", @"\'{");
            addCompressText("PATTERN", @"\'|");
            addCompressText("PRELOAD", @"\'}");
            addCompressText("ROWSPAN", @"\'~");
            addCompressText("SANDBOX", @"\(!");
            addCompressText("SRCLANG", @"\(#");
            addCompressText("<ADDRESS", @"\($");
            addCompressText("<BGSOUND", @"\(%");
            addCompressText("<CAPTION", @"\(&");
            addCompressText("<COMMENT", @"\('");
            addCompressText("<ISINDEX", @"\((");
            addCompressText("<LISTING", @"\()");
            addCompressText("<MARQUEE", @"\(*");
            addCompressText("<NOEMBED", @"\(+");
            addCompressText("</APPLET", @"\(,");
            addCompressText("</BUTTON", @"\(-");
            addCompressText("</CENTER", @"\(.");
            addCompressText("</IFRAME", @"\(/");
            addCompressText("</LEGEND", @"\(0");
            addCompressText("</OPTION", @"\(1");
            addCompressText("</SCRIPT", @"\(2");
            addCompressText("</SELECT", @"\(3");
            addCompressText("</SPACER", @"\(4");
            addCompressText("</STRIKE", @"\(5");
            addCompressText("</STRONG", @"\(6");
            addCompressText("AUTOPLAY", @"\(7");
            addCompressText("CONTROLS", @"\(8");
            addCompressText("DATETIME", @"\(9");
            addCompressText("DISABLED", @"\(:");
            addCompressText("DOWNLOAD", @"\(;");
            addCompressText("DROPZONE", @"\(<");
            addCompressText("HREFLANG", @"\(=");
            addCompressText("MULTIPLE", @"\(>");
            addCompressText("ONCHANGE", @"\(?");
            addCompressText("ONONLINE", @"\(@");
            addCompressText("ONRESIZE", @"\([");
            addCompressText("ONSCROLL", @"\(\");
            addCompressText("ONSEARCH", @"\(]");
            addCompressText("ONSEEKED", @"\(^");
            addCompressText("ONSELECT", @"\(_");
            addCompressText("ONSUBMIT", @"\(`");
            addCompressText("ONTOGGLE", @"\({");
            addCompressText("ONUNLOAD", @"\(|");
            addCompressText("READONLY", @"\(}");
            addCompressText("REQUIRED", @"\(~");
            addCompressText("REVERSED", @"\)!");
            addCompressText("SELECTED", @"\)#");
            addCompressText("TABINDEX", @"\)$");
            addCompressText("<!DOCTYPE", @"\)%");
            addCompressText("<BASEFONT", @"\)&");
            addCompressText("<COLGROUP", @"\)'");
            addCompressText("<FIELDSET", @"\)(");
            addCompressText("<FRAMESET", @"\))");
            addCompressText("<HTMLPLUS", @"\)*");
            addCompressText("<MULTICOL", @"\)+");
            addCompressText("<NOFRAMES", @"\),");
            addCompressText("<NOSCRIPT", @"\)-");
            addCompressText("<TEXTAREA", @"\).");
            addCompressText("</ADDRESS", @"\)/");
            addCompressText("</BGSOUND", @"\)0");
            addCompressText("</CAPTION", @"\)1");
            addCompressText("</COMMENT", @"\)2");
            addCompressText("</ISINDEX", @"\)3");
            addCompressText("</LISTING", @"\)4");
            addCompressText("</MARQUEE", @"\)5");
            addCompressText("</NOEMBED", @"\)6");
            addCompressText("ACCESSKEY", @"\)7");
            addCompressText("AUTOFOCUS", @"\)8");
            addCompressText("DRAGGABLE", @"\)9");
            addCompressText("MAXLENGTH", @"\):");
            addCompressText("ONCANPLAY", @"\);");
            addCompressText("ONDRAGEND", @"\)<");
            addCompressText("ONEMPTIED", @"\)=");
            addCompressText("ONINVALID", @"\)>");
            addCompressText("ONKEYDOWN", @"\)?");
            addCompressText("ONMOUSEUP", @"\)@");
            addCompressText("ONOFFLINE", @"\)[");
            addCompressText("ONPLAYING", @"\)\");
            addCompressText("ONSEEKING", @"\)]");
            addCompressText("ONSTALLED", @"\)^");
            addCompressText("ONSTORAGE", @"\)_");
            addCompressText("ONSUSPEND", @"\)`");
            addCompressText("ONWAITING", @"\){");
            addCompressText("TRANSLATE", @"\)|");
            addCompressText("<PLAINTEXT", @"\)}");
            addCompressText("</!DOCTYPE", @"\)~");
            addCompressText("</BASEFONT", @"\*!");
            addCompressText("</COLGROUP", @"\*#");
            addCompressText("</FIELDSET", @"\*$");
            addCompressText("</FRAMESET", @"\*%");
            addCompressText("</HTMLPLUS", @"\*&");
            addCompressText("</MULTICOL", @"\*'");
            addCompressText("</NOFRAMES", @"\*(");
            addCompressText("</NOSCRIPT", @"\*)");
            addCompressText("</TEXTAREA", @"\**");
            addCompressText("FORMACTION", @"\*+");
            addCompressText("HTTP-EQUIV", @"\*,");
            addCompressText("NOVALIDATE", @"\*-");
            addCompressText("ONDBLCLICK", @"\*.");
            addCompressText("ONDRAGOVER", @"\*/");
            addCompressText("ONKEYPRESS", @"\*0");
            addCompressText("ONMOUSEOUT", @"\*1");
            addCompressText("ONPAGEHIDE", @"\*2");
            addCompressText("ONPAGESHOW", @"\*3");
            addCompressText("ONPOPSTATE", @"\*4");
            addCompressText("ONPROGRESS", @"\*5");
            addCompressText("SPELLCHECK", @"\*6");
            addCompressText("<BLOCKQUOTE", @"\*7");
            addCompressText("</PLAINTEXT", @"\*8");
            addCompressText("ONCUECHANGE", @"\*9");
            addCompressText("ONDRAGENTER", @"\*:");
            addCompressText("ONDRAGLEAVE", @"\*;");
            addCompressText("ONDRAGSTART", @"\*<");
            addCompressText("ONLOADSTART", @"\*=");
            addCompressText("ONMOUSEDOWN", @"\*>");
            addCompressText("ONMOUSEMOVE", @"\*?");
            addCompressText("ONMOUSEOVER", @"\*@");
            addCompressText("PLACEHOLDER", @"\*[");
            addCompressText("</BLOCKQUOTE", @"\*\");
            addCompressText("AUTOCOMPLETE", @"\*]");
            addCompressText("ONAFTERPRINT", @"\*^");
            addCompressText("ONHASHCHANGE", @"\*_");
            addCompressText("ONLOADEDDATA", @"\*`");
            addCompressText("ONMOUSEWHEEL", @"\*{");
            addCompressText("ONRATECHANGE", @"\*|");
            addCompressText("ONTIMEUPDATE", @"\*}");
            addCompressText("ONBEFOREPRINT", @"\*~");
            addCompressText("ONCONTEXTMENU", @"\+!");
            addCompressText("ACCEPT-CHARSET", @"\+#");
            addCompressText("ONBEFOREUNLOAD", @"\+$");
            addCompressText("ONVOLUMECHANGE", @"\+%");
            addCompressText("CONTENTEDITABLE", @"\+&");
            addCompressText("ONCANPLAYTHROUGH", @"\+'");
            addCompressText("ONDURATIONCHANGE", @"\+(");
            addCompressText("ONLOADEDMETADATA", @"\+)");
            addCompressText("WRAP", @"\+*");
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
            StreamReader sr = null;
            StreamWriter sw = null;
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
                    sr = new StreamReader(source, Encoding.GetEncoding("ISO-8859-2"));
                    sw = new StreamWriter(new FileStream(destination, FileMode.OpenOrCreate, FileAccess.ReadWrite), Encoding.UTF8);

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
            finally
            {
                    // closing the reader and writer objects (olvasó és író objektum lezárása)
                sw.Close();
                sr.Close();
            }
        }

        private void deCompress()
        {
            StreamReader sr = null;
            StreamWriter sw = null;
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
                    sr = new StreamReader(source, Encoding.GetEncoding("ISO-8859-2"));
                    sw = new StreamWriter(new FileStream(destination, FileMode.OpenOrCreate, FileAccess.ReadWrite), Encoding.UTF8);

                    // iterating trough source file (végigiterálás a forrásfile-on)
                    while (!sr.EndOfStream)
                    {
                        // current variable stores the current line in the source file (current változó tárolja a jelenlegi sort a forrásfile-ban)
                        string current = sr.ReadLine();
                        
                        // decompress tags and properties (tagek és tulajdonságok visszafejtése)
                        for (int i = compressData.Count - 1; i >= 0; i--)
                        {
                            // simply change the keys to the original tag/property (egyszerűen a kulcsok kicserélése a tagre/tulajdonságra)
                            current = current.Replace(compressData[i][1], compressData[i][0]);
                        }
                        // writing out the decompressed line to the file (visszafejtett sor kiírása fileba)
                        sw.WriteLine(current);
                    }
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
            finally
            {
                // closing the reader and writer objects (olvasó és író objektum lezárása)
                sw.Close();
                sr.Close();
            }
        }
    }
}
