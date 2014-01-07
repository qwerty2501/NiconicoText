using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    public static class NiconicoTextPatterns
    {
        #region Public

        public static string VideoIdPattern
        {
            get
            {
                return videoIdPattern;
            }
        }

        #endregion


        #region captures

        internal const string channelIdCapture = nameStart + "channelId" + nameEnd + channelIdPattern + parenthesisEnd;
        
        internal const string communityIdCapture = nameStart + "communityId" + nameEnd + communityIdPattern + parenthesisEnd;

        



        

        #endregion

        #region patterns

        private const string communityIdPattern = "\\bco\\d{1,14}\\b";

        private const string channelIdPattern = "\\bch\\d{1,14}\\b";

        private const string videoIdPattern = "\\b(?:sm|nm|so|ca|ax|yo|nl|ig|na|cw|z[a-e]|om|sk|yk)\\d{1,14}\\b";

        #endregion

        #region partial

        private const string nameStart = "(?<";

        private const string nameEnd = ">";

        private const string parenthesisEnd = ")";

        #endregion
    }
}
