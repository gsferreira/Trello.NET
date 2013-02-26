using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TrelloNet
{
	public class Board : IBoardId, IUpdatableBoard
	{
        [DataMember(Name = "id")]
		public string Id { get; set; }
        [DataMember(Name = "name")]
		public string Name { get; set; }
        [DataMember(Name = "desc")]
		public string Desc { get; set; }
		public bool Closed { get; set; }
		public string IdOrganization { get; set; }
		public bool Pinned { get; set; }
		public string Url { get; set; }
        //public BoardPreferences Prefs { get; set; }
		public bool Invited { get; set; }
		public Dictionary<Color, string> LabelNames { get; set; }

		public string GetBoardId()
		{
			return Id;
		}

		public override string ToString()
		{
			return Name;
		}
	}
}