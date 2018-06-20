using AngleSharp.Parser.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Музыкальный_плеер
{
    class ParserWorker
    {
        IParser parser;

        HtmlLoader loader;

        string result;

        public IParser Parser
        {
            get
            {
                return parser;
            }
            set
            {
                parser = value;
            }
        }

        public string Result
        {
            get
            {
                return result;
            }
        }

        public ParserWorker(IParser parser)
        {
            this.parser = parser;
        }

        public void ReturnResult()
        {
            Regex regex = new Regex(@"http\S*mp3");
            //MatchCollection matches = regex.Matches(result);
            Match match = regex.Match(result);
            result = match.Value;
        }

        public async void Start(ListenSongFromSite form)
        {
            try
            {
                loader = new HtmlLoader(parser);
                var source = await loader.GetSourceByPage();
                var domParser = new HtmlParser();
                var document = await domParser.ParseAsync(source);
                result = parser.Parse(document);
                ReturnResult();
                form.Close();
            }
            catch
            {
                MessageBox.Show("К сожалению, песен по данному URL-адресу не найдено!");
            }
        }
    }
}
