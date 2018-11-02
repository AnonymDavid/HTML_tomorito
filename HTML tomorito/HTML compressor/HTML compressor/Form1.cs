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
            addCompressText("<A", @"\0");
            addCompressText("<B", @"\1");
            addCompressText("<I", @"\2");
            addCompressText("<P", @"\3");
            addCompressText("<S", @"\4");
            addCompressText("<U", @"\5");
            addCompressText("id", @"\6");
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
            addCompressText("alt", @"\32");
            addCompressText("dir", @"\33");
            addCompressText("for", @"\34");
            addCompressText("low", @"\35");
            addCompressText("max", @"\36");
            addCompressText("min", @"\37");
            addCompressText("rel", @"\38");
            addCompressText("src", @"\39");
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
            addCompressText("cite", @"\76");
            addCompressText("cols", @"\77");
            addCompressText("data", @"\78");
            addCompressText("form", @"\79");
            addCompressText("high", @"\80");
            addCompressText("href", @"\81");
            addCompressText("kind", @"\82");
            addCompressText("lang", @"\83");
            addCompressText("list", @"\84");
            addCompressText("loop", @"\85");
            addCompressText("name", @"\86");
            addCompressText("open", @"\87");
            addCompressText("rows", @"\88");
            addCompressText("size", @"\89");
            addCompressText("span", @"\90");
            addCompressText("step", @"\91");
            addCompressText("type", @"\92");
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
            addCompressText("align", @"&26");
            addCompressText("async", @"&27");
            addCompressText("class", @"&28");
            addCompressText("color", @"&29");
            addCompressText("defer", @"&30");
            addCompressText("ismap", @"&31");
            addCompressText("label", @"&32");
            addCompressText("media", @"&33");
            addCompressText("muted", @"&34");
            addCompressText("oncut", @"&35");
            addCompressText("scope", @"&36");
            addCompressText("shape", @"&37");
            addCompressText("sizes", @"&38");
            addCompressText("start", @"&39");
            addCompressText("style", @"&40");
            addCompressText("title", @"&41");
            addCompressText("value", @"&42");
            addCompressText("width", @"&43");
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
            addCompressText("accept", @"&76");
            addCompressText("action", @"&77");
            addCompressText("border", @"&78");
            addCompressText("coords", @"&79");
            addCompressText("data-*", @"&80");
            addCompressText("height", @"&81");
            addCompressText("hidden", @"&82");
            addCompressText("method", @"&83");
            addCompressText("onblur", @"&84");
            addCompressText("oncopy", @"&85");
            addCompressText("ondrag", @"&86");
            addCompressText("ondrop", @"&87");
            addCompressText("onload", @"&88");
            addCompressText("onplay", @"&89");
            addCompressText("poster", @"&90");
            addCompressText("srcdoc", @"&91");
            addCompressText("srcset", @"&92");
            addCompressText("target", @"&93");
            addCompressText("usemap", @"&94");
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
            addCompressText("bgcolor", @"$22");
            addCompressText("charset", @"$23");
            addCompressText("checked", @"$24");
            addCompressText("colspan", @"$25");
            addCompressText("content", @"$26");
            addCompressText("default", @"$27");
            addCompressText("dirname", @"$28");
            addCompressText("enctype", @"$29");
            addCompressText("headers", @"$30");
            addCompressText("onabort", @"$31");
            addCompressText("onclick", @"$32");
            addCompressText("onended", @"$33");
            addCompressText("onerror", @"$34");
            addCompressText("onfocus", @"$35");
            addCompressText("oninput", @"$36");
            addCompressText("onkeyup", @"$37");
            addCompressText("onpaste", @"$38");
            addCompressText("onpause", @"$39");
            addCompressText("onreset", @"$40");
            addCompressText("onwheel", @"$41");
            addCompressText("optimum", @"$42");
            addCompressText("pattern", @"$43");
            addCompressText("preload", @"$44");
            addCompressText("rowspan", @"$45");
            addCompressText("sandbox", @"$46");
            addCompressText("srclang", @"$47");
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
            addCompressText("autoplay", @"$67");
            addCompressText("controls", @"$68");
            addCompressText("datetime", @"$69");
            addCompressText("disabled", @"$70");
            addCompressText("download", @"$71");
            addCompressText("dropzone", @"$72");
            addCompressText("hreflang", @"$73");
            addCompressText("multiple", @"$74");
            addCompressText("onchange", @"$75");
            addCompressText("ononline", @"$76");
            addCompressText("onresize", @"$77");
            addCompressText("onscroll", @"$78");
            addCompressText("onsearch", @"$79");
            addCompressText("onseeked", @"$80");
            addCompressText("onselect", @"$81");
            addCompressText("onsubmit", @"$82");
            addCompressText("ontoggle", @"$83");
            addCompressText("onunload", @"$84");
            addCompressText("readonly", @"$85");
            addCompressText("required", @"$86");
            addCompressText("reversed", @"$87");
            addCompressText("selected", @"$88");
            addCompressText("tabindex", @"$89");
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
            addCompressText("accesskey", @"%8");
            addCompressText("autofocus", @"%9");
            addCompressText("draggable", @"%10");
            addCompressText("maxlength", @"%11");
            addCompressText("oncanplay", @"%12");
            addCompressText("ondragend", @"%13");
            addCompressText("onemptied", @"%14");
            addCompressText("oninvalid", @"%15");
            addCompressText("onkeydown", @"%16");
            addCompressText("onmouseup", @"%17");
            addCompressText("onoffline", @"%18");
            addCompressText("onplaying", @"%19");
            addCompressText("onseeking", @"%20");
            addCompressText("onstalled", @"%21");
            addCompressText("onstorage", @"%22");
            addCompressText("onsuspend", @"%23");
            addCompressText("onwaiting", @"%24");
            addCompressText("translate", @"%25");
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
            addCompressText("formaction", @"%37");
            addCompressText("http-equiv", @"%38");
            addCompressText("novalidate", @"%39");
            addCompressText("ondblclick", @"%40");
            addCompressText("ondragover", @"%41");
            addCompressText("onkeypress", @"%42");
            addCompressText("onmouseout", @"%43");
            addCompressText("onpagehide", @"%44");
            addCompressText("onpageshow", @"%45");
            addCompressText("onpopstate", @"%46");
            addCompressText("onprogress", @"%47");
            addCompressText("spellcheck", @"%48");
            addCompressText("<BLOCKQUOTE", @"%49");
            addCompressText("</PLAINTEXT", @"%50");
            addCompressText("oncuechange", @"%51");
            addCompressText("ondragenter", @"%52");
            addCompressText("ondragleave", @"%53");
            addCompressText("ondragstart", @"%54");
            addCompressText("onloadstart", @"%55");
            addCompressText("onmousedown", @"%56");
            addCompressText("onmousemove", @"%57");
            addCompressText("onmouseover", @"%58");
            addCompressText("placeholder", @"%59");
            addCompressText("</BLOCKQUOTE", @"%60");
            addCompressText("autocomplete", @"%61");
            addCompressText("onafterprint", @"%62");
            addCompressText("onhashchange", @"%63");
            addCompressText("onloadeddata", @"%64");
            addCompressText("onmousewheel", @"%65");
            addCompressText("onratechange", @"%66");
            addCompressText("ontimeupdate", @"%67");
            addCompressText("onbeforeprint", @"%68");
            addCompressText("oncontextmenu", @"%69");
            addCompressText("accept-charset", @"%70");
            addCompressText("onbeforeunload", @"%71");
            addCompressText("onvolumechange", @"%72");
            addCompressText("contenteditable", @"%73");
            addCompressText("oncanplaythrough", @"%74");
            addCompressText("ondurationchange", @"%75");
            addCompressText("onloadedmetadata", @"%76");
            addCompressText("wrap", @"%77");

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
                        current = current.TrimStart(' ');
                        current = current.TrimStart('\t');
                        if (current != "")
                        {
                            current = current.Replace(@"\", @"\\");
                            current = current.Replace(@"&", @"&&");
                            current = current.Replace(@"$", @"$$");
                            current = current.Replace(@"%", @"%%");

                            string upperCurrent = current.ToUpper();
                            for (int i = compressData.Count - 1; i >= 0; i--)
                            {
                                while (upperCurrent.Contains(compressData[i][0]))
                                {
                                    current = current.Replace(current.Substring(upperCurrent.IndexOf(compressData[i][0]), compressData[i][0].Length), compressData[i][1]);
                                    upperCurrent = current.ToUpper();
                                }
                            }
                            sw.WriteLine(current);
                        }
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
                        current = current.Replace(@"&&", @"&");
                        current = current.Replace(@"$$", @"$");
                        current = current.Replace(@"%%", @"%");

                        for (int i = compressData.Count - 1; i >= 0; i--)
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
