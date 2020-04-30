﻿using System;

namespace ei8.Cortex.Diary.Nucleus.Port.Adapter.Common
{
    public struct EnvironmentVariableKeys
    {
        public const string CortexInBaseUrl = "CORTEX_IN_BASE_URL";
        public const string CortexOutBaseUrl = "CORTEX_OUT_BASE_URL";
        public const string CortexGraphOutBaseUrl = "CORTEX_GRAPH_OUT_BASE_URL";
        public const string EventSourcingOutBaseUrl = "EVENT_SOURCING_OUT_BASE_URL";
        public const string TagInBaseUrl = "TAG_IN_BASE_URL";
        public const string TagOutBaseUrl = "TAG_OUT_BASE_URL";
        public const string AggregateInBaseUrl = "AGGREGATE_IN_BASE_URL";
        public const string AggregateOutBaseUrl = "AGGREGATE_OUT_BASE_URL";
    }
}
