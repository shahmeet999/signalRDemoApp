namespace SignalRAPI.Data
{
    public class ChatMessageEntity
    {
        public int Id { get; set; }
        public string User { get; set; } = default!;
        public string Text { get; set; } = default!;
        public DateTimeOffset At { get; set; }
        public string? Room { get; set; } // null => global
    }
}
