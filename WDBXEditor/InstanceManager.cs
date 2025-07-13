using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;

namespace WDBXEditor;

public class InstanceManager
{
    public static ConcurrentQueue<string> AutoRun = [];

    public static IEnumerable<string> GetFilesToOpen()
    {
        HashSet<string> files = [];

        while (!AutoRun.IsEmpty)
        {
            if (AutoRun.TryDequeue(out string file) && File.Exists(file))
                files.Add(file);
        }

        return files;
    }
}
