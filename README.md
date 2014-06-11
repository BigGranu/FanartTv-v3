FANART.TV
==========

.Net data bindings for [FANART.TV](http://fanart.tv/)

Some of features are:
 * Search Artistinfo
 * Search Albuminfo
 * Search Movieinfo
 * Search Seriesinfo

For an APIKey go to [FANART.TV](http://fanart.tv/get-an-api-key/)

Any Examples:
 * // Set a global Apikey
 * FanartTv.API.Key = "apikey";
 * var album = new Album("1dc4c347-a1db-32aa-b14f-bc9cc507b843");
 * // or use the Key directly
 * var album = new Album("1dc4c347-a1db-32aa-b14f-bc9cc507b843", "apikey");

Artist
 * var artist = new FanartTv.Artist("cc197bad-dc9c-440d-a5b5-d52ba2e14234");

Album 
 * var album = new FanartTv.Album("1dc4c347-a1db-32aa-b14f-bc9cc507b843");

Movie
 * var mo = new FanartTv.Movie("tt0120737");
 
Series
 * var series = new FanartTv.Series("75682"); 

