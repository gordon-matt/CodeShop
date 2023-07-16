using System.Net.Http;
using System.Net.Http.Json;

namespace CodeShop;

/// <summary>
/// Summary description for UpdateChecker.
/// </summary>
public static class AppVersion
{
    public const string Version = "3.0";

    private static VersionInfo latestVersion;

    public static bool HasNewUpdate => CheckForUpdate();

    public static VersionInfo LatestVersion
    {
        get
        {
            try
            {
                if (latestVersion != null)
                {
                    return latestVersion;
                }

                using var client = new HttpClient();
                client.BaseAddress = new Uri(@"TODO");
                latestVersion = client.GetFromJsonAsync<VersionInfo>("version").Result;
                return latestVersion;
            }
            catch
            {
                return new VersionInfo()
                {
                    Name = "Code Shop",
                    Version = Version,
                };
            }
        }
    }

    private static bool CheckForUpdate()
    {
        return LatestVersion.Version != Version;
    }
}

public class VersionInfo
{
    public string Name { get; set; }

    public string Version { get; set; }
}