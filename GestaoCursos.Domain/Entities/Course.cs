public class Course
{
    public int Id { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public int DurationInHours { get; set; }
    public decimal Price { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Active { get; private set; }

    protected Course() { }

    public Course(string title, string description, int durationInHours, decimal price)
    {
        ValidateTitle(title);
        ValidateDescription(description);
        ValidateDuration(durationInHours);
        ValidatePrice(Price);
        Title = title;
        Description = description;
        Price = price;
        DurationInHours = durationInHours;
        Active = true;
    }

    public void Update(string title, string description, decimal price)
    {
        ValidateTitle(title);
        ValidateDescription(description);
        ValidatePrice(price);
        Title = title;
        Description = description;
        Price = price;
    }

    public void UpdatePrice(decimal price)
    {
        ValidatePrice(price);
        Price = price;
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

    private void ValidateDuration(int durationInHours)
    {
        if (durationInHours <= 0)
            throw new ArgumentException("A duração deve ser maior que zero.");
    }

    private void ValidatePrice(decimal price)
    {
        if (price <= 0)
            throw new ArgumentException("O preço não pode ser negativo.");
    }

    public void Deactivate() => Active = false;

    public void Activate() => Active = true;

    public void UpdateCreatedAt(DateTime newDate)
    {
        if (newDate > DateTime.Now)
            throw new ArgumentException("A data de criação não pode ser futura.");
        CreatedAt = newDate;
    }
}