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

            #region tagek
            addCompressText("<!DOCTYPE", @"\0");
            addCompressText("<A", @"\0");
            addCompressText("<B", @"\1");
            addCompressText("<I", @"\2");
            addCompressText("<P", @"\3");
            addCompressText("<S", @"\4");
            addCompressText("<U", @"\5");
            addCompressText("<BR", @"\6");
            addCompressText("<DD", @"\7");
            addCompressText("<DL", @"\8");
            addCompressText("<DT", @"\9");
            addCompressText("<EM", @"\10");
            addCompressText("<H1", @"\11");
            addCompressText("<H2", @"\12");
            addCompressText("<H3", @"\13");
            addCompressText("<H4", @"\14");
            addCompressText("<H5", @"\15");
            addCompressText("<H6", @"\16");
            addCompressText("<HR", @"\17");
            addCompressText("<LI", @"\18");
            addCompressText("<OL", @"\19");
            addCompressText("<TD", @"\20");
            addCompressText("<TH", @"\21");
            addCompressText("<TR", @"\22");
            addCompressText("<TT", @"\23");
            addCompressText("<UL", @"\24");
            addCompressText("</A", @"\25");
            addCompressText("</B", @"\26");
            addCompressText("</I", @"\27");
            addCompressText("</P", @"\28");
            addCompressText("</S", @"\29");
            addCompressText("</U", @"\30");
            addCompressText("<APP", @"\31");
            addCompressText("<BIG", @"\32");
            addCompressText("<COL", @"\33");
            addCompressText("<DEL", @"\34");
            addCompressText("<DFN", @"\35");
            addCompressText("<DIR", @"\36");
            addCompressText("<DIV", @"\37");
            addCompressText("<IMG", @"\38");
            addCompressText("<INS", @"\39");
            addCompressText("<KBD", @"\40");
            addCompressText("<MAP", @"\41");
            addCompressText("<PRE", @"\42");
            addCompressText("<SUB", @"\43");
            addCompressText("<SUP", @"\44");
            addCompressText("<VAR", @"\45");
            addCompressText("<WBR", @"\46");
            addCompressText("<XMP", @"\47");
            addCompressText("</BR", @"\48");
            addCompressText("</DD", @"\49");
            addCompressText("</DL", @"\50");
            addCompressText("</DT", @"\51");
            addCompressText("</EM", @"\52");
            addCompressText("</H1", @"\53");
            addCompressText("</H2", @"\54");
            addCompressText("</H3", @"\55");
            addCompressText("</H4", @"\56");
            addCompressText("</H5", @"\57");
            addCompressText("</H6", @"\58");
            addCompressText("</HR", @"\59");
            addCompressText("</LI", @"\60");
            addCompressText("</OL", @"\61");
            addCompressText("</TD", @"\62");
            addCompressText("</TH", @"\63");
            addCompressText("</TR", @"\64");
            addCompressText("</TT", @"\65");
            addCompressText("</UL", @"\66");
            addCompressText("<AREA", @"\67");
            addCompressText("<BASE", @"\68");
            addCompressText("<BODY", @"\69");
            addCompressText("<CITE", @"\70");
            addCompressText("<CODE", @"\71");
            addCompressText("<FONT", @"\72");
            addCompressText("<FORM", @"\73");
            addCompressText("<HEAD", @"\74");
            addCompressText("<HTML", @"\75");
            addCompressText("<HYPE", @"\76");
            addCompressText("<LINK", @"\77");
            addCompressText("<MENU", @"\78");
            addCompressText("<META", @"\79");
            addCompressText("<NOBR", @"\80");
            addCompressText("<SAMP", @"\81");
            addCompressText("<SPAN", @"\82");
            addCompressText("</APP", @"\83");
            addCompressText("</BIG", @"\84");
            addCompressText("</COL", @"\85");
            addCompressText("</DEL", @"\86");
            addCompressText("</DFN", @"\87");
            addCompressText("</DIR", @"\88");
            addCompressText("</DIV", @"\89");
            addCompressText("</IMG", @"\90");
            addCompressText("</INS", @"\91");
            addCompressText("</KBD", @"\92");
            addCompressText("</MAP", @"\93");
            addCompressText("</PRE", @"\94");
            addCompressText("</SUB", @"\95");
            addCompressText("</SUP", @"\96");
            addCompressText("</VAR", @"\97");
            addCompressText("</WBR", @"\98");
            addCompressText("<BLINK", @"\99");
            addCompressText("<EMBED", @"\100");
            addCompressText("<FRAME", @"\101");
            addCompressText("<INPUT", @"\102");
            addCompressText("<LABEL", @"\103");
            addCompressText("<PARAM", @"\104");
            addCompressText("<SMALL", @"\105");
            addCompressText("<SOUND", @"\106");
            addCompressText("<STYLE", @"\107");
            addCompressText("<TABLE", @"\108");
            addCompressText("<TBODY", @"\109");
            addCompressText("<TFOOT", @"\110");
            addCompressText("<THEAD", @"\111");
            addCompressText("<TBODY", @"\112");
            addCompressText("<TFOOT", @"\113");
            addCompressText("<TITLE", @"\114");
            addCompressText("</AREA", @"\115");
            addCompressText("</BASE", @"\116");
            addCompressText("</BODY", @"\117");
            addCompressText("</CITE", @"\118");
            addCompressText("</CODE", @"\119");
            addCompressText("</FONT", @"\120");
            addCompressText("</FORM", @"\121");
            addCompressText("</HEAD", @"\122");
            addCompressText("</HTML", @"\123");
            addCompressText("</HYPE", @"\124");
            addCompressText("</LINK", @"\125");
            addCompressText("</MENU", @"\126");
            addCompressText("</META", @"\127");
            addCompressText("</NOBR", @"\128");
            addCompressText("</SAMP", @"\129");
            addCompressText("</SPAN", @"\130");
            addCompressText("<APPLET", @"\131");
            addCompressText("<BUTTON", @"\132");
            addCompressText("<CENTER", @"\133");
            addCompressText("<IFRAME", @"\134");
            addCompressText("<LEGEND", @"\135");
            addCompressText("<OPTION", @"\136");
            addCompressText("<SCRIPT", @"\137");
            addCompressText("<SELECT", @"\138");
            addCompressText("<SPACER", @"\139");
            addCompressText("<STRIKE", @"\140");
            addCompressText("<STRONG", @"\141");
            addCompressText("</BLINK", @"\142");
            addCompressText("</EMBED", @"\143");
            addCompressText("</FRAME", @"\144");
            addCompressText("</INPUT", @"\145");
            addCompressText("</LABEL", @"\146");
            addCompressText("</PARAM", @"\147");
            addCompressText("</SMALL", @"\148");
            addCompressText("</SOUND", @"\149");
            addCompressText("</STYLE", @"\150");
            addCompressText("</TABLE", @"\151");
            addCompressText("</TBODY", @"\152");
            addCompressText("</TFOOT", @"\153");
            addCompressText("</THEAD", @"\154");
            addCompressText("</TBODY", @"\155");
            addCompressText("</TFOOT", @"\156");
            addCompressText("</TITLE", @"\157");
            addCompressText("<ADDRESS", @"\158");
            addCompressText("<BGSOUND", @"\159");
            addCompressText("<CAPTION", @"\160");
            addCompressText("<COMMENT", @"\161");
            addCompressText("<ISINDEX", @"\162");
            addCompressText("<LISTING", @"\163");
            addCompressText("<MARQUEE", @"\164");
            addCompressText("<NOEMBED", @"\165");
            addCompressText("</APPLET", @"\166");
            addCompressText("</BUTTON", @"\167");
            addCompressText("</CENTER", @"\168");
            addCompressText("</IFRAME", @"\169");
            addCompressText("</LEGEND", @"\170");
            addCompressText("</OPTION", @"\171");
            addCompressText("</SCRIPT", @"\172");
            addCompressText("</SELECT", @"\173");
            addCompressText("</SPACER", @"\174");
            addCompressText("</STRIKE", @"\175");
            addCompressText("</STRONG", @"\176");
            addCompressText("<!DOCTYPE", @"\177");
            addCompressText("<BASEFONT", @"\178");
            addCompressText("<COLGROUP", @"\179");
            addCompressText("<FIELDSET", @"\180");
            addCompressText("<FRAMESET", @"\181");
            addCompressText("<HTMLPLUS", @"\182");
            addCompressText("<MULTICOL", @"\183");
            addCompressText("<NOFRAMES", @"\184");
            addCompressText("<NOSCRIPT", @"\185");
            addCompressText("<TEXTAREA", @"\186");
            addCompressText("</ADDRESS", @"\187");
            addCompressText("</BGSOUND", @"\188");
            addCompressText("</CAPTION", @"\189");
            addCompressText("</COMMENT", @"\190");
            addCompressText("</ISINDEX", @"\191");
            addCompressText("</LISTING", @"\192");
            addCompressText("</MARQUEE", @"\193");
            addCompressText("</NOEMBED", @"\194");
            addCompressText("<PLAINTEXT", @"\195");
            addCompressText("</!DOCTYPE", @"\196");
            addCompressText("</BASEFONT", @"\197");
            addCompressText("</COLGROUP", @"\198");
            addCompressText("</FIELDSET", @"\199");
            addCompressText("</FRAMESET", @"\200");
            addCompressText("</HTMLPLUS", @"\201");
            addCompressText("</MULTICOL", @"\202");
            addCompressText("</NOFRAMES", @"\203");
            addCompressText("</NOSCRIPT", @"\204");
            addCompressText("</TEXTAREA", @"\205");
            addCompressText("<BLOCKQUOTE", @"\206");
            addCompressText("</PLAINTEXT", @"\207");
            addCompressText("</BLOCKQUOTE", @"\208");
            addCompressText("</XMP", @"\209");
            #endregion
        }

        private void btnForras_Click(object sender, EventArgs e)
        {
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
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "HTML|*.html";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                txtCel.Text = sfd.FileName;
            }
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            compress();
        }

        private void btnDeCompress_Click(object sender, EventArgs e)
        {
            deCompress();
        }

        private void addCompressText(string _base, string _compressed)
        {
            string[] temp = new string[2];
            temp[0] = _base;
            temp[1] = _compressed;
            compressData.Add(temp);
        }

        private void compress()
        {
            try
            {
                source = txtForras.Text;
                destination = txtCel.Text;
                if (source != null && destination != null && File.Exists(source))
                {
                    int l = 0;
                    while (l < destination.Length && destination.IndexOf("\\", l) >= 0)
                        l = destination.IndexOf("\\", l) + 1;
                    if (!Directory.Exists(destination.Substring(0, destination.Length - destination.Substring(l - 1).Length)))
                        Directory.CreateDirectory(destination.Substring(0, destination.Length - destination.Substring(l - 1).Length));

                    StreamReader sr = new StreamReader(source, Encoding.GetEncoding("ISO-8859-2"));
                    StreamWriter sw = new StreamWriter(new FileStream(destination, FileMode.OpenOrCreate, FileAccess.ReadWrite), Encoding.UTF8);
                    while (!sr.EndOfStream)
                    {
                        string current = sr.ReadLine();

                        while (current.Contains("<!--"))
                        {
                            if (current.Contains("-->"))
                            {
                                current = current.Remove(current.IndexOf("<!--"), (current.IndexOf("-->") + 3) - current.IndexOf("<!--"));
                            }
                            else
                            {
                                while (!current.Contains("-->") && !sr.EndOfStream)
                                {
                                    current = sr.ReadLine();
                                }
                                current = current.Remove(0, current.IndexOf("-->") + 3);
                            }
                        }
                        if (current != "")
                        {
                            current = current.TrimStart(' ');
                            current = current.TrimStart('\t');

                            current = current.Replace(@"\", @"\\");

                            string upperCurrent = current.ToUpper();

                            string original = "";
                            for (int i = compressData.Count - 1; i >= 0; i--)
                            {
                                while (upperCurrent.Contains(compressData[i][0]) && original != current)
                                {
                                    original = current;
                                    current = current.Replace(current.Substring(upperCurrent.IndexOf(compressData[i][0]), compressData[i][0].Length), compressData[i][1]);
                                    upperCurrent = current.ToUpper();
                                }
                            }
                        }
                        sw.WriteLine(current);
                    }
                    sw.Close();
                    sr.Close();

                    FileInfo fileBefore = new FileInfo(source);
                    FileInfo fileAfter = new FileInfo(destination);
                    MessageBox.Show(string.Format("Kész!\n\nEredeti méret: {0} B\nTömörített méret: {1} B", fileBefore.Length, fileAfter.Length));
                    
                }
                else
                {
                    MessageBox.Show("A megadott file nem létezik: " + source, "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba: " + ex.Message, "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deCompress()
        {
            try
            {
                source = txtForras.Text;
                destination = txtCel.Text;

                if (source != null && destination != null && File.Exists(source))
                {
                    int l = 0;
                    while (l < destination.Length && destination.IndexOf("\\", l) >= 0)
                        l = destination.IndexOf("\\", l) + 1;
                    if (!Directory.Exists(destination.Substring(0, destination.Length - destination.Substring(l - 1).Length)))
                        Directory.CreateDirectory(destination.Substring(0, destination.Length - destination.Substring(l - 1).Length));

                    StreamReader sr = new StreamReader(source, Encoding.GetEncoding("ISO-8859-2"));
                    StreamWriter sw = new StreamWriter(new FileStream(destination, FileMode.OpenOrCreate, FileAccess.ReadWrite), Encoding.UTF8);
                    while (!sr.EndOfStream)
                    {
                        string current = sr.ReadLine();
                        current = current.Replace(@"\\", @"\");
                        for (int i = compressData.Count - 1; i > 0; i--)
                        {
                            current = current.Replace(compressData[i][1], compressData[i][0]);
                        }
                        sw.WriteLine(current);
                    }
                    sw.Close();
                    sr.Close();

                    MessageBox.Show("Kész!");
                }
                else
                {
                    MessageBox.Show("A megadott file nem létezik: " + source, "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba: " + ex.Message, "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
