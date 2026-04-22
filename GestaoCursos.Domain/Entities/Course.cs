public class Course
{
    public int Id { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public bool Active { get; private set; }

    protected Course() { }

    public Course(string title, string description)
    {
        ValidateTitle(title);
        ValidateDescription(description);
        Title = title;
        Description = description;
        Active = true;
    }

    public void Update(string title, string description)
    {
        ValidateTitle(title);
        ValidateDescription(description);
        Title = title;
        Description = description;
    }

    private void ValidateTitle(string title)
    {
        if (string.IsNullOrWhiteSpace(title) || title.Length < 3)
            throw new ArgumentException("O titulo deve conter ao menos 3 caracteres.");
    }

    private void ValidateDescription(string description)
    {
        if (string.IsNullOrWhiteSpace(description) || description.Length < 10)
            throw new ArgumentException("A descrição deve conter ao menos 10 caracteres.");
    }

    public void Deactivate() => Active = false;
}