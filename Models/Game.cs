using System;

public class Game
{
	public Game(string title)
	{
		this.Title = title;
	}

	public int Id { get; set; } 
	public string Title { get; set; } // name of game
	public string Description { get; set; }
	public string Developer { get; set; }
	public string Platform { get; set; }
	public int YearMade { get; set; }
	public DateOnly FirstDatePlayed { get; set; } // DateOnly should suffice for tracking when games are played
	public DateOnly LatestDatePlayed { get; set; }
	public string Notes { get; set; }

}
