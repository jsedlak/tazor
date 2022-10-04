using Tazor.Workflows;

namespace Tazor.Tests
{
    public class MemoryWorkflowRepository : IWorkflowRepository
    {
        private readonly List<WorkflowTemplate> _templates = new List<WorkflowTemplate>();
        private readonly List<Workflow> _workflows = new List<Workflow>();

        public MemoryWorkflowRepository(IEnumerable<WorkflowTemplate> templates)
        {
            _templates.AddRange(templates);
        }

        public Task UpsertTemplateAsync(WorkflowTemplate template)
        {
            _templates.Add(template);
            return Task.CompletedTask;
        }

        public Task<WorkflowTemplate> GetTemplateAsync(Guid templateId)
        {
            return Task.FromResult(_templates.First(m => m.Id == templateId));
        }

        public Task<Workflow> GetWorkflowAsync(Guid workflowId)
        {
            return Task.FromResult(_workflows.First(m => m.Id == workflowId));
        }

        public Task UpsertWorkflowAsync(Workflow workflow)
        {
            if(_workflows.Contains(workflow))
            {
                return Task.CompletedTask;
            }

            _workflows.Add(workflow);

            return Task.CompletedTask;
        }
    }
}