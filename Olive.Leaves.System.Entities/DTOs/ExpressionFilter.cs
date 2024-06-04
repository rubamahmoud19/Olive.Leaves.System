using Olive.Leaves.System.Entities.Enums;

namespace Olive.Leaves.System.Entities.DTOs
{
    public class ExpressionFilter
    {
        public string PropertyName { get; set; }
        public object Value { get; set; }
        public Comparison Comparison { get; set; }
    }
}
