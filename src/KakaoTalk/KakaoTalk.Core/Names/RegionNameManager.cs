using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KakaoTalk.Core.Enums;

namespace KakaoTalk.Core.Names
{
    public class RegionNameManager
    {
        public static string MainRegion => nameof(Regions.MainRegion);
        public static string ContentRegion => nameof(Regions.ContentRegion);
    }
}
