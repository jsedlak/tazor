namespace Tazor.Workflows;

public class TraceMessage
{
    public static TraceMessage FromException(Exception ex, bool includeStackTrace = false)
    {
        var msg = new TraceMessage
        {
            Severity = Severity.Error,
            Message = ex.Message
        };

        if(ex.InnerException != null)
        {
            msg.Properties.Add("InnerMessage", ex.InnerException.Message);
        }

        if (includeStackTrace && !string.IsNullOrWhiteSpace(ex.StackTrace))
        {
            msg.Properties.Add("StackTrace", ex.StackTrace);
        }

        return msg;
    }


    public Guid Id { get; set; } = Guid.NewGuid();

    public string Message { get; set; } = null!;

    public Dictionary<string, string> Properties { get; set; } = new Dictionary<string, string>();

    public Severity Severity { get; set; }
}
