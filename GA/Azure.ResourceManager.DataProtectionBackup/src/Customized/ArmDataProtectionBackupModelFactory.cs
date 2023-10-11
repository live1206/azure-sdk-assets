// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DataProtectionBackup;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmDataProtectionBackupModelFactory
    {
        /// <summary>
        /// Initializes a new instance of DataProtectionBackupVaultProperties.
        /// </summary>
        /// <param name="alertSettingsForAllJobFailures"></param>
        /// <param name="provisioningState"></param>
        /// <param name="resourceMoveState"></param>
        /// <param name="resourceMoveDetails"></param>
        /// <param name="securitySettings"></param>
        /// <param name="storageSettings"></param>
        /// <param name="isVaultProtectedByResourceGuard"></param>
        /// <param name="crossSubscriptionRestoreState"></param>
        /// <returns></returns>
        public static DataProtectionBackupVaultProperties DataProtectionBackupVaultProperties(AzureMonitorAlertsState? alertSettingsForAllJobFailures = null, DataProtectionBackupProvisioningState? provisioningState = null, BackupVaultResourceMoveState? resourceMoveState = null, BackupVaultResourceMoveDetails resourceMoveDetails = null, BackupVaultSecuritySettings securitySettings = null, IEnumerable<DataProtectionBackupStorageSetting> storageSettings = null, bool? isVaultProtectedByResourceGuard = null, DataProtectionBackupCrossSubscriptionRestoreState? crossSubscriptionRestoreState = null)
        {
            storageSettings ??= new List<DataProtectionBackupStorageSetting>();
            BackupVaultFeatureSettings featureSettings = null;

            if (crossSubscriptionRestoreState != null)
            {
                featureSettings = new BackupVaultFeatureSettings();
                featureSettings.CrossSubscriptionRestoreState = crossSubscriptionRestoreState;
            }

            return new DataProtectionBackupVaultProperties(alertSettingsForAllJobFailures != null ? new MonitoringSettings(new AzureMonitorAlertSettings(alertSettingsForAllJobFailures)) : null, provisioningState, resourceMoveState, resourceMoveDetails, securitySettings, storageSettings?.ToList(), isVaultProtectedByResourceGuard, featureSettings, null);
        }

        /// <summary>
        /// Initializes a new instance of DataProtectionBackupInstanceProperties.
        /// </summary>
        /// <param name="friendlyName"></param>
        /// <param name="dataSourceInfo"></param>
        /// <param name="dataSourceSetInfo"></param>
        /// <param name="policyInfo"></param>
        /// <param name="protectionStatus"></param>
        /// <param name="currentProtectionState"></param>
        /// <param name="protectionErrorDetails"></param>
        /// <param name="provisioningState"></param>
        /// <param name="dataSourceAuthCredentials"></param>
        /// <param name="validationType"></param>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public static DataProtectionBackupInstanceProperties DataProtectionBackupInstanceProperties(string friendlyName = null, DataSourceInfo dataSourceInfo = null, DataSourceSetInfo dataSourceSetInfo = null, BackupInstancePolicyInfo policyInfo = null, BackupInstanceProtectionStatusDetails protectionStatus = null, CurrentProtectionState? currentProtectionState = null, ResponseError protectionErrorDetails = null, string provisioningState = null, DataProtectionBackupAuthCredentials dataSourceAuthCredentials = null, BackupValidationType? validationType = null, string objectType = null)
        {
            return new DataProtectionBackupInstanceProperties(friendlyName, dataSourceInfo, dataSourceSetInfo, policyInfo, protectionStatus, currentProtectionState, protectionErrorDetails, provisioningState, dataSourceAuthCredentials, validationType, null, objectType);
        }

        /// <summary>
        /// Initializes a new instance of DataProtectionBackupJobProperties.
        /// </summary>
        /// <param name="activityId"></param>
        /// <param name="backupInstanceFriendlyName"></param>
        /// <param name="backupInstanceId"></param>
        /// <param name="dataSourceId"></param>
        /// <param name="dataSourceLocation"></param>
        /// <param name="dataSourceName"></param>
        /// <param name="dataSourceSetName"></param>
        /// <param name="dataSourceType"></param>
        /// <param name="duration"></param>
        /// <param name="endOn"></param>
        /// <param name="errorDetails"></param>
        /// <param name="extendedInfo"></param>
        /// <param name="isUserTriggered"></param>
        /// <param name="operation"></param>
        /// <param name="operationCategory"></param>
        /// <param name="policyId"></param>
        /// <param name="policyName"></param>
        /// <param name="isProgressEnabled"></param>
        /// <param name="progressUri"></param>
        /// <param name="restoreType"></param>
        /// <param name="sourceResourceGroup"></param>
        /// <param name="sourceSubscriptionId"></param>
        /// <param name="startOn"></param>
        /// <param name="status"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="supportedActions"></param>
        /// <param name="vaultName"></param>
        /// <param name="eTag"></param>
        /// <param name="sourceDataStoreName"></param>
        /// <param name="destinationDataStoreName"></param>
        /// <returns></returns>
        public static DataProtectionBackupJobProperties DataProtectionBackupJobProperties(string activityId = null, string backupInstanceFriendlyName = null, ResourceIdentifier backupInstanceId = null, ResourceIdentifier dataSourceId = null, AzureLocation dataSourceLocation = default, string dataSourceName = null, string dataSourceSetName = null, string dataSourceType = null, TimeSpan? duration = null, DateTimeOffset? endOn = null, IEnumerable<ResponseError> errorDetails = null, BackupJobExtendedInfo extendedInfo = null, bool isUserTriggered = default, string operation = null, string operationCategory = null, ResourceIdentifier policyId = null, string policyName = null, bool isProgressEnabled = default, Uri progressUri = null, string restoreType = null, string sourceResourceGroup = null, string sourceSubscriptionId = null, DateTimeOffset startOn = default, string status = null, string subscriptionId = null, IEnumerable<string> supportedActions = null, string vaultName = null, ETag? eTag = null, string sourceDataStoreName = null, string destinationDataStoreName = null)
        {
            errorDetails ??= new List<ResponseError>();
            supportedActions ??= new List<string>();

            return new DataProtectionBackupJobProperties(activityId, backupInstanceFriendlyName, backupInstanceId, dataSourceId, dataSourceLocation, dataSourceName, dataSourceSetName, dataSourceType, duration, endOn, errorDetails?.ToList(), extendedInfo, isUserTriggered, operation, operationCategory, policyId, policyName, isProgressEnabled, progressUri, null, restoreType, sourceResourceGroup, sourceSubscriptionId, startOn, status, subscriptionId, supportedActions?.ToList(), vaultName, eTag, sourceDataStoreName, destinationDataStoreName);
        }

        /// <summary>
        /// Initializes a new instance of DataProtectionBackupDataSourceProperties.
        /// </summary>
        /// <param name="friendlyName"></param>
        /// <param name="dataSourceInfo"></param>
        /// <param name="dataSourceSetInfo"></param>
        /// <param name="policyInfo"></param>
        /// <param name="protectionStatus"></param>
        /// <param name="currentProtectionState"></param>
        /// <param name="protectionErrorDetails"></param>
        /// <param name="provisioningState"></param>
        /// <param name="dataSourceAuthCredentials"></param>
        /// <param name="validationType"></param>
        /// <param name="objectType"></param>
        /// <param name="deletionInfo"></param>
        /// <returns></returns>
        public static DeletedDataProtectionBackupInstanceProperties DeletedDataProtectionBackupInstanceProperties(string friendlyName = null, DataSourceInfo dataSourceInfo = null, DataSourceSetInfo dataSourceSetInfo = null, BackupInstancePolicyInfo policyInfo = null, BackupInstanceProtectionStatusDetails protectionStatus = null, CurrentProtectionState? currentProtectionState = null, ResponseError protectionErrorDetails = null, string provisioningState = null, DataProtectionBackupAuthCredentials dataSourceAuthCredentials = null, BackupValidationType? validationType = null, string objectType = null, BackupInstanceDeletionInfo deletionInfo = null)
        {
            return new DeletedDataProtectionBackupInstanceProperties(friendlyName, dataSourceInfo, dataSourceSetInfo, policyInfo, protectionStatus, currentProtectionState, protectionErrorDetails, provisioningState, dataSourceAuthCredentials, validationType, null, objectType, deletionInfo);
        }
    }
}