using System;


namespace Classes;

public class Libraty
{
    private Book[] _books = null;

    /// <summary>
    /// Returns books count
    /// </summary>
    public int BooksCount
    {
        get
        {
            if (_books != null)
                return _books.Length; //Геттер з простою логікою

            return 0;
        }
    }

    /// <summary>
    /// Fills library by default programmers' books
    /// </summary>
    public void FillLibrary()
    {
        _books = new Book[]
        {
            new Book("CLR via C#")
            {
                Author = "Jeffrey Richter"
            },
            new Book("Code Complete")
            {
                Author = "Steve McConnell"
            },
            new Book(" Windows Runtime Via C#")
            {
                Author = "Jeffrey Richter"
            },
        };
    }

    /// <summary>
    /// Find only one book by start title text
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Book FindBookByTitle(string name)
    {
        //Пошук книги за заголовком
        for (int i = 0; i < _books.Length; i++)
        {
            if (_books[i].Title.Contains(name))
            {
                return _books[i];
            }
        }
        return null;
    }

    /// <summary>
    /// Find set of books by start author name text
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Book[] FindBooksByAuthor(string name)
    {
        int counter = 0; //Лічильник для стрворення масиву потрібної довжини
        for (int i = 0; i < _books.Length; i++)
        {
            if (_books[i].Author.Contains(name))
            {
                counter++;
            }
        }

        //Вибірка книг за автором, створивши масив потрібної довжини по порядку додаю потрібні книги
        Book[] result = new Book[counter];
        int j = 0;
        for (int i = 0; i < _books.Length; i++)
        {
            if (_books[i].Author.Contains(name))
            {
                result[j] = _books[i];
                j++;
            }
        }
        return result;
    }

    private Book[] Books
    {
        get
        {
            if (_books == null)
            {
                return new Book[0];
            }

            return _books;
        }
    }
}