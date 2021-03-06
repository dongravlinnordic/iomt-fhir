// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace Microsoft.Health.Events.EventCheckpointing
{
    public class StorageCheckpointOptions
    {
        public const string Settings = "Checkpoint";

        public string BlobPrefix { get; set; }

        public string CheckpointBatchCount { get; set; }
    }
}
