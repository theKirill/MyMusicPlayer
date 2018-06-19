using AngleSharp.Dom.Html;

namespace Музыкальный_плеер
{
    interface IParser
    {
        string BaseURL
        {
            get;
            set;
        }
        string Parse(IHtmlDocument document);
    }
}