﻿using CQRSlite.Commands;
using org.neurul.Common.Domain.Model;
using System;

namespace works.ei8.Cortex.Diary.Nucleus.Application.Neurons.Commands
{
    public class DeactivateNeuron : ICommand
    {
        public DeactivateNeuron(string avatarId, Guid id, Guid authorId, int expectedVersion)
        {
            AssertionConcern.AssertArgumentNotNull(avatarId, nameof(avatarId));
            AssertionConcern.AssertArgumentValid(
                g => g != Guid.Empty,
                id,
                Messages.Exception.InvalidId,
                nameof(id)
                );
            AssertionConcern.AssertArgumentValid(
                g => g != Guid.Empty,
                authorId,
                Messages.Exception.InvalidId,
                nameof(authorId)
                );
            AssertionConcern.AssertArgumentValid(
                i => i >= 1,
                expectedVersion,
                Messages.Exception.InvalidExpectedVersion,
                nameof(expectedVersion)
                );

            this.AvatarId = avatarId;
            this.Id = id;
            this.AuthorId = authorId;            
            this.ExpectedVersion = expectedVersion;
        }

        public string AvatarId { get; private set; }

        public Guid Id { get; private set; }

        public Guid AuthorId { get; private set; }

        public int ExpectedVersion { get; private set; }
    }
}
