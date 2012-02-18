﻿using System;
using System.Collections.Generic;
using System.Linq;
using ExpectedObjects;
using NUnit.Framework;

namespace TrelloNet.Tests
{
	[TestFixture]
	public class ChecklistTests : TrelloTestBase
	{
		[Test]
		public void GetByBoard_WelcomeBoard_ReturnsOneChecklist()
		{
			var checkLists = _trello.Checklists.ForBoard(new BoardId(Constants.WelcomeBoardId));

			Assert.That(checkLists.Count(), Is.EqualTo(1));
		}

		[Test]
		public void GetByBoard_Null_Throws()
		{
			Assert.That(() => _trello.Checklists.ForBoard(null),
			            Throws.TypeOf<ArgumentNullException>().With.Matches<ArgumentNullException>(e => e.ParamName == "board"));
		}

		[Test]
		public void GetByCard_TheChecklistCard_ReturnsOneChecklist()
		{
			var checkLists = _trello.Checklists.ForCard(new CardId("4f2b8b4d4f2cb9d16d3684fc"));

			Assert.That(checkLists.Count(), Is.EqualTo(1));
		}

		[Test]
		public void GetByCard_Null_Throws()
		{
			Assert.That(() => _trello.Checklists.ForCard(null),
						Throws.TypeOf<ArgumentNullException>().With.Matches<ArgumentNullException>(e => e.ParamName == "card"));
		}

		[Test]
		public void GetById_AChecklist_ReturnsThatChecklist()
		{
			var expectedChecklist = new Checklist
			{
				Id = "4f2b8b4d4f2cb9d16d3684c7",
				IdBoard = Constants.WelcomeBoardId,
				Name = "Checklist",
				CheckItems = new List<Checklist.Ítem>
				{
					new Checklist.Ítem { Id = "4f2b8b4d4f2cb9d16d3684c4", Name = "Make your own boards" },
					new Checklist.Ítem { Id = "4f2b8b4d4f2cb9d16d3684c5", Name = "Invite your team" },
					new Checklist.Ítem { Id = "4f2b8b4d4f2cb9d16d3684c6", Name = "Enjoy an ice-cold lemonade" }
				}
			}.ToExpectedObject();

			var actualChecklist = _trello.Checklists.WithId("4f2b8b4d4f2cb9d16d3684c7");

			expectedChecklist.ShouldEqual(actualChecklist);
		}

		[Test]
		public void GetById_Null_Throws()
		{
			Assert.That(() => _trello.Checklists.WithId(null),
						Throws.TypeOf<ArgumentNullException>().With.Matches<ArgumentNullException>(e => e.ParamName == "checklistId"));
		}
	}
}