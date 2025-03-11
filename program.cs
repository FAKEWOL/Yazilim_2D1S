using Microsoft.EntityFrameworkCore;
using Etercih.models;

string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ElektronikTicaretContext>(options =>
{
    options.UseSqlServer(connection);
}
);
