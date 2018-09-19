using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using FanartTv.Types;

namespace FanartTv.TV
{
  /// <summary>
  /// Get images for a Show
  /// </summary>
  public class Show
  {
    /// <summary>
    /// List of images for a Show
    /// </summary>
    public TvData List { get; set; }

    /// <summary>
    /// Get images for a Show
    /// </summary>
    /// <param name="theTvBbId">thetvdb id for the show.</param>
    public Show(string theTvBbId)
    {
      List = Info(theTvBbId, API.Key, API.cKey);
    }

    /// <summary>
    /// Get images for a Show
    /// </summary>
    /// <param name="theTvBbId">thetvdb id for the show.</param>
    /// <param name="apiKey">Users api_key</param>
    public Show(string theTvBbId, string apiKey)
    {
      List = Info(theTvBbId, apiKey, API.cKey);
    }

    /// <summary>
    /// Get images for a Show
    /// </summary>
    /// <param name="theTvBbId">thetvdb id for the show.</param>
    /// <param name="apiKey">Users api_key</param>
    /// <param name="clientKey">Users client_key</param>
    public Show(string theTvBbId, string apiKey, string clientKey)
    {
        List = Info(theTvBbId, apiKey, clientKey);
    }

    /// <summary>
    /// API Result
    /// </summary>
    /// <param name="theTvBbId">thetvdb id for the show.</param>
    /// <param name="apiKey">Users api_key</param>
    /// <param name="clientKey">Users client_key</param>
    /// <returns>List of images for a Shows</returns>
    private static TvData Info(string theTvBbId, string apiKey, string clientKey)
    {
      try
      {
        TvData tmp;
        API.ErrorOccurred = false;
        API.ErrorMessage = string.Empty;

        var json = clientKey != "" ? Helper.Json.GetJson(API.Server + "tv/" + theTvBbId + "?api_key=" + apiKey) : Helper.Json.GetJson(API.Server + "tv/" + theTvBbId + "?api_key=" + apiKey + "&client_key=" + clientKey);

        if (API.ErrorOccurred)
          return new TvData();

        using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
        {
          var settings = new DataContractJsonSerializerSettings { UseSimpleDictionaryFormat = true };
          var serializer = new DataContractJsonSerializer(typeof(TvData), settings);
          tmp = (TvData)serializer.ReadObject(ms);
        }
        return tmp ?? new TvData();
      }
      catch (Exception ex)
      {
        API.ErrorOccurred = true;
        API.ErrorMessage = ex.Message;
        return new TvData();
      }
    }
  }  
}


