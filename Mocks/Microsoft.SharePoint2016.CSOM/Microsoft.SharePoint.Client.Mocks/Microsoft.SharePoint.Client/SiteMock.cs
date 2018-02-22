
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class SiteMock : Site
    {


        public override System.Boolean AllowCreateDeclarativeWorkflow => AllowCreateDeclarativeWorkflowEx;
        public System.Boolean AllowCreateDeclarativeWorkflowEx { get; set; }

        public override System.Boolean AllowDesigner => AllowDesignerEx;
        public System.Boolean AllowDesignerEx { get; set; }

        public override System.Boolean AllowMasterPageEditing => AllowMasterPageEditingEx;
        public System.Boolean AllowMasterPageEditingEx { get; set; }

        public override System.Boolean AllowRevertFromTemplate => AllowRevertFromTemplateEx;
        public System.Boolean AllowRevertFromTemplateEx { get; set; }

        public override System.Boolean AllowSaveDeclarativeWorkflowAsTemplate => AllowSaveDeclarativeWorkflowAsTemplateEx;
        public System.Boolean AllowSaveDeclarativeWorkflowAsTemplateEx { get; set; }

        public override System.Boolean AllowSavePublishDeclarativeWorkflow => AllowSavePublishDeclarativeWorkflowEx;
        public System.Boolean AllowSavePublishDeclarativeWorkflowEx { get; set; }

        public override System.Boolean AllowSelfServiceUpgrade => AllowSelfServiceUpgradeEx;
        public System.Boolean AllowSelfServiceUpgradeEx { get; set; }

        public override System.Boolean AllowSelfServiceUpgradeEvaluation => AllowSelfServiceUpgradeEvaluationEx;
        public System.Boolean AllowSelfServiceUpgradeEvaluationEx { get; set; }

        public override Microsoft.SharePoint.Client.Audit Audit => AuditEx;
        public Microsoft.SharePoint.Client.Audit AuditEx { get; set; }

        public override System.Int32 AuditLogTrimmingRetention => AuditLogTrimmingRetentionEx;
        public System.Int32 AuditLogTrimmingRetentionEx { get; set; }

        public override System.Boolean CanUpgrade => CanUpgradeEx;
        public System.Boolean CanUpgradeEx { get; set; }

        public override System.Int32 CompatibilityLevel => CompatibilityLevelEx;
        public System.Int32 CompatibilityLevelEx { get; set; }

        public override Microsoft.SharePoint.Client.ChangeToken CurrentChangeToken => CurrentChangeTokenEx;
        public Microsoft.SharePoint.Client.ChangeToken CurrentChangeTokenEx { get; set; }

        public override Microsoft.SharePoint.Client.EventReceiverDefinitionCollection EventReceivers => EventReceiversEx;
        public Microsoft.SharePoint.Client.EventReceiverDefinitionCollection EventReceiversEx { get; set; }

        public override System.Boolean ExternalSharingTipsEnabled => ExternalSharingTipsEnabledEx;
        public System.Boolean ExternalSharingTipsEnabledEx { get; set; }

        public override Microsoft.SharePoint.Client.FeatureCollection Features => FeaturesEx;
        public Microsoft.SharePoint.Client.FeatureCollection FeaturesEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.String LockIssue => LockIssueEx;
        public System.String LockIssueEx { get; set; }

        public override System.UInt32 MaxItemsPerThrottledOperation => MaxItemsPerThrottledOperationEx;
        public System.UInt32 MaxItemsPerThrottledOperationEx { get; set; }

        public override System.Boolean NeedsB2BUpgrade => NeedsB2BUpgradeEx;
        public System.Boolean NeedsB2BUpgradeEx { get; set; }

        public override Microsoft.SharePoint.Client.User Owner => OwnerEx;
        public Microsoft.SharePoint.Client.User OwnerEx { get; set; }

        public override System.String PrimaryUri => PrimaryUriEx;
        public System.String PrimaryUriEx { get; set; }

        public override System.Boolean ReadOnly => ReadOnlyEx;
        public System.Boolean ReadOnlyEx { get; set; }

        public override Microsoft.SharePoint.Client.RecycleBinItemCollection RecycleBin => RecycleBinEx;
        public Microsoft.SharePoint.Client.RecycleBinItemCollection RecycleBinEx { get; set; }

        public override System.String RequiredDesignerVersion => RequiredDesignerVersionEx;
        public System.String RequiredDesignerVersionEx { get; set; }

        public override Microsoft.SharePoint.Client.Web RootWeb => RootWebEx;
        public Microsoft.SharePoint.Client.Web RootWebEx { get; set; }

        public override Microsoft.SharePoint.Client.SandboxedCodeActivationCapabilities SandboxedCodeActivationCapability => SandboxedCodeActivationCapabilityEx;
        public Microsoft.SharePoint.Client.SandboxedCodeActivationCapabilities SandboxedCodeActivationCapabilityEx { get; set; }

        public override Microsoft.SharePoint.Client.User SecondaryContact => SecondaryContactEx;
        public Microsoft.SharePoint.Client.User SecondaryContactEx { get; set; }

        public override System.String ServerRelativeUrl => ServerRelativeUrlEx;
        public System.String ServerRelativeUrlEx { get; set; }

        public override System.Boolean ShareByEmailEnabled => ShareByEmailEnabledEx;
        public System.Boolean ShareByEmailEnabledEx { get; set; }

        public override System.Boolean ShareByLinkEnabled => ShareByLinkEnabledEx;
        public System.Boolean ShareByLinkEnabledEx { get; set; }

        public override System.Boolean ShowUrlStructure => ShowUrlStructureEx;
        public System.Boolean ShowUrlStructureEx { get; set; }

        public override System.Boolean TrimAuditLog => TrimAuditLogEx;
        public System.Boolean TrimAuditLogEx { get; set; }

        public override System.Boolean UIVersionConfigurationEnabled => UIVersionConfigurationEnabledEx;
        public System.Boolean UIVersionConfigurationEnabledEx { get; set; }

        public override Microsoft.SharePoint.Client.UpgradeInfo UpgradeInfo => UpgradeInfoEx;
        public Microsoft.SharePoint.Client.UpgradeInfo UpgradeInfoEx { get; set; }

        public override System.DateTime UpgradeReminderDate => UpgradeReminderDateEx;
        public System.DateTime UpgradeReminderDateEx { get; set; }

        public override System.Boolean UpgradeScheduled => UpgradeScheduledEx;
        public System.Boolean UpgradeScheduledEx { get; set; }

        public override System.DateTime UpgradeScheduledDate => UpgradeScheduledDateEx;
        public System.DateTime UpgradeScheduledDateEx { get; set; }

        public override System.Boolean Upgrading => UpgradingEx;
        public System.Boolean UpgradingEx { get; set; }

        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

        public override Microsoft.SharePoint.Client.UsageInfo Usage => UsageEx;
        public Microsoft.SharePoint.Client.UsageInfo UsageEx { get; set; }

        public override Microsoft.SharePoint.Client.UserCustomActionCollection UserCustomActions => UserCustomActionsEx;
        public Microsoft.SharePoint.Client.UserCustomActionCollection UserCustomActionsEx { get; set; }

        public override void UpdateClientObjectModelUseRemoteAPIsPermissionSetting(System.Boolean @requireUseRemoteAPIs)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> NeedsUpgradeByType(System.Boolean @versionUpgrade, System.Boolean @recursive)
        {
            return NeedsUpgradeByTypeEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> NeedsUpgradeByTypeEx { get; set;}

        public override Microsoft.SharePoint.Client.SiteHealth.SiteHealthSummary RunHealthCheck(System.Guid @ruleId, System.Boolean @bRepair, System.Boolean @bRunAlways)
        {
            return RunHealthCheckEx;
        }
        public Microsoft.SharePoint.Client.SiteHealth.SiteHealthSummary RunHealthCheckEx { get; set;}

        public override void CreatePreviewSPSite(System.Boolean @upgrade, System.Boolean @sendemail)
        {
        }

        public override void RunUpgradeSiteSession(System.Boolean @versionUpgrade, System.Boolean @queueOnly, System.Boolean @sendEmail)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> DeleteMigrationJob(System.Guid @id)
        {
            return DeleteMigrationJobEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> DeleteMigrationJobEx { get; set;}

        public override Microsoft.SharePoint.Client.SPMigrationJobStatusCollection GetMigrationStatus()
        {
            return GetMigrationStatusEx;
        }
        public Microsoft.SharePoint.Client.SPMigrationJobStatusCollection GetMigrationStatusEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.MigrationJobState> GetMigrationJobStatus(System.Guid @id)
        {
            return GetMigrationJobStatusEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.MigrationJobState> GetMigrationJobStatusEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Guid> CreateMigrationJob(System.Guid @gWebId, System.String @azureContainerSourceUri, System.String @azureContainerManifestUri, System.String @azureQueueReportUri)
        {
            return CreateMigrationJobEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Guid> CreateMigrationJobEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Guid> CreateMigrationIngestionJob(System.Guid @gWebId, System.String @azureContainerSourceUri, System.String @azureContainerManifestUri, System.String @azureQueueReportUri, Microsoft.SharePoint.Client.IngestionTaskKey @ingestionTaskKey)
        {
            return CreateMigrationIngestionJobEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Guid> CreateMigrationIngestionJobEx { get; set;}

        public override Microsoft.SharePoint.Client.ChangeCollection GetChanges(Microsoft.SharePoint.Client.ChangeQuery @query)
        {
            return GetChangesEx;
        }
        public Microsoft.SharePoint.Client.ChangeCollection GetChangesEx { get; set;}

        public override Microsoft.SharePoint.Client.Web OpenWeb(System.String @strUrl)
        {
            return OpenWebEx;
        }
        public Microsoft.SharePoint.Client.Web OpenWebEx { get; set;}

        public override Microsoft.SharePoint.Client.Web OpenWebById(System.Guid @gWebId)
        {
            return OpenWebByIdEx;
        }
        public Microsoft.SharePoint.Client.Web OpenWebByIdEx { get; set;}

        public override Microsoft.SharePoint.Client.WebTemplateCollection GetWebTemplates(System.UInt32 @LCID, System.Int32 @overrideCompatLevel)
        {
            return GetWebTemplatesEx;
        }
        public Microsoft.SharePoint.Client.WebTemplateCollection GetWebTemplatesEx { get; set;}

        public override Microsoft.SharePoint.Client.ListTemplateCollection GetCustomListTemplates(Microsoft.SharePoint.Client.Web @web)
        {
            return GetCustomListTemplatesEx;
        }
        public Microsoft.SharePoint.Client.ListTemplateCollection GetCustomListTemplatesEx { get; set;}

        public override Microsoft.SharePoint.Client.List GetCatalog(System.Int32 @typeCatalog)
        {
            return GetCatalogEx;
        }
        public Microsoft.SharePoint.Client.List GetCatalogEx { get; set;}

        public override void ExtendUpgradeReminderDate()
        {
        }

        public override void Invalidate()
        {
        }

    }
}

