// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IResolvedEntity.cs" company="Solidsoft Reply Ltd">
// Copyright (c) 2018-2024 Solidsoft Reply Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <summary>
// Represents a resolved entity.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

[assembly: CLSCompliant(true)]

namespace Solidsoft.Reply.Parsers.Common;

using System.Collections.Generic;

/// <summary>
///     Represents a resolved entity.
/// </summary>
public interface IResolvedEntity {
    /// <summary>
    ///     Gets the character position where the error occurred.
    /// </summary>
    int CharacterPosition { get; }

    /// <summary>
    ///     Gets the application identifier data title.
    /// </summary>
    string DataTitle { get; }

    /// <summary>
    ///     Gets the description of the application identifier.
    /// </summary>
    string Description { get; }

    /// <summary>
    ///     Gets the identifier entity.
    /// </summary>
    int Entity { get; }

    /// <summary>
    ///     Gets the exceptions raised during attempted entity resolution.
    /// </summary>
    IEnumerable<ParserException> Exceptions { get; }

    /// <summary>
    ///     Gets the identifier, as represented in the barcode.
    /// </summary>
    string Identifier { get; }

    /// <summary>
    ///     Gets the implied decimal point position in the value.
    /// </summary>
    int? InverseExponent { get; }

    /// <summary>
    ///     Gets a value indicating whether resolution resulted in one or more errors.
    /// </summary>
    bool IsError { get; }

    /// <summary>
    ///     Gets a value indicating whether the error is fatal (further parsing is aborted).
    /// </summary>
    bool IsFatal { get; }

    /// <summary>
    ///     Gets the value associated with the application identifier.
    /// </summary>
    string Value { get; }

    /// <summary>
    ///     Adds a resolver exception.
    /// </summary>
    /// <param name="parserException">The resolver exception to be added.</param>
    // ReSharper disable once UnusedMemberInSuper.Global
    // ReSharper disable once UnusedMember.Global
    void AddException(ParserException parserException);
}