using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using FanartTv.Types;

namespace FanartTv.Movies
{
  /// <summary>
  /// Get images for Latest Movies
  /// </summary>
  public class Latest
  {
    /// <summary>
    /// List of images for Latest Movies
    /// </summary>
    public List<MovieLatest> List { get; set; }

    /// <summary>
    /// Get images Latest Movies
    /// </summary>
    public Latest()
    {
      List = Info(API.Key);
    }

    /// <summary>
    /// Get images Latest Movies
    /// </summary>
    /// <param name="apiKey">Users api_key</param>
    public Latest(string apiKey)
    {
      List = Info(apiKey);
    }

    /// <summary>
    /// API Result
    /// </summary>
    /// <param name="apiKey">Users api_key</param>
    /// <returns>List of images for Latest Movies</returns>
    private List<MovieLatest> Info(string apiKey)
    {
      try
      {
        List<MovieLatest> tmp;

        using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(Helper.Json.GetJson(API.Server + "movies/latest" + "?api_key=" + apiKey))))
        {
          var settings = new DataContractJsonSerializerSettings { UseSimpleDictionaryFormat = true };
          var serializer = new DataContractJsonSerializer(typeof(List<MovieLatest>), settings);
          tmp = (List<MovieLatest>)serializer.ReadObject(ms);
        }
        return tmp ?? new List<MovieLatest>();
      }
      catch (Exception)
      {
        return new List<MovieLatest>();
      }
    }
  }
}
