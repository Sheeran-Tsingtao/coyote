﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;

namespace Microsoft.Coyote.Samples.AccountManager.ETags
{
    public class RowAlreadyExistsException : Exception
    {
    }

    public class RowNotFoundException : Exception
    {
    }

    public class MismatchedETagException : Exception
    {
    }
}
