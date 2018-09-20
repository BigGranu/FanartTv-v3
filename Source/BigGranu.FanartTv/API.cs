namespace FanartTv
{
  public class API
  {
    /// <summary>
    /// The current API key
    /// </summary>
    public static string Key = "91b020d36e832bf14efc3a33c165994e";
    
    /// <summary>
    /// The current client_API key
    /// </summary>
    public static string cKey = "";

    /// <summary>
    /// The current Server
    /// </summary>
    public static string Server = "http://webservice.fanart.tv/v3/";

    /// <summary>
    /// Is an Error occurred
    /// </summary>
    public static bool ErrorOccurred = false;

    /// <summary>
    /// Error Message
    /// </summary>
    public static string ErrorMessage = string.Empty;

    private static bool _proxy;

    /// <summary>
    /// Transparent Proxy
    /// </summary>
    public static bool Proxy
    {
      get { return _proxy; }
      set
      {
        _proxy = value;  
       Server = _proxy ? "http://fanarttv.apiary-proxy.com/v3/" : "http://webservice.fanart.tv/v3/";
      }
    }

  }
}
