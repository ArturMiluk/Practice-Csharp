using System.Windows;
using StudentDiary.Database;

namespace StudentDiary
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            using var context = new AppDbContext();
            DbInitializer.Initialize(context);
        }
    }
}