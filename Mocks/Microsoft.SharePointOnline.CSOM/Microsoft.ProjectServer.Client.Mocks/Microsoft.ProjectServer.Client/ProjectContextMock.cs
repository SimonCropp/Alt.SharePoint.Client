
namespace Microsoft.ProjectServer.Client
{
    public class ProjectContextMock : ProjectContext
    {


        public override Microsoft.ProjectServer.Client.WorkflowActivities WorkflowActivities => WorkflowActivitiesEx;
        public Microsoft.ProjectServer.Client.WorkflowActivities WorkflowActivitiesEx { get; set; }

        public override Microsoft.ProjectServer.Client.WorkflowDesigner WorkflowDesigner => WorkflowDesignerEx;
        public Microsoft.ProjectServer.Client.WorkflowDesigner WorkflowDesignerEx { get; set; }

        public override Microsoft.ProjectServer.Client.EntityTypes EntityTypes => EntityTypesEx;
        public Microsoft.ProjectServer.Client.EntityTypes EntityTypesEx { get; set; }

        public override Microsoft.ProjectServer.Client.ProjectCollection Projects => ProjectsEx;
        public Microsoft.ProjectServer.Client.ProjectCollection ProjectsEx { get; set; }

        public override Microsoft.ProjectServer.Client.CustomFieldCollection CustomFields => CustomFieldsEx;
        public Microsoft.ProjectServer.Client.CustomFieldCollection CustomFieldsEx { get; set; }

        public override Microsoft.ProjectServer.Client.LookupTableCollection LookupTables => LookupTablesEx;
        public Microsoft.ProjectServer.Client.LookupTableCollection LookupTablesEx { get; set; }

        public override Microsoft.ProjectServer.Client.EnterpriseProjectTypeCollection EnterpriseProjectTypes => EnterpriseProjectTypesEx;
        public Microsoft.ProjectServer.Client.EnterpriseProjectTypeCollection EnterpriseProjectTypesEx { get; set; }

        public override Microsoft.ProjectServer.Client.PhaseCollection Phases => PhasesEx;
        public Microsoft.ProjectServer.Client.PhaseCollection PhasesEx { get; set; }

        public override Microsoft.ProjectServer.Client.StageCollection Stages => StagesEx;
        public Microsoft.ProjectServer.Client.StageCollection StagesEx { get; set; }

        public override Microsoft.ProjectServer.Client.ProjectDetailPageCollection ProjectDetailPages => ProjectDetailPagesEx;
        public Microsoft.ProjectServer.Client.ProjectDetailPageCollection ProjectDetailPagesEx { get; set; }

        public override Microsoft.ProjectServer.Client.EnterpriseResourceCollection EnterpriseResources => EnterpriseResourcesEx;
        public Microsoft.ProjectServer.Client.EnterpriseResourceCollection EnterpriseResourcesEx { get; set; }

        public override Microsoft.ProjectServer.Client.EventCollection Events => EventsEx;
        public Microsoft.ProjectServer.Client.EventCollection EventsEx { get; set; }

        public override Microsoft.ProjectServer.Client.EventHandlerCollection EventHandlers => EventHandlersEx;
        public Microsoft.ProjectServer.Client.EventHandlerCollection EventHandlersEx { get; set; }

        public override Microsoft.ProjectServer.Client.TimeSheetPeriodCollection TimeSheetPeriods => TimeSheetPeriodsEx;
        public Microsoft.ProjectServer.Client.TimeSheetPeriodCollection TimeSheetPeriodsEx { get; set; }

        public override Microsoft.ProjectServer.Client.CalendarCollection Calendars => CalendarsEx;
        public Microsoft.ProjectServer.Client.CalendarCollection CalendarsEx { get; set; }

        public override Microsoft.ProjectServer.Client.ServiceStatus ServiceStatus => ServiceStatusEx;
        public Microsoft.ProjectServer.Client.ServiceStatus ServiceStatusEx { get; set; }

        public override Microsoft.ProjectServer.Client.PageSizes PageSizes => PageSizesEx;
        public Microsoft.ProjectServer.Client.PageSizes PageSizesEx { get; set; }

    }
}

