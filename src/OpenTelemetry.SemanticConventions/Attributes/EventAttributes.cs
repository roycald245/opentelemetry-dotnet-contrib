// Copyright The OpenTelemetry Authors
// SPDX-License-Identifier: Apache-2.0

// <auto-generated>This file has been auto generated from 'src\OpenTelemetry.SemanticConventions\scripts\templates\registry\SemanticConventionsAttributes.cs.j2' </auto-generated>

#nullable enable

#pragma warning disable CS1570 // XML comment has badly formed XML

namespace OpenTelemetry.SemanticConventions;

/// <summary>
/// Constants for semantic attribute names outlined by the OpenTelemetry specifications.
/// </summary>
public static class EventAttributes
{
    /// <summary>
    /// Identifies the class / type of event
    /// </summary>
    /// <remarks>
    /// Event names are subject to the same rules as <a href="/docs/general/attribute-naming.md">attribute names</a>. Notably, event names are namespaced to avoid collisions and provide a clean separation of semantics for events in separate domains like browser, mobile, and kubernetes
    /// </remarks>
    public const string AttributeEventName = "event.name";
}
