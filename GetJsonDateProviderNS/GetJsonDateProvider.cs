using Newtonsoft.Json;

namespace GetJsonDateProviderNS;

public static class GetJsonDateProvider
{
    public static string GetJsonDate(this DateTimeOffset dateTimeOffset)
    {
        return JsonConvert.SerializeObject(value: dateTimeOffset);
    }

    public static string GetJsonTimeSpan(this TimeSpan timeSpan)
    {
        return JsonConvert.SerializeObject(value: timeSpan);
    }
}