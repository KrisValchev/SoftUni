namespace MusicHub;

using System;
using System.Text;
using Data;
using Initializer;
using MusicHub.Data.Models;

public class StartUp
{
	public static void Main()
	{
		MusicHubDbContext context =
			new MusicHubDbContext();

		DbInitializer.ResetDatabase(context);

		string output = string.Empty;

		//Test 02.Export Albums Info

		//output = ExportAlbumsInfo(context, 9);

		//Test 03.Export Songs Above Duration
		output = ExportSongsAboveDuration(context, 4);

		Console.WriteLine(output);
	}

	public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
	{
		var sb = new StringBuilder();
		var albums = context.Albums.OrderByDescending(a => a.Price).Where(a => a.ProducerId == producerId).Select(a => new
		{
			a.Name,
			ReleaseDate = a.ReleaseDate.ToString("MM/dd/yyyy"),
			ProducerName = a.Producer.Name,
			Songs = a.Songs.OrderByDescending(s => s.Name).ThenBy(s => s.Writer.Name).ToList(),
			a.Price
		}).ToList();

		foreach (var album in albums)
		{
			sb.AppendLine($"-AlbumName: {album.Name}");
			sb.AppendLine($"-ReleaseDate: {album.ReleaseDate}");
			sb.AppendLine($"-ProducerName: {album.ProducerName}");
			sb.AppendLine($"-Songs:");
			int count = 0;
			foreach (var song in album.Songs)
			{
				sb.AppendLine($"---#{++count}");
				sb.AppendLine($"---SongName: {song.Name}");
				sb.AppendLine($"---Price: {song.Price:f2}");
				sb.AppendLine($"---Writer: {song.Writer.Name}");
			}
			sb.AppendLine($"-AlbumPrice: {album.Price:f2}");
		}
		return sb.ToString().TrimEnd();
	}

	public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
	{
		var sb = new StringBuilder();
		var songs = context.Songs.AsEnumerable().OrderBy(s => s.Name).ThenBy(s => s.Writer.Name).Where(s => s.Duration.TotalSeconds > duration).Select(s => new
		{
			s.Name,
			SongPerformers = s.SongPerformers.Select(p => new
			 {
				 PerformerFullName = $"{p.Performer.FirstName} {p.Performer.LastName}"
			 })
					.OrderBy(p => p.PerformerFullName)
					.ToList(),
			WriterName = s.Writer.Name,
			Producer = s.Album.Producer.Name,
			Duration = s.Duration.ToString("c")
		}); 


		int count = 0;
		foreach (var song in songs)
		{
			sb.AppendLine($"-Song #{++count}");
			sb.AppendLine($"---SongName: {song.Name}");
			sb.AppendLine($"---Writer: {song.WriterName}");
			if (song.SongPerformers.Count > 0)
			{
				foreach (var performer in song.SongPerformers)
				{
					sb.AppendLine($"---Performer: {performer.PerformerFullName}");

				}
			}
			sb.AppendLine($"---AlbumProducer: {song.Producer}");
			sb.AppendLine($"---Duration: {song.Duration}");
		}
		return sb.ToString().TrimEnd();
	}
}