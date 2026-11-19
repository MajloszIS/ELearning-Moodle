# ELearning

Platforma e-learningowa tworzona w ramach przedmiotu **Aplikacje webowe w ASP MVC**

Nauczyciele definiują przedmioty i zajęcia oraz dodają do nich dokumenty. Studenci po zalogowaniu przeglądają materiały, do których mają dostęp.

## Technologie

- ASP.NET Core MVC (.NET 10)
- Bootstrap 5
- planowane: Entity Framework Core + SQL Server, ASP.NET Core Identity

## Wstępne założenia

- **Role:** administrator, nauczyciel, student.
- **Przedmioty** z opisem i dokumentami, podzielone na **zajęcia** (każde z opisem i dokumentami).
- **Studenci i grupy:** student może należeć do wielu grup, a nauczyciel nadaje grupom dostęp do przedmiotów.
- **Wielu nauczycieli:** każdy widzi tylko swoje przedmioty, grupy i studentów.
- **Wiadomości:** ogólne (strona główna) lub dotyczące konkretnego przedmiotu.
- **Projekty** dla studentów: wysyłanie plików oraz komentarze nauczyciela.
- **Testy:** pytania jednokrotnego i wielokrotnego wyboru oraz z wpisywaną wartością, punktacja i oceny.
- **Pozostałe:** formularz pytań do nauczyciela (e-mail), wyszukiwanie, reset hasła.

## Uruchomienie

Otwórz `ELearning.slnx` w Visual Studio i uruchom projekt (F5) albo w terminalu:

```bash
dotnet run --project ELearning
```

Lista przedmiotów: `/Subjects`.
