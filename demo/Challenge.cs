
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class Challenge
    {
        public static string ShortenPath(string path)
        {
            var result = new StringBuilder();

            var startsWithSlash = !string.IsNullOrEmpty(path) && path[0] == '/';

            var dirData = new List<string>();

            var pathLength = path?.Length ?? 0;

            for (var i = 0; i < pathLength; i++)
            {
                var directory = string.Empty;

                while (i < pathLength && path[i] != '/')
                {
                    directory += path[i];
                    i++;
                }

                switch (directory)
                {
                    case ".." when dirData.Count != 0 && dirData[^1] != "..":
                        dirData.RemoveAt(dirData.Count - 1);
                        break;
                    case "..":
                    {
                        if (!startsWithSlash)
                        {
                            dirData.Add(directory);
                        }

                        break;
                    }
                    case ".":
                    case "":
                        continue;
                    default:
                        dirData.Add(directory);
                        break;
                }
            }

            for (var j = 0; j < dirData.Count; j++)
            {
                if (j == 0)
                {
                    result.Append(startsWithSlash ? $"/{dirData[j]}" : dirData[j]);
                    continue;
                }

                result.Append($"/{dirData[j]}");
            }

            return string.IsNullOrEmpty(result.ToString()) ? "/" : result.ToString();
        }


    }
}
