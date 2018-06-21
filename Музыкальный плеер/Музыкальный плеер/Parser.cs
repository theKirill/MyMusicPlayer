using System.Linq;
using AngleSharp.Dom.Html;
namespace Музыкальный_плеер
{
    class Parser : IParser
    {
        string baseURL;

        public string BaseURL
        {
            get
            {
                return baseURL;
            }
            set
            {
                baseURL = value;
            }
        }

        string IParser.Parse(IHtmlDocument document)
        {
            var items = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("button-download__link"));//получение из html-документа элементов с тегом "a" 

            return items.ToArray()[0].OuterHtml;//возврат HTML-кода полученного элемента
        }
    }
}