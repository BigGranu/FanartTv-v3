using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using FanartTv.Types;

namespace FanartTv.Movies
{
  /// <summary>
  /// Get Images for Movie
  /// </summary>
  public class Movie
  {
    /// <summary>
    /// List of Images for a Movie
    /// </summary>
    public MovieData List { get; set; }

    /// <summary>
    /// Get Images for Movie
    /// </summary>
    /// <param name="imdbTmdbId">Numeric tmdb_id or imdb_id of the movie.</param>
    public Movie(string imdbTmdbId)
    {
      List = Info(imdbTmdbId, API.Key, API.cKey);
    }

    /// <summary>
    /// Get Images for Movie
    /// </summary>
    /// <param name="imdbTmdbId">Numeric tmdb_id or imdb_id of the movie.</param>
    /// <param name="apiKey">Users api_key</param>
    public Movie(string imdbTmdbId, string apiKey)
    {
      List = Info(imdbTmdbId, apiKey, API.cKey);
    }

    /// <summary>
    /// Get Images for Movie
    /// </summary>
    /// <param name="imdbTmdbId">Numeric tmdb_id or imdb_id of the movie.</param>
    /// <param name="apiKey">Users api_key</param>
    /// <param name="clientKey">Users client_key</param>
    public Movie(string imdbTmdbId, string apiKey, string clientKey)
    {
        List = Info(imdbTmdbId, apiKey, clientKey);
    }

    /// <summary>
    /// API Result
    /// </summary>
    /// <param name="imdbTmdbId">Numeric tmdb_id or imdb_id of the movie.</param>
    /// <param name="apiKey">Users api_key</param>
    /// <param name="clientKey">Users client_key</param>
    /// <returns>List of Images for a Movie</returns>
    private MovieData Info(string imdbTmdbId, string apiKey, string clientKey)
    {
      try
      {
        MovieData tmp;
        API.ErrorOccurred = false;
        API.ErrorMessage = string.Empty;

        var json = clientKey == "" ? Helper.Json.GetJson(API.Server + "movies/" + imdbTmdbId + "?api_key=" + apiKey) : Helper.Json.GetJson(API.Server + "movies/" + imdbTmdbId + "?api_key=" + apiKey + "&client_key=" + clientKey);

        if (API.ErrorOccurred)
          return new MovieData();

        using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
        {
          var settings = new DataContractJsonSerializerSettings { UseSimpleDictionaryFormat = true };
          var serializer = new DataContractJsonSerializer(typeof(MovieData), settings);
          tmp = (MovieData)serializer.ReadObject(ms);
        }
        return tmp ?? new MovieData();
      }
      catch (Exception ex)
      {
        API.ErrorOccurred = true;
        API.ErrorMessage = ex.Message;
        return new MovieData();
      }
    }
  }
}
