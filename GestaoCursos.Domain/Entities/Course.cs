using GestaoCursos.Domain.Exceptions;

public class Course
{
    public int Id { get; set; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public int DurationInHours { get; private set; }
    public decimal Price { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public bool Active { get; private set; }

    protected Course() 
    {

    }

    public Course(string title, string description, int durationInHours, decimal price)
    {
        ValidateTitle(title);
        ValidateDescription(description);
        ValidateDuration(durationInHours);
        ValidatePrice(price);
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
        DomainException.When(price <= 0, "O preço deve ser maior que zero.");
        Price = price;
    }

    private void ValidateTitle(string title)
    {
        DomainException.When(string.IsNullOrWhiteSpace(title) || title.Length < 3, "O título deve conter ao menos 3 caracteres.");
    }

    private void ValidateDescription(string description)
    {
        DomainException.When(string.IsNullOrWhiteSpace(description) || description.Length < 10, "A descrição deve conter ao menos 10 caracteres.");
    }

    private void ValidateDuration(int durationInHours)
    {
        DomainException.When(durationInHours <= 0, "A duração deve ser maior que zero.");
    }

    private void ValidatePrice(decimal price)
    {
        DomainException.When(price <= 0, "O preço não pode ser negativo.");
    }

    public void Deactivate() => Active = false;

    public void Activate() => Active = true;

    public void UpdateCreatedAt(DateTime newDate)
    {
        DomainException.When(newDate > DateTime.Now, "A data de criação não pode ser futura.");
        CreatedAt = newDate;
    }
}