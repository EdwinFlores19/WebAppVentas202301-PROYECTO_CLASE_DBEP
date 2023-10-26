using WebAppVentas202301.Services.Interface;
using WebAppVentas202301.Services.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Add(new ServiceDescriptor(typeof(ICliente), new ClienteRepository()));
builder.Services.Add(new ServiceDescriptor(typeof(IDistrito), new DistritoRepository()));
builder.Services.Add(new ServiceDescriptor(typeof(IProducto), new ProductoRepository()));
builder.Services.Add(new ServiceDescriptor(typeof(ITemporalVenta), new TemporalVentaRepository()));
builder.Services.Add(new ServiceDescriptor(typeof(IUsuario), new UsuarioRepository()));
builder.Services.Add(new ServiceDescriptor(typeof(IProveedores), new ProveedoresRepository()));

builder.Services.AddControllersWithViews();
builder.Services.AddSession(options => { options.IdleTimeout = TimeSpan.FromSeconds(3600); });
//Agregar sesiones al proyecto, codigo DIAZ

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession(); //Variable de sesión agregada

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Usuario}/{action=Index}/{id?}");

app.Run();
