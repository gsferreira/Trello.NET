using System;
using System.Collections.Generic;

namespace TrelloNet.Internal
{
	internal class Actions : IActions
	{
		private readonly TrelloRestClient _restClient;

		public Actions(TrelloRestClient restClient)
		{
			_restClient = restClient;
		}

		public Action WithId(string actionId)
		{
            throw new System.NotImplementedException();
		}

		public IEnumerable<Action> ForBoard(IBoardId board, IEnumerable<ActionType> filter = null, ISince since = null, Paging paging = null)
		{
            throw new System.NotImplementedException();
		}

		public IEnumerable<Action> ForCard(ICardId card, IEnumerable<ActionType> filter = null, ISince since = null, Paging paging = null)
		{
            throw new System.NotImplementedException();
		}

		public IEnumerable<Action> ForList(IListId list, IEnumerable<ActionType> filter = null, ISince since = null, Paging paging = null)
		{
            throw new System.NotImplementedException();
		}

		public IEnumerable<Action> ForMember(IMemberId member, IEnumerable<ActionType> filter = null, ISince since = null, Paging paging = null)
		{
            throw new System.NotImplementedException();
		}

		public IEnumerable<Action> ForMe(IEnumerable<ActionType> filter = null, ISince since = null, Paging paging = null)
		{
			return ForMember(new Me(), filter, since, paging);
		}

		public IEnumerable<Action> ForOrganization(IOrganizationId organization, IEnumerable<ActionType> filter = null, ISince since = null, Paging paging = null)
		{
            throw new System.NotImplementedException();
		}

		public IEnumerable<Action> Search(string query, int limit = 10, SearchFilter filter = null, DateTime? since = null, bool partial = false)
		{
            throw new System.NotImplementedException();
		}

        public void ChangeText(IActionId action, string newText)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(IActionId action)
        {
            throw new System.NotImplementedException();
        }
    }
}