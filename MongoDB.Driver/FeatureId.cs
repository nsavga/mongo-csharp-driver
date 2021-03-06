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

namespace MongoDB.Driver
{
    /// <summary>
    /// Represents the Id of a feature.
    /// </summary>
    public enum FeatureId
    {
        /// <summary>
        /// The aggregate allow disk usage feature.
        /// </summary>
        AggregateAllowDiskUsage,
        /// <summary>
        /// The aggregate cursor feature.
        /// </summary>
        AggregateCursor,
        /// <summary>
        /// The aggregate explain feature.
        /// </summary>
        AggregateExplain,
        /// <summary>
        /// The aggregate output to collection feature.
        /// </summary>
        AggregateOutputToCollection,
        /// <summary>
        /// The max time feature.
        /// </summary>
        MaxTime,
        /// <summary>
        /// The text search command.
        /// </summary>
        TextSearchCommand,
        /// <summary>
        /// The text search query operator.
        /// </summary>
        TextSearchQuery,
        /// <summary>
        /// The user management commands.
        /// </summary>
        UserManagementCommands,
        /// <summary>
        /// The write commands.
        /// </summary>
        WriteCommands,
        /// <summary>
        /// The write opcodes.
        /// </summary>
        WriteOpcodes
    }
}
