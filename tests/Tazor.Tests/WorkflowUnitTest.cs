using System.Diagnostics;
using Tazor.Workflows;

namespace Tazor.Tests
{
    [TestClass]
    public class WorkflowUnitTest
    {
        [TestMethod]
        public async Task SimpleWorkflowTest()
        {
            var helloWorldTemplate = new WorkflowTemplate
            {
                Name = "Test Template",
                Steps = new StepTemplate[]
                    {
                        new StepTemplate
                        {
                            Name = "Hello World",
                             Order = 0,
                            Type = typeof(HelloWorldAction).FullName ?? ""
                        }
                    }
            };

            var templates = new WorkflowTemplate[]
            {
                helloWorldTemplate
            };

            var repository = new MemoryWorkflowRepository(templates);
            var engine = new WorkflowProcessingEngine(repository);

            var workflowId = await engine.InitializeWorkflowAsync(new WorkflowRequest
            {
                Data = "John",
                TemplateId = helloWorldTemplate.Id
            });

            await engine.ExecuteAsync(workflowId);

            var workflow = await repository.GetWorkflowAsync(workflowId);

            Assert.IsTrue(workflow.Status == ExecutionStatus.Finished);
        }
    }

    public class HelloWorldAction : FunctionalWorkflowAction
    {
        public HelloWorldAction() :
            base ((context) => { Trace.WriteLine($"Hello, {context.Instance.Data ?? "World!"}"); return Task.CompletedTask; })
        {

        }
    }
}