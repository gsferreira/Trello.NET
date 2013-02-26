using System;
using System.Collections.Generic;
using TrelloNet.Internal;

namespace TrelloNet
{
	public class Trello : ITrello
	{
		private readonly TrelloRestClient _restClient;

		public Trello(string key)
		{
			_restClient = new TrelloRestClient(key);

			Async = new AsyncTrello(_restClient);
			Actions = new Actions(_restClient);
		}

		public IMembers Members { get; private set; }
		public IBoards Boards { get; private set; }
		public ILists Lists { get; private set; }
		public ICards Cards { get; private set; }
		public IChecklists Checklists { get; private set; }
		public IOrganizations Organizations { get; private set; }
		public INotifications Notifications { get; private set; }
		public ITokens Tokens { get; private set; }
		public IAsyncTrello Async { get; private set; }
		public IActions Actions { get; private set; }

		public SearchResults Search(string query, int limit = 10, SearchFilter filter = null, IEnumerable<ModelType> modelTypes = null, DateTime? actionsSince = null, bool partial = false)
		{
            throw new NotImplementedException();
		}

		public void Authorize(string token)
		{
			_restClient.Authenticate(token);
		}

		public void Deauthorize()
		{
			_restClient.Authenticate(null);
		}

		public Uri GetAuthorizationUrl(string applicationName, Scope scope, Expiration expiration = Expiration.ThirtyDays)
		{
			return _restClient.GetAuthorizationUrl(applicationName, scope, expiration);
		}
	}
}