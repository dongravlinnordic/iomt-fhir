﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace Microsoft.Health.Fhir.Ingest.Template.CalculatedFunction
{
    public class CalculatedFunctionValueExpression : JsonPathValueExpression
    {
        public ExpressionLanguage? ValueExpressionLanguage { get; set; }
    }
}