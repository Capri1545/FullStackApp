var builder = WebApplication.CreateBuilder(args);

// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy
            .AllowAnyOrigin() // Allow client origin
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

// Use CORS middleware
app.UseCors();

app.MapGet(
    "/api/productlist",
    () =>
    {
        return new[]
        {
            new
            {
                Id = 1,
                Name = "Laptop",
                Price = 1200.50,
                Stock = 25,
                Category = new { Id = 101, Name = "Electronics" },
            },
            new
            {
                Id = 2,
                Name = "Headphones",
                Price = 50.00,
                Stock = 100,
                Category = new { Id = 102, Name = "Accessories" },
            },
        }.Select(product => new
        {
            product.Id,
            product.Name,
            product.Price,
            product.Stock,
            Category = new { product.Category.Id, product.Category.Name },
        });
    }
);

app.Run();
