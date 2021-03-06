﻿using mobSocial.Core.Data;

namespace mobSocial.Core.Services.Events
{
    public interface IEventPublisherService
    {
        /// <summary>
        /// Publishes a particular event
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <param name="eventType"></param>
        void Publish<T>(T entity, EventType eventType) where T : BaseEntity;
    }
}