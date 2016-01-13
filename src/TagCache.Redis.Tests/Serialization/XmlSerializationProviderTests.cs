﻿using NUnit.Framework;
using TagCache.Redis.Interfaces;
using TagCache.Redis.Serialization; 

namespace TagCache.Redis.Tests.Serialization
{
    [TestFixture]
    public class XmlSerializationProviderTests : SerializationProviderTestsBase<RedisCacheItem<TestObject>>
    {
        protected override ISerializationProvider GetSerializer()
        {
            return new XmlSerializationProvider();
        }

        protected override Redis.CacheConfiguration GetCacheConfiguration(RedisConnectionManager redis)
        { 
                return new Redis.CacheConfiguration(redis);
        }
    }
}