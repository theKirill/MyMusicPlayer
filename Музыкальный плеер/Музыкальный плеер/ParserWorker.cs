using AngleSharp.Parser.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Музыкальный_плеер
{
    class ParserWorker
    {
        IParser parser;

        HtmlLoader loader;

        bool isActive;

        #region Properties

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

        public bool IsActive
        {
            get
            {
                return isActive;
            }
        }

        #endregion

        public event Action<object, string> OnNewData;
        public event Action<object> OnCompleted;

        public ParserWorker(IParser parser)
        {
            this.parser = parser;
        }

        public void Start()
        {
            isActive = true;
            Worker();
        }

        public void Abort()
        {
            isActive = false;
        }

        private async void Worker()
        {
            var source = await loader.GetSourceByPageId();
            var domParser = new HtmlParser();
            var document = await domParser.ParseAsync(source);
            string result = parser.Parse(document);
        }
    }
}
