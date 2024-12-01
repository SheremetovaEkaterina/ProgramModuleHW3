using ProgramModuleHW3;

class Program
{
    static void Main(string[] args)
    {
        // Создание экземпляров книг
        LibraryBook book1 = new LibraryBook("1984", "Джордж Оруэлл");
        LibraryBook book2 = new LibraryBook("Убить пересмешника", "Харпер Ли");

        // Демонстрация работы
        book1.DisplayStatus();
        book1.CheckOutBook();
        book1.DisplayStatus();
        book1.CheckOutBook();
        book1.ReturnBook();
        book1.ReturnBook();

        Console.WriteLine();

        book2.DisplayStatus();
        book2.CheckOutBook();
        book2.ReturnBook();
        book2.DisplayStatus();
    }
}
