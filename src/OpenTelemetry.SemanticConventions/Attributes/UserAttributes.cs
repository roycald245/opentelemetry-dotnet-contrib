// Copyright The OpenTelemetry Authors
// SPDX-License-Identifier: Apache-2.0

// <auto-generated>This file has been auto generated from 'src\OpenTelemetry.SemanticConventions\scripts\templates\registry\SemanticConventionsAttributes.cs.j2' </auto-generated>

#nullable enable

#pragma warning disable CS1570 // XML comment has badly formed XML

namespace OpenTelemetry.SemanticConventions;

/// <summary>
/// Constants for semantic attribute names outlined by the OpenTelemetry specifications.
/// </summary>
public static class UserAttributes
{
    /// <summary>
    /// User email address
    /// </summary>
    public const string AttributeUserEmail = "user.email";

    /// <summary>
    /// User's full name
    /// </summary>
    public const string AttributeUserFullName = "user.full_name";

    /// <summary>
    /// Unique user hash to correlate information for a user in anonymized form
    /// </summary>
    /// <remarks>
    /// Useful if <c>user.id</c> or <c>user.name</c> contain confidential information and cannot be used
    /// </remarks>
    public const string AttributeUserHash = "user.hash";

    /// <summary>
    /// Unique identifier of the user
    /// </summary>
    public const string AttributeUserId = "user.id";

    /// <summary>
    /// Short name or login/username of the user
    /// </summary>
    public const string AttributeUserName = "user.name";

    /// <summary>
    /// Array of user roles at the time of the event
    /// </summary>
    public const string AttributeUserRoles = "user.roles";
}
