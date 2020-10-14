using System;
using Weapsy.Cqrs.Domain;
using Weapsy.Framework.Domain;

namespace Weapsy.Domain.Pages.Events
{
    public class PageActivated : DomainEvent
    {
        public Guid SiteId { get; set; }
    }
}