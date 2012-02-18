using System.Collections.Generic;

namespace TrelloNet.Internal
{
	internal class Members : IMembers
	{
		private readonly TrelloRestClient _restClient;

		internal Members(TrelloRestClient restClient)
		{
			_restClient = restClient;
		}

		public Member WithId(string memberIdOrUsername)
		{
			Guard.NotNullOrEmpty(memberIdOrUsername, "memberIdOrUsername");
			return _restClient.Request<Member>(new MemberRequest(memberIdOrUsername));
		}

		public Member Me()
		{
			return _restClient.Request<Member>(new MemberRequest(new Me()));
		}

		public IEnumerable<Member> ForBoard(IBoardId board, MemberFilter filter = MemberFilter.Default)
		{
			Guard.NotNull(board, "board");
			return _restClient.Request<List<Member>>(new BoardMembersRequest(board, filter));
		}

		public IEnumerable<Member> ForCard(ICardId card)
		{
			Guard.NotNull(card, "card");
			return _restClient.Request<List<Member>>(new CardMembersRequest(card));
		}

		public IEnumerable<Member> ForOrganization(IOrganizationId organization, MemberFilter filter = MemberFilter.Default)
		{
			Guard.NotNull(organization, "organization");
			return _restClient.Request<List<Member>>(new OrganizationMembersRequest(organization, filter));
		}
	}
}