namespace Tazor.Workflows;

public enum ExecutionStatus
{
    Default,    // Not yet run
    Executing,  // Doing something!
    Finished,   // Did something!
    Errored,    // It broked
    Skipped,    // or did we skip this?
}