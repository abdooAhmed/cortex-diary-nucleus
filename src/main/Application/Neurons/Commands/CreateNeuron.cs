﻿using CQRSlite.Commands;
using Newtonsoft.Json;
using neurUL.Common.Domain.Model;
using System;

namespace ei8.Cortex.Diary.Nucleus.Application.Neurons.Commands
{
    public class CreateNeuron : ICommand
    {
        public CreateNeuron(Guid id, string tag, Guid regionId, Guid authorId)
        {
            AssertionConcern.AssertArgumentValid(
                g => g != Guid.Empty,
                id,
                Messages.Exception.InvalidId,
                nameof(id)
                );
            AssertionConcern.AssertArgumentNotNull(tag, nameof(tag));
            AssertionConcern.AssertArgumentValid(
                g => g != Guid.Empty,
                authorId,
                Messages.Exception.InvalidId,
                nameof(authorId)
                );

            this.Id = id;            
            this.Tag = tag;
            this.RegionId = regionId;
            this.AuthorId = authorId;
        }

        public Guid Id { get; private set; }
        
        public string Tag { get; private set; }

        public Guid RegionId { get; private set; }

        public Guid AuthorId { get; private set; }

        public int ExpectedVersion { get; private set; }
    }
}
