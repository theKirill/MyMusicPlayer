using AngleSharp.Parser.Html;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Музыкальный_плеер
{
    class ParserWorker
    {
        IParser parser;
        HtmlLoader loader;
        string result;

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
            Match match = regex.Match(result);
            result = match.Value;//нахождение ссылки на mp3 файл
        }

        public async void Start(ListenSongFromSite form)
        {
            try
            {
                loader = new HtmlLoader(parser);
                var source = await loader.GetSourceByPage();//для хранения исходного кода страницы
                var domParser = new HtmlParser();
                var document = await domParser.ParseAsync(source);//парсинг исходного кода, получение документа, с которым можно работать
                result = parser.Parse(document);//запись в переменную "result" HTML-кода полученного элемента
                ReturnResult();//в result будет искаться ссылка на mp3 файл 
                form.Close();
            }
            catch
            {
                MessageBox.Show("К сожалению, песен по данному URL-адресу не найдено!");
            }
        }
    }
}