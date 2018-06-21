using AngleSharp.Dom.Html;

namespace Музыкальный_плеер
{
    interface IParser
    {
        string BaseURL { get; set; }//ссылка на страницу с песней

        string Parse(IHtmlDocument document);
    }
}