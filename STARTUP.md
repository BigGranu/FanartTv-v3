# <a name="using"></a> How to use?

#### The Library has 2 built-in event handlers.

 - Logging
 - Exceptions

```c# 
static void Main()
{
    MusicBrainz.Events.Logging.Instance.Call += LoggingOnCall;
    MusicBrainz.Events.Exceptions.Instance.Call += ExceptionOnCall;
}

private static void LoggingOnCall(object sender, LogEntry e)
{
    Console.WriteLine(e.ToString());
}

private static void ExceptionOnCall(object sender, EventArg e)
{
    Console.WriteLine(e.Message);
    throw e.Exception;
}
```

#### MusicBrainz supports 3 different methods.

 - [Search](#search)
 - [Browse](#browse)
 - [Lookup](#lookup)

### <a name="search"></a> Search

Search for MusicBrainz Entities.

```c# 
var ret = Search.Artist(artist: "fred", type: "group", country: "US");
```

Supported Types are:
 - Annotation
 - Artist
 - CdStub
 - Freedb
 - Label
 - ReleaseGroup
 - Release
 - Recording
 - Taglist
 - Work
 - Area  (Undocumented on MusicBrainz)
 - Place (Undocumented on MusicBrainz)

### <a name="browse"></a> Browse

Browse requests are a direct lookup of all the entities directly linked to another entity. (with directly linked I am referring to any relationship inherent in the database, so no ARs). 
For example, you may want to see all releases on netlabel ubiktune:
```c# 
var ret = Browse.Label(release: "62d1c4ef-fc00-37af-8df7-485f6a31fcc4"); 
```
Note that browse requests are not searches, in order to browse all the releases on the ubiktune label you will need to know the MBID of ubiktune.

Browsed entities are always ordered alphabetically by gid. If you need to sort the entities, you will have to fetch all entities and sort them yourself.

Supported Types are:
 - Area
 - Artist
 - Collection
 - Event
 - Instrument
 - Label
 - Place
 - Recording
 - Release
 - Release-Group
 - Series
 - Work 
 - Url

### <a name="lookup"></a> Lookup

You can perform a lookup of an entity when you have the MBID for that entity.

```c#
var ret = Lookup.Label("aad8fdd7-c3a0-414a-a6ce-2d2e72f57533"); 
```
Just like with normal lookup requests, the server can be instructed to include more data about the entity using an <a href="https://musicbrainz.org/doc/Development/XML_Web_Service/Version_2#inc.3D_arguments_which_affect_subqueries" target="_blank">'inc='</a> argument.

Default all Supported arguments will used. 
The arguments can be individually deactivated
```c# 
var ret = Lookup.Label("aad8fdd7-c3a0-414a-a6ce-2d2e72f57533", tags: false); 
```
or generally.
```c# 
Lookup.UseAllIncs = false;
```

Supported Types are:
 - Area
 - Artist
 - Collection
 - Event
 - Instrument
 - Label
 - Place
 - Recording
 - Release
 - Release-Group
 - Series
 - Work 
 - Url


