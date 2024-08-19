using System.Linq.Expressions;
namespace SampleDatePicker.Components;

public record DateTimePreset(string Title, Expression<Func<DateTime, DateTime>> PresetFunction);