using MongoDB.Driver;

namespace Tazor.Workflows;

public class MongoWorkflowRepository : IWorkflowRepository
{
    private const string WorkflowTemplatesCollectionName = "workflow_templates";
    private const string WorkflowsCollectionName = "workflows";

    private readonly MongoClient _client;
    private readonly IMongoDatabase _database;

    public MongoWorkflowRepository(string connectionString, string databaseName = WorkflowsCollectionName)
    {
        _client = new MongoClient(MongoClientSettings.FromConnectionString(connectionString));
        _database = _client.GetDatabase(databaseName);
    }

    public async Task UpsertTemplateAsync(WorkflowTemplate template)
    {
        var filterBuilder = new FilterDefinitionBuilder<WorkflowTemplate>();
        var filter = filterBuilder.Eq(m => m.Id, template.Id);

        await _database.GetCollection<WorkflowTemplate>(WorkflowTemplatesCollectionName)
            .FindOneAndReplaceAsync(filter, template, new FindOneAndReplaceOptions<WorkflowTemplate, WorkflowTemplate> { IsUpsert = true });
    }

    public async Task<WorkflowTemplate> GetTemplateAsync(Guid templateId)
    {
        return (await _database.GetCollection<WorkflowTemplate>(WorkflowTemplatesCollectionName)
            .FindAsync(m => m.Id == templateId)).First();
    }

    public async Task<Workflow> GetWorkflowAsync(Guid workflowId)
    {
        return (await _database.GetCollection<Workflow>(WorkflowsCollectionName)
            .FindAsync(m => m.Id == workflowId)).First();
    }

    public async Task UpsertWorkflowAsync(Workflow workflow)
    {
        var filterBuilder = new FilterDefinitionBuilder<Workflow>();
        var filter = filterBuilder.Eq(m => m.Id, workflow.Id);

        await _database.GetCollection<Workflow>(WorkflowsCollectionName)
            .FindOneAndReplaceAsync(filter, workflow, new FindOneAndReplaceOptions<Workflow, Workflow> { IsUpsert = true });
    }
}
