namespace Book
{
    // Интерфейс для сервиса
    public interface INewService
    {
        string GetMessage();
    }

    // Реализация сервиса
    public class NewService : INewService
    {
        public string GetMessage()
        {
            return "I am new service";
        }
    }
}
