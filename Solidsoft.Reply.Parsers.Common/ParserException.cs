﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ParserException.cs" company="Solidsoft Reply Ltd">
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
// An exception raised by a parser.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Solidsoft.Reply.Parsers.Common;

using System;
using System.Runtime.Serialization;

/// <summary>
///     An exception raised by a parser.
/// </summary>
[Serializable]
public class ParserException : Exception {
    /// <summary>
    ///     Initializes a new instance of the <see cref="ParserException" /> class.
    /// </summary>
    // ReSharper disable once UnusedMember.Global
    public ParserException() {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="ParserException" /> class.
    /// </summary>
    /// <param name="message">The exception message.</param>
    // ReSharper disable once UnusedMember.Global
    public ParserException(string message)
        : base(message) {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="ParserException" /> class.
    /// </summary>
    /// <param name="message">The exception message.</param>
    /// <param name="innerException">The inner exception.</param>
    // ReSharper disable once UnusedMember.Global
    public ParserException(string message, Exception innerException)
        : base(message, innerException) {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="ParserException" /> class.
    /// </summary>
    /// <param name="errorNumber">The error number.</param>
    /// <param name="message">The error message.</param>
    /// <param name="isFatal">Indicates whether the exception is fatal. </param>
    /// <param name="offset">The character position of the exception.</param>
    // ReSharper disable once StyleCop.SA1642
    public ParserException(int errorNumber, string message, bool isFatal, int offset = 0)
        : base(message) {
        ErrorNumber = errorNumber;
        IsFatal = isFatal;
        Offset = offset;
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="ParserException" /> class.
    /// </summary>
    /// <param name="info">The serialization information.</param>
    /// <param name="context">The streaming context.</param>
#if NET5_0_OR_GREATER
#pragma warning disable S1133 // Deprecated code should be removed
    [Obsolete("Formatter serialisation has been deprecated in .NET.")]
#pragma warning restore S1133 // Deprecated code should be removed
#endif
    protected ParserException(SerializationInfo info, StreamingContext context)
        : base(info, context) {
    }

    /// <summary>
    ///     Gets the error number.
    /// </summary>
    public int ErrorNumber { get; }

    /// <summary>
    ///     Gets a value indicating whether the exception is fatal.  Fatality means that the
    ///     parser must abandon the attempt to parse the exception.
    /// </summary>
    public bool IsFatal { get; }

    /// <summary>
    ///     Gets the offset position of the exception.
    /// </summary>
    public int Offset { get; }
}