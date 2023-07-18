using CodeShop.Shared.Generator;
using System.Diagnostics;
using System.IO;

namespace CodeShop.Generator;

/// <summary>
/// Summary description for FileGenerator.
/// </summary>
public class FileGenerator
{
    public delegate void OnFileGenerationCompletedEventHandler();

    public static event OnFileGenerationCompletedEventHandler OnFileGenerationCompleted;

    public static void Generate(TemplateModel model, string inputDir, string outputDir)
    {
        var directoryInfo = new DirectoryInfo(inputDir);
        foreach (var fileInfo in directoryInfo.GetFiles())
        {
            string fileContent;
            using (var streamReader = File.OpenText(fileInfo.FullName))
            {
                fileContent = streamReader.ReadToEnd();
                streamReader.Close();
            }

            string generatedCode = TemplateParser.Parse(model, fileContent);
            string fileName = TemplateParser.Parse(model, fileInfo.Name.Replace("^", "|"));

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

        OnFileGenerationCompleted?.Invoke();
    }
}