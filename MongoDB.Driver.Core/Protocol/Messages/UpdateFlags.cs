﻿/* Copyright 2010-2013 10gen Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;

namespace MongoDB.Driver.Core.Protocol.Messages
{
    /// <summary>
    /// Flags used in a <see cref="UpdateMessage"/>.
    /// </summary>
    [Flags]
    public enum UpdateFlags
    {
        /// <summary>
        /// No flags.
        /// </summary>
        None = 0,
        /// <summary>
        /// If document doesn't exist then do an Insert.
        /// </summary>
        Upsert = 1,
        /// <summary>
        /// Update all matching documents (instead of just one).
        /// </summary>
        Multi = 2
    }
}