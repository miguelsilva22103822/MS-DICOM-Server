﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;

namespace Microsoft.Health.Dicom.Core.Features.Common;

/// <summary>
/// Metadata on FileProperty table in database
/// </summary>
public readonly struct IndexedFileProperties : IEquatable<IndexedFileProperties>
{
    /// <summary>
    /// Total indexed FileProperty in database
    /// </summary>
    public int TotalIndexed { get; init; }

    /// <summary>
    /// Total sum of all ContentLength rows in FileProperty table
    /// </summary>
    public long TotalSum { get; init; }

    public override bool Equals(object obj)
    {
        return obj is IndexedFileProperties && Equals((IndexedFileProperties)obj);
    }

    public bool Equals(IndexedFileProperties other)
    {
        return TotalIndexed == other.TotalIndexed && TotalSum == other.TotalSum;
    }

    public override int GetHashCode() => (TotalIndexed, TotalSum).GetHashCode();

    public static bool operator ==(IndexedFileProperties left, IndexedFileProperties right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(IndexedFileProperties left, IndexedFileProperties right)
    {
        return !(left == right);
    }
}