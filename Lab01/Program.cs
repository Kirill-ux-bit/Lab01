Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Визитка системы");
Console.ResetColor();

string studentName = "Кирилл";
string studentGroup = "ПМБИ-261";
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n[Студент]");
Console.ResetColor();
Console.WriteLine($"Имя: {studentName}");
Console.WriteLine($"Группа: {studentGroup}");
Console.WriteLine($"Дата: {DateTime.Now:dd.MM.yyyy HH:mm}");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n[Компьютер]");
Console.ResetColor();
Console.WriteLine($"Имя машины: {Environment.MachineName}");
Console.WriteLine($"Пользователь: {Environment.UserName}");
Console.WriteLine($"ОС: {Environment.OSVersion}");
Console.WriteLine($"64-битная ОС: {Environment.Is64BitOperatingSystem}");
Console.WriteLine($"Версия .Net: {Environment.Version}");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n[Процессор]");
Console.ResetColor();
Console.WriteLine($"Логических ядер: {Environment.ProcessorCount}");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n[Память]");
Console.ResetColor();
long workingSetMb = Environment.WorkingSet / 1024 / 1024;
Console.WriteLine($"Память процессора: {workingSetMb} МБ");
Console.WriteLine($"Размер указателя: {IntPtr.Size * 8} бит");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nПрограмма выполнена успешно!");
Console.ResetColor();