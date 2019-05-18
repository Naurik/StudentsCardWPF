namespace Cards.DataAccess
{
    using Cards.Models;
    using System.Data.Entity;

    public class ContextCards : DbContext
    {
        // Контекст настроен для использования строки подключения "ContextCards" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "Cards.DataAccess.ContextCards" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "ContextCards" 
        // в файле конфигурации приложения.
        public ContextCards()
            : base("name=ContextCards")
        {

        }

        public DbSet<Students> Student { get; set; }
        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}