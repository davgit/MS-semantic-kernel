﻿// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.SemanticKernel.Data;

/// <summary>
/// Attribute to mark a property on a record class as the vector.
/// </summary>
[Experimental("SKEXP0001")]
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public sealed class VectorStoreRecordVectorAttribute : Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VectorStoreRecordVectorAttribute"/> class.
    /// </summary>
    public VectorStoreRecordVectorAttribute()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="VectorStoreRecordVectorAttribute"/> class.
    /// </summary>
    /// <param name="Dimensions">The number of dimensions that the vector has.</param>
    public VectorStoreRecordVectorAttribute(int Dimensions)
    {
        this.Dimensions = Dimensions;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="VectorStoreRecordVectorAttribute"/> class.
    /// </summary>
    /// <param name="Dimensions">The number of dimensions that the vector has.</param>
    /// <param name="IndexKind">The kind of index to use.</param>
    /// <param name="DistanceFunction">The distance function to use when comparing vectors.</param>
    public VectorStoreRecordVectorAttribute(int Dimensions, string IndexKind, string DistanceFunction)
    {
        this.Dimensions = Dimensions;
        this.IndexKind = IndexKind;
        this.DistanceFunction = DistanceFunction;
    }

    /// <summary>
    /// Gets or sets the number of dimensions that the vector has.
    /// </summary>
    public int? Dimensions { get; private set; }

    /// <summary>
    /// Gets the kind of index to use.
    /// </summary>
    /// <seealso cref="IndexKind"/>
    public string? IndexKind { get; private set; }

    /// <summary>
    /// Gets the distance function to use when comparing vectors.
    /// </summary>
    /// <seealso cref="DistanceFunction"/>
    public string? DistanceFunction { get; private set; }

    /// <summary>
    /// Gets or sets an optional name to use for the property in storage, if different from the property name.
    /// E.g. the property name might be "MyProperty" but the storage name might be "my_property".
    /// </summary>
    public string? StoragePropertyName { get; set; }
}
