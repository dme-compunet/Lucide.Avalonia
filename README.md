# ✨ Lucide.Avalonia

Implementation of the [Lucide icon library](https://github.com/lucide-icons/lucide) for [AvaloniaUI](https://github.com/AvaloniaUI/Avalonia).

[![NuGet Version](https://img.shields.io/nuget/v/Lucide.Avalonia?logo=nuget)](https://www.nuget.org/packages/Lucide.Avalonia)
[![GitHub License](https://img.shields.io/github/license/dme-compunet/Lucide.Avalonia)](https://github.com/dme-compunet/Lucide.Avalonia/blob/main/LICENSE)

---

## ⚡ Advantages

- No styles include required.
- No xmlns declaration required.
- Automatic daily updates and releases.

---

## 🚀 Usage Examples

### Using the `LucideIcon` Element

```xml
<LucideIcon Kind="Star"/>
<LucideIcon Kind="Star" Size="30"/>
<LucideIcon Kind="Star" Size="30" StrokeWidth="1.5"/>
```

### Using a Markup Extension

```xml
<Button Content="{LucideIconContent Star}"/>
<Button Content="{LucideIconContent Star, 30, 1.5}"/>
<Button Content="{LucideIconContent Kind=Star, Size=30, StrokeWidth=1.5}"/>
```

---

## 🔗 Additional Links

- [AvaloniaUI](https://github.com/AvaloniaUI/Avalonia)
- [Lucide Icons](https://lucide.dev/icons)
- [NuGet Package](https://www.nuget.org/packages/Lucide.Avalonia)
