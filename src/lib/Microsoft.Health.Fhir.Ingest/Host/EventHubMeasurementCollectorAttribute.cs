// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using Microsoft.Azure.WebJobs.Description;

namespace Microsoft.Health.Fhir.Ingest.Host
{
    [Binding]
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = true)]
    public sealed class EventHubMeasurementCollectorAttribute : Attribute
    {
        public EventHubMeasurementCollectorAttribute(string eventHubName)
        {
            EventHubName = eventHubName;
        }

        [AutoResolve]
        public string EventHubName { get; private set; }

        [ConnectionString]
        public string Connection { get; set; }
    }
}