// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Properties for the task that migrates data between MongoDB data sources. </summary>
    public partial class MigrateMongoDBTaskProperties : ProjectTaskProperties
    {
        /// <summary> Initializes a new instance of MigrateMongoDBTaskProperties. </summary>
        public MigrateMongoDBTaskProperties()
        {
            Output = new ChangeTrackingList<MongoDBProgress>();
            TaskType = TaskType.MigrateMongoDB;
        }

        /// <summary> Initializes a new instance of MigrateMongoDBTaskProperties. </summary>
        /// <param name="taskType"> Task type. </param>
        /// <param name="errors"> Array of errors. This is ignored if submitted. </param>
        /// <param name="state"> The state of the task. This is ignored if submitted. </param>
        /// <param name="commands">
        /// Array of command properties.
        /// Please note <see cref="CommandProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MigrateMISyncCompleteCommandProperties"/>, <see cref="MigrateSyncCompleteCommandProperties"/>, <see cref="MongoDBCancelCommand"/>, <see cref="MongoDBFinishCommand"/> and <see cref="MongoDBRestartCommand"/>.
        /// </param>
        /// <param name="clientData"> Key value pairs of client data to attach meta data information to task. </param>
        /// <param name="input"> Describes how a MongoDB data migration should be performed. </param>
        /// <param name="output">
        /// Please note <see cref="MongoDBProgress"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MongoDBDatabaseProgress"/>, <see cref="MongoDBMigrationProgress"/> and <see cref="MongoDBCollectionProgress"/>.
        /// </param>
        internal MigrateMongoDBTaskProperties(TaskType taskType, IReadOnlyList<ODataError> errors, TaskState? state, IReadOnlyList<CommandProperties> commands, IDictionary<string, string> clientData, MongoDBMigrationSettings input, IReadOnlyList<MongoDBProgress> output) : base(taskType, errors, state, commands, clientData)
        {
            Input = input;
            Output = output;
            TaskType = taskType;
        }

        /// <summary> Describes how a MongoDB data migration should be performed. </summary>
        public MongoDBMigrationSettings Input { get; set; }
        /// <summary>
        /// Gets the output
        /// Please note <see cref="MongoDBProgress"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MongoDBDatabaseProgress"/>, <see cref="MongoDBMigrationProgress"/> and <see cref="MongoDBCollectionProgress"/>.
        /// </summary>
        public IReadOnlyList<MongoDBProgress> Output { get; }
    }
}