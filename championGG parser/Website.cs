using System.Net;

namespace championGG_parser
{
    class Website
    {
        #region variables
        private string _URL;

        public string URL
        {
            get
            {
                return _URL;
            }
            set
            {
                _URL = value;
                LoadWebsite();
            }
        }

        public string textHTML
        {
            get;
            set;
        }
        #endregion

        #region constructors
        public Website(string URL)
        {
            this.URL = URL;
            LoadWebsite();

        }

        public Website() { }
        #endregion

        #region functions
        /// <summary>
        /// Loads the website and stores the html into "textHTML" as a string.
        /// </summary>
        void LoadWebsite()
        {
            WebClient wc = new WebClient();
            textHTML = wc.DownloadString(URL).ToLower();
        }
        #endregion
    }
}
