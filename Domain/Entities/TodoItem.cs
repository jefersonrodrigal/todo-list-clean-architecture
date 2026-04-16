namespace Domain.Entities
{
    public class TodoItem
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public bool IsCompleted { get; private set; }

        public TodoItem(string title)
        {
            Id = Guid.NewGuid();
            Title = title;
            IsCompleted = false;
        }

        public void Complete() => IsCompleted = true;
    }
}
