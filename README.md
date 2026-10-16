# Performance Counters Monitor (Монитор счетчиков производительности)

Приложение Windows Forms на платформе C# (.NET Framework 4.7.2), предназначенное для мониторинга и графической визуализации счетчиков производительности операционной системы Windows в режиме реального времени.

---

## Назначение и возможности

Приложение предоставляет удобный графический интерфейс для отслеживания основных показателей работы подсистем компьютера.

### Отслеживаемые показатели

#### Центральный процессор (CPU)
- `% загруженности процессора` (`Processor / % Processor Time / _Total`)
- `% времени бездействия` (`Processor / % Idle Time / _Total`)
- `% работы в привилегированном режиме` (`Processor / % Privileged Time / _Total`)

#### Оперативная память (RAM)
- `% использования выделенной памяти` (`Memory / % Committed Bytes In Use`)
- `Доступно виртуальной памяти` (`Memory / Available Bytes`)
- `Кэш-память` (`Memory / Cache Bytes`)

#### Физический диск (DISK)
- `Скорость записи на диск` (`PhysicalDisk / Disk Write Bytes/sec / _Total`)
- `Скорость чтения с диска` (`PhysicalDisk / Disk Read Bytes/sec / _Total`)
- `% активности диска` (`PhysicalDisk / % Disk Time / _Total`)

### Особенности реализации

Сбор метрик и опрос счетчиков вынесены в отдельный фоновый поток `System.Threading.Thread`, что предотвращает зависание графического интерфейса при длительных операциях. Доступ к элементам управления и графику синхронизируется с помощью конструкции `lock`, обеспечивая потокобезопасное обновление точек диаграммы. Пользователь может в реальном времени скрывать и отображать выбранные графики с помощью чекбоксов, а также задавать желаемую длительность мониторинга в секундах. Программа функционирует для всех категорий учетных записей Windows и не требует запуска с повышенными привилегиями администратора.

---

## Демонстрация работы

### Главное меню программы

<p align="center">
  <img src="readme_images/001.png" alt="Главное меню программы" width="300" />
</p>

### Мониторинг счетчиков производительности

<div align="center">
  <div style="display: flex; flex-wrap: wrap; justify-content: center; gap: 20px;">
    <figure style="display: inline-block; margin: 10px; vertical-align: top; text-align: center;">
      <img src="readme_images/002.png" alt="Счетчики CPU" width="300" /><br />
      <figcaption>Центральный процессор (CPU)</figcaption>
    </figure>
    <figure style="display: inline-block; margin: 10px; vertical-align: top; text-align: center;">
      <img src="readme_images/003.png" alt="Счетчики RAM" width="300" /><br />
      <figcaption>Оперативная память (RAM)</figcaption>
    </figure>
    <figure style="display: inline-block; margin: 10px; vertical-align: top; text-align: center;">
      <img src="readme_images/004.png" alt="Счетчики DISK" width="300" /><br />
      <figcaption>Физический диск (DISK)</figcaption>
    </figure>
  </div>
</div>

---

## Стек технологий и требования

| Параметр | Значение |
| :--- | :--- |
| **Операционная система** | Windows 10 (или новее) |
| **Платформа** | .NET Framework 4.7.2 |
| **Язык разработки** | C# |
| **Основные библиотеки** | `System.Windows.Forms`, `System.Diagnostics.PerformanceCounter`, `System.Windows.Forms.DataVisualization.Charting.Chart`, `System.Threading` |

---

## Структура проекта

```text
performance-counters/
├── PerformanceCounters.sln              # Файл решения Visual Studio
├── PerformanceCounters/
│   ├── App.config                       # Конфигурация сборки .NET Framework
│   ├── PerformanceCounters.csproj       # Файл проекта C# WinForms
│   ├── Program.cs                       # Точка входа в программу
│   ├── MainForm.cs                      # Главная форма приложения (навигация и переключение вкладок)
│   ├── MainForm.Designer.cs
│   ├── MainForm.resx
│   ├── Performance Pages/               # Пользовательские элементы управления (UserControl)
│   │   ├── PerformanceCPU.cs            # Мониторинг процессора и построение графиков CPU
│   │   ├── PerformanceRAM.cs            # Мониторинг и графики оперативной памяти
│   │   └── PerformanceDISK.cs           # Мониторинг скорости и активности диска
│   └── Properties/
│       ├── AssemblyInfo.cs
│       ├── Resources.resx
│       └── Settings.settings
├── docs/
│   └── images/                          # Иллюстрации и скриншоты интерфейса
└── README.md
```
