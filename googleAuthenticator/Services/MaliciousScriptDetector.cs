using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoogleAuthentication.Services
{
    public class MaliciousScriptDetector
    {
        private static readonly string[] BlacklistPatterns = new[]
        {
            "select *", "drop table", "--", ";--", "xp_cmdshell", "exec", "insert into",
            "script>", "<script>", "alert(", "onerror=", "onload=", "||", "&&", "`", "$(", "|"
        };

        public static bool IsMalicious(string input, out string matchedPattern)
        {
            foreach (var pattern in BlacklistPatterns)
            {
                if (!string.IsNullOrWhiteSpace(input) &&
                    input.ToLower().Contains(pattern.ToLower()))
                {
                    matchedPattern = pattern;
                    return true;
                }
            }

            matchedPattern = null;
            return false;
        }
    }
}