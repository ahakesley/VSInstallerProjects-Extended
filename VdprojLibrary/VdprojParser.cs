using System.IO;
using System.Text.RegularExpressions;

namespace SetupProjectHelper.VdprojLibrary;

public class VdprojParser
{
    private static readonly Regex KeyValuePattern = new(@"""([^""]+)""\s*=\s*""(\d+):(.*)""", RegexOptions.Compiled);

    private static readonly Regex NodeNameOnlyPattern = new(@"^""([^""]+)""\s*$", RegexOptions.Compiled);

    public VdprojNode Parse(string[] lines)
    {
        Stack<VdprojNode> stack = new();
        VdprojNode? root = null;
        
        foreach (var raw in lines)
        {
            var line = raw.Trim();
            if (string.IsNullOrWhiteSpace(line))
            {
                continue;
            }

            if (line == "}")
            {
                var node = stack.Pop();
                if (stack.Count == 0)
                {
                    root = node;
                }
                else
                {
                    stack.Peek().Children.Add(node);
                }
            }
            else if (NodeNameOnlyPattern.IsMatch(line))
            {
                var match = NodeNameOnlyPattern.Match(line);
                var node = new VdprojNode() { Name = match.Groups[1].Value };
                stack.Push(node);
            }
            else if (KeyValuePattern.IsMatch(line))
            {
                var match = KeyValuePattern.Match(line);
                string key = match.Groups[1].Value;
                string value = match.Groups[3].Value;
                stack.Peek().Properties[key] = value;
            }
        }

        return root ?? throw new InvalidDataException("Invalid .vdproj structure");
    }
}