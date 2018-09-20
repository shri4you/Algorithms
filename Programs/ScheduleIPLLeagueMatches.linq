<Query Kind="Program" />

//In a tournament with N teams, where in one team can play only one match per day, develop an algo which schedules the matches in the tournament. 
//Each team shall play with the other team once(same as designing the league matches of a Cricket tournament like IPL) 
//He also asked me to optimise on days

void Main()
{
	string[] teams = new[]{"team1","team2","team3","team4","team5", "team6", "team7", "team8"};
	var tournamentScheduler = new TournamentScheduler(teams);
	tournamentScheduler.ScheduleMatches();
}

public class Match
{
	public string Team1 {get;private set;}
	public string Team2 {get; private set;}
	
	public Match(string team1, string team2)
	{
		this.Team1 = team1;
		this.Team2 = team2;
	}
	
	public override string ToString()
	{
		return string.Format("{0} X {1}", this.Team1, this.Team2);
	}
	
	public bool HasConflict(Match match)
	{
		return string.Equals(Team1, match.Team1) || string.Equals(Team2, match.Team1)
			|| string.Equals(Team1, match.Team2) || string.Equals(Team2, match.Team2);
	}
}

public class TournamentScheduler
{
	string[] teams;
	
	List<Match> matches = new List<Match>();
	
	List<List<Match>> matchesAgainstDays = new List<List<Match>>();
	
	public TournamentScheduler(string[] teams)
	{
		this.teams = teams;
	}
	
	public void ScheduleMatches()
	{
		this.FindMatches();
		foreach(var m in matches)
		{
			bool scheduled = false;
			foreach(var d in matchesAgainstDays)
			{
				if(!d.Any(sm => sm.HasConflict(m)))
				{
					d.Add(m);
					scheduled = true;
					break;
				}
			}
			
			if(!scheduled)
			{
				matchesAgainstDays.Add(new List<Match>() {m});
			}
		}
		
		matchesAgainstDays.Dump();
	}
	
	protected void FindMatches()
	{
		int prevTeamIndex;
		for(prevTeamIndex = 0; prevTeamIndex < this.teams.Length - 1; prevTeamIndex++)
		{
			for(int i=prevTeamIndex+1; i < this.teams.Length; i++)
			{
				this.matches.Add(new Match(this.teams[prevTeamIndex], this.teams[i]));
			}
		}
	}
}