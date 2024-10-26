namespace Tazor;

/// <summary>
/// Represents a severity of validation against a dataset
/// </summary>
public enum ValidationSeverity
{
    /// <summary>
    /// The validity has not yet been checked
    /// </summary>
    NotChecked,
    
    /// <summary>
    /// The data is in a valid state
    /// </summary>
    Valid,
    
    /// <summary>
    /// The data is in a valid state, but there are issues that may be resolved
    /// </summary>
    Warning,
    
    /// <summary>
    /// The data is in an invalid state and issues must be resolved
    /// </summary>
    Error
}

