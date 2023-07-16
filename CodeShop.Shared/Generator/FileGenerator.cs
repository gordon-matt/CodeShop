using System.Diagnostics;
using System.IO;
using CodeShop.Shared.Generator;

namespace CodeShop.Generator;

/// <summary>
/// Summary description for FileGenerator.
/// </summary>
public class FileGenerator
{
    public event EventHandler OnComplete;

    public void Generate(TemplateModel model, string inputDir, string outputDir)
    {
        var client = new Client();

        var directoryInfo = new DirectoryInfo(inputDir);
        foreach (var fileInfo in directoryInfo.GetFiles())
        {
            string fileContent;
            using (var streamReader = File.OpenText(fileInfo.FullName))
            {
                fileContent = streamReader.ReadToEnd();
                streamReader.Close();
            }

            string generatedCode = client.Parse(model, fileContent);
            string fileName = client.Parse(model, fileInfo.Name);

            try
            {
                using var streamWriter = new StreamWriter($"{outputDir}{Path.DirectorySeparatorChar}{fileName}");
                streamWriter.Write(generatedCode);
            }
            catch (Exception x)
            {
                Debug.WriteLine(x);
            }
        }

        OnComplete?.Invoke(this, new EventArgs());
    }
}