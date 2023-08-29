using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Windows;

namespace EFcrud
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            DatabaseFacade facade = new DatabaseFacade(new AppDbContext());
            facade.EnsureCreated();
        }

    }
}
