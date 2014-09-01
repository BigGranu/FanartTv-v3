namespace FanartTv
{
  public class API
  {
    /// <summary>
    /// The current API key
    /// </summary>
    public static string Key = "91b020d36e832bf14efc3a33c165994e";

    /// <summary>
    /// The current Server
    /// </summary>
    public static string Server = "http://webservice.fanart.tv/v3/";

    /// <summary>
    /// Defined a new API
    /// </summary>
    /// <param name="apiKey">Your Fanart.Tv API key</param>
    public API(string apiKey)
    {
      Key = apiKey;
    }

    /// <summary>
    /// Defined a new API
    /// </summary>
    /// <param name="apiKey">Your Fanart.Tv API key</param>
    /// <param name="proxy">Transparent Proxy</param>
    public API(string apiKey, bool proxy)
    {
      Key = apiKey;
      Server = proxy ? "http://fanarttv.apiary-proxy.com/v3/" : "http://webservice.fanart.tv/v3/";
    }

    /// <summary>
    /// Defined a new API
    /// </summary>
    /// <param name="proxy">Transparent Proxy</param>
    public API(bool proxy)
    {
      Server = proxy ? "http://fanarttv.apiary-proxy.com/v3/" : "http://webservice.fanart.tv/v3/";
    }
  }
}
